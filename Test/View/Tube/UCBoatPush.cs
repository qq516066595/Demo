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
    public partial class UCBoatPush : UserControl
    {
        public UCBoatPush()
        {
            InitializeComponent();
        }
        TubeHelpClass help = new TubeHelpClass();
        private void UCBoatPush_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 信号灯变化
        /// </summary>
        /// <param name="bsignal"></param>
        /// <param name="label"></param>
        public void LampStatesChange(bool bsignal, Label label)
        {
            if (bsignal)
                label.BackColor = Color.Lime;
            else
                label.BackColor = Color.White;
        }
        private void btnValue_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Name == "btnHMI_PowerOff")
            {
                PlcVar.Tube[frmID.Unit].BoatPush_SV_Ctrl.bPowerOff = !PlcVar.Tube[frmID.Unit].BoatPush_SV_Ctrl.bPowerOff;
                help.SetbtnClickBackColor(btn, Color.LightBlue, PlcVar.Tube[frmID.Unit].BoatPush_SV_Ctrl.bPowerOff);
            }
            else if (btn.Name == "btnBoatPush_Unlock")
            {
                PlcVar.Tube[frmID.Unit].gbBoatPush_Unlock = !PlcVar.Tube[frmID.Unit].gbBoatPush_Unlock;
                help.SetbtnClickBackColor(btn, Color.LightBlue, PlcVar.Tube[frmID.Unit].gbBoatPush_Unlock);
            }
            else if (btn.Name == "btnAxisTakeBoatPos")
            {
                PlcVar.Tube[frmID.Unit].BoatPush_SV_Ctrl.bAbs_Execute[6] = true;
                help.SetbtnClickBackColor(btn, Color.Blue, PlcVar.Tube[frmID.Unit].BoatPush_SV_Ctrl.bAbs_Execute[6] && PlcVar.Tube[frmID.Unit].OP_Mode == (PlcModels.OP_MODE)1);
            }
            else if (btn.Name == "btnAxisLayBoatPos")
            {
                PlcVar.Tube[frmID.Unit].BoatPush_SV_Ctrl.bAbs_Execute[4] = true;
                help.SetbtnClickBackColor(btn, Color.Blue, PlcVar.Tube[frmID.Unit].BoatPush_SV_Ctrl.bAbs_Execute[4] && PlcVar.Tube[frmID.Unit].OP_Mode == (PlcModels.OP_MODE)1);
            }
            else if (btn.Name == "btnAxisProcessPos")
            {
                PlcVar.Tube[frmID.Unit].BoatPush_SV_Ctrl.bAbs_Execute[1] = true;
                help.SetbtnClickBackColor(btn, Color.Blue, PlcVar.Tube[frmID.Unit].BoatPush_SV_Ctrl.bAbs_Execute[1] && PlcVar.Tube[frmID.Unit].OP_Mode == (PlcModels.OP_MODE)1);
            }
            else if (btn.Name == "btnAxisHMI_BoatIn")
            {
                PlcVar.Tube[frmID.Unit].gbHMI_BoatIn = true;
                help.SetbtnClickBackColor(btn, Color.Blue, PlcVar.Tube[frmID.Unit].gbHMI_BoatIn);
            }
            else if (btn.Name == "btnAxisHMI_BoatOut")
            {
                PlcVar.Tube[frmID.Unit].gbHMI_BoatOut = true;
                help.SetbtnClickBackColor(btn, Color.Blue, PlcVar.Tube[frmID.Unit].gbHMI_BoatOut);
            }
            else if (btn.Name == "btnHMI_OpenDoor")
            {
                PlcVar.Tube[frmID.Unit].gbHMI_OpenDoor = true;
                help.SetbtnClickBackColor(btn, Color.Lime, PlcVar.Tube[frmID.Unit].gbHMI_OpenDoor);
            }
            else if (btn.Name == "btnHMI_ColseDoor")
            {
                PlcVar.Tube[frmID.Unit].gbHMI_CloseDoor = true;
                help.SetbtnClickBackColor(btn, Color.Lime, PlcVar.Tube[frmID.Unit].gbHMI_CloseDoor);
            }
            else if (btn.Name == "btnPushpullDoorHMI_Out")
            {
                PlcVar.Tube[frmID.Unit].PushpullDoor_YV_Ctrl.bHMI_Out = true;
                help.SetbtnClickBackColor(btn, Color.Lime, PlcVar.Tube[frmID.Unit].PushpullDoor_YV_Ctrl.bHMI_Out);
            }
            else if (btn.Name == "btnPushpullDoorHMI_Back")
            {
                PlcVar.Tube[frmID.Unit].PushpullDoor_YV_Ctrl.bHMI_Back = true;
                help.SetbtnClickBackColor(btn, Color.Lime, PlcVar.Tube[frmID.Unit].PushpullDoor_YV_Ctrl.bHMI_Back);
            }
            else if (btn.Name == "btnColseDoorHMI_Out")
            {
                PlcVar.Tube[frmID.Unit].CloseDoor_YV_Ctrl.bHMI_Out = true;
                help.SetbtnClickBackColor(btn, Color.Lime, PlcVar.Tube[frmID.Unit].CloseDoor_YV_Ctrl.bHMI_Out);
            }
            else if (btn.Name == "btnColseDoorHMI_Back")
            {
                PlcVar.Tube[frmID.Unit].CloseDoor_YV_Ctrl.bHMI_Back = true;
                help.SetbtnClickBackColor(btn, Color.Lime, PlcVar.Tube[frmID.Unit].CloseDoor_YV_Ctrl.bHMI_Back);
            }
            else if (btn.Name == "btnHMI_LeakCheck")
            {
                PlcVar.Tube[frmID.Unit].gbHMI_LeakCheck = !PlcVar.Tube[frmID.Unit].gbHMI_LeakCheck;
                help.SetbtnClickBackColor(btnHMI_LeakCheck, Color.Lime, PlcVar.Tube[frmID.Unit].gbHMI_LeakCheck);
            }
            else if (btn.Name == "btnHMI_LeakCheck")
            {
                PlcVar.Tube[frmID.Unit].gbHMI_LeakCheck = !PlcVar.Tube[frmID.Unit].gbHMI_LeakCheck;
                help.SetbtnClickBackColor(btn, Color.Lime, PlcVar.Tube[frmID.Unit].gbHMI_LeakCheck);
            }
            else if (btn.Name == "btnStartOrStopPump")
            {
                PlcVar.Tube[frmID.Unit].stPump_Ctrl.bStartPump = !PlcVar.Tube[frmID.Unit].stPump_Ctrl.bStartPump;
                help.SetbtnClickBackColor(btn, Color.Lime, PlcVar.Tube[frmID.Unit].stPump_Ctrl.bStartPump);
            }
            else if (btn.Name == "btnSourceBottle_LeakCheck")
            {
                PlcVar.Tube[frmID.Unit].gbSourceBottle_LeakCheck = !PlcVar.Tube[frmID.Unit].gbSourceBottle_LeakCheck;
                help.SetbtnClickBackColor(btn, Color.Lime, PlcVar.Tube[frmID.Unit].gbSourceBottle_LeakCheck);
            }
        }


        private void btnJog_F_MouseDown(object sender, MouseEventArgs e)
        {
            PlcVar.Tube[frmID.Unit].BoatPush_SV_Ctrl.bJogF = true;
        }

        private void btnJog_F_MouseUp(object sender, MouseEventArgs e)
        {
            PlcVar.Tube[frmID.Unit].BoatPush_SV_Ctrl.bJogF = false;
        }

        private void btnJog_B_MouseDown(object sender, MouseEventArgs e)
        {
            PlcVar.Tube[frmID.Unit].BoatPush_SV_Ctrl.bJogB = true;
        }

        private void btnJog_B_MouseUp(object sender, MouseEventArgs e)
        {
            PlcVar.Tube[frmID.Unit].BoatPush_SV_Ctrl.bJogB = false;
        }

        private void txtHMI_JogSpeed_TextChanged(object sender, EventArgs e)
        {
            PlcVar.Tube[frmID.Unit].BoatPush_SV_Para.rJogSpeed = (float)Convert.ToDouble(txtHMI_JogSpeed.Text);
        }

        List<Control> lstErrorControl = new List<Control>();
        private void txtValue_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            lstErrorControl.Clear();
            bool bOK = this.verificationComponent1.Verification();
            if (!bOK) return;
            if (txt.Text == "") txt.Text = "0";

            if (txt.Name == "txtHWCs_SV")
                PlcVar.Jht.stHWCs_Ctrl.rSetTemperature = (float)Convert.ToDouble(txtHWCs_SV.Text);
            else if (txt.Name == "txtActSpeed")
                PlcVar.Tube[frmID.Unit].stPump_Ctrl.rActSpeed = (float)Convert.ToDouble(txtActSpeed.Text);
            else if (txt.Name == "txtActLeakRate")
                PlcVar.Tube[frmID.Unit].grActLeakRate = (float)Convert.ToDouble(txtActLeakRate.Text);
            else if (txt.Name == "txtSource_Counter")
                PlcVar.Tube[frmID.Unit].giSource_Counter = Convert.ToInt16(txtSource_Counter.Text);
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
