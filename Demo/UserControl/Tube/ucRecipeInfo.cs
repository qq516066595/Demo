using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using com.DataBaseModels;
using Demo.Forms.Tube;
using com.TubeServices;

/*
* namespace：Demo.Forms.Tube
* className：ColorHelpClass
* 
* Version：HMI_RPxx_V001_202012
* Author：hehf
* Date：2020/12/28 11:39:22
* Desc：炉管工艺信息显示与操作。
* 
* Remarks：待完善：操作权限、到达信号量按钮变绿、按钮操作条件是否满足
*/
namespace Demo.UserControl.Tube
{
    public partial class ucRecipeInfo : DevExpress.XtraEditors.XtraUserControl
    {
        TubeHelpClass help = new TubeHelpClass();
        public ucRecipeInfo()
        {
            InitializeComponent();
        }
        public void ucRecipe(PlcModels myModus)
        {
            //modus = myModus;
            //tsAutoSelect.IsOn = modus.OP_Mode == 1 ? false : modus.OP_Mode == 3 ? true : false;
            //lblRecipeName.Text = modus.sCurrentRecipeName;
            //lblRecipeTotalTime.Text = help.timeFormatIntToString(modus.gnProcessWorkingTime);
            //lblRecipeWorkTime.Text = help.timeFormatIntToString(modus.gnProcessWorkingTime);
            //lblRecipeRemainTime.Text = help.timeFormatIntToString(modus.gnProcessRemainTime);
            //lblStepID.Text = modus.giRecipe_ID.ToString();
            //lblStepName.Text = help.KSrecipeNameFormatIntToString(modus.stcurrentRecipeCtrl.eName);
            //lblStepTotalTime.Text = help.timeFormatIntToString(modus.stcurrentRecipeCtrl.nDuration);
            //lblStepWorkTime.Text = help.timeFormatIntToString(modus.stcurrentRecipeCtrl.nWorking_Time);
            //lblStepRemainTime.Text = help.timeFormatIntToString(modus.stcurrentRecipeCtrl.nRemain_Time);

            //cmbBoatState.SelectedIndexChanged += CmbBoatState_SelectedIndexChanged;
            //btnStart.Click += BtnStart_Click;
        }



        PlcModels modus = new PlcModels();

        /// <summary>
        /// 舟状态改变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CmbBoatState_SelectedIndexChanged(object sender, EventArgs e)
        {
           // modus.stTube_BoatInfos.eBoatState = cmbBoatState.SelectedIndex;
        }

        /// <summary>
        /// 手自动切换
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsAutoSelect_Toggled(object sender, EventArgs e)
        {
            //if (tsAutoSelect.IsOn)//自动
            //{
            //    modus.OP_Mode = 3;
            //}
            //else//手动
            //{
            //    modus.OP_Mode = 1;
            //}
        }

        private void ucRecipeInfo_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 开始
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnStart_Click(object sender, EventArgs e)
        {
            //modus.gbHMI_Recipe_Start = !modus.gbHMI_Recipe_Start;
            //help.SetbtnClickBackColor(btnStart, Color.Lime, modus.gbHMI_Recipe_Start);
        }
        /// <summary>
        /// 保持
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHold_Click(object sender, EventArgs e)
        {
            //modus.gbHMI_Recipe_Hold = !modus.gbHMI_Recipe_Hold;
            //help.SetbtnClickBackColor(btnHold, Color.Yellow, modus.gbHMI_Recipe_Hold);
        }
        /// <summary>
        /// 跳步
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnJumpStep_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 中止
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAbort_Click(object sender, EventArgs e)
        {
            //modus.gbHMI_Recipe_Abort = !modus.gbHMI_Recipe_Abort;
            //help.SetbtnClickBackColor(btnAbort, Color.Red, modus.gbHMI_Recipe_Abort);
        }
        /// <summary>
        /// 结束
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFinish_Click(object sender, EventArgs e)
        {
            //modus.gbHMI_Recipe_Finish = !modus.gbHMI_Recipe_Finish;
            //help.SetbtnClickBackColor(btnFinish, Color.Yellow, modus.gbHMI_Recipe_Finish);
        }
        /// <summary>
        /// 锁管
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTubeDisable_Click(object sender, EventArgs e)
        {
            //btnTubeDisable.Appearance.Options.UseBackColor = true;
            //modus.gbTube_Disable = !modus.gbTube_Disable;
            //help.SetbtnClickBackColor(btnTubeDisable, Color.Red, modus.gbTube_Disable);
            //if (modus.gbTube_Disable)
            //    btnTubeDisable.ForeColor = Color.Black;
            //else
            //    btnTubeDisable.ForeColor = Color.Red;
        }

        private void btnStart_Click_1(object sender, EventArgs e)
        {
          
        }
    }
}
