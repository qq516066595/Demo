namespace Test.View.Tube
{
    partial class UCReport
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
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Step = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StepName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Zone1In = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zone2In = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zone3In = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zone4In = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zone5In = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zone6In = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zone7In = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zone8In = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zone1Ex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zone2Ex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zone3Ex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(769, 24);
            this.panel1.TabIndex = 27;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "yyyy-MM-dd HH:MM:SS";
            this.dateTimePicker2.Location = new System.Drawing.Point(333, 3);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker2.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd HH:MM:SS";
            this.dateTimePicker1.Location = new System.Drawing.Point(65, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(271, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "结束时间";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "开始时间";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(769, 1);
            this.label1.TabIndex = 26;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Time,
            this.Step,
            this.StepName,
            this.Zone1In,
            this.Zone2In,
            this.Zone3In,
            this.Zone4In,
            this.Zone5In,
            this.Zone6In,
            this.Zone7In,
            this.Zone8In,
            this.Zone1Ex,
            this.Zone2Ex,
            this.Zone3Ex});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(769, 554);
            this.dataGridView1.TabIndex = 28;
            // 
            // Time
            // 
            this.Time.Frozen = true;
            this.Time.HeaderText = "时间";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
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
            this.StepName.ReadOnly = true;
            // 
            // Zone1In
            // 
            this.Zone1In.Frozen = true;
            this.Zone1In.HeaderText = "温区1内偶";
            this.Zone1In.Name = "Zone1In";
            this.Zone1In.ReadOnly = true;
            // 
            // Zone2In
            // 
            this.Zone2In.Frozen = true;
            this.Zone2In.HeaderText = "温区2内偶";
            this.Zone2In.Name = "Zone2In";
            this.Zone2In.ReadOnly = true;
            // 
            // Zone3In
            // 
            this.Zone3In.Frozen = true;
            this.Zone3In.HeaderText = "温区3内偶";
            this.Zone3In.Name = "Zone3In";
            this.Zone3In.ReadOnly = true;
            // 
            // Zone4In
            // 
            this.Zone4In.Frozen = true;
            this.Zone4In.HeaderText = "温区4内偶";
            this.Zone4In.Name = "Zone4In";
            this.Zone4In.ReadOnly = true;
            // 
            // Zone5In
            // 
            this.Zone5In.Frozen = true;
            this.Zone5In.HeaderText = "温区5内偶";
            this.Zone5In.Name = "Zone5In";
            this.Zone5In.ReadOnly = true;
            // 
            // Zone6In
            // 
            this.Zone6In.Frozen = true;
            this.Zone6In.HeaderText = "温区6内偶";
            this.Zone6In.Name = "Zone6In";
            this.Zone6In.ReadOnly = true;
            // 
            // Zone7In
            // 
            this.Zone7In.Frozen = true;
            this.Zone7In.HeaderText = "温区7内偶";
            this.Zone7In.Name = "Zone7In";
            this.Zone7In.ReadOnly = true;
            // 
            // Zone8In
            // 
            this.Zone8In.Frozen = true;
            this.Zone8In.HeaderText = "温区8内偶";
            this.Zone8In.Name = "Zone8In";
            this.Zone8In.ReadOnly = true;
            // 
            // Zone1Ex
            // 
            this.Zone1Ex.Frozen = true;
            this.Zone1Ex.HeaderText = "温区1外偶";
            this.Zone1Ex.Name = "Zone1Ex";
            this.Zone1Ex.ReadOnly = true;
            // 
            // Zone2Ex
            // 
            this.Zone2Ex.Frozen = true;
            this.Zone2Ex.HeaderText = "温区2外偶";
            this.Zone2Ex.Name = "Zone2Ex";
            this.Zone2Ex.ReadOnly = true;
            // 
            // Zone3Ex
            // 
            this.Zone3Ex.Frozen = true;
            this.Zone3Ex.HeaderText = "温区3外偶";
            this.Zone3Ex.Name = "Zone3Ex";
            this.Zone3Ex.ReadOnly = true;
            // 
            // UCReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "UCReport";
            this.Size = new System.Drawing.Size(769, 579);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Step;
        private System.Windows.Forms.DataGridViewComboBoxColumn StepName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zone1In;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zone2In;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zone3In;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zone4In;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zone5In;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zone6In;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zone7In;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zone8In;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zone1Ex;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zone2Ex;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zone3Ex;
    }
}
