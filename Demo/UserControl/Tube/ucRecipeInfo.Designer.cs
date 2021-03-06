﻿namespace Demo.UserControl.Tube
{
    partial class ucRecipeInfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tsAutoSelect = new DevExpress.XtraEditors.ToggleSwitch();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.btnStart = new DevExpress.XtraEditors.SimpleButton();
            this.btnHold = new DevExpress.XtraEditors.SimpleButton();
            this.btnJumpStep = new DevExpress.XtraEditors.SimpleButton();
            this.btnAbort = new DevExpress.XtraEditors.SimpleButton();
            this.btnFinish = new DevExpress.XtraEditors.SimpleButton();
            this.separatorControl2 = new DevExpress.XtraEditors.SeparatorControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btnTubeDisable = new DevExpress.XtraEditors.SimpleButton();
            this.pbcRecipeBar = new DevExpress.XtraEditors.ProgressBarControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.separatorControl3 = new DevExpress.XtraEditors.SeparatorControl();
            this.pbcStepBar = new DevExpress.XtraEditors.ProgressBarControl();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.lblRecipeName = new DevExpress.XtraEditors.LabelControl();
            this.lblRecipeTotalTime = new DevExpress.XtraEditors.LabelControl();
            this.lblRecipeWorkTime = new DevExpress.XtraEditors.LabelControl();
            this.lblRecipeRemainTime = new DevExpress.XtraEditors.LabelControl();
            this.lblStepID = new DevExpress.XtraEditors.LabelControl();
            this.lblStepName = new DevExpress.XtraEditors.LabelControl();
            this.lblStepTotalTime = new DevExpress.XtraEditors.LabelControl();
            this.lblStepWorkTime = new DevExpress.XtraEditors.LabelControl();
            this.lblStepRemainTime = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cmbBoatState = new DevExpress.XtraEditors.ComboBoxEdit();
            this.separatorControl4 = new DevExpress.XtraEditors.SeparatorControl();
            ((System.ComponentModel.ISupportInitialize)(this.tsAutoSelect.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbcRecipeBar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbcStepBar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBoatState.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl4)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(60, 160);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(96, 31);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "工艺设置";
            // 
            // tsAutoSelect
            // 
            this.tsAutoSelect.Location = new System.Drawing.Point(60, 13);
            this.tsAutoSelect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tsAutoSelect.Name = "tsAutoSelect";
            this.tsAutoSelect.Properties.OffText = "";
            this.tsAutoSelect.Properties.OnText = "";
            this.tsAutoSelect.Properties.ShowText = false;
            this.tsAutoSelect.Size = new System.Drawing.Size(109, 34);
            this.tsAutoSelect.TabIndex = 3;
            this.tsAutoSelect.Toggled += new System.EventHandler(this.tsAutoSelect_Toggled);
            // 
            // separatorControl1
            // 
            this.separatorControl1.Location = new System.Drawing.Point(7, 49);
            this.separatorControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Padding = new System.Windows.Forms.Padding(13, 14, 13, 14);
            this.separatorControl1.Size = new System.Drawing.Size(209, 30);
            this.separatorControl1.TabIndex = 4;
            // 
            // btnStart
            // 
            this.btnStart.Appearance.BackColor = System.Drawing.Color.Lime;
            this.btnStart.Appearance.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnStart.Appearance.Options.UseBackColor = true;
            this.btnStart.Appearance.Options.UseFont = true;
            this.btnStart.Location = new System.Drawing.Point(44, 204);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(136, 47);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "开始";
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // btnHold
            // 
            this.btnHold.Appearance.BackColor = System.Drawing.Color.Yellow;
            this.btnHold.Appearance.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnHold.Appearance.Options.UseBackColor = true;
            this.btnHold.Appearance.Options.UseFont = true;
            this.btnHold.Location = new System.Drawing.Point(44, 259);
            this.btnHold.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHold.Name = "btnHold";
            this.btnHold.Size = new System.Drawing.Size(136, 47);
            this.btnHold.TabIndex = 5;
            this.btnHold.Text = "保持";
            this.btnHold.Click += new System.EventHandler(this.btnHold_Click);
            // 
            // btnJumpStep
            // 
            this.btnJumpStep.Appearance.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnJumpStep.Appearance.Options.UseFont = true;
            this.btnJumpStep.Location = new System.Drawing.Point(44, 314);
            this.btnJumpStep.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnJumpStep.Name = "btnJumpStep";
            this.btnJumpStep.Size = new System.Drawing.Size(136, 47);
            this.btnJumpStep.TabIndex = 5;
            this.btnJumpStep.Text = "跳步";
            this.btnJumpStep.Click += new System.EventHandler(this.btnJumpStep_Click);
            // 
            // btnAbort
            // 
            this.btnAbort.Appearance.BackColor = System.Drawing.Color.Red;
            this.btnAbort.Appearance.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnAbort.Appearance.Options.UseBackColor = true;
            this.btnAbort.Appearance.Options.UseFont = true;
            this.btnAbort.Location = new System.Drawing.Point(44, 369);
            this.btnAbort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAbort.Name = "btnAbort";
            this.btnAbort.Size = new System.Drawing.Size(136, 47);
            this.btnAbort.TabIndex = 5;
            this.btnAbort.Text = "中断";
            this.btnAbort.Click += new System.EventHandler(this.btnAbort_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.Appearance.BackColor = System.Drawing.Color.Red;
            this.btnFinish.Appearance.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnFinish.Appearance.Options.UseBackColor = true;
            this.btnFinish.Appearance.Options.UseFont = true;
            this.btnFinish.Location = new System.Drawing.Point(44, 424);
            this.btnFinish.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(136, 47);
            this.btnFinish.TabIndex = 5;
            this.btnFinish.Text = "结束";
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // separatorControl2
            // 
            this.separatorControl2.Location = new System.Drawing.Point(10, 534);
            this.separatorControl2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.separatorControl2.Name = "separatorControl2";
            this.separatorControl2.Padding = new System.Windows.Forms.Padding(13, 14, 13, 14);
            this.separatorControl2.Size = new System.Drawing.Size(206, 30);
            this.separatorControl2.TabIndex = 4;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(60, 574);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(96, 31);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "工艺信息";
            // 
            // btnTubeDisable
            // 
            this.btnTubeDisable.Appearance.BackColor = System.Drawing.Color.Red;
            this.btnTubeDisable.Appearance.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnTubeDisable.Appearance.ForeColor = System.Drawing.Color.Red;
            this.btnTubeDisable.Appearance.Options.UseBackColor = true;
            this.btnTubeDisable.Appearance.Options.UseFont = true;
            this.btnTubeDisable.Appearance.Options.UseForeColor = true;
            this.btnTubeDisable.Location = new System.Drawing.Point(44, 479);
            this.btnTubeDisable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTubeDisable.Name = "btnTubeDisable";
            this.btnTubeDisable.Size = new System.Drawing.Size(136, 47);
            this.btnTubeDisable.TabIndex = 5;
            this.btnTubeDisable.Text = "锁管";
            this.btnTubeDisable.Click += new System.EventHandler(this.btnTubeDisable_Click);
            // 
            // pbcRecipeBar
            // 
            this.pbcRecipeBar.EditValue = "10";
            this.pbcRecipeBar.Location = new System.Drawing.Point(10, 622);
            this.pbcRecipeBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbcRecipeBar.Name = "pbcRecipeBar";
            this.pbcRecipeBar.Properties.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pbcRecipeBar.Properties.ShowTitle = true;
            this.pbcRecipeBar.Properties.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pbcRecipeBar.Size = new System.Drawing.Size(206, 28);
            this.pbcRecipeBar.TabIndex = 6;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(10, 677);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(42, 28);
            this.labelControl5.TabIndex = 1;
            this.labelControl5.Text = "名称";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(10, 734);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(42, 28);
            this.labelControl6.TabIndex = 1;
            this.labelControl6.Text = "总时";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(10, 790);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(42, 28);
            this.labelControl7.TabIndex = 1;
            this.labelControl7.Text = "运行";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(10, 847);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(42, 28);
            this.labelControl8.TabIndex = 1;
            this.labelControl8.Text = "剩余";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(73, 929);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(72, 31);
            this.labelControl9.TabIndex = 0;
            this.labelControl9.Text = "步信息";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(10, 1025);
            this.labelControl10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(42, 28);
            this.labelControl10.TabIndex = 1;
            this.labelControl10.Text = "步号";
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(10, 1080);
            this.labelControl11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(42, 28);
            this.labelControl11.TabIndex = 1;
            this.labelControl11.Text = "名称";
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Location = new System.Drawing.Point(10, 1135);
            this.labelControl12.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(42, 28);
            this.labelControl12.TabIndex = 1;
            this.labelControl12.Text = "总时";
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Location = new System.Drawing.Point(10, 1190);
            this.labelControl13.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(42, 28);
            this.labelControl13.TabIndex = 1;
            this.labelControl13.Text = "运行";
            // 
            // separatorControl3
            // 
            this.separatorControl3.Location = new System.Drawing.Point(7, 889);
            this.separatorControl3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.separatorControl3.Name = "separatorControl3";
            this.separatorControl3.Padding = new System.Windows.Forms.Padding(13, 14, 13, 14);
            this.separatorControl3.Size = new System.Drawing.Size(209, 30);
            this.separatorControl3.TabIndex = 4;
            // 
            // pbcStepBar
            // 
            this.pbcStepBar.EditValue = "73";
            this.pbcStepBar.Location = new System.Drawing.Point(10, 971);
            this.pbcStepBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbcStepBar.Name = "pbcStepBar";
            this.pbcStepBar.Properties.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pbcStepBar.Properties.ShowTitle = true;
            this.pbcStepBar.Properties.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pbcStepBar.Size = new System.Drawing.Size(206, 28);
            this.pbcStepBar.TabIndex = 6;
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.labelControl14.Appearance.Options.UseFont = true;
            this.labelControl14.Location = new System.Drawing.Point(7, 1245);
            this.labelControl14.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(42, 28);
            this.labelControl14.TabIndex = 1;
            this.labelControl14.Text = "剩余";
            // 
            // lblRecipeName
            // 
            this.lblRecipeName.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecipeName.Appearance.Options.UseFont = true;
            this.lblRecipeName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblRecipeName.Location = new System.Drawing.Point(70, 680);
            this.lblRecipeName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblRecipeName.Name = "lblRecipeName";
            this.lblRecipeName.Size = new System.Drawing.Size(146, 22);
            this.lblRecipeName.TabIndex = 9;
            this.lblRecipeName.Text = "无";
            // 
            // lblRecipeTotalTime
            // 
            this.lblRecipeTotalTime.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Underline);
            this.lblRecipeTotalTime.Appearance.Options.UseFont = true;
            this.lblRecipeTotalTime.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblRecipeTotalTime.Location = new System.Drawing.Point(70, 737);
            this.lblRecipeTotalTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblRecipeTotalTime.Name = "lblRecipeTotalTime";
            this.lblRecipeTotalTime.Size = new System.Drawing.Size(146, 22);
            this.lblRecipeTotalTime.TabIndex = 9;
            this.lblRecipeTotalTime.Text = "00 min 00 s";
            // 
            // lblRecipeWorkTime
            // 
            this.lblRecipeWorkTime.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Underline);
            this.lblRecipeWorkTime.Appearance.Options.UseFont = true;
            this.lblRecipeWorkTime.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblRecipeWorkTime.Location = new System.Drawing.Point(70, 794);
            this.lblRecipeWorkTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblRecipeWorkTime.Name = "lblRecipeWorkTime";
            this.lblRecipeWorkTime.Size = new System.Drawing.Size(146, 22);
            this.lblRecipeWorkTime.TabIndex = 9;
            this.lblRecipeWorkTime.Text = "00 min 00 s";
            // 
            // lblRecipeRemainTime
            // 
            this.lblRecipeRemainTime.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Underline);
            this.lblRecipeRemainTime.Appearance.Options.UseFont = true;
            this.lblRecipeRemainTime.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblRecipeRemainTime.Location = new System.Drawing.Point(70, 850);
            this.lblRecipeRemainTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblRecipeRemainTime.Name = "lblRecipeRemainTime";
            this.lblRecipeRemainTime.Size = new System.Drawing.Size(146, 22);
            this.lblRecipeRemainTime.TabIndex = 9;
            this.lblRecipeRemainTime.Text = "00 min 00 s";
            // 
            // lblStepID
            // 
            this.lblStepID.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Underline);
            this.lblStepID.Appearance.Options.UseFont = true;
            this.lblStepID.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblStepID.Location = new System.Drawing.Point(70, 1028);
            this.lblStepID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblStepID.Name = "lblStepID";
            this.lblStepID.Size = new System.Drawing.Size(146, 22);
            this.lblStepID.TabIndex = 9;
            this.lblStepID.Text = "无";
            // 
            // lblStepName
            // 
            this.lblStepName.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Underline);
            this.lblStepName.Appearance.Options.UseFont = true;
            this.lblStepName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblStepName.Location = new System.Drawing.Point(70, 1084);
            this.lblStepName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblStepName.Name = "lblStepName";
            this.lblStepName.Size = new System.Drawing.Size(146, 22);
            this.lblStepName.TabIndex = 9;
            this.lblStepName.Text = "无";
            // 
            // lblStepTotalTime
            // 
            this.lblStepTotalTime.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Underline);
            this.lblStepTotalTime.Appearance.Options.UseFont = true;
            this.lblStepTotalTime.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblStepTotalTime.Location = new System.Drawing.Point(70, 1141);
            this.lblStepTotalTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblStepTotalTime.Name = "lblStepTotalTime";
            this.lblStepTotalTime.Size = new System.Drawing.Size(146, 22);
            this.lblStepTotalTime.TabIndex = 9;
            this.lblStepTotalTime.Text = "00 min 00 s";
            // 
            // lblStepWorkTime
            // 
            this.lblStepWorkTime.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Underline);
            this.lblStepWorkTime.Appearance.Options.UseFont = true;
            this.lblStepWorkTime.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblStepWorkTime.Location = new System.Drawing.Point(70, 1197);
            this.lblStepWorkTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblStepWorkTime.Name = "lblStepWorkTime";
            this.lblStepWorkTime.Size = new System.Drawing.Size(146, 22);
            this.lblStepWorkTime.TabIndex = 9;
            this.lblStepWorkTime.Text = "00 min 00 s";
            // 
            // lblStepRemainTime
            // 
            this.lblStepRemainTime.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Underline);
            this.lblStepRemainTime.Appearance.Options.UseFont = true;
            this.lblStepRemainTime.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblStepRemainTime.Location = new System.Drawing.Point(70, 1248);
            this.lblStepRemainTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblStepRemainTime.Name = "lblStepRemainTime";
            this.lblStepRemainTime.Size = new System.Drawing.Size(146, 22);
            this.lblStepRemainTime.TabIndex = 9;
            this.lblStepRemainTime.Text = "00 min 00 s";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(14, 17);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(42, 28);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "手动";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(166, 17);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(42, 28);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "自动";
            // 
            // cmbBoatState
            // 
            this.cmbBoatState.Location = new System.Drawing.Point(44, 82);
            this.cmbBoatState.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbBoatState.Name = "cmbBoatState";
            this.cmbBoatState.Properties.Appearance.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.cmbBoatState.Properties.Appearance.Options.UseFont = true;
            this.cmbBoatState.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbBoatState.Properties.Items.AddRange(new object[] {
            " -- ",
            "无舟",
            "空舟",
            "未工艺舟",
            "已工艺舟",
            "异常舟",
            "空桨饱和",
            "饱和完成",
            "正在工艺",
            "待清洗舟"});
            this.cmbBoatState.Size = new System.Drawing.Size(136, 38);
            this.cmbBoatState.TabIndex = 10;
            this.cmbBoatState.SelectedIndexChanged += new System.EventHandler(this.CmbBoatState_SelectedIndexChanged);
            // 
            // separatorControl4
            // 
            this.separatorControl4.Location = new System.Drawing.Point(7, 126);
            this.separatorControl4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.separatorControl4.Name = "separatorControl4";
            this.separatorControl4.Padding = new System.Windows.Forms.Padding(13, 14, 13, 14);
            this.separatorControl4.Size = new System.Drawing.Size(209, 30);
            this.separatorControl4.TabIndex = 4;
            // 
            // ucRecipeInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbBoatState);
            this.Controls.Add(this.lblStepRemainTime);
            this.Controls.Add(this.lblStepWorkTime);
            this.Controls.Add(this.lblStepTotalTime);
            this.Controls.Add(this.lblStepName);
            this.Controls.Add(this.lblStepID);
            this.Controls.Add(this.lblRecipeRemainTime);
            this.Controls.Add(this.lblRecipeWorkTime);
            this.Controls.Add(this.lblRecipeTotalTime);
            this.Controls.Add(this.lblRecipeName);
            this.Controls.Add(this.pbcStepBar);
            this.Controls.Add(this.pbcRecipeBar);
            this.Controls.Add(this.btnTubeDisable);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.btnAbort);
            this.Controls.Add(this.btnJumpStep);
            this.Controls.Add(this.btnHold);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.separatorControl3);
            this.Controls.Add(this.separatorControl2);
            this.Controls.Add(this.separatorControl4);
            this.Controls.Add(this.separatorControl1);
            this.Controls.Add(this.tsAutoSelect);
            this.Controls.Add(this.labelControl14);
            this.Controls.Add(this.labelControl13);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl12);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucRecipeInfo";
            this.Size = new System.Drawing.Size(226, 1296);
            this.Load += new System.EventHandler(this.ucRecipeInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tsAutoSelect.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbcRecipeBar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbcStepBar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBoatState.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ToggleSwitch tsAutoSelect;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private DevExpress.XtraEditors.SimpleButton btnStart;
        private DevExpress.XtraEditors.SimpleButton btnHold;
        private DevExpress.XtraEditors.SimpleButton btnJumpStep;
        private DevExpress.XtraEditors.SimpleButton btnAbort;
        private DevExpress.XtraEditors.SimpleButton btnFinish;
        private DevExpress.XtraEditors.SeparatorControl separatorControl2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton btnTubeDisable;
        private DevExpress.XtraEditors.ProgressBarControl pbcRecipeBar;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.SeparatorControl separatorControl3;
        private DevExpress.XtraEditors.ProgressBarControl pbcStepBar;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.LabelControl lblRecipeName;
        private DevExpress.XtraEditors.LabelControl lblRecipeTotalTime;
        private DevExpress.XtraEditors.LabelControl lblRecipeWorkTime;
        private DevExpress.XtraEditors.LabelControl lblRecipeRemainTime;
        private DevExpress.XtraEditors.LabelControl lblStepID;
        private DevExpress.XtraEditors.LabelControl lblStepName;
        private DevExpress.XtraEditors.LabelControl lblStepTotalTime;
        private DevExpress.XtraEditors.LabelControl lblStepWorkTime;
        private DevExpress.XtraEditors.LabelControl lblStepRemainTime;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ComboBoxEdit cmbBoatState;
        private DevExpress.XtraEditors.SeparatorControl separatorControl4;
    }
}
