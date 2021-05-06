using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using com.DataBaseModels;
using Test.View.Common;

namespace Test.View.Tube
{
    public partial class UCSetTemp : UserControl
    {
        public UCSetTemp()
        {
            InitializeComponent();
        }
        TubeHelpClass help = new TubeHelpClass();
        List<Control> lstErrorControl = new List<Control>();
        private void UCSetTemp_Load(object sender, EventArgs e)
        {

        }
        private void txtValue_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            lstErrorControl.Clear();
            bool bOK = this.verificationComponent1.Verification();
            if (!bOK) return;
            if (txt.Text == "") txt.Text = "0";

            int num = Convert.ToInt16(System.Text.RegularExpressions.Regex.Replace(txt.Name, @"[^0-9]+", "0")) - 1;
            if (txt.Name == "txtIP")
                PlcVar.Tube[frmID.Unit].stSysPara.TempModule1_IP = txt.Text;
            else if (txt.Name.Contains("txtBreakPV"))
                PlcVar.Tube[frmID.Unit].stTempPara[num].nBreakPV = Convert.ToUInt16(txt.Text);
            else if (txt.Name.Contains("txtAlmPV"))
                PlcVar.Tube[frmID.Unit].stTempPara[num].nAlmPV = Convert.ToUInt16(txt.Text);
            else if (txt.Name.Contains("txtKp"))
                PlcVar.Tube[frmID.Unit].stTempPara[num].nKp = Convert.ToUInt16(txt.Text);
            else if (txt.Name.Contains("txtKi"))
                PlcVar.Tube[frmID.Unit].stTempPara[num].nKi = Convert.ToUInt16(txt.Text);
            else if (txt.Name.Contains("txtKd"))
                PlcVar.Tube[frmID.Unit].stTempPara[num].nKd = Convert.ToUInt16(txt.Text);
            else if (txt.Name.Contains("txtWarnDiff"))
                PlcVar.Tube[frmID.Unit].stTempPara[num].nWarnDiff = Convert.ToUInt16(txt.Text);
            else if (txt.Name.Contains("txtAlmDiff"))
                PlcVar.Tube[frmID.Unit].stTempPara[num].nAlmDiff = Convert.ToUInt16(txt.Text);
        }
        private void btnValue_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int num = Convert.ToInt16(System.Text.RegularExpressions.Regex.Replace(btn.Name, @"[^0-9]+", "0")) - 1;
            bool bval = false;
            if (btn.Name == "btnCutExAndIn")
            {
                if (PlcVar.Tube[frmID.Unit].gnMini8_Ctrl_Type == 0)
                {
                    PlcVar.Tube[frmID.Unit].gnMini8_Ctrl_Type = 1;
                    bval = true;
                    btn.Text = "外偶控温";
                }
                else
                {
                    PlcVar.Tube[frmID.Unit].gnMini8_Ctrl_Type = 0;
                    bval = false;
                    btn.Text = "内偶控温";
                }
                help.SetbtnClickBackColor((Button)btn, Color.LightCoral, bval);
            }
            else if (btn.Name.Contains("btnShield"))
            {
                PlcVar.Tube[frmID.Unit].stTempPara[num].bShield = !PlcVar.Tube[frmID.Unit].stTempPara[num].bShield;
                help.SetbtnClickBackColor((Button)btn, Color.LightCoral, PlcVar.Tube[frmID.Unit].stTempPara[num].bShield);
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
