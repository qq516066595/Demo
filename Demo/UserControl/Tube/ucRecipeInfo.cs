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
        //TubeModelClass models = new TubeModelClass();
        public ucRecipeInfo()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 舟状态改变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CmbBoatState_SelectedIndexChanged(object sender, EventArgs e)
        {
            PlcVar.Tube[frmID.Unit].stTube_BoatInfo.eBoatState = (PlcModels.BoatState)cmbBoatState.SelectedIndex;
        }

        /// <summary>
        /// 手自动切换
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsAutoSelect_Toggled(object sender, EventArgs e)
        {
            if (tsAutoSelect.IsOn)//自动
            {
                PlcVar.Tube[frmID.Unit].OP_Cmd.bAutoSelect = true;
            }
            else//手动
            {
                PlcVar.Tube[frmID.Unit].OP_Cmd.bAutoSelect = false;
            }
        }

        private void ucRecipeInfo_Load(object sender, EventArgs e)
        {
            //tsAutoSelect.IsOn = PlcVar.Tube[frmID.Unit].OP_Cmd.bAutoSelect;
            //lblRecipeName.Text = PlcVar.Tube[frmID.Unit].stCurrentRecipeName;
            //lblRecipeTotalTime.Text = help.timeFormatUshortToString(PlcVar.Tube[frmID.Unit].gnProcessWorkingTime);
            //lblRecipeWorkTime.Text = help.timeFormatUshortToString(PlcVar.Tube[frmID.Unit].gnProcessWorkingTime);
            //lblRecipeRemainTime.Text = help.timeFormatUshortToString(PlcVar.Tube[frmID.Unit].gnProcessRemainTime);
            //lblStepID.Text = PlcVar.Tube[frmID.Unit].giRecipe_ID.ToString();
            //lblStepName.Text = help.KSrecipeNameFormatIntToString(PlcVar.Tube[frmID.Unit].stCurrentRecipeCtrl.eName);
            //lblStepTotalTime.Text = help.timeFormatFloatToString(PlcVar.Tube[frmID.Unit].stCurrentRecipeCtrl.nDuration);
            //lblStepWorkTime.Text = help.timeFormatFloatToString(PlcVar.Tube[frmID.Unit].stCurrentRecipeCtrl.nWorking_Time);
            //lblStepRemainTime.Text = help.timeFormatFloatToString(PlcVar.Tube[frmID.Unit].stCurrentRecipeCtrl.nRemain_Time);
        }

        /// <summary>
        /// 开始
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnStart_Click(object sender, EventArgs e)
        {
            PlcVar.Tube[frmID.Unit].gbHMI_Recipe_Start = !PlcVar.Tube[frmID.Unit].gbHMI_Recipe_Start;
            help.SetbtnClickBackColor(btnStart, Color.Lime, PlcVar.Tube[frmID.Unit].gbHMI_Recipe_Start);
        }
        /// <summary>
        /// 保持
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHold_Click(object sender, EventArgs e)
        {
            PlcVar.Tube[frmID.Unit].gbHMI_Recipe_Hold = !PlcVar.Tube[frmID.Unit].gbHMI_Recipe_Hold;
            help.SetbtnClickBackColor(btnHold, Color.Yellow, PlcVar.Tube[frmID.Unit].gbHMI_Recipe_Hold);
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
            PlcVar.Tube[frmID.Unit].gbHMI_Recipe_Abort = !PlcVar.Tube[frmID.Unit].gbHMI_Recipe_Abort;
            help.SetbtnClickBackColor(btnAbort, Color.Red, PlcVar.Tube[frmID.Unit].gbHMI_Recipe_Abort);
        }
        /// <summary>
        /// 结束
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFinish_Click(object sender, EventArgs e)
        {
            PlcVar.Tube[frmID.Unit].gbHMI_Recipe_Finish = !PlcVar.Tube[frmID.Unit].gbHMI_Recipe_Finish;
            help.SetbtnClickBackColor(btnFinish, Color.Yellow, PlcVar.Tube[frmID.Unit].gbHMI_Recipe_Finish);
        }
        /// <summary>
        /// 锁管
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTubeDisable_Click(object sender, EventArgs e)
        {
            btnTubeDisable.Appearance.Options.UseBackColor = true;
            PlcVar.Tube[frmID.Unit].gbHMI_Tube_Disable = !PlcVar.Tube[frmID.Unit].gbHMI_Tube_Disable;
            help.SetbtnClickBackColor(btnTubeDisable, Color.Red, PlcVar.Tube[frmID.Unit].gbHMI_Tube_Disable);
            if (PlcVar.Tube[frmID.Unit].gbHMI_Tube_Disable)
                btnTubeDisable.ForeColor = Color.Black;
            else
                btnTubeDisable.ForeColor = Color.Red;
        }
    }
}
