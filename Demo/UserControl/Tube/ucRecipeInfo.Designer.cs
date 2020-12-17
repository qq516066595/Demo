namespace Demo.UserControl.Tube
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
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
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
            this.txtRecipeName = new System.Windows.Forms.TextBox();
            this.txtRecipeTotalTime = new System.Windows.Forms.TextBox();
            this.txtRecipeWorkingTime = new System.Windows.Forms.TextBox();
            this.txtRecipeRemainTime = new System.Windows.Forms.TextBox();
            this.txtStepID = new System.Windows.Forms.TextBox();
            this.txtStepName = new System.Windows.Forms.TextBox();
            this.txtStepTotalTime = new System.Windows.Forms.TextBox();
            this.txtStepWorkingTime = new System.Windows.Forms.TextBox();
            this.txtStepRemainTime = new System.Windows.Forms.TextBox();
            this.lblBoatState = new DevExpress.XtraEditors.LabelControl();
            this.cmbBoatState = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.tsAutoSelect.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbcRecipeBar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbcStepBar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBoatState.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(55, 49);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(102, 19);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "当前工艺设置";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(22, 11);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(28, 17);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "手动";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(148, 11);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(28, 17);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "自动";
            // 
            // tsAutoSelect
            // 
            this.tsAutoSelect.Location = new System.Drawing.Point(66, 6);
            this.tsAutoSelect.Name = "tsAutoSelect";
            this.tsAutoSelect.Properties.OffText = "自动";
            this.tsAutoSelect.Properties.OnText = "手动";
            this.tsAutoSelect.Properties.ShowText = false;
            this.tsAutoSelect.Size = new System.Drawing.Size(76, 25);
            this.tsAutoSelect.TabIndex = 3;
            // 
            // separatorControl1
            // 
            this.separatorControl1.Location = new System.Drawing.Point(0, 31);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(205, 19);
            this.separatorControl1.TabIndex = 4;
            // 
            // btnStart
            // 
            this.btnStart.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Appearance.Options.UseFont = true;
            this.btnStart.Location = new System.Drawing.Point(56, 81);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(95, 30);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "开始";
            // 
            // btnHold
            // 
            this.btnHold.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHold.Appearance.Options.UseFont = true;
            this.btnHold.Location = new System.Drawing.Point(56, 116);
            this.btnHold.Name = "btnHold";
            this.btnHold.Size = new System.Drawing.Size(95, 30);
            this.btnHold.TabIndex = 5;
            this.btnHold.Text = "保持";
            // 
            // btnJumpStep
            // 
            this.btnJumpStep.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJumpStep.Appearance.Options.UseFont = true;
            this.btnJumpStep.Location = new System.Drawing.Point(56, 151);
            this.btnJumpStep.Name = "btnJumpStep";
            this.btnJumpStep.Size = new System.Drawing.Size(95, 30);
            this.btnJumpStep.TabIndex = 5;
            this.btnJumpStep.Text = "跳步";
            // 
            // btnAbort
            // 
            this.btnAbort.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbort.Appearance.Options.UseFont = true;
            this.btnAbort.Location = new System.Drawing.Point(56, 186);
            this.btnAbort.Name = "btnAbort";
            this.btnAbort.Size = new System.Drawing.Size(95, 30);
            this.btnAbort.TabIndex = 5;
            this.btnAbort.Text = "中断";
            // 
            // btnFinish
            // 
            this.btnFinish.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinish.Appearance.Options.UseFont = true;
            this.btnFinish.Location = new System.Drawing.Point(56, 221);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(95, 30);
            this.btnFinish.TabIndex = 5;
            this.btnFinish.Text = "结束";
            // 
            // separatorControl2
            // 
            this.separatorControl2.Location = new System.Drawing.Point(0, 317);
            this.separatorControl2.Name = "separatorControl2";
            this.separatorControl2.Size = new System.Drawing.Size(205, 19);
            this.separatorControl2.TabIndex = 4;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(46, 342);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(102, 19);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "当前工艺信息";
            // 
            // btnTubeDisable
            // 
            this.btnTubeDisable.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTubeDisable.Appearance.ForeColor = System.Drawing.Color.Red;
            this.btnTubeDisable.Appearance.Options.UseFont = true;
            this.btnTubeDisable.Appearance.Options.UseForeColor = true;
            this.btnTubeDisable.Location = new System.Drawing.Point(56, 256);
            this.btnTubeDisable.Name = "btnTubeDisable";
            this.btnTubeDisable.Size = new System.Drawing.Size(95, 30);
            this.btnTubeDisable.TabIndex = 5;
            this.btnTubeDisable.Text = "锁管";
            // 
            // pbcRecipeBar
            // 
            this.pbcRecipeBar.EditValue = "10";
            this.pbcRecipeBar.Location = new System.Drawing.Point(7, 373);
            this.pbcRecipeBar.Name = "pbcRecipeBar";
            this.pbcRecipeBar.Properties.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pbcRecipeBar.Properties.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pbcRecipeBar.Size = new System.Drawing.Size(186, 18);
            this.pbcRecipeBar.TabIndex = 6;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(7, 408);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(56, 17);
            this.labelControl5.TabIndex = 1;
            this.labelControl5.Text = "工艺名称";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(7, 448);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(56, 17);
            this.labelControl6.TabIndex = 1;
            this.labelControl6.Text = "工艺总时";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(7, 488);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(56, 17);
            this.labelControl7.TabIndex = 1;
            this.labelControl7.Text = "工艺运行";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(7, 528);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(56, 17);
            this.labelControl8.TabIndex = 1;
            this.labelControl8.Text = "工艺剩余";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(46, 574);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(85, 19);
            this.labelControl9.TabIndex = 0;
            this.labelControl9.Text = "当前步信息";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(23, 639);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(28, 17);
            this.labelControl10.TabIndex = 1;
            this.labelControl10.Text = "步号";
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(15, 678);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(42, 17);
            this.labelControl11.TabIndex = 1;
            this.labelControl11.Text = "步名称";
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Location = new System.Drawing.Point(15, 717);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(42, 17);
            this.labelControl12.TabIndex = 1;
            this.labelControl12.Text = "步总时";
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Location = new System.Drawing.Point(15, 756);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(42, 17);
            this.labelControl13.TabIndex = 1;
            this.labelControl13.Text = "步运行";
            // 
            // separatorControl3
            // 
            this.separatorControl3.Location = new System.Drawing.Point(0, 553);
            this.separatorControl3.Name = "separatorControl3";
            this.separatorControl3.Size = new System.Drawing.Size(205, 19);
            this.separatorControl3.TabIndex = 4;
            // 
            // pbcStepBar
            // 
            this.pbcStepBar.EditValue = "73";
            this.pbcStepBar.Location = new System.Drawing.Point(7, 605);
            this.pbcStepBar.Name = "pbcStepBar";
            this.pbcStepBar.Properties.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pbcStepBar.Properties.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pbcStepBar.Size = new System.Drawing.Size(186, 18);
            this.pbcStepBar.TabIndex = 6;
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl14.Appearance.Options.UseFont = true;
            this.labelControl14.Location = new System.Drawing.Point(15, 795);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(48, 19);
            this.labelControl14.TabIndex = 1;
            this.labelControl14.Text = "步剩余";
            // 
            // txtRecipeName
            // 
            this.txtRecipeName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRecipeName.Enabled = false;
            this.txtRecipeName.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtRecipeName.Location = new System.Drawing.Point(75, 408);
            this.txtRecipeName.Name = "txtRecipeName";
            this.txtRecipeName.Size = new System.Drawing.Size(118, 20);
            this.txtRecipeName.TabIndex = 7;
            // 
            // txtRecipeTotalTime
            // 
            this.txtRecipeTotalTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRecipeTotalTime.Enabled = false;
            this.txtRecipeTotalTime.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtRecipeTotalTime.Location = new System.Drawing.Point(75, 448);
            this.txtRecipeTotalTime.Name = "txtRecipeTotalTime";
            this.txtRecipeTotalTime.Size = new System.Drawing.Size(118, 20);
            this.txtRecipeTotalTime.TabIndex = 7;
            // 
            // txtRecipeWorkingTime
            // 
            this.txtRecipeWorkingTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRecipeWorkingTime.Enabled = false;
            this.txtRecipeWorkingTime.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtRecipeWorkingTime.Location = new System.Drawing.Point(75, 488);
            this.txtRecipeWorkingTime.Name = "txtRecipeWorkingTime";
            this.txtRecipeWorkingTime.Size = new System.Drawing.Size(118, 20);
            this.txtRecipeWorkingTime.TabIndex = 7;
            // 
            // txtRecipeRemainTime
            // 
            this.txtRecipeRemainTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRecipeRemainTime.Enabled = false;
            this.txtRecipeRemainTime.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtRecipeRemainTime.Location = new System.Drawing.Point(75, 528);
            this.txtRecipeRemainTime.Name = "txtRecipeRemainTime";
            this.txtRecipeRemainTime.Size = new System.Drawing.Size(118, 20);
            this.txtRecipeRemainTime.TabIndex = 7;
            // 
            // txtStepID
            // 
            this.txtStepID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStepID.Enabled = false;
            this.txtStepID.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtStepID.Location = new System.Drawing.Point(75, 639);
            this.txtStepID.Name = "txtStepID";
            this.txtStepID.Size = new System.Drawing.Size(118, 20);
            this.txtStepID.TabIndex = 7;
            // 
            // txtStepName
            // 
            this.txtStepName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStepName.Enabled = false;
            this.txtStepName.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtStepName.Location = new System.Drawing.Point(75, 678);
            this.txtStepName.Name = "txtStepName";
            this.txtStepName.Size = new System.Drawing.Size(118, 20);
            this.txtStepName.TabIndex = 7;
            // 
            // txtStepTotalTime
            // 
            this.txtStepTotalTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStepTotalTime.Enabled = false;
            this.txtStepTotalTime.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtStepTotalTime.Location = new System.Drawing.Point(75, 717);
            this.txtStepTotalTime.Name = "txtStepTotalTime";
            this.txtStepTotalTime.Size = new System.Drawing.Size(118, 20);
            this.txtStepTotalTime.TabIndex = 7;
            // 
            // txtStepWorkingTime
            // 
            this.txtStepWorkingTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStepWorkingTime.Enabled = false;
            this.txtStepWorkingTime.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtStepWorkingTime.Location = new System.Drawing.Point(75, 756);
            this.txtStepWorkingTime.Name = "txtStepWorkingTime";
            this.txtStepWorkingTime.Size = new System.Drawing.Size(118, 20);
            this.txtStepWorkingTime.TabIndex = 7;
            // 
            // txtStepRemainTime
            // 
            this.txtStepRemainTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStepRemainTime.Enabled = false;
            this.txtStepRemainTime.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtStepRemainTime.Location = new System.Drawing.Point(75, 795);
            this.txtStepRemainTime.Name = "txtStepRemainTime";
            this.txtStepRemainTime.Size = new System.Drawing.Size(118, 20);
            this.txtStepRemainTime.TabIndex = 7;
            // 
            // lblBoatState
            // 
            this.lblBoatState.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoatState.Appearance.Options.UseFont = true;
            this.lblBoatState.Location = new System.Drawing.Point(15, 298);
            this.lblBoatState.Name = "lblBoatState";
            this.lblBoatState.Size = new System.Drawing.Size(48, 19);
            this.lblBoatState.TabIndex = 1;
            this.lblBoatState.Text = "舟状态";
            // 
            // cmbBoatState
            // 
            this.cmbBoatState.Location = new System.Drawing.Point(75, 295);
            this.cmbBoatState.Name = "cmbBoatState";
            this.cmbBoatState.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            "空桨饱和完成",
            "正在工艺",
            "待清洗舟"});
            this.cmbBoatState.Size = new System.Drawing.Size(118, 26);
            this.cmbBoatState.TabIndex = 8;
            // 
            // ucRecipeInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbBoatState);
            this.Controls.Add(this.txtStepRemainTime);
            this.Controls.Add(this.txtStepWorkingTime);
            this.Controls.Add(this.txtStepTotalTime);
            this.Controls.Add(this.txtStepName);
            this.Controls.Add(this.txtStepID);
            this.Controls.Add(this.txtRecipeRemainTime);
            this.Controls.Add(this.txtRecipeWorkingTime);
            this.Controls.Add(this.txtRecipeTotalTime);
            this.Controls.Add(this.txtRecipeName);
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
            this.Controls.Add(this.lblBoatState);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl1);
            this.Name = "ucRecipeInfo";
            this.Size = new System.Drawing.Size(205, 835);
            ((System.ComponentModel.ISupportInitialize)(this.tsAutoSelect.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbcRecipeBar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbcStepBar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBoatState.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
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
        private System.Windows.Forms.TextBox txtRecipeName;
        private System.Windows.Forms.TextBox txtRecipeTotalTime;
        private System.Windows.Forms.TextBox txtRecipeWorkingTime;
        private System.Windows.Forms.TextBox txtRecipeRemainTime;
        private System.Windows.Forms.TextBox txtStepID;
        private System.Windows.Forms.TextBox txtStepName;
        private System.Windows.Forms.TextBox txtStepTotalTime;
        private System.Windows.Forms.TextBox txtStepWorkingTime;
        private System.Windows.Forms.TextBox txtStepRemainTime;
        private DevExpress.XtraEditors.LabelControl lblBoatState;
        private DevExpress.XtraEditors.ComboBoxEdit cmbBoatState;
    }
}
