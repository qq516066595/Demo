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

/*
* namespace：Demo.Forms.Tube
* className：ColorHelpClass
* 
* Version：HMI_RPxx_V001_202012
* Author：hehf
* Date：2021/1/8 11:39:22
* Desc：炉管水平轴功能编写。
* 
* Remarks：待完善：操作权限、到达信号量按钮变绿、按钮操作条件是否满足
*/
namespace Demo.UserControl.Tube
{
    public partial class ucAxisX : DevExpress.XtraEditors.XtraUserControl
    {
        TubeHelpClass colorHelp = new TubeHelpClass();
        //TubeModelClass models = new TubeModelClass();
        public ucAxisX()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 数据显示到界面
        /// </summary>
        private void ucAxisX_Load(object sender, EventArgs e)
        {
            lblAxisActPos.Text = PlcVar.Tube[frmID.Unit].BoatPush_SV_Ctrl.rActPos.ToString();//models.BoatPush_SV_Ctrl.rActPos.ToString();
            lblAxisActSpeed.Text = PlcVar.Tube[frmID.Unit].BoatPush_SV_Ctrl.rActSpeed.ToString(); //models.BoatPush_SV_Ctrl.rActSpeed.ToString();
            lblAxisRulerPos.Text = PlcVar.Tube[frmID.Unit].grHand_X_RulerPos.ToString(); //models.grHand_X_RulerPos.ToString();
            lblAxisActTorque.Text = PlcVar.Tube[frmID.Unit].BoatPush_SV_Ctrl.rAct_Torque.ToString(); //models.BoatPush_SV_Ctrl.rAct_Torque.ToString();
            //信号灯:false为白色，true为绿色
            LampStatesChange(PlcVar.Tube[frmID.Unit].BoatPush_SV_Ctrl.O_SW, lblAxisHome_SW);//models.BoatPush_SV_Ctrl.O_SW
            LampStatesChange(PlcVar.Tube[frmID.Unit].BoatPush_SV_Ctrl.N_SW, lblAxisN_OT);   //models.BoatPush_SV_Ctrl.N_SW
            LampStatesChange(PlcVar.Tube[frmID.Unit].BoatPush_SV_Ctrl.P_SW, lblAxisP_OT);   //models.BoatPush_SV_Ctrl.P_SW
            //点动速度
            txtHMI_JogSpeed.Text = PlcVar.Tube[frmID.Unit].BoatPush_SV_Para.rJogSpeed.ToString();//models.BoatPush_SV_Para.rJogSpeed.ToString();

            //条件满足时，启用鼠标按下事件
            if (PlcVar.Tube[frmID.Unit].OP_Mode == (PlcModels.OP_MODE)1 && PlcVar.Tube[frmID.Unit].BoatPush_SV_Ctrl.bJogF_Condition == true)
            {
                btnJog_F.Enabled = true;
                btnJog_F.MouseDown += btnJog_F_MouseDown;
                btnJog_F.MouseUp += btnJog_F_MouseUp;
            }
            else
            {
                btnJog_F.Enabled = false;
            }
            if (PlcVar.Tube[frmID.Unit].OP_Mode == (PlcModels.OP_MODE)1 && PlcVar.Tube[frmID.Unit].BoatPush_SV_Ctrl.bJogB_Condition == true)
            {
                btnJog_B.Enabled = true;
                btnJog_B.MouseDown += btnJog_B_MouseDown;
                btnJog_B.MouseUp += btnJog_B_MouseUp;
            }
            else
            {
                btnJog_B.Enabled = false;
            }
        }
    
        /// <summary>
        /// 信号灯变化
        /// </summary>
        /// <param name="bsignal"></param>
        /// <param name="label"></param>
        public void LampStatesChange(bool bsignal, LabelControl label)
        {
            if (bsignal)
                label.BackColor = Color.Lime;
            else
                label.BackColor = Color.White;
        }

