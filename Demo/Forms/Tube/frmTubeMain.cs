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

        #region 主界面
        /// <summary>
        /// 主界面--过渡值与功率输出显示与隐藏
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShowMVAndSP_Click(object sender, EventArgs e)
        {
            Fold(165,115,"上下",pcTempZone,btnShowMVAndSP);
        }
        /// <summary>
        /// 主界面--轴控单元操作按钮显示与隐藏
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShowAxis_Click(object sender, EventArgs e)
        {
            Fold(357, 115, "上下", pcAxis, btnShowAxis);
        }
        #endregion

        #region 设置
        /// <summary>
        /// 设置--初始化和温控系统
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShowInit_Click(object sender, EventArgs e)
        {
           Fold(290, 25, "上下", pcInit, btnShowInit);
        }
        /// <summary>
        /// 设置--气路系统
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShowSetMFC_Click(object sender, EventArgs e)
        {
          Fold(445, 25, "上下", pcSetMFC, btnShowSetMFC);
        }
        /// <summary>
        /// 设置--真空系统和运动控制
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSetAxisPara_Click(object sender, EventArgs e)
        {
           Fold(360, 25, "上下", pcSetAxisPara, btnSetAxisPara);
        }
        /// <summary>
        /// 设置-气缸参数和补偿参数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSetCylinderAnOther_Click(object sender, EventArgs e)
        {
            Fold(270, 25, "上下", pcSetCylinderAnOther, btnSetCylinderAnOther);
        }
        #endregion

        #region 调用方法
        /// <summary>
        /// 收缩与展开
        /// </summary>
        /// <param name="showHight">展开高度</param>
        /// <param name="hideHight">收缩高度</param>
        /// <param name="direction">方向（上下 或 左右）</param>
        private void Fold(int showHight,int hideHight,string direction,PanelControl pannelName,SimpleButton btnName)
        {
            if (direction == "上下")
            {
                if (pannelName.Height == hideHight)
                {
                    pannelName.Height = showHight;
                    btnName.Text = "︽";
                }
                else
                {
                    pannelName.Height = hideHight;
                    btnName.Text = "︾";
                }
            }
            if (direction == "左右")
            {
                if (pannelName.Height == hideHight)
                {
                    pannelName.Height = showHight;
                    btnName.Text = "<<";
                }
                else
                {
                    pannelName.Height = hideHight;
                    btnName.Text = ">>";
                }
            }
        }

        #endregion
    }
}