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
    public partial class UCSetBoatPush : UserControl
    {
        public UCSetBoatPush()
        {
            InitializeComponent();
        }
        View.Common.TubeHelpClass help = new View.Common.TubeHelpClass();
        List<Control> lstErrorControl = new List<Control>();
        private void txtValue_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            lstErrorControl.Clear();
            bool bOK = this.verificationComponent1.Verification();
            if (!bOK) return;
            if (txt.Text == "") txt.Text = "0";

            if (txt.Name == "txtAbs_Pos1")
                PlcVar.Tube[frmID.Unit].BoatPush_SV_Para.rAbs_Pos[1] = (float)Convert.ToDouble(txtAbs_Pos1.Text);
            else if (txt.Name == "txtAbs_Pos4")
                PlcVar.Tube[frmID.Unit].BoatPush_SV_Para.rAbs_Pos[4] = (float)Convert.ToDouble(txtAbs_Pos4.Text);
            else if (txt.Name == "txtAbs_Pos6")
                PlcVar.Tube[frmID.Unit].BoatPush_SV_Para.rAbs_Pos[6] = (float)Convert.ToDouble(txtAbs_Pos6.Text);
            else if (txt.Name == "txtAbs_Speed1")
                PlcVar.Tube[frmID.Unit].BoatPush_SV_Para.rAbs_Speed[1] = (float)Convert.ToDouble(txtAbs_Speed1.Text);
            else if (txt.Name == "txtAbs_Speed4")
                PlcVar.Tube[frmID.Unit].BoatPush_SV_Para.rAbs_Speed[4] = (float)Convert.ToDouble(txtAbs_Speed4.Text);
            else if (txt.Name == "txtAbs_Speed6")
                PlcVar.Tube[frmID.Unit].BoatPush_SV_Para.rAbs_Speed[6] = (float)Convert.ToDouble(txtAbs_Speed6.Text);
            else if (txt.Name == "txtAcc")
                PlcVar.Tube[frmID.Unit].BoatPush_SV_Para.rAcc = (float)Convert.ToDouble(txtAcc.Text);
            else if (txt.Name == "txtBoatPush_SV_MaxT")
                PlcVar.Tube[frmID.Unit].AxisParaEx.rBoatPush_SV_MaxT = (float)Convert.ToDouble(txtBoatPush_SV_MaxT.Text);
            else if (txt.Name == "txtMaxPos")
                PlcVar.Tube[frmID.Unit].BoatPush_SV_Para.rMaxPos = (float)Convert.ToDouble(txtMaxPos.Text);
            else if (txt.Name == "txtMinPos")
                PlcVar.Tube[frmID.Unit].BoatPush_SV_Para.rMinPos = (float)Convert.ToDouble(txtMinPos.Text);
            else if (txt.Name == "txtBoatOut_OffsetPos")
                PlcVar.Tube[frmID.Unit].AxisParaEx.rBoatOut_OffsetPos = (float)Convert.ToDouble(txtBoatOut_OffsetPos.Text);
            else if (txt.Name == "txtBoatOutAlmOffsetPos")
                PlcVar.Tube[frmID.Unit].AxisParaEx.rBoatOut_AlmOffsetPos = (float)Convert.ToDouble(txtBoatOutAlmOffsetPos.Text);
        }
        private void btnValue_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Name == "btnHome_Excute")
            {
                PlcVar.Tube[frmID.Unit].BoatPush_SV_Para.bHome_OK = true;
                help.SetbtnClickBackColor(btnHome_Excute, Color.Green, PlcVar.Tube[frmID.Unit].BoatPush_SV_Para.bHome_OK);
            }
            else if (btn.Name == "btnEnableT_Protect")
            {
                PlcVar.Tube[frmID.Unit].BoatPush_SV_Para.bEnableT_Protect = !PlcVar.Tube[frmID.Unit].BoatPush_SV_Para.bEnableT_Protect;
                help.SetbtnClickBackColor(btnEnableT_Protect, Color.LightCoral, PlcVar.Tube[frmID.Unit].BoatPush_SV_Para.bEnableT_Protect);
            }
        }

        private void verificationComponent1_Verificationed(HZH_Controls.Controls.VerificationEventArgs e)
        {
            if (!e.IsVerifySuccess)
            {
                lstErrorControl.Add(e.VerificationControl);
            }
        }
    }
}