        /// <summary>
        /// 使能
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHMI_PowerOff_Click(object sender, EventArgs e)
        {
            PlcVar.Tube[frmID.Unit].BoatPush_SV_Ctrl.bPowerOff = !PlcVar.Tube[frmID.Unit].BoatPush_SV_Ctrl.bPowerOff;
            colorHelp.SetbtnClickBackColor(btnHMI_PowerOff, Color.Lime, PlcVar.Tube[frmID.Unit].BoatPush_SV_Ctrl.bPowerOff);
        }
        /// <summary>
        /// 接触联锁
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBoatPush_Unlock_Click(object sender, EventArgs e)
        {
            PlcVar.Tube[frmID.Unit].gbBoatPush_Unlock = !PlcVar.Tube[frmID.Unit].gbBoatPush_Unlock;
            colorHelp.SetbtnClickBackColor(btnBoatPush_Unlock, Color.Lime, PlcVar.Tube[frmID.Unit].gbBoatPush_Unlock);
        }
        /// <summary>
        /// 前进
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnJog_F_MouseDown(object sender, MouseEventArgs e)
        {
            PlcVar.Tube[frmID.Unit].BoatPush_SV_Ctrl.bJogF = true;
        }
        private void btnJog_F_MouseUp(object sender, MouseEventArgs e)
        {
            PlcVar.Tube[frmID.Unit].BoatPush_SV_Ctrl.bJogF = false;
        }
        /// <summary>
        /// 后退
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnJog_B_MouseDown(object sender, MouseEventArgs e)
        {
            PlcVar.Tube[frmID.Unit].BoatPush_SV_Ctrl.bJogB = true;
        }
        private void btnJog_B_MouseUp(object sender, MouseEventArgs e)
        {
            PlcVar.Tube[frmID.Unit].BoatPush_SV_Ctrl.bJogB = false;
        }
        /// <summary>
        /// 取舟位
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAxisTakeBoatPos_Click(object sender, EventArgs e)
        {
            PlcVar.Tube[frmID.Unit].BoatPush_SV_Ctrl.bAbs_Execute[6] = true;
        }
        /// <summary>
        /// 放舟位
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAxisLayBoatPos_Click(object sender, EventArgs e)
        {
            PlcVar.Tube[frmID.Unit].BoatPush_SV_Ctrl.bAbs_Execute[4] = true;
        }
        /// <summary>
        /// 工艺位
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAxisProcessPos_Click(object sender, EventArgs e)
        {
            PlcVar.Tube[frmID.Unit].BoatPush_SV_Ctrl.bAbs_Execute[1] = true;
        }
        /// <summary>
        /// 手动进舟联动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAxisHMI_BoatIn_Click(object sender, EventArgs e)
        {
            PlcVar.Tube[frmID.Unit].gbHMI_BoatIn = true;
        }
        /// <summary>
        /// 手动出舟联动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAxisHMI_BoatOut_Click(object sender, EventArgs e)
        {
            PlcVar.Tube[frmID.Unit].gbHMI_BoatOut = true;
        }
        /// <summary>
        /// 炉门打开联动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHMI_OpenDoor_Click(object sender, EventArgs e)
        {
            PlcVar.Tube[frmID.Unit].gbHMI_OpenDoor = true;
        }
        /// <summary>
        /// 炉门关闭联动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHMI_ColseDoor_Click(object sender, EventArgs e)
        {
            PlcVar.Tube[frmID.Unit].gbHMI_CloseDoor = true;
        }
        /// <summary>
        /// 关门:伸出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPushpullDoorHMI_Out_Click(object sender, EventArgs e)
        {
            PlcVar.Tube[frmID.Unit].PushpullDoor_YV_Ctrl.bHMI_Out = true;
        }
        /// <summary>
        /// 开门:缩回
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPushpullDoorHMI_Back_Click(object sender, EventArgs e)
        {
            PlcVar.Tube[frmID.Unit].PushpullDoor_YV_Ctrl.bHMI_Back = true;
        }
        /// <summary>
        /// 开门:伸出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnColseDoorHMI_Out_Click(object sender, EventArgs e)
        {
            PlcVar.Tube[frmID.Unit].CloseDoor_YV_Ctrl.bHMI_Out = true;
        }
        /// <summary>
        /// 关门:缩回
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnColseDoorHMI_Back_Click(object sender, EventArgs e)
        {
            PlcVar.Tube[frmID.Unit].CloseDoor_YV_Ctrl.bHMI_Back = true;
        }
        /// <summary>
        /// 点动速度
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtHMI_JogSpeed_TextChanged(object sender, EventArgs e)
        {
            PlcVar.Tube[frmID.Unit].BoatPush_SV_Para.rJogSpeed = (float)Convert.ToDouble(txtHMI_JogSpeed.Text);
        }
    }
}
