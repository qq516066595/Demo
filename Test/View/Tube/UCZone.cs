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
    public partial class UCZone : UserControl
    {
        public UCZone()
        {
            InitializeComponent();
        }
        List<Control> lstErrorControl = new List<Control>();
        private void lblOnHeating_Click(object sender, EventArgs e)
        {
            new FrmHeating().ShowDialog(this);
        }

        private void UCZone_Load(object sender, EventArgs e)
        {

        }

        private void txtZoneSV_TextChanged(object sender, EventArgs e)
        {
            TextBox setZoneValue = (TextBox)sender;
            lstErrorControl.Clear();
            bool bOK = this.verificationComponent1.Verification();
            if (!bOK) return;
            if (setZoneValue.Text == "") setZoneValue.Text = "0";

            int num = Convert.ToInt16(System.Text.RegularExpressions.Regex.Replace(setZoneValue.Name, @"[^0-9]+", "")) - 1;
            PlcVar.Tube[frmID.Unit].stTempZone[num].rCurrent_SV = (float)Convert.ToDouble(setZoneValue.Text);
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
