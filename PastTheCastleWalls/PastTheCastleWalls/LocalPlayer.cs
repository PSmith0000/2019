using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DNA.CastleMinerZ;
using DNA.CastleMinerZ.UI;
using DNA.CastleMinerZ.Utils.Threading;
using DNA.CastleMinerZ.Net;
using DNA.Input;
using DNA.CastleMinerZ.AI;

namespace PastTheCastleWalls
{
    public class LocalPlayer : IGameMessageHandler
    {
        private static Player LPlayer { get { return GameWorld.instance.LocalPlayer; } }
        public static GameModeTypes SetGameMode { set { GameWorld.instance.GameMode = value; } }

        public static GameDifficultyTypes gameDifficulty { set { GameWorld.instance.Difficulty = value; } }

        public static int JmpCount { set { LPlayer.JumpCountLimit = value; } }

        public static void RefillHPSP(float amt = 1f)
        {
            GameWorld.instance.GameScreen.HUD.PlayerHealth = amt;
            GameWorld.instance.GameScreen.HUD.PlayerStamina = amt;       
        }

        public static void ForceHostMigration()
        {
            GameWorld.instance.CurrentNetworkSession.AllowHostMigration = true;
            AppointServerMessage.Send(GameWorld.instance.MyNetworkGamer, GameWorld.instance.MyNetworkGamer.Id);
            if (GameWorld.instance.IsGameHost)
            {
                Console.WriteLine("Forced Host Migration!", ConsoleColor.Green);
            }
        }

        public static void SetName(string name)
        {
            GameWorld.instance.MyNetworkGamer.Gamertag = name;
        }

        public static void SetSpeed(float amt)
        {
            LPlayer.Speed = amt * 2;
        }

        public static void InfiniteAmmo(bool state)
        {
            if (state)
            {
                GameMessageManager.Instance.Subscribe(Init.LP_MSG_HANDLER, GameMessageType.LocalPlayerFiredGun);
            }
            else
            {
                GameMessageManager.Instance.UnSubscribe(GameMessageType.LocalPlayerFiredGun, Init.LP_MSG_HANDLER);
            }
        }

        public static void UnlockDragonMode()
        {
            GameWorld.instance.PlayerStats.UndeadDragonKills = 1;
        }

        public static void setDamage(float dmg = float.MaxValue)
        {
            var _class = (DNA.CastleMinerZ.Inventory.InventoryItem.InventoryItemClass)System.Reflection.Assembly.GetEntryAssembly().GetType("DNA.CastleMinerZ.Inventory.InventoryItem").GetField("_class", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(LPlayer.PlayerInventory.ActiveInventoryItem);
            _class.EnemyDamage = dmg;
        }
        public void HandleMessage(GameMessageType type, object data, object sender)
        {
            switch (type)
            {
                case GameMessageType.LocalPlayerMinedBlock:
                    break;
                case GameMessageType.LocalPlayerPickedAtBlock:
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
