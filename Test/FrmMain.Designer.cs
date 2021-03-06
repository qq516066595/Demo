﻿namespace Test
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.tvMenu = new HZH_Controls.Controls.TreeViewEx();
            this.ucSplitLine_V1 = new HZH_Controls.Controls.UCSplitLine_V();
            this.panControl = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsCompanyName = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.scrollbarComponent1 = new HZH_Controls.Controls.ScrollbarComponent(this.components);
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.lblLoader = new System.Windows.Forms.Label();
            this.lblT5 = new System.Windows.Forms.Label();
            this.lblT4 = new System.Windows.Forms.Label();
            this.lblT3 = new System.Windows.Forms.Label();
            this.lblT2 = new System.Windows.Forms.Label();
            this.lblT1 = new System.Windows.Forms.Label();
            this.lblCurrentLocation = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvMenu
            // 
            this.tvMenu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tvMenu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.tvMenu.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawAll;
            this.tvMenu.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.tvMenu.ForeColor = System.Drawing.Color.Black;
            this.tvMenu.FullRowSelect = true;
            this.tvMenu.HideSelection = false;
            this.tvMenu.IsShowByCustomModel = true;
            this.tvMenu.IsShowTip = false;
            this.tvMenu.ItemHeight = 50;
            this.tvMenu.LineColor = System.Drawing.Color.LightGray;
            this.tvMenu.Location = new System.Drawing.Point(0, 61);
            this.tvMenu.LstTips = ((System.Collections.Generic.Dictionary<string, string>)(resources.GetObject("tvMenu.LstTips")));
            this.tvMenu.Name = "tvMenu";
            this.tvMenu.NodeBackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.tvMenu.NodeDownPic = ((System.Drawing.Image)(resources.GetObject("tvMenu.NodeDownPic")));
            this.tvMenu.NodeForeColor = System.Drawing.Color.DimGray;
            this.tvMenu.NodeHeight = 50;
            this.tvMenu.NodeIsShowSplitLine = true;
            this.tvMenu.NodeSelectedColor = System.Drawing.Color.Silver;
            this.tvMenu.NodeSelectedForeColor = System.Drawing.Color.Black;
            this.tvMenu.NodeSplitLineColor = System.Drawing.Color.Silver;
            this.tvMenu.NodeUpPic = ((System.Drawing.Image)(resources.GetObject("tvMenu.NodeUpPic")));
            this.tvMenu.ParentNodeCanSelect = true;
            this.tvMenu.ShowLines = false;
            this.tvMenu.ShowPlusMinus = false;
            this.tvMenu.ShowRootLines = false;
            this.tvMenu.Size = new System.Drawing.Size(114, 707);
            this.tvMenu.TabIndex = 7;
            this.tvMenu.TipFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tvMenu.TipImage = ((System.Drawing.Image)(resources.GetObject("tvMenu.TipImage")));
            this.scrollbarComponent1.SetUserCustomScrollbar(this.tvMenu, true);
            this.tvMenu.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvMenu_AfterSelect);
            // 
            // ucSplitLine_V1
            // 
            this.ucSplitLine_V1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.ucSplitLine_V1.Dock = System.Windows.Forms.DockStyle.Left;
            this.ucSplitLine_V1.Location = new System.Drawing.Point(114, 61);
            this.ucSplitLine_V1.Name = "ucSplitLine_V1";
            this.ucSplitLine_V1.Size = new System.Drawing.Size(1, 707);
            this.ucSplitLine_V1.TabIndex = 8;
            this.ucSplitLine_V1.TabStop = false;
            // 
            // panControl
            // 
            this.panControl.AutoScroll = true;
            this.panControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panControl.Location = new System.Drawing.Point(115, 110);
            this.panControl.Name = "panControl";
            this.panControl.Size = new System.Drawing.Size(909, 626);
            this.panControl.TabIndex = 9;
            this.scrollbarComponent1.SetUserCustomScrollbar(this.panControl, true);
            this.panControl.Click += new System.EventHandler(this.Lable_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.statusStrip1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(115, 736);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(909, 32);
            this.panel1.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusStrip1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.tsTime,
            this.tsCompanyName});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(909, 31);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(56, 26);
            this.toolStripStatusLabel1.Text = "用户名：";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(70, 26);
            this.toolStripStatusLabel2.Text = "UserName";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(83, 26);
            this.toolStripStatusLabel3.Text = "      系统时间:";
            // 
            // tsTime
            // 
            this.tsTime.Name = "tsTime";
            this.tsTime.Size = new System.Drawing.Size(36, 26);
            this.tsTime.Text = "Time";
            // 
            // tsCompanyName
            // 
            this.tsCompanyName.IsLink = true;
            this.tsCompanyName.Name = "tsCompanyName";
            this.tsCompanyName.Size = new System.Drawing.Size(649, 26);
            this.tsCompanyName.Spring = true;
            this.tsCompanyName.Text = "深圳市拉普拉斯能源技术有限公司";
            this.tsCompanyName.Click += new System.EventHandler(this.tsCompanyName_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(909, 1);
            this.label1.TabIndex = 1;
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.lblLoader);
            this.pnlMenu.Controls.Add(this.lblT5);
            this.pnlMenu.Controls.Add(this.lblT4);
            this.pnlMenu.Controls.Add(this.lblT3);
            this.pnlMenu.Controls.Add(this.lblT2);
            this.pnlMenu.Controls.Add(this.lblT1);
            this.pnlMenu.Controls.Add(this.lblCurrentLocation);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenu.Location = new System.Drawing.Point(115, 61);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(909, 49);
            this.pnlMenu.TabIndex = 10;
            // 
            // lblLoader
            // 
            this.lblLoader.AutoSize = true;
            this.lblLoader.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblLoader.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLoader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblLoader.Location = new System.Drawing.Point(401, 0);
            this.lblLoader.Name = "lblLoader";
            this.lblLoader.Padding = new System.Windows.Forms.Padding(10, 15, 10, 0);
            this.lblLoader.Size = new System.Drawing.Size(78, 36);
            this.lblLoader.TabIndex = 25;
            this.lblLoader.Tag = "0";
            this.lblLoader.Text = "机械手";
            this.lblLoader.Click += new System.EventHandler(this.Lable_Click);
            // 
            // lblT5
            // 
            this.lblT5.AutoSize = true;
            this.lblT5.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblT5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblT5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblT5.Location = new System.Drawing.Point(323, 0);
            this.lblT5.Name = "lblT5";
            this.lblT5.Padding = new System.Windows.Forms.Padding(10, 15, 10, 0);
            this.lblT5.Size = new System.Drawing.Size(78, 36);
            this.lblT5.TabIndex = 26;
            this.lblT5.Tag = "5";
            this.lblT5.Text = "炉管五";
            this.lblT5.Click += new System.EventHandler(this.Lable_Click);
            // 
            // lblT4
            // 
            this.lblT4.AutoSize = true;
            this.lblT4.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblT4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblT4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblT4.Location = new System.Drawing.Point(245, 0);
            this.lblT4.Name = "lblT4";
            this.lblT4.Padding = new System.Windows.Forms.Padding(10, 15, 10, 0);
            this.lblT4.Size = new System.Drawing.Size(78, 36);
            this.lblT4.TabIndex = 27;
            this.lblT4.Tag = "4";
            this.lblT4.Text = "炉管四";
            this.lblT4.Click += new System.EventHandler(this.Lable_Click);
            // 
            // lblT3
            // 
            this.lblT3.AutoSize = true;
            this.lblT3.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblT3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblT3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblT3.Location = new System.Drawing.Point(167, 0);
            this.lblT3.Name = "lblT3";
            this.lblT3.Padding = new System.Windows.Forms.Padding(10, 15, 10, 0);
            this.lblT3.Size = new System.Drawing.Size(78, 36);
            this.lblT3.TabIndex = 28;
            this.lblT3.Tag = "3";
            this.lblT3.Text = "炉管三";
            this.lblT3.Click += new System.EventHandler(this.Lable_Click);
            // 
            // lblT2
            // 
            this.lblT2.AutoSize = true;
            this.lblT2.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblT2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblT2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblT2.Location = new System.Drawing.Point(89, 0);
            this.lblT2.Name = "lblT2";
            this.lblT2.Padding = new System.Windows.Forms.Padding(10, 15, 10, 0);
            this.lblT2.Size = new System.Drawing.Size(78, 36);
            this.lblT2.TabIndex = 29;
            this.lblT2.Tag = "2";
            this.lblT2.Text = "炉管二";
            this.lblT2.Click += new System.EventHandler(this.Lable_Click);
            // 
            // lblT1
            // 
            this.lblT1.AutoSize = true;
            this.lblT1.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblT1.Font = new System.Drawing.Font("微软雅黑", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblT1.Location = new System.Drawing.Point(0, 0);
            this.lblT1.Name = "lblT1";
            this.lblT1.Padding = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.lblT1.Size = new System.Drawing.Size(89, 36);
            this.lblT1.TabIndex = 30;
            this.lblT1.Tag = "1";
            this.lblT1.Text = "炉管一";
            this.lblT1.Click += new System.EventHandler(this.Lable_Click);
            // 
            // lblCurrentLocation
            // 
            this.lblCurrentLocation.AutoSize = true;
            this.lblCurrentLocation.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentLocation.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblCurrentLocation.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCurrentLocation.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblCurrentLocation.Location = new System.Drawing.Point(788, 0);
            this.lblCurrentLocation.Name = "lblCurrentLocation";
            this.lblCurrentLocation.Padding = new System.Windows.Forms.Padding(0, 10, 0, 8);
            this.lblCurrentLocation.Size = new System.Drawing.Size(121, 38);
            this.lblCurrentLocation.TabIndex = 24;
            this.lblCurrentLocation.Text = "当前位置：炉管一";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.panControl);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucSplitLine_V1);
            this.Controls.Add(this.tvMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsFullSize = true;
            this.IsShowCloseBtn = true;
            this.Name = "FrmMain";
            this.ShowIcon = true;
            this.ShowInTaskbar = true;
            this.Text = "FrmMain";
            this.Title = "磷扩散控制系统--首页";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.Controls.SetChildIndex(this.tvMenu, 0);
            this.Controls.SetChildIndex(this.ucSplitLine_V1, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.pnlMenu, 0);
            this.Controls.SetChildIndex(this.panControl, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public HZH_Controls.Controls.TreeViewEx tvMenu;
        private HZH_Controls.Controls.UCSplitLine_V ucSplitLine_V1;
        private System.Windows.Forms.Panel panControl;
        private System.Windows.Forms.Panel panel1;
        private HZH_Controls.Controls.ScrollbarComponent scrollbarComponent1;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLoader;
        private System.Windows.Forms.Label lblT5;
        private System.Windows.Forms.Label lblT4;
        private System.Windows.Forms.Label lblT3;
        private System.Windows.Forms.Label lblT2;
        private System.Windows.Forms.Label lblT1;
        private System.Windows.Forms.Label lblCurrentLocation;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel tsCompanyName;
        internal System.Windows.Forms.Timer timer1;
        internal System.Windows.Forms.ToolStripStatusLabel tsTime;
    }
}