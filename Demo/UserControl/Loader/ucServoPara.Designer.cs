namespace Demo.UserControl.Loader
{
    partial class ucServoPara
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
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit5 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit6 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit4 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(30, 19);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(151, 14);
            this.labelControl1.TabIndex = 31;
            this.labelControl1.Text = " 加速度：             (mm/s2)";
            // 
            // textEdit2
            // 
            this.textEdit2.EditValue = "9999.9";
            this.textEdit2.Location = new System.Drawing.Point(82, 16);
            this.textEdit2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(47, 20);
            this.textEdit2.TabIndex = 32;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(39, 128);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(123, 23);
            this.simpleButton1.TabIndex = 33;
            this.simpleButton1.Text = "扭矩保护使能";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(22, 45);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(142, 14);
            this.labelControl5.TabIndex = 31;
            this.labelControl5.Text = "正软极限:               (mm)";
            // 
            // textEdit5
            // 
            this.textEdit5.EditValue = "50";
            this.textEdit5.Location = new System.Drawing.Point(82, 42);
            this.textEdit5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textEdit5.Name = "textEdit5";
            this.textEdit5.Size = new System.Drawing.Size(47, 20);
            this.textEdit5.TabIndex = 32;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(22, 71);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(142, 14);
            this.labelControl6.TabIndex = 31;
            this.labelControl6.Text = "负软极限:               (mm)";
            // 
            // textEdit6
            // 
            this.textEdit6.EditValue = "50";
            this.textEdit6.Location = new System.Drawing.Point(82, 68);
            this.textEdit6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textEdit6.Name = "textEdit6";
            this.textEdit6.Size = new System.Drawing.Size(47, 20);
            this.textEdit6.TabIndex = 32;
            // 
            // textEdit4
            // 
            this.textEdit4.EditValue = "50";
            this.textEdit4.Location = new System.Drawing.Point(82, 94);
            this.textEdit4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textEdit4.Name = "textEdit4";
            this.textEdit4.Size = new System.Drawing.Size(47, 20);
            this.textEdit4.TabIndex = 32;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(22, 97);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(134, 14);
            this.labelControl3.TabIndex = 31;
            this.labelControl3.Text = "最大力矩:               (%)";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(39, 161);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(123, 23);
            this.simpleButton2.TabIndex = 33;
            this.simpleButton2.Text = "原点";
            // 
            // ucServoPara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.textEdit2);
            this.Controls.Add(this.textEdit6);
            this.Controls.Add(this.textEdit5);
            this.Controls.Add(this.textEdit4);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ucServoPara";
            this.Size = new System.Drawing.Size(204, 195);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit textEdit5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit textEdit6;
        private DevExpress.XtraEditors.TextEdit textEdit4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}
