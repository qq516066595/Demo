namespace Test.View.Tube
{
    partial class UCMain
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
            this.ucRecipeInfo1 = new Test.View.Tube.UCRecipeInfo();
            this.ucBoatPush1 = new Test.View.Tube.UCBoatPush();
            this.ucRoad1 = new Test.View.Tube.UCRoad();
            this.ucZone1 = new Test.View.Tube.UCZone();

            this.SuspendLayout();
            // 
            // ucRecipeInfo1
            // 
            this.ucRecipeInfo1.Dock = System.Windows.Forms.DockStyle.Left;
            this.ucRecipeInfo1.Location = new System.Drawing.Point(0, 0);
            this.ucRecipeInfo1.Name = "ucRecipeInfo1";
            this.ucRecipeInfo1.Size = new System.Drawing.Size(224, 932);
            this.ucRecipeInfo1.TabIndex = 0;
            // 
            // ucBoatPush1
            // 
            this.ucBoatPush1.Dock = System.Windows.Forms.DockStyle.Right;
            this.ucBoatPush1.Location = new System.Drawing.Point(939, 0);
            this.ucBoatPush1.Name = "ucBoatPush1";
            this.ucBoatPush1.Size = new System.Drawing.Size(224, 932);
            this.ucBoatPush1.TabIndex = 1;
            // 
            // ucRoad1
            // 
            this.ucRoad1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucRoad1.Location = new System.Drawing.Point(224, 196);
            this.ucRoad1.Name = "ucRoad1";
            this.ucRoad1.Size = new System.Drawing.Size(715, 736);
            this.ucRoad1.TabIndex = 3;
            // 
            // ucZone1
            // 
            this.ucZone1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucZone1.Location = new System.Drawing.Point(224, 0);
            this.ucZone1.Name = "ucZone1";
            this.ucZone1.Size = new System.Drawing.Size(715, 196);
            this.ucZone1.TabIndex = 2;
            // 
            // UCMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ucRoad1);
            this.Controls.Add(this.ucZone1);
            this.Controls.Add(this.ucBoatPush1);
            this.Controls.Add(this.ucRecipeInfo1);
            this.Name = "UCMain";
            this.Size = new System.Drawing.Size(1163, 932);
            this.Load += new System.EventHandler(this.UCMain_Load);
            this.ResumeLayout(false);
        }

        #endregion

        private UCRecipeInfo ucRecipeInfo1;
        private UCBoatPush ucBoatPush1;
        private UCRoad ucRoad1;
        private UCZone ucZone1;
    }
}
