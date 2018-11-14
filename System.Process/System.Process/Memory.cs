using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace System.Process
{
    public class Memory
    {

        #region READ
        public static T Read<T>(Objects.ProcessObject p_obj, IntPtr Address, int size = 4)
        {
            object value = null;
            IntPtr num = IntPtr.Zero;
            byte[] array = new byte[size];
            Unmanaged.WinAPI.ReadProcessMemory(p_obj.Handle, Address, array, array.Length, out num);
            if (typeof(T) == typeof(int))
            {
                value = BitConverter.ToInt32(array, 0);
            }
            else if (typeof(T) == typeof(long))
            {
                value = BitConverter.ToInt64(array, 0);
            }
            if (typeof(T) == typeof(float))
            {
                value = BitConverter.ToSingle(array, 0);
            }
            else if (typeof(T) == typeof(string))
            {
                byte[] array2 = ReadBytesByLength(p_obj, Address, 255);
                for (int i = 0; i < array2.Length; i++)
                {
                    if (array2[i] == 0)
                    {
                        value = Encoding.ASCII.GetString(array2, 0, i);
                        break;
                    }
                }
            }
            else if (typeof(T) == typeof(IntPtr))
            {
                value = size == 4 ? (IntPtr)BitConverter.ToInt32(array, 0) : (IntPtr)BitConverter.ToInt64(array, 0);
            }

            return (T)((object)Convert.ChangeType(value, typeof(T)));
        }

        public static T ReadPtr<T>(Objects.ProcessObject p_obj, long Address, int[] Offsets, int size = 4)
        {
            IntPtr address = (IntPtr)Address;
            for (int i = 0; i < Offsets.Length; i++)
            {
                address = Read<IntPtr>(p_obj, address, size) + Offsets[i];
            }
            return (T)((object)Convert.ChangeType(address, typeof(T)));
        }

        public static byte[] ReadBytesByLength(Objects.ProcessObject p_obj, IntPtr address, int len)
        {
            IntPtr num = (IntPtr)0;
            byte[] array = new byte[len];
            Unmanaged.WinAPI.ReadProcessMemory(p_obj.Handle, address, array, array.Length, out num);
            return array;
        }

        public static byte[] READ_BYTE_ARRAY(Objects.ProcessObject p_obj, int index)
        {
            IntPtr BaseAdr = p_obj.Process.Modules[index].BaseAddress;
            byte[] MemorySizeBuffer = new byte[p_obj.Process.Modules[index].ModuleMemorySize];
            IntPtr out_size = IntPtr.Zero;
            Unmanaged.WinAPI.ReadProcessMemory(p_obj.Handle, BaseAdr, MemorySizeBuffer, MemorySizeBuffer.Length, out out_size);
            return MemorySizeBuffer;
        }

        public static byte[] ReadByteArrayByLength(byte[] refByteArray, int length, long index)
        {
            byte[] array = new byte[length];
            int num = 0;
            for (long num2 = index; num2 < (long)refByteArray.Length; num2 += 1L)
            {
                array[num] = refByteArray[(int)(checked((IntPtr)num2))];
                num++;
                if (num == length)
                {
                    break;
                }
            }
            return array;
        }

        public static long[] FindPattern(byte[] RefByteArray, byte[] Pattern, string mask, long BASE)
        {
            if (Pattern.Length != mask.Length)
            {
                return new long[0];
            }  
            long num = 0L;
            int num2 = 0;
            List<long> list = new List<long>();
            for (int i = 0; i < RefByteArray.Length; i++)
            {
                byte[] array = ReadByteArrayByLength(RefByteArray, Pattern.Length, num);
                for (int j = 0; j < array.Length; j++)
                {
                    if (mask[j] == '?')
                    {
                        num2++;
                    }
                    else if (num2 == Pattern.Length)
                    {
                        num2 = 0;
                        list.Add(BASE + num - (long)Pattern.Length);
                    }
                    else
                    {
                        if (array[j] != Pattern[j])
                        {
                            num2 = 0;
                            break;
                        }
                        num2++;
                    }
                }
                num += (long)Pattern.Length;
            }
            return list.ToArray();
        }
        #endregion

        #region WRITE
        public static void Write<T>(Objects.ProcessObject p_obj, IntPtr Address, T Value, int size = 4)
        {
            byte[] array = new byte[size];
            long num = 0L;
            if (typeof(T) == typeof(int))
            {
                array = BitConverter.GetBytes(Convert.ToInt32(Value));
            }
            else if (typeof(T) == typeof(long))
            {
                array = BitConverter.GetBytes(Convert.ToInt64(Value));
            }
            else if (typeof(T) == typeof(float))
            {
                array = BitConverter.GetBytes(Convert.ToSingle(Value));
            }
            else if (typeof(T) == typeof(byte[]))
            {
                array = (byte[])Convert.ChangeType(Value, typeof(byte[]));
            }
            else if (typeof(T) == typeof(IntPtr))
            {
                array = size == 4 ? BitConverter.GetBytes(Convert.ToInt32(Value)) : BitConverter.GetBytes(Convert.ToInt64(Value)); 
            }
            Unmanaged.WinAPI.WriteProcessMemory(p_obj.Handle, Address, array, array.Length, ref num);
        }

        public static bool WritePtr<T>(Objects.ProcessObject p_obj, IntPtr Address, int[] Offset, T Value, int size = 4)
        {
            IntPtr address = ReadPtr<IntPtr>(p_obj, (long)Address, Offset, size);
            Write<T>(p_obj, address, Value);
            return false;
        }
        #endregion

        #region ntdll



        public static Unmanaged.WinAPI.PROCESS_BASIC_INFORMATION GetProcessInfo(Objects.ProcessObject processObject)
        {
            IntPtr pbi = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(Unmanaged.WinAPI.PROCESS_BASIC_INFORMATION)));
            IntPtr OutPtr = IntPtr.Zero;
            IntPtr outL = Marshal.AllocHGlobal(sizeof(long));

            var qs = Unmanaged.WinAPI.NtQueryInformationProcess(processObject.Handle, 0, pbi, (uint)Marshal.SizeOf(typeof(Unmanaged.WinAPI.PROCESS_BASIC_INFORMATION)), outL);           

            var _struct = Marshal.PtrToStructure<Unmanaged.WinAPI.PROCESS_BASIC_INFORMATION>(pbi);

            Marshal.FreeHGlobal(pbi);
            Marshal.FreeHGlobal(outL);

            processObject.PROCESS_BASIC_INFORMATION = _struct;

            return _struct;
        }

        #endregion

    }
}
