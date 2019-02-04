namespace Brutus
{
    partial class MainUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainUI));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ShowFailedCB = new System.Windows.Forms.CheckBox();
            this.StopBtn = new System.Windows.Forms.Button();
            this.BruteBtn = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CreateCmbsBtn = new System.Windows.Forms.Button();
            this.LoadCmbsBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.UndPlugsBtn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(798, 447);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ShowFailedCB);
            this.tabPage1.Controls.Add(this.StopBtn);
            this.tabPage1.Controls.Add(this.BruteBtn);
            this.tabPage1.Controls.Add(this.Output);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(790, 418);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Brute";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ShowFailedCB
            // 
            this.ShowFailedCB.AutoSize = true;
            this.ShowFailedCB.Location = new System.Drawing.Point(615, 189);
            this.ShowFailedCB.Name = "ShowFailedCB";
            this.ShowFailedCB.Size = new System.Drawing.Size(165, 21);
            this.ShowFailedCB.TabIndex = 5;
            this.ShowFailedCB.Text = "Show Failed Attempts";
            this.ShowFailedCB.UseVisualStyleBackColor = true;
            // 
            // StopBtn
            // 
            this.StopBtn.Location = new System.Drawing.Point(115, 6);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(102, 33);
            this.StopBtn.TabIndex = 4;
            this.StopBtn.Text = "Stop Brute";
            this.StopBtn.UseVisualStyleBackColor = true;
            this.StopBtn.Click += new System.EventHandler(this.StopBtn_Click);
            // 
            // BruteBtn
            // 
            this.BruteBtn.Location = new System.Drawing.Point(7, 6);
            this.BruteBtn.Name = "BruteBtn";
            this.BruteBtn.Size = new System.Drawing.Size(102, 33);
            this.BruteBtn.TabIndex = 3;
            this.BruteBtn.Text = "Brute";
            this.BruteBtn.UseVisualStyleBackColor = true;
            this.BruteBtn.Click += new System.EventHandler(this.BruteBtn_Click);
            // 
            // Output
            // 
            this.Output.FormattingEnabled = true;
            this.Output.ItemHeight = 16;
            this.Output.Location = new System.Drawing.Point(7, 216);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(773, 196);
            this.Output.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Brute Output";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.UndPlugsBtn);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(790, 418);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Settings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cCount);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.CreateCmbsBtn);
            this.groupBox2.Controls.Add(this.LoadCmbsBtn);
            this.groupBox2.Location = new System.Drawing.Point(190, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(140, 117);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Brute Settings";
            // 
            // cCount
            // 
            this.cCount.AutoSize = true;
            this.cCount.Location = new System.Drawing.Point(52, 92);
            this.cCount.Name = "cCount";
            this.cCount.Size = new System.Drawing.Size(16, 17);
            this.cCount.TabIndex = 6;
            this.cCount.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Count:";
            // 
            // CreateCmbsBtn
            // 
            this.CreateCmbsBtn.Location = new System.Drawing.Point(6, 58);
            this.CreateCmbsBtn.Name = "CreateCmbsBtn";
            this.CreateCmbsBtn.Size = new System.Drawing.Size(117, 31);
            this.CreateCmbsBtn.TabIndex = 4;
            this.CreateCmbsBtn.Text = "Create Combos";
            this.CreateCmbsBtn.UseVisualStyleBackColor = true;
            this.CreateCmbsBtn.Click += new System.EventHandler(this.CreateCmbsBtn_Click);
            // 
            // LoadCmbsBtn
            // 
            this.LoadCmbsBtn.Location = new System.Drawing.Point(6, 21);
            this.LoadCmbsBtn.Name = "LoadCmbsBtn";
            this.LoadCmbsBtn.Size = new System.Drawing.Size(117, 31);
            this.LoadCmbsBtn.TabIndex = 3;
            this.LoadCmbsBtn.Text = "Load Combos";
            this.LoadCmbsBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Use This Module";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Router"});
            this.comboBox1.Location = new System.Drawing.Point(6, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(178, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // UndPlugsBtn
            // 
            this.UndPlugsBtn.Location = new System.Drawing.Point(3, 59);
            this.UndPlugsBtn.Name = "UndPlugsBtn";
            this.UndPlugsBtn.Size = new System.Drawing.Size(140, 27);
            this.UndPlugsBtn.TabIndex = 5;
            this.UndPlugsBtn.Text = "Unload Plugins";
            this.UndPlugsBtn.UseVisualStyleBackColor = true;
            this.UndPlugsBtn.Click += new System.EventHandler(this.UndPlugsBtn_Click);
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainUI";
            this.Text = "Brutus";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button StopBtn;
        private System.Windows.Forms.Button BruteBtn;
        private System.Windows.Forms.ListBox Output;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ShowFailedCB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label cCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CreateCmbsBtn;
        private System.Windows.Forms.Button LoadCmbsBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button UndPlugsBtn;
    }
}

