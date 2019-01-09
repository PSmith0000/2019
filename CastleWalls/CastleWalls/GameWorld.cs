using DNA.CastleMinerZ;

namespace CastleWalls
{
    internal class GameWorld
    {
        public static CastleMinerZGame instance { get { return CastleMinerZGame.Instance; } }

        public static void ChangeGameTitle(string text)
        {
            instance.Window.Title = text;
        }
    }
}