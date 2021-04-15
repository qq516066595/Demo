namespace Test.View.Tube
{
    partial class UCRecipe
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Step = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StepName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Condition = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.StepTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zone1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zone2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zone3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zone4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zone5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zone6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zone7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Step,
            this.StepName,
            this.Condition,
            this.StepTime,
            this.Zone1,
            this.Zone2,
            this.Zone3,
            this.Zone4,
            this.Zone5,
            this.Zone6,
            this.Zone7});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(753, 485);
            this.dataGridView1.TabIndex = 0;
            // 
            // Step
            // 
            this.Step.Frozen = true;
            this.Step.HeaderText = "步号";
            this.Step.Name = "Step";
            this.Step.ReadOnly = true;
            // 
            // StepName
            // 
            this.StepName.Frozen = true;
            this.StepName.HeaderText = "步名称";
            this.StepName.Name = "StepName";
            // 
            // Condition
            // 
            this.Condition.Frozen = true;
            this.Condition.HeaderText = "条件";
            this.Condition.Name = "Condition";
            // 
            // StepTime
            // 
            this.StepTime.Frozen = true;
            this.StepTime.HeaderText = "步时间";
            this.StepTime.Name = "StepTime";
            // 
            // Zone1
            // 
            this.Zone1.HeaderText = "温区1";
            this.Zone1.Name = "Zone1";
            // 
            // Zone2
            // 
            this.Zone2.HeaderText = "温区2";
            this.Zone2.Name = "Zone2";
            // 
            // Zone3
            // 
            this.Zone3.HeaderText = "温区3";
            this.Zone3.Name = "Zone3";
            // 
            // Zone4
            // 
            this.Zone4.HeaderText = "温区4";
            this.Zone4.Name = "Zone4";
            // 
            // Zone5
            // 
            this.Zone5.HeaderText = "温区5";
            this.Zone5.Name = "Zone5";
            // 
            // Zone6
            // 
            this.Zone6.HeaderText = "温区6";
            this.Zone6.Name = "Zone6";
            // 
            // Zone7
            // 
            this.Zone7.HeaderText = "温区7";
            this.Zone7.Name = "Zone7";
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(753, 1);
            this.label4.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(753, 25);
            this.panel1.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(237, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(90, 25);
            this.comboBox1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(179, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "工艺名称：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(87, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "RecipeName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "当前工艺名称：";
            // 
            // UCRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Name = "UCRecipe";
            this.Size = new System.Drawing.Size(753, 511);
            this.Load += new System.EventHandler(this.UCRecipe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Step;
        private System.Windows.Forms.DataGridViewComboBoxColumn StepName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Condition;
        private System.Windows.Forms.DataGridViewTextBoxColumn StepTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zone1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zone2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zone3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zone4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zone5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zone6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zone7;
    }
}
