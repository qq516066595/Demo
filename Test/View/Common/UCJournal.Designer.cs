namespace Test.View.Common
{
    partial class UCJournal
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtEndTime = new System.Windows.Forms.DateTimePicker();
            this.dtStartTime = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvJournal = new System.Windows.Forms.DataGridView();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecoveryTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJournal)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1070, 2);
            this.label1.TabIndex = 29;
            // 
            // dtEndTime
            // 
            this.dtEndTime.CustomFormat = "yyyy-MM-dd HH:MM:SS";
            this.dtEndTime.Location = new System.Drawing.Point(500, 4);
            this.dtEndTime.Margin = new System.Windows.Forms.Padding(4);
            this.dtEndTime.Name = "dtEndTime";
            this.dtEndTime.Size = new System.Drawing.Size(298, 28);
            this.dtEndTime.TabIndex = 6;
            // 
            // dtStartTime
            // 
            this.dtStartTime.CustomFormat = "yyyy-MM-dd HH:MM:SS";
            this.dtStartTime.Location = new System.Drawing.Point(98, 4);
            this.dtStartTime.Margin = new System.Windows.Forms.Padding(4);
            this.dtStartTime.Name = "dtStartTime";
            this.dtStartTime.Size = new System.Drawing.Size(298, 28);
            this.dtStartTime.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(406, 8);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "结束时间";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(4, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "开始时间";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtEndTime);
            this.panel1.Controls.Add(this.dtStartTime);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1070, 36);
            this.panel1.TabIndex = 30;
            // 
            // dgvJournal
            // 
            this.dgvJournal.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvJournal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvJournal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJournal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Time,
            this.UserName,
            this.RecoveryTime,
            this.Desc});
            this.dgvJournal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvJournal.Location = new System.Drawing.Point(0, 38);
            this.dgvJournal.Margin = new System.Windows.Forms.Padding(4);
            this.dgvJournal.Name = "dgvJournal";
            this.dgvJournal.RowTemplate.Height = 23;
            this.dgvJournal.Size = new System.Drawing.Size(1070, 856);
            this.dgvJournal.TabIndex = 31;
            // 
            // Time
            // 
            this.Time.Frozen = true;
            this.Time.HeaderText = "报警时间";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            // 
            // UserName
            // 
            this.UserName.HeaderText = "用户名称";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            // 
            // RecoveryTime
            // 
            this.RecoveryTime.HeaderText = "恢复时间";
            this.RecoveryTime.Name = "RecoveryTime";
            this.RecoveryTime.ReadOnly = true;
            // 
            // Desc
            // 
            this.Desc.HeaderText = "描述";
            this.Desc.Name = "Desc";
            this.Desc.ReadOnly = true;
            // 
            // UCJournal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvJournal);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCJournal";
            this.Size = new System.Drawing.Size(1070, 894);
            this.Load += new System.EventHandler(this.UCJournal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJournal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DateTimePicker dtEndTime;
        public System.Windows.Forms.DateTimePicker dtStartTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DataGridView dgvJournal;
        public System.Windows.Forms.DataGridViewTextBoxColumn Time;
        public System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        public System.Windows.Forms.DataGridViewTextBoxColumn RecoveryTime;
        public System.Windows.Forms.DataGridViewTextBoxColumn Desc;
    }
}
