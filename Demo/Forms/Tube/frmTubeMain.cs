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

            lblZoneEx1.Text = this.Tag.ToString();
        }

        #region 主界面
        #region 温区
        /// <summary>
        /// 主界面--过渡值与功率输出显示与隐藏
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShowMVAndSP_Click(object sender, EventArgs e)
        {
            Fold(165, 115, "上下", pcTempZone, btnShowMVAndSP);
        }

        /// <summary>
        /// 温度内容绑定
        /// </summary>
        private void TempBindings(MyModus modus)
        {
            foreach (Control control in this.pcTempZone.Controls)
            {
                if (control is LabelControl)
                {
                    for (int i = 1; i <= 7; i++)
                    {
                        if (control.Name.Equals("lblZoneEx" + i.ToString(), StringComparison.CurrentCultureIgnoreCase))//外偶
                            ((LabelControl)control).Text = modus.StTempZoneArray[i].rExternal_Temp.ToString();
                        else if (control.Name.Equals("lblZoneIn" + i.ToString(), StringComparison.CurrentCultureIgnoreCase))//内偶
                            ((LabelControl)control).Text = modus.StTempZoneArray[i].rInternal_Temp.ToString();
                        else if (control.Name.Equals("lblZoneMV" + i.ToString(), StringComparison.CurrentCultureIgnoreCase))//功率
                            ((LabelControl)control).Text = modus.StTempZoneArray[i].rMV.ToString();
                        else if (control.Name.Equals("lblZoneSP" + i.ToString(), StringComparison.CurrentCultureIgnoreCase))//过渡
                            ((LabelControl)control).Text = modus.grTemp_SPArray[i].ToString();
                    }
                    //水冷
                    lblWaterCooling1.Text = modus.grCooling_PV1.ToString();
                    lblWaterCooling2.Text = modus.grCooling_PV2.ToString();
                }
                //设定值
                if (control is TextEdit)
                {
                    for (int i = 1; i < 7; i++)
                    {
                        if (control.Name.Equals("txtZoneSV" + i.ToString(), StringComparison.CurrentCultureIgnoreCase))//设定值
                            ((TextEdit)control).Text = modus.StTempZoneArray[i].rSet_Temp.ToString();
                    }
                }
            }
        }
        #endregion

        #region 轴控
        /// <summary>
        /// 主界面--轴控单元操作按钮显示与隐藏
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShowAxis_Click(object sender, EventArgs e)
        {
            Fold(490, 115, "上下", pcAxis, btnShowAxis);
        }
        #endregion

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
        #endregion

        #region 调用方法
        /// <summary>
        /// 收缩与展开
        /// </summary>
        /// <param name="showHight">展开高度</param>
        /// <param name="hideHight">收缩高度</param>
        /// <param name="direction">方向（上下 或 左右）</param>
        private void Fold(int showHight, int hideHight, string direction, PanelControl pannelName, SimpleButton btnName)
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

        #region 获取炉管号
        /// <summary>
        /// 将本窗体的tag值传递出去
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        MyModus myModus1 = new MyModus();
        MyModus myModus2 = new MyModus();
        MyModus myModus3 = new MyModus();
        MyModus myModus4 = new MyModus();
        MyModus myModus5 = new MyModus();
        private void frmTubeMain_Load(object sender, EventArgs e)
        {
            //int a = (Int32)this.Tag;
            //if (a == 1)//炉管一
            //    gettag(1);
            //else if (a == 2)//炉管二
            //    gettag(2);
            //else if (a == 3)//炉管三
            //    gettag(3);
            //else if (a == 4)//炉管四
            //    gettag(4);
            //else if (a == 5)//炉管五
            //    gettag(5);


            //2020-12-29 hhf 测试使用；需写到委托事件中实时刷新数据
            //MyModus[] myModus = new MyModus[5];
            //MyModus mys = new MyModus();
            //int index = Convert.ToInt32(this.Tag) - 1;
            //myModus[index] = mys;
            myModus1.giRecipe_ID = 1;
            myModus2.giRecipe_ID = 2;
            myModus3.giRecipe_ID = 3;
            myModus4.giRecipe_ID = 4;
            myModus5.giRecipe_ID = 5;

            MyModus mys = new MyModus();
            int index = Convert.ToInt32(this.Tag);
            if (index == 1)
                mys = myModus1;
            else if (index == 2)
                mys = myModus2;
            else if (index == 3)
                mys = myModus3;
            else if (index == 4)
                mys = myModus4;
            else if (index == 5)
                mys = myModus5;
            else
                return;
            mys.grTemp_SPArray[0] = 91;
            mys.grTemp_SPArray[1] = 92;
            mys.grTemp_SPArray[2] = 93;
            mys.grTemp_SPArray[3] = 94;
            mys.grTemp_SPArray[4] = 95;
            mys.grTemp_SPArray[5] = 96;
            mys.grTemp_SPArray[6] = 97;
            mys.StTempZoneArray[0].rMV = 11;
            mys.StTempZoneArray[0].rSet_Temp = 500;
            mys.StTempZoneArray[0].rExternal_Temp = 300;
            mys.StTempZoneArray[0].rInternal_Temp = 289.4;

            //温区值绑定
            TempBindings(mys);
            ucRecipeInfo1.ucRecipe(mys);
        }

        #endregion

        /// <summary>
        /// 开启加热弹窗
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblHeating_Click(object sender, EventArgs e)
        {
            frmHeating frmheat = new frmHeating();
            frmheat.frmIndex = (int)this.Tag;
            frmheat.ShowDialog();
        }
    }
}