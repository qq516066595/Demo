﻿namespace Demo.Forms.Template
{
    partial class frmParent
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
            DevExpress.XtraSplashScreen.SplashScreenManager SplashManagerfrmLoading = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::Demo.Forms.Template.frmLoading), true, true);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmParent));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.picLogo = new DevExpress.XtraEditors.PictureEdit();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit3 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.picUserInfo = new DevExpress.XtraEditors.PictureEdit();
            this.picAbout = new DevExpress.XtraEditors.PictureEdit();
            this.picExit = new DevExpress.XtraEditors.PictureEdit();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.cmbSelectSkip = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUserInfo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAbout.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSelectSkip.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // SplashManagerfrmLoading
            // 
            SplashManagerfrmLoading.ClosingDelay = 500;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.picLogo);
            this.panelControl1.Controls.Add(this.panelControl3);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(910, 50);
            this.panelControl1.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("华文行楷", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(176, 25);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(198, 23);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "低压水平磷扩散系统";
            // 
            // picLogo
            // 
            this.picLogo.Cursor = System.Windows.Forms.Cursors.Default;
            this.picLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.picLogo.EditValue = ((object)(resources.GetObject("picLogo.EditValue")));
            this.picLogo.Location = new System.Drawing.Point(2, 2);
            this.picLogo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picLogo.Name = "picLogo";
            this.picLogo.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.Properties.Appearance.Options.UseBackColor = true;
            this.picLogo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picLogo.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picLogo.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.picLogo.Properties.ZoomAccelerationFactor = 1D;
            this.picLogo.Size = new System.Drawing.Size(170, 46);
            this.picLogo.TabIndex = 3;
            // 
            // panelControl3
            // 
            this.panelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl3.Controls.Add(this.pictureEdit2);
            this.panelControl3.Controls.Add(this.pictureEdit3);
            this.panelControl3.Controls.Add(this.pictureEdit1);
            this.panelControl3.Controls.Add(this.picUserInfo);
            this.panelControl3.Controls.Add(this.picAbout);
            this.panelControl3.Controls.Add(this.picExit);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl3.Location = new System.Drawing.Point(580, 2);
            this.panelControl3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(328, 46);
            this.panelControl3.TabIndex = 1;
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureEdit2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureEdit2.EditValue = global::Demo.Properties.Resources.CloseDoor;
            this.pictureEdit2.Location = new System.Drawing.Point(16, 0);
            this.pictureEdit2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit2.Properties.ZoomAccelerationFactor = 1D;
            this.pictureEdit2.Size = new System.Drawing.Size(52, 46);
            this.pictureEdit2.TabIndex = 9;
            // 
            // pictureEdit3
            // 
            this.pictureEdit3.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureEdit3.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureEdit3.EditValue = ((object)(resources.GetObject("pictureEdit3.EditValue")));
            this.pictureEdit3.Location = new System.Drawing.Point(68, 0);
            this.pictureEdit3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureEdit3.Name = "pictureEdit3";
            this.pictureEdit3.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit3.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit3.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit3.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit3.Properties.ZoomAccelerationFactor = 1D;
            this.pictureEdit3.Size = new System.Drawing.Size(52, 46);
            this.pictureEdit3.TabIndex = 3;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureEdit1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(120, 0);
            this.pictureEdit1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit1.Properties.ZoomAccelerationFactor = 1D;
            this.pictureEdit1.Size = new System.Drawing.Size(52, 46);
            this.pictureEdit1.TabIndex = 8;
            this.pictureEdit1.Click += new System.EventHandler(this.pictureEdit1_Click);
            // 
            // picUserInfo
            // 
            this.picUserInfo.Cursor = System.Windows.Forms.Cursors.Default;
            this.picUserInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.picUserInfo.EditValue = ((object)(resources.GetObject("picUserInfo.EditValue")));
            this.picUserInfo.Location = new System.Drawing.Point(172, 0);
            this.picUserInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picUserInfo.Name = "picUserInfo";
            this.picUserInfo.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.picUserInfo.Properties.Appearance.Options.UseBackColor = true;
            this.picUserInfo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picUserInfo.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picUserInfo.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.picUserInfo.Properties.ZoomAccelerationFactor = 1D;
            this.picUserInfo.Size = new System.Drawing.Size(52, 46);
            this.picUserInfo.TabIndex = 7;
            this.picUserInfo.Click += new System.EventHandler(this.picUserInfo_Click);
            // 
            // picAbout
            // 
            this.picAbout.Cursor = System.Windows.Forms.Cursors.Default;
            this.picAbout.Dock = System.Windows.Forms.DockStyle.Right;
            this.picAbout.EditValue = ((object)(resources.GetObject("picAbout.EditValue")));
            this.picAbout.Location = new System.Drawing.Point(224, 0);
            this.picAbout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picAbout.Name = "picAbout";
            this.picAbout.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.picAbout.Properties.Appearance.Options.UseBackColor = true;
            this.picAbout.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picAbout.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picAbout.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.picAbout.Properties.ZoomAccelerationFactor = 1D;
            this.picAbout.Size = new System.Drawing.Size(52, 46);
            this.picAbout.TabIndex = 6;
            this.picAbout.Click += new System.EventHandler(this.picAbout_Click);
            // 
            // picExit
            // 
            this.picExit.Cursor = System.Windows.Forms.Cursors.Default;
            this.picExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.picExit.EditValue = ((object)(resources.GetObject("picExit.EditValue")));
            this.picExit.Location = new System.Drawing.Point(276, 0);
            this.picExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picExit.Name = "picExit";
            this.picExit.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.picExit.Properties.Appearance.Options.UseBackColor = true;
            this.picExit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picExit.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picExit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.picExit.Properties.ZoomAccelerationFactor = 1D;
            this.picExit.Size = new System.Drawing.Size(52, 46);
            this.picExit.TabIndex = 5;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2007 Black";
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.AppearancePage.Header.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.xtraTabbedMdiManager1.AppearancePage.Header.ForeColor = System.Drawing.Color.Black;
            this.xtraTabbedMdiManager1.AppearancePage.Header.Options.UseFont = true;
            this.xtraTabbedMdiManager1.AppearancePage.Header.Options.UseForeColor = true;
            this.xtraTabbedMdiManager1.AppearancePage.HeaderActive.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.xtraTabbedMdiManager1.AppearancePage.HeaderActive.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.xtraTabbedMdiManager1.AppearancePage.HeaderActive.Options.UseFont = true;
            this.xtraTabbedMdiManager1.AppearancePage.HeaderActive.Options.UseForeColor = true;
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.labelControl6);
            this.panelControl4.Controls.Add(this.cmbSelectSkip);
            this.panelControl4.Controls.Add(this.labelControl5);
            this.panelControl4.Controls.Add(this.labelControl3);
            this.panelControl4.Controls.Add(this.labelControl4);
            this.panelControl4.Controls.Add(this.labelControl2);
            this.panelControl4.Controls.Add(this.label1);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl4.Location = new System.Drawing.Point(0, 644);
            this.panelControl4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(910, 20);
            this.panelControl4.TabIndex = 2;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelControl6.Location = new System.Drawing.Point(700, 2);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(104, 17);
            this.labelControl6.TabIndex = 1;
            this.labelControl6.Text = "2021-3-9 08:45:38";
            // 
            // cmbSelectSkip
            // 
            this.cmbSelectSkip.Dock = System.Windows.Forms.DockStyle.Right;
            this.cmbSelectSkip.Location = new System.Drawing.Point(804, 2);
            this.cmbSelectSkip.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbSelectSkip.Name = "cmbSelectSkip";
            this.cmbSelectSkip.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbSelectSkip.Properties.Items.AddRange(new object[] {
            "Office 2013 Dark Gray",
            "Visual Studio 2013 Blue",
            "Visual Studio 2013 Dark",
            "London Liquid Sky",
            "Glass Oceans",
            "Springtime",
            "Summer 2008",
            "Office 2007 Pink",
            "Xmas 2008 Blue"});
            this.cmbSelectSkip.Size = new System.Drawing.Size(104, 20);
            this.cmbSelectSkip.TabIndex = 2;
            this.cmbSelectSkip.SelectedIndexChanged += new System.EventHandler(this.cmbSelectSkip_SelectedIndexChanged);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(202, 2);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(60, 17);
            this.labelControl5.TabIndex = 1;
            this.labelControl5.Text = "LoginTime";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(50, 3);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(62, 17);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "UserName";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(134, 2);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(60, 17);
            this.labelControl4.TabIndex = 1;
            this.labelControl4.Text = "登陆时间：";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(8, 3);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(36, 17);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "用户：";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(2, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(906, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "深圳市拉普拉斯能源技术有限公司 版权©2020-12";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 664);
            this.Controls.Add(this.panelControl4);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.MaximizeBox = false;
            this.Name = "frmParent";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmParent_Load);
            this.Layout += new System.Windows.Forms.LayoutEventHandler(this.frmParent_Layout);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUserInfo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAbout.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSelectSkip.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.PictureEdit picUserInfo;
        private DevExpress.XtraEditors.PictureEdit picAbout;
        private DevExpress.XtraEditors.PictureEdit picExit;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.Utils.ImageCollection imageCollection1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit3;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PictureEdit picLogo;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private DevExpress.XtraEditors.ComboBoxEdit cmbSelectSkip;
    }
}