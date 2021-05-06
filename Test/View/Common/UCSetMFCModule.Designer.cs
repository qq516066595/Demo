namespace Test.View.Common
{
    partial class UCSetMFCModule
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWarnValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAlmValue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaxRange = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSheild = new System.Windows.Forms.Button();
            this.verificationComponent1 = new HZH_Controls.Controls.VerificationComponent(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "MFC名称";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(14, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "偏差警示值(%)：";
            // 
            // txtWarnValue
            // 
            this.txtWarnValue.Location = new System.Drawing.Point(148, 26);
            this.txtWarnValue.Margin = new System.Windows.Forms.Padding(4);
            this.txtWarnValue.Name = "txtWarnValue";
            this.txtWarnValue.Size = new System.Drawing.Size(92, 28);
            this.txtWarnValue.TabIndex = 2;
            this.verificationComponent1.SetVerificationCustomRegex(this.txtWarnValue, "");
            this.verificationComponent1.SetVerificationErrorMsg(this.txtWarnValue, "");
            this.verificationComponent1.SetVerificationModel(this.txtWarnValue, HZH_Controls.Controls.VerificationModel.UnsignNumber);
            this.verificationComponent1.SetVerificationRequired(this.txtWarnValue, false);
            this.txtWarnValue.TextChanged += new System.EventHandler(this.txtValue_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(14, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "报警警示值(%)：";
            // 
            // txtAlmValue
            // 
            this.txtAlmValue.Location = new System.Drawing.Point(148, 58);
            this.txtAlmValue.Margin = new System.Windows.Forms.Padding(4);
            this.txtAlmValue.Name = "txtAlmValue";
            this.txtAlmValue.Size = new System.Drawing.Size(92, 28);
            this.txtAlmValue.TabIndex = 2;
            this.verificationComponent1.SetVerificationCustomRegex(this.txtAlmValue, "");
            this.verificationComponent1.SetVerificationErrorMsg(this.txtAlmValue, "");
            this.verificationComponent1.SetVerificationModel(this.txtAlmValue, HZH_Controls.Controls.VerificationModel.UnsignNumber);
            this.verificationComponent1.SetVerificationRequired(this.txtAlmValue, false);
            this.txtAlmValue.TextChanged += new System.EventHandler(this.txtValue_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(4, 94);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "最大量程(sccm)：";
            // 
            // txtMaxRange
            // 
            this.txtMaxRange.Location = new System.Drawing.Point(148, 92);
            this.txtMaxRange.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaxRange.Name = "txtMaxRange";
            this.txtMaxRange.Size = new System.Drawing.Size(92, 28);
            this.txtMaxRange.TabIndex = 2;
            this.verificationComponent1.SetVerificationCustomRegex(this.txtMaxRange, "");
            this.verificationComponent1.SetVerificationErrorMsg(this.txtMaxRange, "");
            this.verificationComponent1.SetVerificationModel(this.txtMaxRange, HZH_Controls.Controls.VerificationModel.UnsignNumber);
            this.verificationComponent1.SetVerificationRequired(this.txtMaxRange, false);
            this.txtMaxRange.TextChanged += new System.EventHandler(this.txtValue_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(42, 124);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "流量计屏蔽：";
            // 
            // btnSheild
            // 
            this.btnSheild.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSheild.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSheild.Location = new System.Drawing.Point(148, 123);
            this.btnSheild.Margin = new System.Windows.Forms.Padding(4);
            this.btnSheild.Name = "btnSheild";
            this.btnSheild.Size = new System.Drawing.Size(94, 32);
            this.btnSheild.TabIndex = 22;
            this.btnSheild.Text = "屏蔽";
            this.btnSheild.UseVisualStyleBackColor = true;
            this.btnSheild.Click += new System.EventHandler(this.btnSheild_Click);
            // 
            // verificationComponent1
            // 
            this.verificationComponent1.AutoCloseErrorTipsTime = 3000;
            this.verificationComponent1.ErrorTipsBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(58)))));
            this.verificationComponent1.ErrorTipsForeColor = System.Drawing.Color.White;
            this.verificationComponent1.Verificationed += new HZH_Controls.Controls.VerificationComponent.VerificationedHandle(this.verificationComponent1_Verificationed);
            // 
            // UCSetMFCModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSheild);
            this.Controls.Add(this.txtMaxRange);
            this.Controls.Add(this.txtAlmValue);
            this.Controls.Add(this.txtWarnValue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCSetMFCModule";
            this.Size = new System.Drawing.Size(248, 160);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtWarnValue;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtAlmValue;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtMaxRange;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button btnSheild;
        private HZH_Controls.Controls.VerificationComponent verificationComponent1;
    }
}
