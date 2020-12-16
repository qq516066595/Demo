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
            this.btnCut.Text = "气\n\n路\n\n画\n\n面";
        }


        /// <summary>
        /// 设置气路与控制画面的切换
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks>遗留问题：spcMain分割线无法取消点击事件，那么点击时，btnCut显示文字需改变</remarks>
        private void btnCut_Click(object sender, EventArgs e)
        {
            if (this.btnCut.Text == "气\n\n路\n\n画\n\n面")
            {
                this.btnCut.Text = "控\n\n制\n\n画\n\n面";
                this.spcRoadAndControl.CollapsePanel= SplitCollapsePanel.Panel1;
            }
            else
            {
                this.btnCut.Text = "气\n\n路\n\n画\n\n面";
                this.spcRoadAndControl.CollapsePanel = SplitCollapsePanel.Panel2;
            }

        }
        /// <summary>
        /// 过渡值与功率输出显示与隐藏
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShowMVAndSP_Click(object sender, EventArgs e)
        {
            pcMVAndSP.Visible = !pcMVAndSP.Visible;
        }
    }
}