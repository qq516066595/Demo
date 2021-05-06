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
    public partial class UCInit : UserControl
    {
        public UCInit()
        {
            InitializeComponent();
        }

        private void btnValue_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Name == "btnProcessInit")
                PlcVar.Tube[frmID.Unit].gbProcess_InitStart = !PlcVar.Tube[frmID.Unit].gbProcess_InitStart;
            else if (btn.Name == "btnHeatingInit")
                PlcVar.Tube[frmID.Unit].gbHeating_InitStart = !PlcVar.Tube[frmID.Unit].gbHeating_InitStart;
            else if (btn.Name == "btnGasInit")
                PlcVar.Tube[frmID.Unit].gbGas_InitStart = !PlcVar.Tube[frmID.Unit].gbGas_InitStart;
            else if (btn.Name == "btnBoatPushInit")
                PlcVar.Tube[frmID.Unit].gbBoatPush_InitStart = !PlcVar.Tube[frmID.Unit].gbBoatPush_InitStart;
            else if (btn.Name == "btnVacuumInit")
                PlcVar.Tube[frmID.Unit].gbVacuum_InitStart = !PlcVar.Tube[frmID.Unit].gbVacuum_InitStart;
        }
    }
}
