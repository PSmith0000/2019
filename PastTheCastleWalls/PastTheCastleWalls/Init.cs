using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PastTheCastleWalls
{
    public class Init
    {
        public static LocalPlayer LP_MSG_HANDLER { get; set; }
        public Init()
        {
            new Forms.MainUI().Show();
            LP_MSG_HANDLER = new LocalPlayer();
            LocalPlayer.UnlockDragonMode();
        }
    }
}
