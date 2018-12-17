using DNA.CastleMinerZ;
using System;
using System.Linq;
using System.Windows.Forms;

namespace CastleWalls.Forms
{
    public partial class MainUI : Form
    {
        public MainUI()
        {
            InitializeComponent();
            Timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (GameWorld.instance.CurrentNetworkSession != null)
            {
                #region Local

                if (HostCB.Checked)
                {
                    LocalPlayer.ForceHostMigration();
                }

                if (GodCB.Checked)
                {
                    LocalPlayer.RefillHPSP();
                }

                if (rPidCB.Checked && GameWorld.instance.MyNetworkGamer != null)
                {
                    LocalPlayer.RandomizeID();
                }

                if (KillCB.Checked)
                {
                    LocalPlayer.setDamage(float.MaxValue, RapidCB.Checked);
                }

                PIDlbl.Text = GameWorld.instance.MyNetworkGamer.Id.ToString();
                hNameLbl.Text = GameWorld.instance.CurrentNetworkSession.Host.Gamertag;

                if (Server.GetPlayers().Count < PlayerSelect.Items.Count || Server.GetPlayers().Count > PlayerSelect.Items.Count)
                {
                    PlayerSelect.Items.Clear();
                    Server.GetPlayers().ForEach(x =>
                    {
                        PlayerSelect.Items.Add(x.Gamertag);
                    });
                }

                #endregion Local
            }

            #region BlasterShot_Bug_Fix

            BlasterShot._garbage.ForEach(x =>
            {
                if (x.CollisionsRemaining == 0)
                {
                    x.DrawPriority = 0;
                    x.RemoveFromParent();
                }
            });

            #endregion BlasterShot_Bug_Fix
        }

        private void ammoCB_CheckedChanged(object sender, EventArgs e)
        {
            LocalPlayer.InfiniteAmmo(ammoCB.Checked);
        }

        private void MineCB_CheckedChanged(object sender, EventArgs e)
        {
            LocalPlayer.SuperPix(MineCB.Checked);
        }

        private void SetGmBtn_Click(object sender, EventArgs e)
        {
            LocalPlayer.SetGameMode = DNA.CastleMinerZ.UI.GameModeTypes.Creative;
        }

        private void KillAllBtn_Click(object sender, EventArgs e)
        {
            Server.KillAllPlayers();
        }

        private void KillAllMonstersBtn_Click(object sender, EventArgs e)
        {
            Server.KillAllMonsters();
        }

        private void pJoinCB_CheckedChanged(object sender, EventArgs e)
        {
            Hooks.PreventPlayerJoin(pJoinCB.Checked);
        }

        private void CpyItemsBtn_Click(object sender, EventArgs e)
        {
            LocalPlayer.CpyPInven(PlayerSelect.Text);
        }

        private void KillrpBtn_Click(object sender, EventArgs e)
        {
            Server.KillPlayer(PlayerSelect.Text);
        }

        private void SpawnDragoonBtn_Click(object sender, EventArgs e)
        {
            Server.ForceDragon();
        }

        private void SwnHellBtn_Click(object sender, EventArgs e)
        {
            Server.SpawnHell(PlayerSelect.Text);
        }

        private void HostCB_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void pSpeedTB_Scroll(object sender, EventArgs e)
        {
            LocalPlayer.SetSpeed(pSpeedTB.Value);
        }

        private void IdStealBtn_Click(object sender, EventArgs e)
        {
            byte id = Server.GetPlayers().Where(x => x.Gamertag == PlayerSelect.Text).FirstOrDefault().Id;
            LocalPlayer.RandomizeID(id);
        }
    }
}