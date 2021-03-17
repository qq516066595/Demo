namespace Demo.UserControl.Tube
{
    partial class ucSetMFC
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
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtSetGasWarnDiff = new DevExpress.XtraEditors.TextEdit();
            this.txtSetGasAlmDiff = new DevExpress.XtraEditors.TextEdit();
            this.txtSetGasMaxRange = new DevExpress.XtraEditors.TextEdit();
            this.btnSetGasShield = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtSetGasWarnDiff.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSetGasAlmDiff.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSetGasMaxRange.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(9, 2);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(67, 28);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "MFC1:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(11, 44);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(138, 28);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "偏差警示值(%)";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(11, 86);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(138, 28);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "报警警示值(%)";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(6, 126);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(150, 28);
            this.labelControl4.TabIndex = 1;
            this.labelControl4.Text = "最大量程(sccm)";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(46, 167);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(105, 28);
            this.labelControl5.TabIndex = 1;
            this.labelControl5.Text = "流量计屏蔽";
            // 
            // txtSetGasWarnDiff
            // 
            this.txtSetGasWarnDiff.Location = new System.Drawing.Point(168, 39);
            this.txtSetGasWarnDiff.Margin = new System.Windows.Forms.Padding(2);
            this.txtSetGasWarnDiff.Name = "txtSetGasWarnDiff";
            this.txtSetGasWarnDiff.Properties.Appearance.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.txtSetGasWarnDiff.Properties.Appearance.Options.UseFont = true;
            this.txtSetGasWarnDiff.Size = new System.Drawing.Size(149, 34);
            this.txtSetGasWarnDiff.TabIndex = 2;
            this.txtSetGasWarnDiff.TextChanged += new System.EventHandler(this.txtSetGasWarnDiff_TextChanged);
            // 
            // txtSetGasAlmDiff
            // 
            this.txtSetGasAlmDiff.Location = new System.Drawing.Point(168, 79);
            this.txtSetGasAlmDiff.Margin = new System.Windows.Forms.Padding(2);
            this.txtSetGasAlmDiff.Name = "txtSetGasAlmDiff";
            this.txtSetGasAlmDiff.Properties.Appearance.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.txtSetGasAlmDiff.Properties.Appearance.Options.UseFont = true;
            this.txtSetGasAlmDiff.Size = new System.Drawing.Size(149, 34);
            this.txtSetGasAlmDiff.TabIndex = 3;
            this.txtSetGasAlmDiff.TextChanged += new System.EventHandler(this.txtSetGasAlmDiff_TextChanged);
            // 
            // txtSetGasMaxRange
            // 
            this.txtSetGasMaxRange.Location = new System.Drawing.Point(168, 121);
            this.txtSetGasMaxRange.Margin = new System.Windows.Forms.Padding(2);
            this.txtSetGasMaxRange.Name = "txtSetGasMaxRange";
            this.txtSetGasMaxRange.Properties.Appearance.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.txtSetGasMaxRange.Properties.Appearance.Options.UseFont = true;
            this.txtSetGasMaxRange.Size = new System.Drawing.Size(149, 34);
            this.txtSetGasMaxRange.TabIndex = 3;
            this.txtSetGasMaxRange.TextChanged += new System.EventHandler(this.txtSetGasMaxRange_TextChanged);
            // 
            // btnSetGasShield
            // 
            this.btnSetGasShield.Appearance.BackColor = System.Drawing.Color.LightCoral;
            this.btnSetGasShield.Appearance.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.btnSetGasShield.Appearance.Options.UseBackColor = true;
            this.btnSetGasShield.Appearance.Options.UseFont = true;
            this.btnSetGasShield.Location = new System.Drawing.Point(168, 163);
            this.btnSetGasShield.Margin = new System.Windows.Forms.Padding(2);
            this.btnSetGasShield.Name = "btnSetGasShield";
            this.btnSetGasShield.Size = new System.Drawing.Size(149, 38);
            this.btnSetGasShield.TabIndex = 4;
            this.btnSetGasShield.Text = "屏蔽";
            this.btnSetGasShield.Click += new System.EventHandler(this.btnSetGasShield_Click);
            // 
            // ucSetMFC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSetGasShield);
            this.Controls.Add(this.txtSetGasMaxRange);
            this.Controls.Add(this.txtSetGasAlmDiff);
            this.Controls.Add(this.txtSetGasWarnDiff);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ucSetMFC";
            this.Size = new System.Drawing.Size(320, 204);
            ((System.ComponentModel.ISupportInitialize)(this.txtSetGasWarnDiff.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSetGasAlmDiff.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSetGasMaxRange.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtSetGasWarnDiff;
        private DevExpress.XtraEditors.TextEdit txtSetGasAlmDiff;
        private DevExpress.XtraEditors.TextEdit txtSetGasMaxRange;
        private DevExpress.XtraEditors.SimpleButton btnSetGasShield;
    }
}
