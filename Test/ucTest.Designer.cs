namespace Test
{
    partial class ucTest
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
            this.components = new System.ComponentModel.Container();
            HZH_Controls.Controls.NavigationMenuItem navigationMenuItem1 = new HZH_Controls.Controls.NavigationMenuItem();
            HZH_Controls.Controls.NavigationMenuItem navigationMenuItem2 = new HZH_Controls.Controls.NavigationMenuItem();
            HZH_Controls.Controls.NavigationMenuItem navigationMenuItem3 = new HZH_Controls.Controls.NavigationMenuItem();
            HZH_Controls.Controls.NavigationMenuItem navigationMenuItem4 = new HZH_Controls.Controls.NavigationMenuItem();
            HZH_Controls.Controls.NavigationMenuItem navigationMenuItem5 = new HZH_Controls.Controls.NavigationMenuItem();
            HZH_Controls.Controls.NavigationMenuItem navigationMenuItem6 = new HZH_Controls.Controls.NavigationMenuItem();
            this.ucNavigationMenu1 = new HZH_Controls.Controls.UCNavigationMenu();
            this.graphicalOverlayComponent1 = new HZH_Controls.Controls.GraphicalOverlayComponent(this.components);
            this.lblCurrentLocation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ucNavigationMenu1
            // 
            this.ucNavigationMenu1.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ucNavigationMenu1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ucNavigationMenu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucNavigationMenu1.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucNavigationMenu1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            navigationMenuItem1.AnchorRight = false;
            navigationMenuItem1.DataSource = null;
            navigationMenuItem1.HasSplitLintAtTop = false;
            navigationMenuItem1.Icon = null;
            navigationMenuItem1.Items = null;
            navigationMenuItem1.ItemWidth = 100;
            navigationMenuItem1.ShowTip = false;
            navigationMenuItem1.Text = "炉管一";
            navigationMenuItem1.TipText = null;
            navigationMenuItem2.AnchorRight = false;
            navigationMenuItem2.DataSource = null;
            navigationMenuItem2.HasSplitLintAtTop = false;
            navigationMenuItem2.Icon = null;
            navigationMenuItem2.Items = null;
            navigationMenuItem2.ItemWidth = 100;
            navigationMenuItem2.ShowTip = false;
            navigationMenuItem2.Text = "炉管二";
            navigationMenuItem2.TipText = null;
            navigationMenuItem3.AnchorRight = false;
            navigationMenuItem3.DataSource = null;
            navigationMenuItem3.HasSplitLintAtTop = false;
            navigationMenuItem3.Icon = null;
            navigationMenuItem3.Items = null;
            navigationMenuItem3.ItemWidth = 100;
            navigationMenuItem3.ShowTip = false;
            navigationMenuItem3.Text = "炉管三";
            navigationMenuItem3.TipText = null;
            navigationMenuItem4.AnchorRight = false;
            navigationMenuItem4.DataSource = null;
            navigationMenuItem4.HasSplitLintAtTop = false;
            navigationMenuItem4.Icon = null;
            navigationMenuItem4.Items = null;
            navigationMenuItem4.ItemWidth = 100;
            navigationMenuItem4.ShowTip = false;
            navigationMenuItem4.Text = "炉管四";
            navigationMenuItem4.TipText = null;
            navigationMenuItem5.AnchorRight = false;
            navigationMenuItem5.DataSource = null;
            navigationMenuItem5.HasSplitLintAtTop = false;
            navigationMenuItem5.Icon = null;
            navigationMenuItem5.Items = null;
            navigationMenuItem5.ItemWidth = 100;
            navigationMenuItem5.ShowTip = false;
            navigationMenuItem5.Text = "炉管五";
            navigationMenuItem5.TipText = null;
            navigationMenuItem6.AnchorRight = false;
            navigationMenuItem6.DataSource = null;
            navigationMenuItem6.HasSplitLintAtTop = false;
            navigationMenuItem6.Icon = null;
            navigationMenuItem6.Items = null;
            navigationMenuItem6.ItemWidth = 100;
            navigationMenuItem6.ShowTip = false;
            navigationMenuItem6.Text = "机械手";
            navigationMenuItem6.TipText = null;
            this.ucNavigationMenu1.Items = new HZH_Controls.Controls.NavigationMenuItem[] {
        navigationMenuItem1,
        navigationMenuItem2,
        navigationMenuItem3,
        navigationMenuItem4,
        navigationMenuItem5,
        navigationMenuItem6};
            this.ucNavigationMenu1.Location = new System.Drawing.Point(0, 0);
            this.ucNavigationMenu1.Name = "ucNavigationMenu1";
            this.ucNavigationMenu1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.ucNavigationMenu1.Size = new System.Drawing.Size(1208, 60);
            this.ucNavigationMenu1.TabIndex = 0;
            this.ucNavigationMenu1.TipColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.ucNavigationMenu1.ClickItemed += new System.EventHandler(this.ucNavigationMenu1_ClickItemed);
            // 
            // graphicalOverlayComponent1
            // 
            this.graphicalOverlayComponent1.Owner = null;
            // 
            // lblCurrentLocation
            // 
            this.lblCurrentLocation.AutoSize = true;
            this.lblCurrentLocation.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblCurrentLocation.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblCurrentLocation.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCurrentLocation.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblCurrentLocation.Location = new System.Drawing.Point(1091, 0);
            this.lblCurrentLocation.Name = "lblCurrentLocation";
            this.lblCurrentLocation.Size = new System.Drawing.Size(117, 28);
            this.lblCurrentLocation.TabIndex = 2;
            this.lblCurrentLocation.Text = "当前位置：";
            // 
            // ucTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblCurrentLocation);
            this.Controls.Add(this.ucNavigationMenu1);
            this.Name = "ucTest";
            this.Size = new System.Drawing.Size(1208, 60);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HZH_Controls.Controls.UCNavigationMenu ucNavigationMenu1;
        private HZH_Controls.Controls.GraphicalOverlayComponent graphicalOverlayComponent1;
        private System.Windows.Forms.Label lblCurrentLocation;
    }
}
