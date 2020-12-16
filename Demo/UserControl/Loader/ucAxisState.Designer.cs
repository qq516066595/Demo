namespace Demo.UserControl.Loader
{
    partial class ucAxisState
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
            this.lblPosition = new DevExpress.XtraEditors.LabelControl();
            this.lblVelocity = new DevExpress.XtraEditors.LabelControl();
            this.lblTorque = new DevExpress.XtraEditors.LabelControl();
            this.lblMagnetic_Scale = new DevExpress.XtraEditors.LabelControl();
            this.lblOrigin = new DevExpress.XtraEditors.LabelControl();
            this.txtPosition = new DevExpress.XtraEditors.TextEdit();
            this.txtVelocity = new DevExpress.XtraEditors.TextEdit();
            this.txtTorque = new DevExpress.XtraEditors.TextEdit();
            this.txtMagnetic_Scale = new DevExpress.XtraEditors.TextEdit();
            this.txtOrigin = new DevExpress.XtraEditors.TextEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.btnEnable = new DevExpress.XtraEditors.SimpleButton();
            this.btnUnlock = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtPosition.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVelocity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTorque.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMagnetic_Scale.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrigin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(44, 26);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(0, 18);
            this.labelControl1.TabIndex = 0;
            // 
            // lblPosition
            // 
            this.lblPosition.Location = new System.Drawing.Point(50, 20);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(38, 36);
            this.lblPosition.TabIndex = 1;
            this.lblPosition.Text = " 位置\r\n(mm)";
            // 
            // lblVelocity
            // 
            this.lblVelocity.Location = new System.Drawing.Point(98, 20);
            this.lblVelocity.Name = "lblVelocity";
            this.lblVelocity.Size = new System.Drawing.Size(51, 36);
            this.lblVelocity.TabIndex = 1;
            this.lblVelocity.Text = "   速度\r\n(mm/s)";
            // 
            // lblTorque
            // 
            this.lblTorque.Location = new System.Drawing.Point(159, 20);
            this.lblTorque.Name = "lblTorque";
            this.lblTorque.Size = new System.Drawing.Size(43, 36);
            this.lblTorque.TabIndex = 1;
            this.lblTorque.Text = " 扭矩\r\n(N*m)";
            // 
            // lblMagnetic_Scale
            // 
            this.lblMagnetic_Scale.Location = new System.Drawing.Point(212, 20);
            this.lblMagnetic_Scale.Name = "lblMagnetic_Scale";
            this.lblMagnetic_Scale.Size = new System.Drawing.Size(45, 36);
            this.lblMagnetic_Scale.TabIndex = 1;
            this.lblMagnetic_Scale.Text = "磁栅尺\r\n (mm)";
            // 
            // lblOrigin
            // 
            this.lblOrigin.Location = new System.Drawing.Point(267, 20);
            this.lblOrigin.Name = "lblOrigin";
            this.lblOrigin.Size = new System.Drawing.Size(38, 36);
            this.lblOrigin.TabIndex = 1;
            this.lblOrigin.Text = " 原点\r\n(mm)";
            // 
            // txtPosition
            // 
            this.txtPosition.EditValue = "9999";
            this.txtPosition.Location = new System.Drawing.Point(50, 62);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(41, 24);
            this.txtPosition.TabIndex = 2;
            // 
            // txtVelocity
            // 
            this.txtVelocity.EditValue = "9999";
            this.txtVelocity.Location = new System.Drawing.Point(104, 62);
            this.txtVelocity.Name = "txtVelocity";
            this.txtVelocity.Size = new System.Drawing.Size(41, 24);
            this.txtVelocity.TabIndex = 2;
            // 
            // txtTorque
            // 
            this.txtTorque.EditValue = "9999";
            this.txtTorque.Location = new System.Drawing.Point(158, 62);
            this.txtTorque.Name = "txtTorque";
            this.txtTorque.Size = new System.Drawing.Size(41, 24);
            this.txtTorque.TabIndex = 2;
            // 
            // txtMagnetic_Scale
            // 
            this.txtMagnetic_Scale.EditValue = "9999";
            this.txtMagnetic_Scale.Location = new System.Drawing.Point(212, 62);
            this.txtMagnetic_Scale.Name = "txtMagnetic_Scale";
            this.txtMagnetic_Scale.Size = new System.Drawing.Size(41, 24);
            this.txtMagnetic_Scale.TabIndex = 2;
            // 
            // txtOrigin
            // 
            this.txtOrigin.EditValue = "9999";
            this.txtOrigin.Location = new System.Drawing.Point(266, 62);
            this.txtOrigin.Name = "txtOrigin";
            this.txtOrigin.Size = new System.Drawing.Size(41, 24);
            this.txtOrigin.TabIndex = 2;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureEdit1.EditValue = global::Demo.Properties.Resources.下拉箭头3;
            this.pictureEdit1.Location = new System.Drawing.Point(50, 92);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Properties.ZoomAccelerationFactor = 1D;
            this.pictureEdit1.Size = new System.Drawing.Size(255, 21);
            this.pictureEdit1.TabIndex = 3;
            // 
            // btnEnable
            // 
            this.btnEnable.Location = new System.Drawing.Point(50, 119);
            this.btnEnable.Name = "btnEnable";
            this.btnEnable.Size = new System.Drawing.Size(41, 30);
            this.btnEnable.TabIndex = 4;
            this.btnEnable.Text = "使能";
            // 
            // btnUnlock
            // 
            this.btnUnlock.Location = new System.Drawing.Point(104, 119);
            this.btnUnlock.Name = "btnUnlock";
            this.btnUnlock.Size = new System.Drawing.Size(71, 30);
            this.btnUnlock.TabIndex = 4;
            this.btnUnlock.Text = "解除联锁";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(186, 119);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(71, 30);
            this.simpleButton1.TabIndex = 4;
            this.simpleButton1.Text = "向里";
            // 
            // ucAxisState
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.btnUnlock);
            this.Controls.Add(this.btnEnable);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.txtOrigin);
            this.Controls.Add(this.txtMagnetic_Scale);
            this.Controls.Add(this.txtTorque);
            this.Controls.Add(this.txtVelocity);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.lblOrigin);
            this.Controls.Add(this.lblMagnetic_Scale);
            this.Controls.Add(this.lblTorque);
            this.Controls.Add(this.lblVelocity);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.labelControl1);
            this.Name = "ucAxisState";
            this.Size = new System.Drawing.Size(328, 198);
            ((System.ComponentModel.ISupportInitialize)(this.txtPosition.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVelocity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTorque.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMagnetic_Scale.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrigin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lblPosition;
        private DevExpress.XtraEditors.LabelControl lblVelocity;
        private DevExpress.XtraEditors.LabelControl lblTorque;
        private DevExpress.XtraEditors.LabelControl lblMagnetic_Scale;
        private DevExpress.XtraEditors.LabelControl lblOrigin;
        private DevExpress.XtraEditors.TextEdit txtPosition;
        private DevExpress.XtraEditors.TextEdit txtVelocity;
        private DevExpress.XtraEditors.TextEdit txtTorque;
        private DevExpress.XtraEditors.TextEdit txtMagnetic_Scale;
        private DevExpress.XtraEditors.TextEdit txtOrigin;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.SimpleButton btnEnable;
        private DevExpress.XtraEditors.SimpleButton btnUnlock;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}
