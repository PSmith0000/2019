using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1
{/// <summary>
/// Writes to memory in its scope 
/// </summary>
    unsafe class UnsafeReadWrite
    {
        public static void Write<T>(IntPtr Address, T Value, int Length = 0)
        {
            if (typeof(T) == typeof(int))
            {
                *(int*)(Address.ToPointer()) = (int)(object)Value;
            }
            else if (typeof(T) == typeof(float))
            {
                *(float*)(Address.ToPointer()) = (float)(object)Value;
            }
            else if (typeof(T) == typeof(string))
            {
                fixed (char* str = (string)(object)Value)
                {
                    *(char**)(Address.ToPointer()) = str;
                }
            }
            else if(typeof(char) == typeof(T))
            {
                *(char*)(Address.ToPointer()) = (char)(object)Value;
            }
            else if(typeof(byte[]) == typeof(T))
            {
                byte[] IL = (byte[])(object)Value;
                for (int i = 0; i < Length; i++)
                {
                    Marshal.WriteByte(Address, i, IL[i]);
                }
            }
        }

        public static void WritePtr<T>(IntPtr Address, int[] offsets, T Value)
        {
            IntPtr _Address = Address;
            for (int i = 0; i < offsets.Length; i++)
            {
                _Address = (IntPtr)(*(int*)Address) + offsets[i];
            }
            Write<T>(_Address, Value);
        }

        public static T Read<T>(IntPtr Address, int Length = 0)
        {
            object value = null;
            if (typeof(T) == typeof(int))
            {
                value =  *(int*)(Address.ToPointer());
            }
            else if (typeof(T) == typeof(float))
            {
                value = *(float*)(Address.ToPointer());
            }
            else if (typeof(T) == typeof(char))
            {
                value = *(char*)(Address.ToPointer());
            }
            else if (typeof(T) == typeof(string))
            {
                value = Marshal.PtrToStringAuto(Address);
            }
            else if (typeof(T) == typeof(byte))
            {
                value = *(byte*)(Address.ToPointer());
            }
            else if(typeof(T) == typeof(byte[]))
            {
                byte[] Method_Ops = new byte[Length];
                Marshal.Copy(Address, Method_Ops, 0, Length);
                value = Method_Ops;
            }
            return (T)((object)Convert.ChangeType(value, typeof(T)));
        }

        public static void ReadPtr<T>(IntPtr Address, int[] offsets, T Value)
        {
            IntPtr _Address = Address;
            for (int i = 0; i < offsets.Length; i++)
            {
                _Address = (IntPtr)(*(int*)Address) + offsets[i];
            }
            Read<T>(_Address);
        }

        public static void Hook(IntPtr MethodToHook, byte[] OpCodes)
        {
            Write<byte[]>(MethodToHook, OpCodes, OpCodes.Length);          
        }
    }
}
