namespace Demo.UserControl.Loader
{
    partial class ucBuffer
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
            this.lblStorageTime = new DevExpress.XtraEditors.LabelControl();
            this.lblMode = new DevExpress.XtraEditors.LabelControl();
            this.lblCDTime = new DevExpress.XtraEditors.LabelControl();
            this.lblFromTube = new DevExpress.XtraEditors.LabelControl();
            this.cmbBoatState = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtBoatID = new DevExpress.XtraEditors.TextEdit();
            this.lblLight_L = new DevExpress.XtraEditors.LabelControl();
            this.lblLight_R = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBoatState.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBoatID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStorageTime
            // 
            this.lblStorageTime.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStorageTime.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblStorageTime.Appearance.Options.UseFont = true;
            this.lblStorageTime.Appearance.Options.UseForeColor = true;
            this.lblStorageTime.Location = new System.Drawing.Point(202, 57);
            this.lblStorageTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblStorageTime.Name = "lblStorageTime";
            this.lblStorageTime.Size = new System.Drawing.Size(69, 14);
            this.lblStorageTime.TabIndex = 9;
            this.lblStorageTime.Text = "存放：9999s";
            // 
            // lblMode
            // 
            this.lblMode.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMode.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblMode.Appearance.Options.UseFont = true;
            this.lblMode.Appearance.Options.UseForeColor = true;
            this.lblMode.Location = new System.Drawing.Point(132, 57);
            this.lblMode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(48, 14);
            this.lblMode.TabIndex = 10;
            this.lblMode.Text = "舟装卸片";
            // 
            // lblCDTime
            // 
            this.lblCDTime.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCDTime.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblCDTime.Appearance.Options.UseFont = true;
            this.lblCDTime.Appearance.Options.UseForeColor = true;
            this.lblCDTime.Location = new System.Drawing.Point(202, 29);
            this.lblCDTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblCDTime.Name = "lblCDTime";
            this.lblCDTime.Size = new System.Drawing.Size(69, 14);
            this.lblCDTime.TabIndex = 11;
            this.lblCDTime.Text = "冷却：9999s";
            // 
            // lblFromTube
            // 
            this.lblFromTube.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFromTube.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblFromTube.Appearance.Options.UseFont = true;
            this.lblFromTube.Appearance.Options.UseForeColor = true;
            this.lblFromTube.Location = new System.Drawing.Point(132, 29);
            this.lblFromTube.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblFromTube.Name = "lblFromTube";
            this.lblFromTube.Size = new System.Drawing.Size(48, 14);
            this.lblFromTube.TabIndex = 12;
            this.lblFromTube.Text = "来自管一";
            // 
            // cmbBoatState
            // 
            this.cmbBoatState.EditValue = "饱和完成";
            this.cmbBoatState.Location = new System.Drawing.Point(32, 55);
            this.cmbBoatState.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbBoatState.Name = "cmbBoatState";
            this.cmbBoatState.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbBoatState.Size = new System.Drawing.Size(78, 20);
            this.cmbBoatState.TabIndex = 8;
            this.cmbBoatState.EditValueChanged += new System.EventHandler(this.cmbBoatState_SelectedIndexChanged);
            // 
            // txtBoatID
            // 
            this.txtBoatID.EditValue = "JK0000000";
            this.txtBoatID.Location = new System.Drawing.Point(32, 27);
            this.txtBoatID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoatID.Name = "txtBoatID";
            this.txtBoatID.Size = new System.Drawing.Size(78, 20);
            this.txtBoatID.TabIndex = 7;
            this.txtBoatID.EditValueChanged += new System.EventHandler(this.txtBoatID_EditValueChanged);
            // 
            // lblLight_L
            // 
            this.lblLight_L.Appearance.BackColor = System.Drawing.Color.Lime;
            this.lblLight_L.Appearance.Font = new System.Drawing.Font("Tahoma", 4F);
            this.lblLight_L.Appearance.Options.UseBackColor = true;
            this.lblLight_L.Appearance.Options.UseFont = true;
            this.lblLight_L.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblLight_L.Location = new System.Drawing.Point(2, 36);
            this.lblLight_L.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblLight_L.Name = "lblLight_L";
            this.lblLight_L.Size = new System.Drawing.Size(5, 31);
            this.lblLight_L.TabIndex = 13;
            this.lblLight_L.Text = "                  ";
            // 
            // lblLight_R
            // 
            this.lblLight_R.Appearance.BackColor = System.Drawing.Color.Lime;
            this.lblLight_R.Appearance.Font = new System.Drawing.Font("Tahoma", 4F);
            this.lblLight_R.Appearance.Options.UseBackColor = true;
            this.lblLight_R.Appearance.Options.UseFont = true;
            this.lblLight_R.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblLight_R.Location = new System.Drawing.Point(296, 36);
            this.lblLight_R.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblLight_R.Name = "lblLight_R";
            this.lblLight_R.Size = new System.Drawing.Size(5, 31);
            this.lblLight_R.TabIndex = 14;
            this.lblLight_R.Text = "                  ";
            // 
            // ucBuffer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Demo.Properties.Resources.图片3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lblLight_L);
            this.Controls.Add(this.lblLight_R);
            this.Controls.Add(this.lblStorageTime);
            this.Controls.Add(this.lblMode);
            this.Controls.Add(this.lblCDTime);
            this.Controls.Add(this.lblFromTube);
            this.Controls.Add(this.cmbBoatState);
            this.Controls.Add(this.txtBoatID);
            this.DoubleBuffered = true;
            this.Name = "ucBuffer";
            this.Size = new System.Drawing.Size(326, 102);
            ((System.ComponentModel.ISupportInitialize)(this.cmbBoatState.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBoatID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblStorageTime;
        private DevExpress.XtraEditors.LabelControl lblMode;
        private DevExpress.XtraEditors.LabelControl lblCDTime;
        private DevExpress.XtraEditors.LabelControl lblFromTube;
        private DevExpress.XtraEditors.ComboBoxEdit cmbBoatState;
        private DevExpress.XtraEditors.TextEdit txtBoatID;
        private DevExpress.XtraEditors.LabelControl lblLight_L;
        private DevExpress.XtraEditors.LabelControl lblLight_R;
    }
}
