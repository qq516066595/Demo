namespace Demo.UserControl.Loader
{
    partial class ucAxisPos
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
            this.lblZPos_Up = new DevExpress.XtraEditors.LabelControl();
            this.txtZPos_Up = new DevExpress.XtraEditors.TextEdit();
            this.lblZPos_Down = new DevExpress.XtraEditors.LabelControl();
            this.txtZPos_Down = new DevExpress.XtraEditors.TextEdit();
            this.lblXPos = new DevExpress.XtraEditors.LabelControl();
            this.txtXPos = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZPos_Up.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZPos_Down.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtXPos.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblZPos_Up
            // 
            this.lblZPos_Up.Location = new System.Drawing.Point(20, 11);
            this.lblZPos_Up.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblZPos_Up.Name = "lblZPos_Up";
            this.lblZPos_Up.Size = new System.Drawing.Size(115, 14);
            this.lblZPos_Up.TabIndex = 1;
            this.lblZPos_Up.Text = "Z上位：             mm";
            // 
            // txtZPos_Up
            // 
            this.txtZPos_Up.EditValue = "9999.9";
            this.txtZPos_Up.Location = new System.Drawing.Point(63, 8);
            this.txtZPos_Up.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtZPos_Up.Name = "txtZPos_Up";
            this.txtZPos_Up.Size = new System.Drawing.Size(47, 20);
            this.txtZPos_Up.TabIndex = 2;
            this.txtZPos_Up.EditValueChanged += new System.EventHandler(this.textEdit1_EditValueChanged);
            // 
            // lblZPos_Down
            // 
            this.lblZPos_Down.Location = new System.Drawing.Point(20, 37);
            this.lblZPos_Down.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblZPos_Down.Name = "lblZPos_Down";
            this.lblZPos_Down.Size = new System.Drawing.Size(115, 14);
            this.lblZPos_Down.TabIndex = 1;
            this.lblZPos_Down.Text = "Z下位：             mm";
            // 
            // txtZPos_Down
            // 
            this.txtZPos_Down.EditValue = "9999";
            this.txtZPos_Down.Location = new System.Drawing.Point(63, 34);
            this.txtZPos_Down.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtZPos_Down.Name = "txtZPos_Down";
            this.txtZPos_Down.Size = new System.Drawing.Size(47, 20);
            this.txtZPos_Down.TabIndex = 2;
            this.txtZPos_Down.EditValueChanged += new System.EventHandler(this.textEdit1_EditValueChanged);
            // 
            // lblXPos
            // 
            this.lblXPos.Location = new System.Drawing.Point(20, 63);
            this.lblXPos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblXPos.Name = "lblXPos";
            this.lblXPos.Size = new System.Drawing.Size(115, 14);
            this.lblXPos.TabIndex = 1;
            this.lblXPos.Text = "X工位：             mm";
            // 
            // txtXPos
            // 
            this.txtXPos.EditValue = "9999";
            this.txtXPos.Location = new System.Drawing.Point(63, 60);
            this.txtXPos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtXPos.Name = "txtXPos";
            this.txtXPos.Size = new System.Drawing.Size(47, 20);
            this.txtXPos.TabIndex = 2;
            this.txtXPos.EditValueChanged += new System.EventHandler(this.textEdit1_EditValueChanged);
            // 
            // ucAxisPos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtXPos);
            this.Controls.Add(this.txtZPos_Down);
            this.Controls.Add(this.txtZPos_Up);
            this.Controls.Add(this.lblXPos);
            this.Controls.Add(this.lblZPos_Down);
            this.Controls.Add(this.lblZPos_Up);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ucAxisPos";
            this.Size = new System.Drawing.Size(154, 88);
            ((System.ComponentModel.ISupportInitialize)(this.txtZPos_Up.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZPos_Down.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtXPos.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl lblZPos_Up;
        private DevExpress.XtraEditors.TextEdit txtZPos_Up;
        private DevExpress.XtraEditors.LabelControl lblZPos_Down;
        private DevExpress.XtraEditors.TextEdit txtZPos_Down;
        private DevExpress.XtraEditors.LabelControl lblXPos;
        private DevExpress.XtraEditors.TextEdit txtXPos;
    }
}
