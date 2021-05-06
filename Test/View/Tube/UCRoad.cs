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
    public partial class UCRoad : UserControl
    {
        public UCRoad()
        {
            InitializeComponent();
        }

        private void UCRoad_Load(object sender, EventArgs e)
        {

        }
        List<Control> lstErrorControl = new List<Control>();
        private void txtMFCSV_TextChanged(object sender, EventArgs e)
        {
            TextBox mfcSV = (TextBox)sender;
            lstErrorControl.Clear();
            bool bOK = this.verificationComponent1.Verification();
            if (!bOK) return;
            if (mfcSV.Text == "") mfcSV.Text = "0";

            int num = Convert.ToInt16(System.Text.RegularExpressions.Regex.Replace(mfcSV.Name, @"[^0-9]+", "")) - 1;
            PlcVar.Tube[frmID.Unit].stMFC_Value[num].SV = (ushort)Convert.ToDouble(mfcSV.Text);
        }
        private void ucValve_Click(object sender, EventArgs e)
        {
            HZH_Controls.Controls.UCValve valve = (HZH_Controls.Controls.UCValve)sender;
            int num = Convert.ToInt16(System.Text.RegularExpressions.Regex.Replace(valve.Name, @"[^0-9]+", "")) - 1;
            PlcVar.Tube[frmID.Unit].stValve_Ctrl[num].bHMI_Trigger = !PlcVar.Tube[frmID.Unit].stValve_Ctrl[num].bHMI_Trigger;
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
