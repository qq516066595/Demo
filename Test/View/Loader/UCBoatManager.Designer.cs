namespace Test.View.Loader
{
    partial class UCBoatManager
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label27 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BoatID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GenerationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GenerationDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OnlineTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UseCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UseDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectTube = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.SelectRecipe = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Clean = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1209, 38);
            this.panel1.TabIndex = 0;
            // 
            // label27
            // 
            this.label27.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label27.Dock = System.Windows.Forms.DockStyle.Top;
            this.label27.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label27.Location = new System.Drawing.Point(0, 0);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(1209, 2);
            this.label27.TabIndex = 31;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.BoatID,
            this.GenerationDate,
            this.GenerationDays,
            this.OnlineTime,
            this.UseCount,
            this.UseDays,
            this.SelectTube,
            this.SelectRecipe,
            this.Clean});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(1209, 956);
            this.dataGridView1.TabIndex = 32;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "预警值设置";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(110, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 29);
            this.button2.TabIndex = 0;
            this.button2.Text = "删除";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.Location = new System.Drawing.Point(217, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 29);
            this.button3.TabIndex = 0;
            this.button3.Text = "新增";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button4.Location = new System.Drawing.Point(324, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(101, 29);
            this.button4.TabIndex = 0;
            this.button4.Text = "保存";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // ID
            // 
            this.ID.HeaderText = "编号";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // BoatID
            // 
            this.BoatID.HeaderText = "舟编号";
            this.BoatID.Name = "BoatID";
            // 
            // GenerationDate
            // 
            this.GenerationDate.HeaderText = "生成日期";
            this.GenerationDate.Name = "GenerationDate";
            this.GenerationDate.ReadOnly = true;
            // 
            // GenerationDays
            // 
            this.GenerationDays.HeaderText = "生成天数";
            this.GenerationDays.Name = "GenerationDays";
            this.GenerationDays.ReadOnly = true;
            // 
            // OnlineTime
            // 
            this.OnlineTime.HeaderText = "上线时间";
            this.OnlineTime.Name = "OnlineTime";
            this.OnlineTime.ReadOnly = true;
            // 
            // UseCount
            // 
            this.UseCount.HeaderText = "使用次数";
            this.UseCount.Name = "UseCount";
            this.UseCount.ReadOnly = true;
            // 
            // UseDays
            // 
            this.UseDays.HeaderText = "使用天数";
            this.UseDays.Name = "UseDays";
            this.UseDays.ReadOnly = true;
            // 
            // SelectTube
            // 
            this.SelectTube.HeaderText = "去往炉管";
            this.SelectTube.Name = "SelectTube";
            // 
            // SelectRecipe
            // 
            this.SelectRecipe.HeaderText = "工艺名称";
            this.SelectRecipe.Name = "SelectRecipe";
            // 
            // Clean
            // 
            this.Clean.HeaderText = "下线清洗";
            this.Clean.Name = "Clean";
            // 
            // UCBoatManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label27);
            this.Name = "UCBoatManager";
            this.Size = new System.Drawing.Size(1209, 996);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BoatID;
        private System.Windows.Forms.DataGridViewTextBoxColumn GenerationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn GenerationDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn OnlineTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn UseCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn UseDays;
        private System.Windows.Forms.DataGridViewComboBoxColumn SelectTube;
        private System.Windows.Forms.DataGridViewComboBoxColumn SelectRecipe;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Clean;
    }
}
