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
    public partial class UCSetVacuum : UserControl
    {
        public UCSetVacuum()
        {
            InitializeComponent();
        }
        List<Control> lstErrorControl = new List<Control>();
        private void txtValue_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TextBox txt = (TextBox)sender;
                lstErrorControl.Clear();
                bool bOK = this.verificationComponent1.Verification();
                if (!bOK) return;
                if (txt.Text == "") txt.Text = "0";

                if (txt.Name == "txtPump_IP")
                    PlcVar.Tube[frmID.Unit].stSysPara.Pump_IP = txtPump_IP.Text;
                else if (txt.Name == "txtWarnDiff_Persent")
                    PlcVar.Tube[frmID.Unit].stPump_Para.rWarnDiff_Persent = (float)Convert.ToDouble(txtWarnDiff_Persent.Text);
                else if (txt.Name == "txtAlmDiff_Persent")
                    PlcVar.Tube[frmID.Unit].stPump_Para.rAlmDiff_Persent = (float)Convert.ToDouble(txtAlmDiff_Persent.Text);
                else if (txt.Name == "txtCheckValue")
                    PlcVar.Tube[frmID.Unit].stPump_Para.rCheckValue = (float)Convert.ToDouble(txtCheckValue.Text);
                else if (txt.Name == "txtCheckTime")
                    PlcVar.Tube[frmID.Unit].stPump_Para.nCheckTime = Convert.ToUInt16(txtCheckTime.Text);
                else if (txt.Name == "txtAlmTail_Temp")
                    PlcVar.Tube[frmID.Unit].stSysPara.rAlmTail_Temp = Convert.ToUInt16(txtAlmTail_Temp.Text);
                else if (txt.Name == "txtNormal_Pressure")
                    PlcVar.Tube[frmID.Unit].stSysPara.rNormal_Pressure = (float)Convert.ToDouble(txtNormal_Pressure.Text);
                else if (txt.Name == "txtSetSpeed")
                    PlcVar.Tube[frmID.Unit].stPump_Ctrl.rSetSpeed = (float)Convert.ToDouble(txtSetSpeed.Text);
                else if (txt.Name == "txtAI_Para_FilterN")
                    txtAI_Para_FilterN.Text = PlcVar.Tube[frmID.Unit].stAI_Para.FilterN.ToString();
                else if (txt.Name == "txtAI_Para_rMinAct")
                    txtAI_Para_rMinAct.Text = PlcVar.Tube[frmID.Unit].stAI_Para.rMinAct.ToString();
                else if (txt.Name == "txtAI_Para_rMinOriginal")
                    txtAI_Para_rMinOriginal.Text = PlcVar.Tube[frmID.Unit].stAI_Para.rMinOriginal.ToString();
                else if (txt.Name == "txtAI_Para_rMaxAct")
                    txtAI_Para_rMaxAct.Text = PlcVar.Tube[frmID.Unit].stAI_Para.rMaxAct.ToString();
                else if (txt.Name == "txtAI_Para_rMaxOriginal")
                    txtAI_Para_rMaxOriginal.Text = PlcVar.Tube[frmID.Unit].stAI_Para.rMaxOriginal.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("真空系统数值输入异常：" + ex.Message.ToString());
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
