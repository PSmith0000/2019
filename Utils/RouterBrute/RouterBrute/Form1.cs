using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RouterBrute
{
    public partial class Form1 : Form
    {
        private static List<string> CredList = new List<string>();

        public Form1()
        {
            InitializeComponent();
            this.Text = "Gateway: " + Network.GATEWAY;
        }

        private void BruteBtn_Click(object sender, EventArgs e)
        {
            if (CredList.Count != 0)
            {
                CredList.ForEach(login => {
                    var result = Network.SendLogin(login);
                    if (result != null)
                    {
                        this.textBox1.Text = result;
                        return;
                    }
                });
            }
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            if (File.Exists(Application.StartupPath + "\\Creds.txt"))
            {
                CredList.AddRange(File.ReadAllLines(Application.StartupPath + "\\Creds.txt").ToList());
            }
            else
            {
                File.Create(Application.StartupPath + "\\Creds.txt").Dispose();
                MessageBox.Show("ComboList Not Found, Created. \nOne Per Line\nuser:pass format.");
            }
        }
    }
}
