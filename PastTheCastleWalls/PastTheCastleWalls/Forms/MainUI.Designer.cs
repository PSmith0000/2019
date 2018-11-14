namespace PastTheCastleWalls.Forms
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
            this.components = new System.ComponentModel.Container();
            this.godCB = new System.Windows.Forms.CheckBox();
            this.HostBtn = new System.Windows.Forms.Button();
            this.kpBtn = new System.Windows.Forms.Button();
            this.pBox = new System.Windows.Forms.ListBox();
            this.GMBox = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.speedMPBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.INFAMMOCB = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.spnDrag = new System.Windows.Forms.Button();
            this.kill_a_m = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.speedMPBar)).BeginInit();
            this.SuspendLayout();
            // 
            // godCB
            // 
            this.godCB.AutoSize = true;
            this.godCB.Location = new System.Drawing.Point(15, 148);
            this.godCB.Name = "godCB";
            this.godCB.Size = new System.Drawing.Size(57, 21);
            this.godCB.TabIndex = 0;
            this.godCB.Text = "God";
            this.godCB.UseVisualStyleBackColor = true;
            this.godCB.CheckedChanged += new System.EventHandler(this.godCB_CheckedChanged);
            // 
            // HostBtn
            // 
            this.HostBtn.Location = new System.Drawing.Point(174, 12);
            this.HostBtn.Name = "HostBtn";
            this.HostBtn.Size = new System.Drawing.Size(88, 45);
            this.HostBtn.TabIndex = 1;
            this.HostBtn.Text = "Host Me";
            this.HostBtn.UseVisualStyleBackColor = true;
            this.HostBtn.Click += new System.EventHandler(this.HostBtn_Click);
            // 
            // kpBtn
            // 
            this.kpBtn.Location = new System.Drawing.Point(93, 12);
            this.kpBtn.Name = "kpBtn";
            this.kpBtn.Size = new System.Drawing.Size(75, 45);
            this.kpBtn.TabIndex = 2;
            this.kpBtn.Text = "Kill All Players";
            this.kpBtn.UseVisualStyleBackColor = true;
            this.kpBtn.Click += new System.EventHandler(this.kpBtn_Click);
            // 
            // pBox
            // 
            this.pBox.FormattingEnabled = true;
            this.pBox.ItemHeight = 16;
            this.pBox.Location = new System.Drawing.Point(274, 8);
            this.pBox.Name = "pBox";
            this.pBox.Size = new System.Drawing.Size(156, 244);
            this.pBox.TabIndex = 3;
            // 
            // GMBox
            // 
            this.GMBox.Location = new System.Drawing.Point(12, 113);
            this.GMBox.Name = "GMBox";
            this.GMBox.Size = new System.Drawing.Size(75, 23);
            this.GMBox.TabIndex = 4;
            this.GMBox.Text = "Set GM";
            this.GMBox.UseVisualStyleBackColor = true;
            this.GMBox.Click += new System.EventHandler(this.GMBox_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Creative"});
            this.comboBox1.Location = new System.Drawing.Point(96, 112);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(75, 24);
            this.comboBox1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 42);
            this.button1.TabIndex = 6;
            this.button1.Text = "Fill Server";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // speedMPBar
            // 
            this.speedMPBar.Location = new System.Drawing.Point(12, 202);
            this.speedMPBar.Maximum = 20;
            this.speedMPBar.Minimum = 1;
            this.speedMPBar.Name = "speedMPBar";
            this.speedMPBar.Size = new System.Drawing.Size(256, 56);
            this.speedMPBar.TabIndex = 7;
            this.speedMPBar.Value = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Player Speed";
            // 
            // INFAMMOCB
            // 
            this.INFAMMOCB.AutoSize = true;
            this.INFAMMOCB.Location = new System.Drawing.Point(78, 148);
            this.INFAMMOCB.Name = "INFAMMOCB";
            this.INFAMMOCB.Size = new System.Drawing.Size(114, 21);
            this.INFAMMOCB.TabIndex = 9;
            this.INFAMMOCB.Text = "Infinite Ammo";
            this.INFAMMOCB.UseVisualStyleBackColor = true;
            this.INFAMMOCB.CheckedChanged += new System.EventHandler(this.INFAMMOCB_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(185, 148);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(83, 21);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Inf Jump";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // spnDrag
            // 
            this.spnDrag.Location = new System.Drawing.Point(12, 60);
            this.spnDrag.Name = "spnDrag";
            this.spnDrag.Size = new System.Drawing.Size(75, 47);
            this.spnDrag.TabIndex = 11;
            this.spnDrag.Text = "Spawn Dragon";
            this.spnDrag.UseVisualStyleBackColor = true;
            this.spnDrag.Click += new System.EventHandler(this.spnDrag_Click);
            // 
            // kill_a_m
            // 
            this.kill_a_m.Location = new System.Drawing.Point(96, 59);
            this.kill_a_m.Name = "kill_a_m";
            this.kill_a_m.Size = new System.Drawing.Size(75, 47);
            this.kill_a_m.TabIndex = 12;
            this.kill_a_m.Text = "Kill All Monsters";
            this.kill_a_m.UseVisualStyleBackColor = true;
            this.kill_a_m.Click += new System.EventHandler(this.kill_a_m_Click);
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 270);
            this.Controls.Add(this.kill_a_m);
            this.Controls.Add(this.spnDrag);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.INFAMMOCB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.speedMPBar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.GMBox);
            this.Controls.Add(this.pBox);
            this.Controls.Add(this.kpBtn);
            this.Controls.Add(this.HostBtn);
            this.Controls.Add(this.godCB);
            this.Name = "MainUI";
            this.Text = "CastleMiner Z";
            ((System.ComponentModel.ISupportInitialize)(this.speedMPBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox godCB;
        private System.Windows.Forms.Button HostBtn;
        private System.Windows.Forms.Button kpBtn;
        private System.Windows.Forms.ListBox pBox;
        private System.Windows.Forms.Button GMBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar speedMPBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox INFAMMOCB;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button spnDrag;
        private System.Windows.Forms.Button kill_a_m;
    }
}