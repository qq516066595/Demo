using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using com.DataBaseModels;

namespace Test.View.Tube
{
    public partial class UCRecipeInfo : UserControl
    {
        public UCRecipeInfo()
        {
            InitializeComponent();

        }
        //View.Common.CommonClass comm = new Common.CommonClass();
        View.Common.TubeHelpClass help = new Common.TubeHelpClass();

        private void UCRecipeInfo_Load(object sender, EventArgs e)
        {
            List<KeyValuePair<string, string>> lstCom = new List<KeyValuePair<string, string>>();

            lstCom.Add(new KeyValuePair<string, string>("0", "--"));
            lstCom.Add(new KeyValuePair<string, string>("1", "无舟"));
            lstCom.Add(new KeyValuePair<string, string>("2", "空舟"));
            lstCom.Add(new KeyValuePair<string, string>("3", "未工艺舟"));
            lstCom.Add(new KeyValuePair<string, string>("4", "已工艺舟"));
            lstCom.Add(new KeyValuePair<string, string>("5", "异常舟"));
            lstCom.Add(new KeyValuePair<string, string>("6", "实验舟"));
            lstCom.Add(new KeyValuePair<string, string>("7", "空桨饱和"));
            lstCom.Add(new KeyValuePair<string, string>("8", "饱和完成"));
            lstCom.Add(new KeyValuePair<string, string>("9", "正在工艺"));
            lstCom.Add(new KeyValuePair<string, string>("10", "待清洗舟"));
            this.ucBoatState.Source = lstCom;
            this.ucBoatState.SelectedIndex = 0;
            lblRecipeInfoTitle.Text = "工艺设置-管";

        }
        private void ucSwitch_CheckedChanged(object sender, EventArgs e)
        {
            PlcVar.Tube[frmID.Unit].OP_Cmd.bAutoSelect = ucSwitch.Checked;
        }
        private void ucBoatState_SelectedChangedEvent(object sender, EventArgs e)
        {
            PlcVar.Tube[frmID.Unit].stTube_BoatInfo.eBoatState = (PlcModels.BoatState)ucBoatState.SelectedIndex;
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            PlcVar.Tube[frmID.Unit].gbHMI_Recipe_Start = !PlcVar.Tube[frmID.Unit].gbHMI_Recipe_Start;
            help.SetbtnClickBackColor(btnStart, Color.Lime, PlcVar.Tube[frmID.Unit].gbHMI_Recipe_Start);
        }
        private void btnHold_Click(object sender, EventArgs e)
        {
            PlcVar.Tube[frmID.Unit].gbHMI_Recipe_Hold = !PlcVar.Tube[frmID.Unit].gbHMI_Recipe_Hold;
            help.SetbtnClickBackColor(btnHold, Color.Yellow, PlcVar.Tube[frmID.Unit].gbHMI_Recipe_Hold);
        }

        private void btnJumpStep_Click(object sender, EventArgs e)
        {
            //打开弹窗时，还需把配方名称（下载时，备份记录的名称）传值过去
            //frmJumpStep frm = new frmJumpStep(frmID.Unit, models.stCurrentRecipeName);
            //frm.ShowDialog();
        }

        private void btnAbort_Click(object sender, EventArgs e)
        {
            PlcVar.Tube[frmID.Unit].gbHMI_Recipe_Abort = !PlcVar.Tube[frmID.Unit].gbHMI_Recipe_Abort;
            help.SetbtnClickBackColor(btnAbort, Color.Red, PlcVar.Tube[frmID.Unit].gbHMI_Recipe_Abort);
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            PlcVar.Tube[frmID.Unit].gbHMI_Recipe_Finish = !PlcVar.Tube[frmID.Unit].gbHMI_Recipe_Finish;
            help.SetbtnClickBackColor(btnFinish, Color.Yellow, PlcVar.Tube[frmID.Unit].gbHMI_Recipe_Finish);
        }

        private void btnTubeDisable_Click(object sender, EventArgs e)
        {
            PlcVar.Tube[frmID.Unit].gbHMI_Tube_Disable = !PlcVar.Tube[frmID.Unit].gbHMI_Tube_Disable;
            help.SetbtnClickBackColor(btnTubeDisable, Color.Red, PlcVar.Tube[frmID.Unit].gbHMI_Tube_Disable);
            if (PlcVar.Tube[frmID.Unit].gbHMI_Tube_Disable)
                btnTubeDisable.ForeColor = Color.Black;
            else
                btnTubeDisable.ForeColor = Color.Red;
        }
    }
}
