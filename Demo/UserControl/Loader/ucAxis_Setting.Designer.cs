namespace Demo.UserControl.Loader
{
    partial class ucAxis_Setting
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
            this.txtZAxisup = new DevExpress.XtraEditors.TextEdit();
            this.txtZAxisDown = new DevExpress.XtraEditors.TextEdit();
            this.txtYAxiz = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZAxisup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZAxisDown.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYAxiz.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtZAxisup
            // 
            this.txtZAxisup.EditValue = "9999";
            this.txtZAxisup.Location = new System.Drawing.Point(64, 3);
            this.txtZAxisup.Name = "txtZAxisup";
            this.txtZAxisup.Size = new System.Drawing.Size(48, 24);
            this.txtZAxisup.TabIndex = 0;
            // 
            // txtZAxisDown
            // 
            this.txtZAxisDown.EditValue = "9999";
            this.txtZAxisDown.Location = new System.Drawing.Point(147, 3);
            this.txtZAxisDown.Name = "txtZAxisDown";
            this.txtZAxisDown.Size = new System.Drawing.Size(48, 24);
            this.txtZAxisDown.TabIndex = 0;
            // 
            // txtYAxiz
            // 
            this.txtYAxiz.EditValue = "9999";
            this.txtYAxiz.Location = new System.Drawing.Point(230, 3);
            this.txtYAxiz.Name = "txtYAxiz";
            this.txtYAxiz.Size = new System.Drawing.Size(48, 24);
            this.txtYAxiz.TabIndex = 0;
            // 
            // ucAxis_Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtYAxiz);
            this.Controls.Add(this.txtZAxisDown);
            this.Controls.Add(this.txtZAxisup);
            this.Name = "ucAxis_Setting";
            this.Size = new System.Drawing.Size(279, 31);
            ((System.ComponentModel.ISupportInitialize)(this.txtZAxisup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZAxisDown.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYAxiz.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtZAxisup;
        private DevExpress.XtraEditors.TextEdit txtZAxisDown;
        private DevExpress.XtraEditors.TextEdit txtYAxiz;
    }
}
