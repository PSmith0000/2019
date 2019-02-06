using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Brutus
{
    public partial class MainUI : Form
    {
        internal static ListBox _Output { get; set; }
        internal static ComboBox _ModuleList { get; set; }

        internal  static NotifyIcon Notify { get; set; }
        public MainUI()
        {
            InitializeComponent();
            _Output = this.Output;
            _ModuleList = this.comboBox1;
            Notify = this.LoginFoundTip;


            Notify.Icon = SystemIcons.Information;
            Notify.BalloonTipText = "Loading Plugins..";
            Notify.ShowBalloonTip(1000);

            Reflection.ModuleManager.LoadModules();
        }

        private void CreateCmbsBtn_Click(object sender, EventArgs e)
        {
            Utils.Utils.FileDialog.ShowDialog();
            var CombosTask = Utils.ComboGenerator.CreateFromFile(Utils.Utils.FileDialog.FileName);
            if (CombosTask.IsCompleted)
            {
                Settings.Combos = CombosTask.Result;
            }
            else
            {
                Notify.BalloonTipText = "Were Working Hard!";
                Notify.ShowBalloonTip(200);


                Task.Factory.StartNew(() => {
                while (!CombosTask.IsCompleted)
                {
                    Thread.Sleep(100);
                }
                    Settings.Combos = CombosTask.Result;
                    Utils.Utils.SafeInvoke(cCount, new Action(() => {
                        cCount.Text = Settings.Combos.Count.ToString();
                    }));
                    Notify.BalloonTipText = "Combos Created!";
                    Notify.ShowBalloonTip(200);
                });
            }
            cCount.Text = Settings.Combos.Count.ToString();
        }

        private void BruteBtn_Click(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "Router":
                    Work(typeof(Modules.Router));
                    break;

                default:
                    Work(Brutus.Modules.PluginManager.LoadedPlugins.FirstOrDefault());
                    break;
            }
        }

        private static void Work(Modules.Plugin Mod)
        {
            var w = Worker.doWork(Mod);
            w.Result.ForEach(x =>
            {
                _Output.Items.Add("Successful: " + x);
            });
        }

        private static void Work(Type Mod)
        {
            var w = Worker.doWork(Mod);
            w.Result.ForEach(x =>
            {
                _Output.Items.Add("Successful: " + x);
            });
        }

        private void StopBtn_Click(object sender, EventArgs e)
        {

        }

        private void UndPlugsBtn_Click(object sender, EventArgs e)
        {
            Reflection.ModuleManager.UnloadModules();
        }
    }
}