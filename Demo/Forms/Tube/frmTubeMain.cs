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
/*
* namespace：Demo.Forms
* className：frmHomePage
* 
* Version：HMI_RPxx_V001_202012
* Author：hehf
* Date：2020-12-12 11:57:58
* Desc：炉管页面
* 
* Remarks：
*/
namespace Demo.Forms.Tube
{
    public partial class frmTubeMain : DevExpress.XtraEditors.XtraForm
    {
        public frmTubeMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 过渡值与功率输出显示与隐藏
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShowMVAndSP_Click(object sender, EventArgs e)
        {
            if (pcTempZone.Height == 110)
            {
                pcTempZone.Height = 165;
                pcRoad.Text = "︽";
            }
            else
            {
                pcTempZone.Height = 110;
                pcRoad.Text = "︾";
            }
        }
        /// <summary>
        /// 气路图的相关参数信息隐藏与显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShowRoadPara_Click(object sender, EventArgs e)
        {
            pcShowRoadPara.Visible = !pcShowRoadPara.Visible;
            if (pcShowRoadPara.Visible)
                btnShowRoadPara.Text = "<<";
            else
                btnShowRoadPara.Text = ">>";
        }
        /// <summary>
        /// 轴控单元操作按钮隐藏与显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShowAxisPara_Click(object sender, EventArgs e)
        {
            if (pcAxis.Height == 70)
            {
                pcAxis.Height = 135;
                btnShowAxisPara.Text = "︽";
            }
            else
            {
                pcAxis.Height = 70;
                btnShowAxisPara.Text = "︾";
            }
        }
    }
}