using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using com.DataBaseModels;
/*
* namespace：Demo.Forms
* className：frmHeating
* 
* Version：HMI_RPxx_V001_202012
* Author：hehf
* Date：2020-12-28 15:57:58
* Desc：温区-开启加热弹窗，设置设定温度、设定斜率
* 
* Remarks：权限控制待完善
*/
namespace Demo.Forms.Tube
{
    public partial class frmHeating : DevExpress.XtraEditors.XtraForm
    {
        public int frmIndex;

        public frmHeating()
        {
            InitializeComponent();
        }

        int TubeIndex = 0;
        private void frmHeating_Load(object sender, EventArgs e)
        {
            TubeIndex = frmIndex;//获取主界面的tag值
        }

        /// <summary>
        /// 确认
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            PlcModels.grHMI_TempSV = (float)Convert.ToDouble(txtTempSV.Text);
            PlcModels.grHMI_TempRump = (float)Convert.ToDouble(txtTempRump.Text);
            PlcModels.gbHMI_Temp_Enable = true;
            this.Close();
        }

        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}