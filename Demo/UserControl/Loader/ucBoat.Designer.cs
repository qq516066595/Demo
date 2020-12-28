namespace Demo.Forms.Loader
{
    partial class ucBoat
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
            this.txtBoatID = new DevExpress.XtraEditors.TextEdit();
            this.lblLight_R = new DevExpress.XtraEditors.LabelControl();
            this.lblLight_L = new DevExpress.XtraEditors.LabelControl();
            this.cmbBoatState = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtFromTube = new DevExpress.XtraEditors.LabelControl();
            this.lblMode = new DevExpress.XtraEditors.LabelControl();
            this.lblCDTime = new DevExpress.XtraEditors.LabelControl();
            this.lblStorageTime = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtBoatID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBoatState.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoatID
            // 
            this.txtBoatID.EditValue = "JK0000000";
            this.txtBoatID.Location = new System.Drawing.Point(12, 19);
            this.txtBoatID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoatID.Name = "txtBoatID";
            this.txtBoatID.Size = new System.Drawing.Size(78, 20);
            this.txtBoatID.TabIndex = 2;
            // 
            // lblLight_R
            // 
            this.lblLight_R.Appearance.BackColor = System.Drawing.Color.Lime;
            this.lblLight_R.Appearance.Font = new System.Drawing.Font("Tahoma", 4F);
            this.lblLight_R.Appearance.Options.UseBackColor = true;
            this.lblLight_R.Appearance.Options.UseFont = true;
            this.lblLight_R.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblLight_R.Location = new System.Drawing.Point(235, 29);
            this.lblLight_R.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblLight_R.Name = "lblLight_R";
            this.lblLight_R.Size = new System.Drawing.Size(5, 31);
            this.lblLight_R.TabIndex = 3;
            this.lblLight_R.Text = "                  ";
            // 
            // lblLight_L
            // 
            this.lblLight_L.Appearance.BackColor = System.Drawing.Color.Lime;
            this.lblLight_L.Appearance.Font = new System.Drawing.Font("Tahoma", 4F);
            this.lblLight_L.Appearance.Options.UseBackColor = true;
            this.lblLight_L.Appearance.Options.UseFont = true;
            this.lblLight_L.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblLight_L.Location = new System.Drawing.Point(0, 29);
            this.lblLight_L.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblLight_L.Name = "lblLight_L";
            this.lblLight_L.Size = new System.Drawing.Size(5, 31);
            this.lblLight_L.TabIndex = 3;
            this.lblLight_L.Text = "                  ";
            // 
            // cmbBoatState
            // 
            this.cmbBoatState.EditValue = "饱和完成";
            this.cmbBoatState.Location = new System.Drawing.Point(12, 47);
            this.cmbBoatState.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbBoatState.Name = "cmbBoatState";
            this.cmbBoatState.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbBoatState.Size = new System.Drawing.Size(78, 20);
            this.cmbBoatState.TabIndex = 4;
            // 
            // txtFromTube
            // 
            this.txtFromTube.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFromTube.Appearance.Options.UseFont = true;
            this.txtFromTube.Location = new System.Drawing.Point(95, 21);
            this.txtFromTube.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFromTube.Name = "txtFromTube";
            this.txtFromTube.Size = new System.Drawing.Size(48, 14);
            this.txtFromTube.TabIndex = 6;
            this.txtFromTube.Text = "来自管一";
            // 
            // lblMode
            // 
            this.lblMode.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMode.Appearance.Options.UseFont = true;
            this.lblMode.Location = new System.Drawing.Point(95, 49);
            this.lblMode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(48, 14);
            this.lblMode.TabIndex = 6;
            this.lblMode.Text = "舟装卸片";
            // 
            // lblCDTime
            // 
            this.lblCDTime.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCDTime.Appearance.Options.UseFont = true;
            this.lblCDTime.Location = new System.Drawing.Point(153, 21);
            this.lblCDTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblCDTime.Name = "lblCDTime";
            this.lblCDTime.Size = new System.Drawing.Size(69, 14);
            this.lblCDTime.TabIndex = 6;
            this.lblCDTime.Text = "冷却：9999s";
            // 
            // lblStorageTime
            // 
            this.lblStorageTime.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStorageTime.Appearance.Options.UseFont = true;
            this.lblStorageTime.Location = new System.Drawing.Point(153, 49);
            this.lblStorageTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblStorageTime.Name = "lblStorageTime";
            this.lblStorageTime.Size = new System.Drawing.Size(69, 14);
            this.lblStorageTime.TabIndex = 6;
            this.lblStorageTime.Text = "存放：9999s";
            // 
            // ucBoat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblStorageTime);
            this.Controls.Add(this.lblMode);
            this.Controls.Add(this.lblCDTime);
            this.Controls.Add(this.txtFromTube);
            this.Controls.Add(this.cmbBoatState);
            this.Controls.Add(this.lblLight_L);
            this.Controls.Add(this.lblLight_R);
            this.Controls.Add(this.txtBoatID);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ucBoat";
            this.Size = new System.Drawing.Size(242, 76);
            ((System.ComponentModel.ISupportInitialize)(this.txtBoatID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBoatState.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit txtBoatID;
        private DevExpress.XtraEditors.LabelControl lblLight_R;
        private DevExpress.XtraEditors.LabelControl lblLight_L;
        private DevExpress.XtraEditors.ComboBoxEdit cmbBoatState;
        private DevExpress.XtraEditors.LabelControl txtFromTube;
        private DevExpress.XtraEditors.LabelControl lblMode;
        private DevExpress.XtraEditors.LabelControl lblCDTime;
        private DevExpress.XtraEditors.LabelControl lblStorageTime;
    }
}
