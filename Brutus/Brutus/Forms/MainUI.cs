using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Brutus
{
    public partial class MainUI : Form
    {
        internal static ListBox _Output { get; set; }
        internal static ComboBox _ModuleList { get; set; }

        public MainUI()
        {
            InitializeComponent();
            _Output = Output;
            _ModuleList = comboBox1;

            Reflection.ModuleManager.LoadModules();
        }

        private void CreateCmbsBtn_Click(object sender, EventArgs e)
        {
            Utils.Utils.FileDialog.ShowDialog();
            Settings.Combos = Utils.ComboGenerator.CreateFromFile(Utils.Utils.FileDialog.FileName);
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