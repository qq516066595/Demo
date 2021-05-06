using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using com.DataBaseModels;

namespace Test.View.Common
{
    public partial class UCSetMFCModule : UserControl
    {
        public UCSetMFCModule()
        {
            InitializeComponent();
        }
        List<Control> lstErrorControl = new List<Control>();
        public int MFC_ID { get; set; }
        TubeHelpClass help = new TubeHelpClass();

        private void txtValue_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            lstErrorControl.Clear();
            bool bOK = this.verificationComponent1.Verification();
            if (!bOK) return;
            if (txt.Text == "") txt.Text = "0";

            if (txt.Name == "txtWarnValue")
                PlcVar.Tube[frmID.Unit].stMFC_Para[MFC_ID].rWarnDiff_Persent = (float)Convert.ToDouble(txt.Text);
            else if (txt.Name == "txtAlmValue")
                PlcVar.Tube[frmID.Unit].stMFC_Para[MFC_ID].rAlmDiff_Persent = (float)Convert.ToDouble(txt.Text);
            else if (txt.Name == "txtMaxRange")
                PlcVar.Tube[frmID.Unit].stMFC_Para[MFC_ID].nMaxRange = (ushort)Convert.ToDouble(txt.Text);
        }

        private void btnSheild_Click(object sender, EventArgs e)
        {
            PlcVar.Tube[frmID.Unit].stMFC_Para[MFC_ID].bShield = !PlcVar.Tube[frmID.Unit].stMFC_Para[MFC_ID].bShield;
            help.SetbtnClickBackColor(btnSheild, Color.LightCoral, PlcVar.Tube[frmID.Unit].stMFC_Para[MFC_ID].bShield);
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
