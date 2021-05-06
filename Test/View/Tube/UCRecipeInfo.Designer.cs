namespace Test.View.Tube
{
    partial class UCRecipeInfo
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblRecipeInfoTitle = new System.Windows.Forms.Label();
            this.lblLineH = new System.Windows.Forms.Label();
            this.lblLineV = new System.Windows.Forms.Label();
            this.ucSwitch = new HZH_Controls.Controls.UCSwitch();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ucBoatState = new HZH_Controls.Controls.UCCombox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ucRecipeBar = new HZH_Controls.Controls.UCTrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.ucStepBar = new HZH_Controls.Controls.UCTrackBar();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblRecipeName = new System.Windows.Forms.Label();
            this.lblRecipeTotalTime = new System.Windows.Forms.Label();
            this.lblRecipeWorkTime = new System.Windows.Forms.Label();
            this.lblRecipeRemainTime = new System.Windows.Forms.Label();
            this.lblStepId = new System.Windows.Forms.Label();
            this.lblStepName = new System.Windows.Forms.Label();
            this.lblStepTotalTime = new System.Windows.Forms.Label();
            this.lblStepWorkTime = new System.Windows.Forms.Label();
            this.lblStepRemainTime = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnHold = new System.Windows.Forms.Button();
            this.btnJumpStep = new System.Windows.Forms.Button();
            this.btnAbort = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.btnTubeDisable = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRecipeInfoTitle
            // 
            this.lblRecipeInfoTitle.AutoSize = true;
            this.lblRecipeInfoTitle.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblRecipeInfoTitle.Location = new System.Drawing.Point(60, 123);
            this.lblRecipeInfoTitle.Name = "lblRecipeInfoTitle";
            this.lblRecipeInfoTitle.Size = new System.Drawing.Size(110, 31);
            this.lblRecipeInfoTitle.TabIndex = 1;
            this.lblRecipeInfoTitle.Text = "工艺设置";
            // 
            // lblLineH
            // 
            this.lblLineH.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLineH.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLineH.Location = new System.Drawing.Point(0, 0);
            this.lblLineH.Name = "lblLineH";
            this.lblLineH.Size = new System.Drawing.Size(226, 2);
            this.lblLineH.TabIndex = 3;
            // 
            // lblLineV
            // 
            this.lblLineV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLineV.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblLineV.Location = new System.Drawing.Point(226, 0);
            this.lblLineV.Name = "lblLineV";
            this.lblLineV.Size = new System.Drawing.Size(2, 916);
            this.lblLineV.TabIndex = 2;
            // 
            // ucSwitch
            // 
            this.ucSwitch.BackColor = System.Drawing.Color.Transparent;
            this.ucSwitch.Checked = true;
            this.ucSwitch.FalseColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.ucSwitch.FalseTextColr = System.Drawing.Color.White;
            this.ucSwitch.Location = new System.Drawing.Point(69, 16);
            this.ucSwitch.Name = "ucSwitch";
            this.ucSwitch.Size = new System.Drawing.Size(86, 32);
            this.ucSwitch.SwitchType = HZH_Controls.Controls.SwitchType.Quadrilateral;
            this.ucSwitch.TabIndex = 14;
            this.ucSwitch.Texts = new string[0];
            this.ucSwitch.TrueColor = System.Drawing.Color.LimeGreen;
            this.ucSwitch.TrueTextColr = System.Drawing.Color.White;
            this.ucSwitch.CheckedChanged += new System.EventHandler(this.ucSwitch_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(20, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "手动";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(160, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "自动";
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(22, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 2);
            this.label4.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(22, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 2);
            this.label5.TabIndex = 15;
            // 
            // ucBoatState
            // 
            this.ucBoatState.BackColor = System.Drawing.Color.Transparent;
            this.ucBoatState.BackColorExt = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ucBoatState.BoxStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.ucBoatState.ConerRadius = 5;
            this.ucBoatState.DropPanelHeight = -1;
            this.ucBoatState.FillColor = System.Drawing.Color.White;
            this.ucBoatState.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.ucBoatState.IsRadius = true;
            this.ucBoatState.IsShowRect = true;
            this.ucBoatState.ItemWidth = 70;
            this.ucBoatState.Location = new System.Drawing.Point(22, 74);
            this.ucBoatState.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.ucBoatState.Name = "ucBoatState";
            this.ucBoatState.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ucBoatState.RectWidth = 1;
            this.ucBoatState.SelectedIndex = -1;
            this.ucBoatState.SelectedValue = "";
            this.ucBoatState.Size = new System.Drawing.Size(172, 32);
            this.ucBoatState.Source = null;
            this.ucBoatState.TabIndex = 16;
            this.ucBoatState.TextValue = null;
            this.ucBoatState.TriangleColor = System.Drawing.Color.Black;
            this.ucBoatState.SelectedChangedEvent += new System.EventHandler(this.ucBoatState_SelectedChangedEvent);
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(22, 432);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 2);
            this.label6.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(58, 441);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 31);
            this.label7.TabIndex = 1;
            this.label7.Text = "工艺信息";
            // 
            // ucRecipeBar
            // 
            this.ucRecipeBar.DcimalDigits = 1;
            this.ucRecipeBar.Enabled = false;
            this.ucRecipeBar.IsShowTips = true;
            this.ucRecipeBar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.ucRecipeBar.LineWidth = 10F;
            this.ucRecipeBar.Location = new System.Drawing.Point(8, 476);
            this.ucRecipeBar.MaxValue = 100F;
            this.ucRecipeBar.MinValue = 0F;
            this.ucRecipeBar.Name = "ucRecipeBar";
            this.ucRecipeBar.Size = new System.Drawing.Size(212, 30);
            this.ucRecipeBar.TabIndex = 22;
            this.ucRecipeBar.Text = "ucTrackBar1";
            this.ucRecipeBar.TipsFormat = "0.0%";
            this.ucRecipeBar.Value = 40F;
            this.ucRecipeBar.ValueColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(20, 512);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 24);
            this.label8.TabIndex = 23;
            this.label8.Text = "名称";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(20, 546);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 24);
            this.label9.TabIndex = 23;
            this.label9.Text = "总时";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(20, 580);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 24);
            this.label10.TabIndex = 23;
            this.label10.Text = "运行";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(20, 614);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 24);
            this.label11.TabIndex = 23;
            this.label11.Text = "剩余";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(58, 657);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 31);
            this.label12.TabIndex = 1;
            this.label12.Text = "步信息";
            // 
            // ucStepBar
            // 
            this.ucStepBar.DcimalDigits = 1;
            this.ucStepBar.Enabled = false;
            this.ucStepBar.IsShowTips = true;
            this.ucStepBar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.ucStepBar.LineWidth = 10F;
            this.ucStepBar.Location = new System.Drawing.Point(8, 692);
            this.ucStepBar.MaxValue = 100F;
            this.ucStepBar.MinValue = 0F;
            this.ucStepBar.Name = "ucStepBar";
            this.ucStepBar.Size = new System.Drawing.Size(212, 30);
            this.ucStepBar.TabIndex = 22;
            this.ucStepBar.Text = "ucTrackBar1";
            this.ucStepBar.TipsFormat = "0.0%";
            this.ucStepBar.Value = 40F;
            this.ucStepBar.ValueColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(20, 730);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 24);
            this.label13.TabIndex = 23;
            this.label13.Text = "步号";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(20, 765);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 24);
            this.label14.TabIndex = 23;
            this.label14.Text = "名称";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(20, 800);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 24);
            this.label15.TabIndex = 23;
            this.label15.Text = "总时";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.Location = new System.Drawing.Point(20, 836);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(46, 24);
            this.label16.TabIndex = 23;
            this.label16.Text = "运行";
            // 
            // label17
            // 
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label17.Location = new System.Drawing.Point(22, 650);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(184, 2);
            this.label17.TabIndex = 24;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label18.Location = new System.Drawing.Point(20, 870);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(46, 24);
            this.label18.TabIndex = 23;
            this.label18.Text = "剩余";
            // 
            // lblRecipeName
            // 
            this.lblRecipeName.AutoSize = true;
            this.lblRecipeName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblRecipeName.Location = new System.Drawing.Point(72, 512);
            this.lblRecipeName.Name = "lblRecipeName";
            this.lblRecipeName.Size = new System.Drawing.Size(28, 24);
            this.lblRecipeName.TabIndex = 23;
            this.lblRecipeName.Text = "无";
            // 
            // lblRecipeTotalTime
            // 
            this.lblRecipeTotalTime.AutoSize = true;
            this.lblRecipeTotalTime.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblRecipeTotalTime.Location = new System.Drawing.Point(72, 546);
            this.lblRecipeTotalTime.Name = "lblRecipeTotalTime";
            this.lblRecipeTotalTime.Size = new System.Drawing.Size(111, 24);
            this.lblRecipeTotalTime.TabIndex = 23;
            this.lblRecipeTotalTime.Text = "00 Min 00 s";
            // 
            // lblRecipeWorkTime
            // 
            this.lblRecipeWorkTime.AutoSize = true;
            this.lblRecipeWorkTime.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblRecipeWorkTime.Location = new System.Drawing.Point(72, 580);
            this.lblRecipeWorkTime.Name = "lblRecipeWorkTime";
            this.lblRecipeWorkTime.Size = new System.Drawing.Size(111, 24);
            this.lblRecipeWorkTime.TabIndex = 23;
            this.lblRecipeWorkTime.Text = "00 Min 00 s";
            // 
            // lblRecipeRemainTime
            // 
            this.lblRecipeRemainTime.AutoSize = true;
            this.lblRecipeRemainTime.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblRecipeRemainTime.Location = new System.Drawing.Point(72, 614);
            this.lblRecipeRemainTime.Name = "lblRecipeRemainTime";
            this.lblRecipeRemainTime.Size = new System.Drawing.Size(111, 24);
            this.lblRecipeRemainTime.TabIndex = 23;
            this.lblRecipeRemainTime.Text = "00 Min 00 s";
            // 
            // lblStepId
            // 
            this.lblStepId.AutoSize = true;
            this.lblStepId.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblStepId.Location = new System.Drawing.Point(72, 730);
            this.lblStepId.Name = "lblStepId";
            this.lblStepId.Size = new System.Drawing.Size(21, 24);
            this.lblStepId.TabIndex = 23;
            this.lblStepId.Text = "0";
            // 
            // lblStepName
            // 
            this.lblStepName.AutoSize = true;
            this.lblStepName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblStepName.Location = new System.Drawing.Point(72, 765);
            this.lblStepName.Name = "lblStepName";
            this.lblStepName.Size = new System.Drawing.Size(28, 24);
            this.lblStepName.TabIndex = 23;
            this.lblStepName.Text = "无";
            // 
            // lblStepTotalTime
            // 
            this.lblStepTotalTime.AutoSize = true;
            this.lblStepTotalTime.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblStepTotalTime.Location = new System.Drawing.Point(72, 800);
            this.lblStepTotalTime.Name = "lblStepTotalTime";
            this.lblStepTotalTime.Size = new System.Drawing.Size(111, 24);
            this.lblStepTotalTime.TabIndex = 23;
            this.lblStepTotalTime.Text = "00 Min 00 s";
            // 
            // lblStepWorkTime
            // 
            this.lblStepWorkTime.AutoSize = true;
            this.lblStepWorkTime.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblStepWorkTime.Location = new System.Drawing.Point(72, 836);
            this.lblStepWorkTime.Name = "lblStepWorkTime";
            this.lblStepWorkTime.Size = new System.Drawing.Size(111, 24);
            this.lblStepWorkTime.TabIndex = 23;
            this.lblStepWorkTime.Text = "00 Min 00 s";
            // 
            // lblStepRemainTime
            // 
            this.lblStepRemainTime.AutoSize = true;
            this.lblStepRemainTime.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblStepRemainTime.Location = new System.Drawing.Point(72, 870);
            this.lblStepRemainTime.Name = "lblStepRemainTime";
            this.lblStepRemainTime.Size = new System.Drawing.Size(111, 24);
            this.lblStepRemainTime.TabIndex = 23;
            this.lblStepRemainTime.Text = "00 Min 00 s";
            // 
            // btnStart
            // 
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStart.Location = new System.Drawing.Point(57, 159);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(118, 34);
            this.btnStart.TabIndex = 25;
            this.btnStart.Text = "开始";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnHold
            // 
            this.btnHold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHold.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnHold.Location = new System.Drawing.Point(57, 204);
            this.btnHold.Margin = new System.Windows.Forms.Padding(4);
            this.btnHold.Name = "btnHold";
            this.btnHold.Size = new System.Drawing.Size(118, 34);
            this.btnHold.TabIndex = 25;
            this.btnHold.Text = "保持";
            this.btnHold.UseVisualStyleBackColor = true;
            this.btnHold.Click += new System.EventHandler(this.btnHold_Click);
            // 
            // btnJumpStep
            // 
            this.btnJumpStep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJumpStep.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnJumpStep.Location = new System.Drawing.Point(57, 249);
            this.btnJumpStep.Margin = new System.Windows.Forms.Padding(4);
            this.btnJumpStep.Name = "btnJumpStep";
            this.btnJumpStep.Size = new System.Drawing.Size(118, 34);
            this.btnJumpStep.TabIndex = 25;
            this.btnJumpStep.Text = "跳步";
            this.btnJumpStep.UseVisualStyleBackColor = true;
            this.btnJumpStep.Click += new System.EventHandler(this.btnJumpStep_Click);
            // 
            // btnAbort
            // 
            this.btnAbort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbort.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAbort.Location = new System.Drawing.Point(57, 294);
            this.btnAbort.Margin = new System.Windows.Forms.Padding(4);
            this.btnAbort.Name = "btnAbort";
            this.btnAbort.Size = new System.Drawing.Size(118, 34);
            this.btnAbort.TabIndex = 25;
            this.btnAbort.Text = "中断";
            this.btnAbort.UseVisualStyleBackColor = true;
            this.btnAbort.Click += new System.EventHandler(this.btnAbort_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinish.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnFinish.Location = new System.Drawing.Point(57, 339);
            this.btnFinish.Margin = new System.Windows.Forms.Padding(4);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(118, 34);
            this.btnFinish.TabIndex = 25;
            this.btnFinish.Text = "结束";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // btnTubeDisable
            // 
            this.btnTubeDisable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTubeDisable.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnTubeDisable.Location = new System.Drawing.Point(57, 384);
            this.btnTubeDisable.Margin = new System.Windows.Forms.Padding(4);
            this.btnTubeDisable.Name = "btnTubeDisable";
            this.btnTubeDisable.Size = new System.Drawing.Size(118, 34);
            this.btnTubeDisable.TabIndex = 25;
            this.btnTubeDisable.Text = "锁管";
            this.btnTubeDisable.UseVisualStyleBackColor = true;
            this.btnTubeDisable.Click += new System.EventHandler(this.btnTubeDisable_Click);
            // 
            // UCRecipeInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnTubeDisable);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.btnAbort);
            this.Controls.Add(this.btnJumpStep);
            this.Controls.Add(this.btnHold);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblStepRemainTime);
            this.Controls.Add(this.lblStepWorkTime);
            this.Controls.Add(this.lblStepTotalTime);
            this.Controls.Add(this.lblStepName);
            this.Controls.Add(this.lblStepId);
            this.Controls.Add(this.lblRecipeRemainTime);
            this.Controls.Add(this.lblRecipeWorkTime);
            this.Controls.Add(this.lblRecipeTotalTime);
            this.Controls.Add(this.lblRecipeName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ucStepBar);
            this.Controls.Add(this.ucRecipeBar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ucBoatState);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ucSwitch);
            this.Controls.Add(this.lblLineH);
            this.Controls.Add(this.lblLineV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblRecipeInfoTitle);
            this.Name = "UCRecipeInfo";
            this.Size = new System.Drawing.Size(228, 916);
            this.Load += new System.EventHandler(this.UCRecipeInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblRecipeInfoTitle;
        public System.Windows.Forms.Label lblLineH;
        public System.Windows.Forms.Label lblLineV;
        public HZH_Controls.Controls.UCSwitch ucSwitch;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public HZH_Controls.Controls.UCCombox ucBoatState;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label7;
        public HZH_Controls.Controls.UCTrackBar ucRecipeBar;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label label12;
        public HZH_Controls.Controls.UCTrackBar ucStepBar;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.Label label14;
        public System.Windows.Forms.Label label15;
        public System.Windows.Forms.Label label16;
        public System.Windows.Forms.Label label17;
        public System.Windows.Forms.Label label18;
        public System.Windows.Forms.Label lblRecipeName;
        public System.Windows.Forms.Label lblRecipeTotalTime;
        public System.Windows.Forms.Label lblRecipeWorkTime;
        public System.Windows.Forms.Label lblRecipeRemainTime;
        public System.Windows.Forms.Label lblStepId;
        public System.Windows.Forms.Label lblStepName;
        public System.Windows.Forms.Label lblStepTotalTime;
        public System.Windows.Forms.Label lblStepWorkTime;
        public System.Windows.Forms.Label lblStepRemainTime;
        public System.Windows.Forms.Button btnStart;
        public System.Windows.Forms.Button btnHold;
        public System.Windows.Forms.Button btnJumpStep;
        public System.Windows.Forms.Button btnAbort;
        public System.Windows.Forms.Button btnFinish;
        public System.Windows.Forms.Button btnTubeDisable;
    }
}
