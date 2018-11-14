using DNA.CastleMinerZ.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PastTheCastleWalls.Forms
{
    public partial class MainUI : Form
    {
        public MainUI()
        {
            InitializeComponent();
            timer1.Start();
            speedMPBar.MouseUp += SpeedMPBar_MouseUp;
        }

        private void SpeedMPBar_MouseUp(object sender, MouseEventArgs e)
        {
            LocalPlayer.SetSpeed((float)speedMPBar.Value);
            Console.WriteLine("Set Speed: " + speedMPBar.Value.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Server.SendFakeConnect();
        }

        private void HostBtn_Click(object sender, EventArgs e)
        {
            LocalPlayer.ForceHostMigration();
        }

        private void kpBtn_Click(object sender, EventArgs e)
        {
            Server.KillAllPlayers();
        }

        private void godCB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (GameWorld.instance.CurrentNetworkSession != null)
            {
                if (godCB.Checked)
                {
                    LocalPlayer.RefillHPSP();
                }
                pBox.Items.Clear();
                Server.GetPlayers().ForEach(x =>
                {
                    pBox.Items.Add(x.Gamertag);
                });

                
            }
        }

        private void GMBox_Click(object sender, EventArgs e)
        {
            LocalPlayer.SetGameMode = (GameModeTypes)Enum.Parse(typeof(GameModeTypes), comboBox1.Text);
        }

        private void INFAMMOCB_CheckedChanged(object sender, EventArgs e)
        {
            if (INFAMMOCB.Checked)
            {
                LocalPlayer.InfiniteAmmo(true);
            }
            else { LocalPlayer.InfiniteAmmo(false); }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                LocalPlayer.JmpCount = 10000 * 5;
            }
            else
            {
                LocalPlayer.JmpCount = 1;
            }
        }

        private void spnDrag_Click(object sender, EventArgs e)
        {
            Server.ForceDragon();
        }

        private void kill_a_m_Click(object sender, EventArgs e)
        {
            Server.KillAllMonsters();
        }
    }
}
