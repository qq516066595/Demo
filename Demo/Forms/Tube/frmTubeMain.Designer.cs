namespace Demo.Forms.Tube
{
    partial class frmTubeMain
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
            this.ucTubeMain1 = new Demo.UserControl.ucTubeMain();
            this.SuspendLayout();
            // 
            // ucTubeMain1
            // 
            this.ucTubeMain1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucTubeMain1.Location = new System.Drawing.Point(0, 0);
            this.ucTubeMain1.Name = "ucTubeMain1";
            this.ucTubeMain1.Size = new System.Drawing.Size(1024, 1140);
            this.ucTubeMain1.TabIndex = 0;
            // 
            // frmTubeMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 1140);
            this.Controls.Add(this.ucTubeMain1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmTubeMain";
            this.Tag = "0";
            this.Text = "frmTubeMian";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControl.ucTubeMain ucTubeMain1;
    }
}