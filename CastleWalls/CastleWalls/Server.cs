using DNA;
using DNA.CastleMinerZ;
using DNA.CastleMinerZ.AI;
using DNA.CastleMinerZ.Inventory;
using DNA.CastleMinerZ.Net;
using DNA.Net.GamerServices;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CastleWalls
{
    internal class Server
    {
        public static void SendFakeConnect()
        {
            string username = Globalization.Chars.ToList().OrderBy(x => Globalization.rand.Next(0, Globalization.Chars.Length)).Select(x => x.ToString()).Aggregate((a, b) => { return a + b; });
            GameWorld.instance.CurrentNetworkSession.ReportClientJoined(username);
        }

        public static void KillAllPlayers()
        {
            Console.WriteLine("BOOM");
            foreach (NetworkGamer networkGamer in GameWorld.instance.CurrentNetworkSession.AllGamers)
            {
                if (networkGamer.Gamertag != GameWorld.instance.MyNetworkGamer.Gamertag)
                {
                    Player player = (Player)networkGamer.Tag;
                    DetonateExplosiveMessage.Send(GameWorld.instance.MyNetworkGamer, new IntVector3((int)player.LocalPosition.X, (int)player.LocalPosition.Y, (int)player.LocalPosition.Z), true, ExplosiveTypes.Rocket);
                }
            }
        }

        public static void KillPlayer(string name)
        {
            Console.WriteLine("BOOM");
            var player = (Player)GetPlayers().Where(x => x.Gamertag == name).FirstOrDefault().Tag;
            DetonateExplosiveMessage.Send(GameWorld.instance.MyNetworkGamer, new IntVector3((int)player.LocalPosition.X, (int)player.LocalPosition.Y, (int)player.LocalPosition.Z), true, ExplosiveTypes.Rocket);
        }

        public static List<NetworkGamer> GetPlayers()
        {
            return GameWorld.instance.CurrentNetworkSession.AllGamers.Cast<NetworkGamer>().ToList();
        }

        public static void ForceDragon()
        {
            EnemyManager.Instance.ForceDragonSpawn(DragonTypeEnum.SKELETON);
        }

        public static void KillAllMonsters()
        {
            EnemyManager.Instance._enemies.ForEach(z =>
            {
                DetonateExplosiveMessage.Send(GameWorld.instance.MyNetworkGamer, new IntVector3((int)z.LocalPosition.X, (int)z.LocalPosition.Y, (int)z.LocalPosition.Z), true, ExplosiveTypes.Rocket);
            });
        }

        public static void SpawnHell()
        {
            GetPlayers().ForEach(x =>
            {
                Player p = (Player)x.Tag;
                for (int i = 0; i < 20; i++)
                {
                    EnemyManager.Instance.SpawnEnemy(p.LocalPosition, EnemyTypeEnum.ALIEN, p.LocalPosition, 10, p.Name);
                }
                EnemyManager.Instance._enemies.ForEach(z => { z.Target = p; });
            });
        }

        public static void SpawnHell(string name)
        {
            var p = (Player)GetPlayers().Where(x => x.Gamertag == name).FirstOrDefault().Tag;
            EnemyManager.Instance.SpawnEnemy(p.LocalPosition, EnemyTypeEnum.ALIEN, p.LocalPosition, 10, p.Name);
        }

        public static void TpToCursor(string name)
        {
            var p = (Player)GetPlayers().Where(x => x.Gamertag == name).FirstOrDefault().Tag;
            p.LocalPosition = DNA.CastleMinerZ.Terrain.BlockTerrain.Instance._cursorPosition;
        }
    }
}