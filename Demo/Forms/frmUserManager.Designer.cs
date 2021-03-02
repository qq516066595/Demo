namespace Demo.Forms
{
    partial class frmUserManager
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtUserName = new DevExpress.XtraEditors.TextEdit();
            this.txtOldUserPwd = new DevExpress.XtraEditors.TextEdit();
            this.txtNewUserPwd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.cmbUserLimits = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOldUserPwd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewUserPwd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbUserLimits.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(118, 22);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "-- 用户信息 --";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(31, 51);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(90, 22);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "账户名称：";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(31, 85);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(90, 22);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "原始密码：";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(31, 119);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(90, 22);
            this.labelControl4.TabIndex = 1;
            this.labelControl4.Text = "重置密码：";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(127, 48);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(170, 28);
            this.txtUserName.TabIndex = 2;
            // 
            // txtOldUserPwd
            // 
            this.txtOldUserPwd.Location = new System.Drawing.Point(127, 82);
            this.txtOldUserPwd.Name = "txtOldUserPwd";
            this.txtOldUserPwd.Size = new System.Drawing.Size(170, 28);
            this.txtOldUserPwd.TabIndex = 2;
            // 
            // txtNewUserPwd
            // 
            this.txtNewUserPwd.Location = new System.Drawing.Point(127, 116);
            this.txtNewUserPwd.Name = "txtNewUserPwd";
            this.txtNewUserPwd.Size = new System.Drawing.Size(170, 28);
            this.txtNewUserPwd.TabIndex = 2;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(31, 153);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(90, 22);
            this.labelControl5.TabIndex = 1;
            this.labelControl5.Text = "所属权限：";
            // 
            // cmbUserLimits
            // 
            this.cmbUserLimits.Location = new System.Drawing.Point(127, 150);
            this.cmbUserLimits.Name = "cmbUserLimits";
            this.cmbUserLimits.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbUserLimits.Properties.Items.AddRange(new object[] {
            "管理员",
            "设备",
            "工艺",
            "生产"});
            this.cmbUserLimits.Size = new System.Drawing.Size(170, 28);
            this.cmbUserLimits.TabIndex = 3;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(66, 193);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(88, 38);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "确认";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(191, 193);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 38);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "取消";
            // 
            // frmUserManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 252);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cmbUserLimits);
            this.Controls.Add(this.txtNewUserPwd);
            this.Controls.Add(this.txtOldUserPwd);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUserManager";
            this.Text = "frmUserManager";
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOldUserPwd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewUserPwd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbUserLimits.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtUserName;
        private DevExpress.XtraEditors.TextEdit txtOldUserPwd;
        private DevExpress.XtraEditors.TextEdit txtNewUserPwd;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.ComboBoxEdit cmbUserLimits;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
    }
}