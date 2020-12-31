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

namespace Demo.UserControl.Tube
{
    public partial class ucRecipeInfo : DevExpress.XtraEditors.XtraUserControl
    {
        public ucRecipeInfo()
        {
            InitializeComponent();
        }
        public void ucRecipe(MyModus myModus)
        {
            modus = myModus;
            tsAutoSelect.IsOn = modus.OP_Mode == 1 ? false : modus.OP_Mode == 3 ? true : false;
            lblRecipeName.Text = modus.sCurrentRecipeName;
            lblRecipeTotalTime.Text = FormatHelpClass.timeFormatIntToString(modus.gnProcessWorkingTime);
            lblRecipeWorkTime.Text = FormatHelpClass.timeFormatIntToString(modus.gnProcessWorkingTime);
            lblRecipeRemainTime.Text = FormatHelpClass.timeFormatIntToString(modus.gnProcessRemainTime);
            lblStepID.Text = modus.giRecipe_ID.ToString();
            lblStepName.Text = FormatHelpClass.KSrecipeNameFormatIntToString(modus.stcurrentRecipeCtrl.eName);
            lblStepTotalTime.Text = FormatHelpClass.timeFormatIntToString(modus.stcurrentRecipeCtrl.nDuration);
            lblStepWorkTime.Text = FormatHelpClass.timeFormatIntToString(modus.stcurrentRecipeCtrl.nWorking_Time);
            lblStepRemainTime.Text = FormatHelpClass.timeFormatIntToString(modus.stcurrentRecipeCtrl.nRemain_Time);

            cmbBoatState.SelectedIndexChanged += CmbBoatState_SelectedIndexChanged;
            btnStart.Click += BtnStart_Click;
        }

        

        MyModus modus = new MyModus();

        /// <summary>
        /// 舟状态改变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CmbBoatState_SelectedIndexChanged(object sender, EventArgs e)
        {
            modus.stTube_BoatInfos.eBoatState = cmbBoatState.SelectedIndex;
        }
        /// <summary>
        /// 开始
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnStart_Click(object sender, EventArgs e)
        {
            
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
                modus.OP_Mode = 3;
            }
            else//手动
            {
                modus.OP_Mode = 1;
            }
        }

        private void ucRecipeInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
