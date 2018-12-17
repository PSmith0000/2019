using DNA.CastleMinerZ;
using DNA.CastleMinerZ.Net;
using DNA.CastleMinerZ.UI;
using DNA.Drawing;
using DNA.Timers;
using System;
using System.Linq;
using System.Reflection;

namespace CastleWalls
{
    public class LocalPlayer : IGameMessageHandler
    {
        public static Player LPlayer { get { return GameWorld.instance.LocalPlayer; } }
        public static GameModeTypes SetGameMode { set { GameWorld.instance.GameMode = value; } }

        public static GameDifficultyTypes gameDifficulty { set { GameWorld.instance.Difficulty = value; } }

        public static int JmpCount { set { LPlayer.JumpCountLimit = value; } }

        public static void RefillHPSP(float amt = float.MaxValue)
        {
            GameWorld.instance.GameScreen.HUD.PlayerHealth = amt;
            GameWorld.instance.GameScreen.HUD.PlayerStamina = amt;
            GameWorld.instance.GameScreen.HUD.HealthRecoverRate = float.MaxValue;
            GameWorld.instance.GameScreen.HUD.HealthRecoverTimer = new OneShotTimer(TimeSpan.FromMilliseconds(0));
        }

        public static void ForceHostMigration()
        {
            if (!GameWorld.instance.IsGameHost)
            {
                GameWorld.instance.CurrentNetworkSession.AllowHostMigration = true;
                AppointServerMessage.Send(GameWorld.instance.MyNetworkGamer, GameWorld.instance.MyNetworkGamer.Id);
            }
        }

        public static void SetName(string name)
        {
            GameWorld.instance.MyNetworkGamer.Gamertag = name;
        }

        public static void SetSpeed(float amt)
        {
            Assembly.GetEntryAssembly().GetType("DNA.CastleMinerZ.Player").GetField("_sprintMultiplier", BindingFlags.NonPublic | BindingFlags.Instance).SetValue(LPlayer, amt);
        }

        public static void SetGravity(float amt)
        {
            BasicPhysics.Gravity = new Microsoft.Xna.Framework.Vector3(0f, amt, 0f);
        }

        public static void InfiniteAmmo(bool state)
        {
            if (state)
            {
                GameMessageManager.Instance.Subscribe(Init.MSGHANDLER, GameMessageType.LocalPlayerFiredGun);
                GameWorld.instance.InfiniteResourceMode = true;
            }
            else
            {
                GameMessageManager.Instance.UnSubscribe(GameMessageType.LocalPlayerFiredGun, Init.MSGHANDLER);
                GameWorld.instance.InfiniteResourceMode = false;
            }
        }

        public static void UnlockDragonMode()
        {
            GameWorld.instance.PlayerStats.UndeadDragonKills = 1;
        }

        public static void MaxItems()
        {
            LPlayer.PlayerInventory.Inventory.ToList().ForEach(x =>
            {
                x.ItemClass.CreateItem(255);
            });
        }

        public static void SuperPix(bool state)
        {
            if (state)
            {
                GameMessageManager.Instance.Subscribe(Init.MSGHANDLER, GameMessageType.LocalPlayerPickedAtBlock);
            }
            else
            {
                GameMessageManager.Instance.UnSubscribe(GameMessageType.LocalPlayerPickedAtBlock, Init.MSGHANDLER);
            }
        }

        public static void RandomizeID(byte? id = null)
        {
            Assembly.GetAssembly(typeof(DNA.Net.GamerServices.NetworkGamer)).GetType("DNA.Net.GamerServices.NetworkGamer").GetField("_alternateAddress", BindingFlags.NonPublic | BindingFlags.Instance).SetValue(GameWorld.instance.MyNetworkGamer, Convert.ToUInt64((Globalization.rand.Next(1, int.MaxValue))));
            Assembly.GetAssembly(typeof(DNA.Net.GamerServices.NetworkGamer)).GetType("DNA.Net.GamerServices.NetworkGamer").GetField("_globalId", BindingFlags.Instance | BindingFlags.NonPublic).SetValue(GameWorld.instance.MyNetworkGamer, id != null ? id : (byte)Globalization.rand.Next(0, byte.MaxValue));
        }

        public static void DaytimeGetsAawayFromMe(float amt = 0.41f)
        {
            //GameWorld.instance.GameScreen._sky.Day = amt;
            GameWorld.instance.GameScreen._sky.drawLightning = true;
        }

        public static void setDamage(float dmg = float.MaxValue, bool rapid = false)
        {
            if ((LPlayer.PlayerInventory.ActiveInventoryItem is DNA.CastleMinerZ.Inventory.GunInventoryItem))
            {
                var gun = (LPlayer.PlayerInventory.ActiveInventoryItem as DNA.CastleMinerZ.Inventory.GunInventoryItem).GunClass;

                if (gun.EnemyDamage != float.MaxValue || gun.Name.ToLower().Contains("rocket") || rapid)
                {
                    gun.EnemyDamage = dmg;
                    gun.Velocity = 100000f;
                    gun.FlightTime = 100000f;
                    gun.Recoil = new DNA.Angle();
                    gun.MinInnaccuracy = new DNA.Angle();
                    gun.MaxInnaccuracy = new DNA.Angle();
                    gun.ShoulderedMaxAccuracy = new DNA.Angle();
                    gun.ShoulderedMinAccuracy = new DNA.Angle();
                    gun.ClipCapacity = int.MaxValue;
                    gun.ItemSelfDamagePerUse = 0f;
                }

                if (rapid)
                {
                    gun.Automatic = rapid;
                    LPlayer.PlayerInventory.ActiveInventoryItem._coolDownTimer = new OneShotTimer(new TimeSpan(0));
                }
            }
        }

        public static void CpyPInven(string pname)
        {
            var i = (Server.GetPlayers().Where(x => x.Gamertag == pname).FirstOrDefault().Tag as Player).PlayerInventory;
            LPlayer.PlayerInventory.DropAll(true);
            i.Inventory.ToList().ForEach(x =>
            {
                LPlayer.PlayerInventory.AddInventoryItem(x);
            });
        }

        public void HandleMessage(GameMessageType type, object data, object sender)
        {
            switch (type)
            {
                case GameMessageType.LocalPlayerMinedBlock:
                    break;

                case GameMessageType.LocalPlayerPickedAtBlock:
                    GameWorld.instance.GameScreen.HUD.Dig(LPlayer.PlayerInventory.ActiveInventoryItem, true);
                    break;

                case GameMessageType.LocalPlayerFiredGun:
                    (LPlayer.PlayerInventory.ActiveInventoryItem as DNA.CastleMinerZ.Inventory.GunInventoryItem).RoundsInClip++;
                    break;

                case GameMessageType.Count:
                    break;

                default:
                    break;
            }
        }
    }
}