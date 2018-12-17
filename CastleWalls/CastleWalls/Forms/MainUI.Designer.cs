namespace CastleWalls.Forms
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SetGmBtn = new System.Windows.Forms.Button();
            this.HostCB = new System.Windows.Forms.CheckBox();
            this.MineCB = new System.Windows.Forms.CheckBox();
            this.RapidCB = new System.Windows.Forms.CheckBox();
            this.KillCB = new System.Windows.Forms.CheckBox();
            this.ammoCB = new System.Windows.Forms.CheckBox();
            this.GodCB = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SwnHellBtn = new System.Windows.Forms.Button();
            this.KillrpBtn = new System.Windows.Forms.Button();
            this.CpyItemsBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.PlayerSelect = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pJoinCB = new System.Windows.Forms.CheckBox();
            this.SpawnDragoonBtn = new System.Windows.Forms.Button();
            this.KillAllMonstersBtn = new System.Windows.Forms.Button();
            this.KillAllBtn = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.hNameLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PIDlbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pSpeedTB = new System.Windows.Forms.TrackBar();
            this.PlayerSpeedLbl = new System.Windows.Forms.Label();
            this.rPidCB = new System.Windows.Forms.CheckBox();
            this.IdStealBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pSpeedTB)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SetGmBtn);
            this.groupBox1.Controls.Add(this.HostCB);
            this.groupBox1.Controls.Add(this.MineCB);
            this.groupBox1.Controls.Add(this.RapidCB);
            this.groupBox1.Controls.Add(this.KillCB);
            this.groupBox1.Controls.Add(this.ammoCB);
            this.groupBox1.Controls.Add(this.GodCB);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 191);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Local";
            // 
            // SetGmBtn
            // 
            this.SetGmBtn.Location = new System.Drawing.Point(166, 15);
            this.SetGmBtn.Name = "SetGmBtn";
            this.SetGmBtn.Size = new System.Drawing.Size(96, 32);
            this.SetGmBtn.TabIndex = 1;
            this.SetGmBtn.Text = "Set Creative";
            this.SetGmBtn.UseVisualStyleBackColor = true;
            this.SetGmBtn.Click += new System.EventHandler(this.SetGmBtn_Click);
            // 
            // HostCB
            // 
            this.HostCB.AutoSize = true;
            this.HostCB.Location = new System.Drawing.Point(6, 155);
            this.HostCB.Name = "HostCB";
            this.HostCB.Size = new System.Drawing.Size(99, 21);
            this.HostCB.TabIndex = 1;
            this.HostCB.Text = "Force Host";
            this.HostCB.UseVisualStyleBackColor = true;
            this.HostCB.CheckedChanged += new System.EventHandler(this.HostCB_CheckedChanged);
            // 
            // MineCB
            // 
            this.MineCB.AutoSize = true;
            this.MineCB.Location = new System.Drawing.Point(6, 128);
            this.MineCB.Name = "MineCB";
            this.MineCB.Size = new System.Drawing.Size(106, 21);
            this.MineCB.TabIndex = 5;
            this.MineCB.Text = "Instant Mine";
            this.MineCB.UseVisualStyleBackColor = true;
            this.MineCB.CheckedChanged += new System.EventHandler(this.MineCB_CheckedChanged);
            // 
            // RapidCB
            // 
            this.RapidCB.AutoSize = true;
            this.RapidCB.Location = new System.Drawing.Point(5, 101);
            this.RapidCB.Name = "RapidCB";
            this.RapidCB.Size = new System.Drawing.Size(95, 21);
            this.RapidCB.TabIndex = 4;
            this.RapidCB.Text = "Rapid Fire";
            this.RapidCB.UseVisualStyleBackColor = true;
            // 
            // KillCB
            // 
            this.KillCB.AutoSize = true;
            this.KillCB.Location = new System.Drawing.Point(6, 75);
            this.KillCB.Name = "KillCB";
            this.KillCB.Size = new System.Drawing.Size(94, 21);
            this.KillCB.TabIndex = 3;
            this.KillCB.Text = "Instant Kill";
            this.KillCB.UseVisualStyleBackColor = true;
            // 
            // ammoCB
            // 
            this.ammoCB.AutoSize = true;
            this.ammoCB.Location = new System.Drawing.Point(6, 48);
            this.ammoCB.Name = "ammoCB";
            this.ammoCB.Size = new System.Drawing.Size(114, 21);
            this.ammoCB.TabIndex = 2;
            this.ammoCB.Text = "Infinite Ammo";
            this.ammoCB.UseVisualStyleBackColor = true;
            this.ammoCB.CheckedChanged += new System.EventHandler(this.ammoCB_CheckedChanged);
            // 
            // GodCB
            // 
            this.GodCB.AutoSize = true;
            this.GodCB.Location = new System.Drawing.Point(6, 21);
            this.GodCB.Name = "GodCB";
            this.GodCB.Size = new System.Drawing.Size(57, 21);
            this.GodCB.TabIndex = 1;
            this.GodCB.Text = "God";
            this.GodCB.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.IdStealBtn);
            this.groupBox2.Controls.Add(this.SwnHellBtn);
            this.groupBox2.Controls.Add(this.KillrpBtn);
            this.groupBox2.Controls.Add(this.CpyItemsBtn);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.PlayerSelect);
            this.groupBox2.Location = new System.Drawing.Point(286, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(502, 191);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Remote Players";
            // 
            // SwnHellBtn
            // 
            this.SwnHellBtn.Location = new System.Drawing.Point(6, 53);
            this.SwnHellBtn.Name = "SwnHellBtn";
            this.SwnHellBtn.Size = new System.Drawing.Size(145, 23);
            this.SwnHellBtn.TabIndex = 4;
            this.SwnHellBtn.Text = "Spawn Hell";
            this.SwnHellBtn.UseVisualStyleBackColor = true;
            this.SwnHellBtn.Click += new System.EventHandler(this.SwnHellBtn_Click);
            // 
            // KillrpBtn
            // 
            this.KillrpBtn.Location = new System.Drawing.Point(157, 21);
            this.KillrpBtn.Name = "KillrpBtn";
            this.KillrpBtn.Size = new System.Drawing.Size(70, 26);
            this.KillrpBtn.TabIndex = 3;
            this.KillrpBtn.Text = "Kill";
            this.KillrpBtn.UseVisualStyleBackColor = true;
            this.KillrpBtn.Click += new System.EventHandler(this.KillrpBtn_Click);
            // 
            // CpyItemsBtn
            // 
            this.CpyItemsBtn.Location = new System.Drawing.Point(6, 21);
            this.CpyItemsBtn.Name = "CpyItemsBtn";
            this.CpyItemsBtn.Size = new System.Drawing.Size(145, 26);
            this.CpyItemsBtn.TabIndex = 2;
            this.CpyItemsBtn.Text = "Copy Inventory";
            this.CpyItemsBtn.UseVisualStyleBackColor = true;
            this.CpyItemsBtn.Click += new System.EventHandler(this.CpyItemsBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(297, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Target";
            // 
            // PlayerSelect
            // 
            this.PlayerSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PlayerSelect.FormattingEnabled = true;
            this.PlayerSelect.Location = new System.Drawing.Point(300, 38);
            this.PlayerSelect.Name = "PlayerSelect";
            this.PlayerSelect.Size = new System.Drawing.Size(187, 24);
            this.PlayerSelect.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rPidCB);
            this.groupBox3.Controls.Add(this.pJoinCB);
            this.groupBox3.Controls.Add(this.SpawnDragoonBtn);
            this.groupBox3.Controls.Add(this.KillAllMonstersBtn);
            this.groupBox3.Controls.Add(this.KillAllBtn);
            this.groupBox3.Location = new System.Drawing.Point(12, 209);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(175, 229);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Game\\Server";
            // 
            // pJoinCB
            // 
            this.pJoinCB.AutoSize = true;
            this.pJoinCB.Location = new System.Drawing.Point(7, 117);
            this.pJoinCB.Name = "pJoinCB";
            this.pJoinCB.Size = new System.Drawing.Size(116, 21);
            this.pJoinCB.TabIndex = 4;
            this.pJoinCB.Text = "Prevent Joins";
            this.pJoinCB.UseVisualStyleBackColor = true;
            this.pJoinCB.CheckedChanged += new System.EventHandler(this.pJoinCB_CheckedChanged);
            // 
            // SpawnDragoonBtn
            // 
            this.SpawnDragoonBtn.Location = new System.Drawing.Point(6, 85);
            this.SpawnDragoonBtn.Name = "SpawnDragoonBtn";
            this.SpawnDragoonBtn.Size = new System.Drawing.Size(145, 26);
            this.SpawnDragoonBtn.TabIndex = 2;
            this.SpawnDragoonBtn.Text = "Spawn Dragoon";
            this.SpawnDragoonBtn.UseVisualStyleBackColor = true;
            this.SpawnDragoonBtn.Click += new System.EventHandler(this.SpawnDragoonBtn_Click);
            // 
            // KillAllMonstersBtn
            // 
            this.KillAllMonstersBtn.Location = new System.Drawing.Point(6, 53);
            this.KillAllMonstersBtn.Name = "KillAllMonstersBtn";
            this.KillAllMonstersBtn.Size = new System.Drawing.Size(145, 26);
            this.KillAllMonstersBtn.TabIndex = 1;
            this.KillAllMonstersBtn.Text = "Kill All Monsters";
            this.KillAllMonstersBtn.UseVisualStyleBackColor = true;
            this.KillAllMonstersBtn.Click += new System.EventHandler(this.KillAllMonstersBtn_Click);
            // 
            // KillAllBtn
            // 
            this.KillAllBtn.Location = new System.Drawing.Point(6, 21);
            this.KillAllBtn.Name = "KillAllBtn";
            this.KillAllBtn.Size = new System.Drawing.Size(145, 26);
            this.KillAllBtn.TabIndex = 0;
            this.KillAllBtn.Text = "Kill All Players";
            this.KillAllBtn.UseVisualStyleBackColor = true;
            this.KillAllBtn.Click += new System.EventHandler(this.KillAllBtn_Click);
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.hNameLbl);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.PIDlbl);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Location = new System.Drawing.Point(586, 374);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 64);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Info Display";
            // 
            // hNameLbl
            // 
            this.hNameLbl.AutoSize = true;
            this.hNameLbl.Location = new System.Drawing.Point(40, 38);
            this.hNameLbl.Name = "hNameLbl";
            this.hNameLbl.Size = new System.Drawing.Size(0, 17);
            this.hNameLbl.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Host:";
            // 
            // PIDlbl
            // 
            this.PIDlbl.AutoSize = true;
            this.PIDlbl.Location = new System.Drawing.Point(38, 18);
            this.PIDlbl.Name = "PIDlbl";
            this.PIDlbl.Size = new System.Drawing.Size(0, 17);
            this.PIDlbl.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "PID:";
            // 
            // pSpeedTB
            // 
            this.pSpeedTB.Location = new System.Drawing.Point(193, 382);
            this.pSpeedTB.Minimum = 1;
            this.pSpeedTB.Name = "pSpeedTB";
            this.pSpeedTB.Size = new System.Drawing.Size(373, 56);
            this.pSpeedTB.TabIndex = 4;
            this.pSpeedTB.Value = 1;
            this.pSpeedTB.Scroll += new System.EventHandler(this.pSpeedTB_Scroll);
            // 
            // PlayerSpeedLbl
            // 
            this.PlayerSpeedLbl.AutoSize = true;
            this.PlayerSpeedLbl.Location = new System.Drawing.Point(193, 362);
            this.PlayerSpeedLbl.Name = "PlayerSpeedLbl";
            this.PlayerSpeedLbl.Size = new System.Drawing.Size(93, 17);
            this.PlayerSpeedLbl.TabIndex = 5;
            this.PlayerSpeedLbl.Text = "Player Speed";
            // 
            // rPidCB
            // 
            this.rPidCB.AutoSize = true;
            this.rPidCB.Location = new System.Drawing.Point(7, 144);
            this.rPidCB.Name = "rPidCB";
            this.rPidCB.Size = new System.Drawing.Size(109, 21);
            this.rPidCB.TabIndex = 5;
            this.rPidCB.Text = "Random PID";
            this.rPidCB.UseVisualStyleBackColor = true;
            // 
            // IdStealBtn
            // 
            this.IdStealBtn.Location = new System.Drawing.Point(6, 82);
            this.IdStealBtn.Name = "IdStealBtn";
            this.IdStealBtn.Size = new System.Drawing.Size(145, 23);
            this.IdStealBtn.TabIndex = 5;
            this.IdStealBtn.Text = "ID Theft";
            this.IdStealBtn.UseVisualStyleBackColor = true;
            this.IdStealBtn.Click += new System.EventHandler(this.IdStealBtn_Click);
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PlayerSpeedLbl);
            this.Controls.Add(this.pSpeedTB);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainUI";
            this.Text = "CMZ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pSpeedTB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button SetGmBtn;
        private System.Windows.Forms.CheckBox HostCB;
        private System.Windows.Forms.CheckBox MineCB;
        private System.Windows.Forms.CheckBox RapidCB;
        private System.Windows.Forms.CheckBox KillCB;
        private System.Windows.Forms.CheckBox ammoCB;
        private System.Windows.Forms.CheckBox GodCB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox PlayerSelect;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button KillAllBtn;
        private System.Windows.Forms.Button KillAllMonstersBtn;
        private System.Windows.Forms.Button SpawnDragoonBtn;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Button KillrpBtn;
        private System.Windows.Forms.Button CpyItemsBtn;
        private System.Windows.Forms.CheckBox pJoinCB;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label PIDlbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label hNameLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SwnHellBtn;
        private System.Windows.Forms.TrackBar pSpeedTB;
        private System.Windows.Forms.Label PlayerSpeedLbl;
        private System.Windows.Forms.Button IdStealBtn;
        private System.Windows.Forms.CheckBox rPidCB;
    }
}