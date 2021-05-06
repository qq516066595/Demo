using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using com.DataBaseModels;
using HZH_Controls;
using HZH_Controls.Controls;
using HZH_Controls.Forms;
/**********************************************
 --问题描述：
 --1、菜单切换
 --   ①配方、图表需隐藏机械手；
 --   ②点击机械手不应该跳到主页；
**********************************************/
namespace Test
{
    public partial class FrmMain : FrmWithTitle
    {
        public static View.Common.CommonClass comm = null;
        public FrmMain()
        {
            InitializeComponent();
            if (comm == null)
            {
                comm = new View.Common.CommonClass();
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            try
            {
                frmID.Unit = 1;
                TreeConentLoad();
                AddControl(new View.Tube.UCMain());
            }
            finally
            {
                ControlHelper.FreezeControl(this, false);
            }

            PlcVar.Tube[1].gnProcessWorkingTime = 1;
            PlcVar.Tube[2].gnProcessWorkingTime = 2;
            PlcVar.Tube[3].gnProcessWorkingTime = 3;
            PlcVar.Tube[4].gnProcessWorkingTime = 4;
            PlcVar.Tube[5].gnProcessWorkingTime = 5;
            PlcVar.Tube[1].gnProcessTotalTime = 111;
            PlcVar.Tube[2].gnProcessTotalTime = 222;
            PlcVar.Tube[3].gnProcessTotalTime = 333;
            PlcVar.Tube[4].gnProcessTotalTime = 444;
            PlcVar.Tube[5].gnProcessTotalTime = 555;
        }

        /// <summary>
        /// 功能菜单加载
        /// </summary>
        public void TreeConentLoad()
        {
            this.tvMenu.Nodes.Clear();
            ControlHelper.FreezeControl(this, true);
            this.tvMenu.Nodes.Add(" 用户");
            this.tvMenu.Nodes.Add(" 首页");
            this.tvMenu.Nodes.Add(" 主页");
            if (frmID.Unit != 0)
            {
                this.tvMenu.Nodes.Add(" 配方");
                this.tvMenu.Nodes.Add(" I/O");
                TreeNode tnData = new TreeNode(" 数据");
                tnData.Nodes.Add("图表");
                tnData.Nodes.Add("报表");
                this.tvMenu.Nodes.Add(tnData);
            }
            else
            {
                TreeNode tnIO = new TreeNode("I/O");
                tnIO.Nodes.Add("I/O");
                tnIO.Nodes.Add("通讯");
                this.tvMenu.Nodes.Add(tnIO);
            }
            TreeNode tnControl = new TreeNode(" 配置");
            if (frmID.Unit == 0)
            {
                tnControl.Nodes.Add("初始化");
                tnControl.Nodes.Add("轴控");
                tnControl.Nodes.Add("工位");
            }
            else
            {
                tnControl.Nodes.Add("初始化");
                tnControl.Nodes.Add("气路");
                tnControl.Nodes.Add("温控");
                tnControl.Nodes.Add("真空");
                tnControl.Nodes.Add("轴控");
                tnControl.Nodes.Add("限幅");
            }
            this.tvMenu.Nodes.Add(tnControl);
            if (frmID.Unit == 0)
                this.tvMenu.Nodes.Add(" 舟管理");
            TreeNode tnJournal = new TreeNode(" 日志");
            tnJournal.Nodes.Add("事件");
            tnJournal.Nodes.Add("报警");
            this.tvMenu.Nodes.Add(tnJournal);
            this.tvMenu.Nodes.Add(" 关于");

            for (int i = 0; i < tvMenu.Nodes.Count; i++)
            {
                if (tvMenu.Nodes[i].Text.Trim() == "主页")
                    tvMenu.SelectedNode = tvMenu.Nodes[i];
            }
        }

        #region 实例化窗体
        View.Tube.UCMain ucMain = null;
        View.Common.UCUserInfo ucUserInfo = null;
        View.Tube.UCRecipe ucRecipe = null;
        View.Tube.UCIO ucIO = null;
        View.Tube.UCChart ucChart = null;
        View.Tube.UCReport ucReport = null;
        View.Tube.UCInit ucInit = null;
        View.Tube.UCSetMFC ucSetMFC = null;
        View.Tube.UCSetTemp ucSetTemp = null;
        View.Tube.UCSetVacuum ucSetVacuum = null;
        View.Tube.UCSetBoatPush ucSetBoatPush = null;
        View.Common.UCJournal ucJournal = null;
        View.Common.UCAbout ucAbout = null;
        View.Loader.UCMain ucMainLoader = null;
        View.Loader.UCIO ucIOLoader = null;
        View.Loader.UCCommIO ucCommIOLoader = null;
        View.Loader.UCSetInit ucSetInit = null;
        View.Loader.UCSetAxisPara ucSetAxisPara = null;
        View.Loader.UCSetStation ucSetStation = null;
        View.Loader.UCBoatManager ucBoatManager = null;
        #endregion

        /// <summary>
        /// 功能菜单选择弹出内容
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tvMenu_AfterSelect(object sender, TreeViewEventArgs e)
        {
            panControl.Controls.Clear();
            string strName = e.Node.Text.Trim();
            this.Title = "磷扩散控制系统--" + strName;
            if (frmID.Unit == 1 || frmID.Unit == 2 || frmID.Unit == 3 || frmID.Unit == 4 || frmID.Unit == 5)
            {
                switch (strName)
                {
                    case "首页":
                        pnlMenu.Visible = true;
                        AddControl(new View.Tube.UCRecipe());
                        break;
                    case "用户":
                        if (ucUserInfo == null)
                            ucUserInfo = new View.Common.UCUserInfo();
                        AddControl(ucUserInfo);
                        pnlMenu.Visible = false;
                        break;
                    case "主页":
                        pnlMenu.Visible = true;
                        if (ucMain == null)
                            ucMain = new View.Tube.UCMain();
                        AddControl(ucMain);
                        break;
                    case "配方":
                        pnlMenu.Visible = true;
                        if (ucRecipe == null)
                            ucRecipe = new View.Tube.UCRecipe();
                        AddControl(ucRecipe);
                        break;
                    case "I/O":
                        pnlMenu.Visible = true;
                        if (ucIO == null)
                            ucIO = new View.Tube.UCIO();
                        AddControl(ucIO);
                        break;
                    case "数据":
                    case "图表":
                        pnlMenu.Visible = true;
                        if (ucChart == null)
                            ucChart = new View.Tube.UCChart();
                        AddControl(ucChart);
                        break;
                    case "报表":
                        pnlMenu.Visible = true;
                        if (ucReport == null)
                            ucReport = new View.Tube.UCReport();
                        AddControl(ucReport);
                        break;
                    case "配置":
                    case "初始化":
                        pnlMenu.Visible = true;
                        if (ucInit == null)
                            ucInit = new View.Tube.UCInit();
                        AddControl(ucInit);
                        break;
                    case "气路":
                        pnlMenu.Visible = true;
                        if (ucSetMFC == null)
                            ucSetMFC = new View.Tube.UCSetMFC();
                        AddControl(ucSetMFC);
                        break;
                    case "温控":
                        pnlMenu.Visible = true;
                        if (ucSetTemp == null)
                            ucSetTemp = new View.Tube.UCSetTemp();
                        AddControl(ucSetTemp);
                        break;
                    case "真空":
                        pnlMenu.Visible = true;
                        if (ucSetVacuum == null)
                            ucSetVacuum = new View.Tube.UCSetVacuum();
                        AddControl(ucSetVacuum);
                        break;
                    case "轴控":
                        pnlMenu.Visible = true;
                        if (ucSetBoatPush == null)
                            ucSetBoatPush = new View.Tube.UCSetBoatPush();
                        AddControl(ucSetBoatPush);
                        break;
                    case "日志":
                    case "报警":
                    case "事件":
                        pnlMenu.Visible = true;
                        if (ucJournal == null)
                            ucJournal = new View.Common.UCJournal();
                        AddControl(ucJournal);
                        break;
                    case "关于":
                        pnlMenu.Visible = false;
                        if (ucAbout == null)
                            ucAbout = new View.Common.UCAbout();
                        AddControl(ucAbout);
                        break;
                    default:
                        MessageBox.Show("打开画面异常！");
                        break;
                }
            }
            else
            {
                switch (strName)
                {
                    case "首页":
                        AddControl(new View.Tube.UCRecipe());
                        pnlMenu.Visible = false;
                        break;
                    case "用户":
                        AddControl(new View.Common.UCUserInfo());
                        pnlMenu.Visible = false;
                        break;
                    case "主页":
                        pnlMenu.Visible = true;
                        if (ucMainLoader == null)
                            ucMainLoader = new View.Loader.UCMain();
                        AddControl(ucMainLoader);
                        break;
                    case "I/O":
                        pnlMenu.Visible = true;
                        if (ucIOLoader == null)
                            ucIOLoader = new View.Loader.UCIO();
                        AddControl(ucIOLoader);
                        break;
                    case "通讯":
                        pnlMenu.Visible = true;
                        if (ucCommIOLoader == null)
                            ucCommIOLoader = new View.Loader.UCCommIO();
                        AddControl(ucCommIOLoader);
                        break;
                    case "配置":
                    case "初始化":
                        pnlMenu.Visible = true;
                        if (ucSetInit == null)
                            ucSetInit = new View.Loader.UCSetInit();
                        AddControl(ucSetInit);
                        break;
                    case "轴控":
                        pnlMenu.Visible = true;
                        if (ucSetAxisPara == null)
                            ucSetAxisPara = new View.Loader.UCSetAxisPara();
                        AddControl(ucSetAxisPara);
                        break;
                    case "工位":
                        pnlMenu.Visible = true;
                        if (ucSetStation == null)
                            ucSetStation = new View.Loader.UCSetStation();
                        AddControl(ucSetStation);
                        break;
                    case "舟管理":
                        pnlMenu.Visible = false;
                        if (ucBoatManager == null)
                            ucBoatManager = new View.Loader.UCBoatManager();
                        AddControl(ucBoatManager);
                        break;
                    case "日志":
                    case "报警":
                    case "事件":
                        pnlMenu.Visible = true;
                        if (ucJournal == null)
                            ucJournal = new View.Common.UCJournal();
                        AddControl(ucJournal);
                        break;
                    case "关于":
                        pnlMenu.Visible = false;
                        if (ucAbout == null)
                            ucAbout = new View.Common.UCAbout();
                        AddControl(ucAbout);
                        break;
                    default:
                        MessageBox.Show("打开画面异常！");
                        break;
                }
            }
            DataBings();
        }

        /// <summary>
        /// 内容页添加，居中显示
        /// </summary>
        /// <param name="c"></param>
        private void AddControl(Control c)
        {
            c.Dock = DockStyle.Fill;
            this.panControl.Controls.Add(c);
        }

        /// <summary>
        /// 设备菜单切换
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        int LastNum = 1;
        private void Lable_Click(object sender, EventArgs e)
        {
            #region 字体设置
            Label lbl = (Label)sender;
            lbl.Font = new System.Drawing.Font("微软雅黑", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            lbl.Padding = new System.Windows.Forms.Padding(10, 10, 10, 0);
            foreach (Control c in this.pnlMenu.Controls)
            {
                if (c is Label && c != lbl && c != lblCurrentLocation)
                {
                    c.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                    c.Padding = new System.Windows.Forms.Padding(10, 15, 10, 0);
                }
            }
            lblCurrentLocation.Text = "当前位置：" + lbl.Text;
            #endregion
            int num = Convert.ToInt16(((Label)sender).Tag);
            #region 窗体打开判断

            if (LastNum == num || (LastNum != 0 && num != 0))
            {
                frmID.Unit = num;
            }
            else
            {
                frmID.Unit = num;
                TreeConentLoad();
                ControlHelper.FreezeControl(this, false);
            }
            LastNum = num;
            DataBings();
            #endregion
        }

        /// <summary>
        /// 内容刷新
        /// </summary>
        public void DataBings()
        {
            View.Common.TubeHelpClass help = new View.Common.TubeHelpClass();
            string strName = tvMenu.SelectedNode.Text.Trim();

            switch (strName)
            {
                case "用户":
                    break;
                case "首页":
                    break;
                case "主页":
                    var bodyMain = this.panControl.Controls.Find("UCMain", false);
                    //当bodyMain有元素时候
                    if (bodyMain.Any())
                        foreach (var item in bodyMain[0].Controls)
                        {
                            if (item is View.Tube.UCRecipeInfo)//工艺信息
                            {
                                var recipeInfo = item as View.Tube.UCRecipeInfo;
                                recipeInfo.ucSwitch.Checked = PlcVar.Tube[frmID.Unit].OP_Cmd.bAutoSelect;
                                recipeInfo.ucBoatState.SelectedIndex = Convert.ToInt32(PlcVar.Tube[frmID.Unit].stTube_BoatInfo.eBoatState);
                                help.SetbtnClickBackColor(recipeInfo.btnStart, Color.Lime, PlcVar.Tube[frmID.Unit].gbHMI_Recipe_Start);
                                help.SetbtnClickBackColor(recipeInfo.btnHold, Color.Yellow, PlcVar.Tube[frmID.Unit].gbHMI_Recipe_Hold);
                                help.SetbtnClickBackColor(recipeInfo.btnAbort, Color.Red, PlcVar.Tube[frmID.Unit].gbHMI_Recipe_Abort);
                                help.SetbtnClickBackColor(recipeInfo.btnFinish, Color.Yellow, PlcVar.Tube[frmID.Unit].gbHMI_Recipe_Finish);
                                help.SetbtnClickBackColor(recipeInfo.btnTubeDisable, Color.Red, PlcVar.Tube[frmID.Unit].gbHMI_Tube_Disable);
                                if (PlcVar.Tube[frmID.Unit].gbHMI_Tube_Disable)
                                    recipeInfo.btnTubeDisable.ForeColor = Color.Black;
                                else
                                    recipeInfo.btnTubeDisable.ForeColor = Color.Red;
                                //recipeInfo.lblRecipeName.Text = PlcVar.Tube[frmID.Unit].stCurrentRecipeName;
                                recipeInfo.lblRecipeTotalTime.Text = help.timeFormatUshortToString(PlcVar.Tube[frmID.Unit].gnProcessTotalTime);
                                recipeInfo.lblRecipeWorkTime.Text = help.timeFormatUshortToString(PlcVar.Tube[frmID.Unit].gnProcessWorkingTime);
                                recipeInfo.lblRecipeRemainTime.Text = help.timeFormatUshortToString(PlcVar.Tube[frmID.Unit].gnProcessRemainTime);
                                recipeInfo.lblStepId.Text = PlcVar.Tube[frmID.Unit].giRecipe_ID.ToString();
                                recipeInfo.lblStepName.Text = help.KSrecipeNameFormatIntToString(PlcVar.Tube[frmID.Unit].stCurrentRecipeCtrl.eName);
                                recipeInfo.lblStepTotalTime.Text = help.timeFormatFloatToString(PlcVar.Tube[frmID.Unit].stCurrentRecipeCtrl.nDuration);
                                recipeInfo.lblStepWorkTime.Text = help.timeFormatFloatToString(PlcVar.Tube[frmID.Unit].stCurrentRecipeCtrl.nWorking_Time);
                                recipeInfo.lblStepRemainTime.Text = help.timeFormatFloatToString(PlcVar.Tube[frmID.Unit].stCurrentRecipeCtrl.nRemain_Time);
                                float totaltime = PlcVar.Tube[frmID.Unit].stCurrentRecipeCtrl.nDuration;
                                float workingtime = PlcVar.Tube[frmID.Unit].stCurrentRecipeCtrl.nWorking_Time;
                                recipeInfo.ucRecipeBar.Value = workingtime / totaltime;
                                recipeInfo.ucRecipeBar.Text = (workingtime / totaltime).ToString() + "%";
                            }
                            if (item is View.Tube.UCBoatPush)//推舟
                            {
                                var axisInfo = item as View.Tube.UCBoatPush;
                                axisInfo.lblAxisActPos.Text = PlcVar.Tube[frmID.Unit].BoatPush_SV_Ctrl.rActPos.ToString();
                                axisInfo.lblAxisActSpeed.Text = PlcVar.Tube[frmID.Unit].BoatPush_SV_Ctrl.rActSpeed.ToString();
                                axisInfo.lblAxisRulerPos.Text = PlcVar.Tube[frmID.Unit].grHand_X_RulerPos.ToString();
                                axisInfo.lblAxisActTorque.Text = PlcVar.Tube[frmID.Unit].BoatPush_SV_Ctrl.rAct_Torque.ToString();
                                axisInfo.LampStatesChange(PlcVar.Tube[frmID.Unit].BoatPush_SV_Ctrl.O_SW, axisInfo.lblAxisHome_SW);
                                axisInfo.LampStatesChange(PlcVar.Tube[frmID.Unit].BoatPush_SV_Ctrl.N_SW, axisInfo.lblAxisN_OT);
                                axisInfo.LampStatesChange(PlcVar.Tube[frmID.Unit].BoatPush_SV_Ctrl.P_SW, axisInfo.lblAxisP_OT);
                                axisInfo.txtHMI_JogSpeed.Text = PlcVar.Tube[frmID.Unit].BoatPush_SV_Para.rJogSpeed.ToString();
                                help.SetbtnClickBackColor(axisInfo.btnHMI_PowerOff, Color.LightBlue, PlcVar.Tube[frmID.Unit].BoatPush_SV_Ctrl.bPowerOff);
                                help.SetbtnClickBackColor(axisInfo.btnBoatPush_Unlock, Color.LightBlue, PlcVar.Tube[frmID.Unit].gbBoatPush_Unlock);
                                help.SetbtnClickBackColor(axisInfo.btnAxisHMI_BoatIn, Color.Blue, PlcVar.Tube[frmID.Unit].gbHMI_BoatIn);
                                help.SetbtnClickBackColor(axisInfo.btnAxisHMI_BoatOut, Color.Blue, PlcVar.Tube[frmID.Unit].gbHMI_BoatOut);
                                help.SetbtnClickBackColor(axisInfo.btnAxisTakeBoatPos, Color.Blue, PlcVar.Tube[frmID.Unit].BoatPush_SV_Ctrl.bAbs_Execute[6] && PlcVar.Tube[frmID.Unit].OP_Mode == (PlcModels.OP_MODE)1);
                                help.SetbtnClickBackColor(axisInfo.btnAxisLayBoatPos, Color.Blue, PlcVar.Tube[frmID.Unit].BoatPush_SV_Ctrl.bAbs_Execute[4] && PlcVar.Tube[frmID.Unit].OP_Mode == (PlcModels.OP_MODE)1);
                                help.SetbtnClickBackColor(axisInfo.btnAxisProcessPos, Color.Blue, PlcVar.Tube[frmID.Unit].BoatPush_SV_Ctrl.bAbs_Execute[1] && PlcVar.Tube[frmID.Unit].OP_Mode == (PlcModels.OP_MODE)1);
                                help.SetbtnClickBackColor(axisInfo.btnHMI_OpenDoor, Color.Lime, PlcVar.Tube[frmID.Unit].gbHMI_OpenDoor);
                                help.SetbtnClickBackColor(axisInfo.btnHMI_ColseDoor, Color.Lime, PlcVar.Tube[frmID.Unit].gbHMI_CloseDoor);
                                help.SetbtnClickBackColor(axisInfo.btnPushpullDoorHMI_Out, Color.Lime, PlcVar.Tube[frmID.Unit].PushpullDoor_YV_Ctrl.bHMI_Out);
                                help.SetbtnClickBackColor(axisInfo.btnPushpullDoorHMI_Back, Color.Lime, PlcVar.Tube[frmID.Unit].PushpullDoor_YV_Ctrl.bHMI_Back);
                                help.SetbtnClickBackColor(axisInfo.btnColseDoorHMI_Out, Color.Lime, PlcVar.Tube[frmID.Unit].CloseDoor_YV_Ctrl.bHMI_Out);
                                help.SetbtnClickBackColor(axisInfo.btnColseDoorHMI_Back, Color.Lime, PlcVar.Tube[frmID.Unit].CloseDoor_YV_Ctrl.bHMI_Back);
                                //真空
                                axisInfo.lblHWCs_PV.Text = PlcVar.Jht.stHWCs_Ctrl.rActTemperature.ToString();
                                axisInfo.txtHWCs_SV.Text = PlcVar.Jht.stHWCs_Ctrl.rSetTemperature.ToString();
                                if (frmID.Unit == 0)
                                {
                                    axisInfo.lblHWCs_level.Text = PlcVar.Jht.stHWCs_Ctrl.nNetWeight_1.ToString();
                                    if (PlcVar.Jht.stHWCs_Ctrl.nWeightStatus_1 == 0)
                                        axisInfo.ucSLHWCs_Working.LampColor[0] = Color.LimeGreen;
                                    else if (PlcVar.Jht.stHWCs_Ctrl.nWeightStatus_1 == 1)
                                        axisInfo.ucSLHWCs_Working.LampColor[0] = Color.Red;
                                }
                                else if (frmID.Unit == 1)
                                {
                                    axisInfo.lblHWCs_level.Text = PlcVar.Jht.stHWCs_Ctrl.nNetWeight_2.ToString();
                                    if (PlcVar.Jht.stHWCs_Ctrl.nWeightStatus_2 == 0)
                                        axisInfo.ucSLHWCs_Working.LampColor[0] = Color.LimeGreen;
                                    else if (PlcVar.Jht.stHWCs_Ctrl.nWeightStatus_2 == 1)
                                        axisInfo.ucSLHWCs_Working.LampColor[0] = Color.Red;
                                }
                                else if (frmID.Unit == 2)
                                {
                                    axisInfo.lblHWCs_level.Text = PlcVar.Jht.stHWCs_Ctrl.nNetWeight_3.ToString();
                                    if (PlcVar.Jht.stHWCs_Ctrl.nWeightStatus_3 == 0)
                                        axisInfo.ucSLHWCs_Working.LampColor[0] = Color.LimeGreen;
                                    else if (PlcVar.Jht.stHWCs_Ctrl.nWeightStatus_3 == 1)
                                        axisInfo.ucSLHWCs_Working.LampColor[0] = Color.Red;
                                }
                                else if (frmID.Unit == 3)
                                {
                                    axisInfo.lblHWCs_level.Text = PlcVar.Jht.stHWCs_Ctrl.nNetWeight_4.ToString();
                                    if (PlcVar.Jht.stHWCs_Ctrl.nWeightStatus_4 == 0)
                                        axisInfo.ucSLHWCs_Working.LampColor[0] = Color.LimeGreen;
                                    else if (PlcVar.Jht.stHWCs_Ctrl.nWeightStatus_4 == 1)
                                        axisInfo.ucSLHWCs_Working.LampColor[0] = Color.Red;
                                }
                                else if (frmID.Unit == 4)
                                {
                                    axisInfo.lblHWCs_level.Text = PlcVar.Jht.stHWCs_Ctrl.nNetWeight_5.ToString();
                                    if (PlcVar.Jht.stHWCs_Ctrl.nWeightStatus_5 == 0)
                                        axisInfo.ucSLHWCs_Working.LampColor[0] = Color.LimeGreen;
                                    else if (PlcVar.Jht.stHWCs_Ctrl.nWeightStatus_5 == 1)
                                        axisInfo.ucSLHWCs_Working.LampColor[0] = Color.Red;
                                }
                                help.SetbtnClickBackColor(axisInfo.btnHMI_LeakCheck, Color.Lime, PlcVar.Tube[frmID.Unit].gbHMI_LeakCheck);
                                help.SetbtnClickBackColor(axisInfo.btnNOBOAT_LeakCheck, Color.Lime, PlcVar.Tube[frmID.Unit].gbNOBOAT_LeakCheck);
                                help.SetbtnClickBackColor(axisInfo.btnStartOrStopPump, Color.Lime, PlcVar.Tube[frmID.Unit].stPump_Ctrl.bStartPump);
                                help.SetbtnClickBackColor(axisInfo.btnSourceBottle_LeakCheck, Color.Lime, PlcVar.Tube[frmID.Unit].gbSourceBottle_LeakCheck);
                                axisInfo.txtActSpeed.Text = PlcVar.Tube[frmID.Unit].stPump_Ctrl.rActSpeed.ToString();
                                axisInfo.txtActLeakRate.Text = PlcVar.Tube[frmID.Unit].grActLeakRate.ToString();
                                axisInfo.lblButterflyOpen.Text = PlcVar.Tube[frmID.Unit].grButterFly_ActPos.ToString();
                                axisInfo.txtSource_Counter.Text = PlcVar.Tube[frmID.Unit].giSource_Counter.ToString();
                            }
                            if (item is View.Tube.UCZone)//温区
                            {
                                var zoneInfo = item as View.Tube.UCZone;
                                foreach (Control control in zoneInfo.Controls)
                                {
                                    int i = Convert.ToInt16(System.Text.RegularExpressions.Regex.Replace(control.Name, @"[^0-9]+", "0")) - 1;
                                    if (control is Label)
                                    {
                                        if (control.Name.Equals("lblZoneEx" + (i + 1).ToString(), StringComparison.CurrentCultureIgnoreCase))//外偶
                                            ((Label)control).Text = PlcVar.Tube[frmID.Unit].stTempZone[i].rExternal_Temp.ToString();
                                        else if (control.Name.Equals("lblZoneIn" + (i + 1).ToString(), StringComparison.CurrentCultureIgnoreCase))//内偶
                                            ((Label)control).Text = PlcVar.Tube[frmID.Unit].stTempZone[i].rInternal_Temp.ToString();
                                        else if (control.Name.Equals("lblZoneMV" + (i + 1).ToString(), StringComparison.CurrentCultureIgnoreCase))//功率
                                            ((Label)control).Text = PlcVar.Tube[frmID.Unit].stTempZone[i].rMV.ToString();
                                        //else if (control.Name.Equals("lblZoneSP" + i.ToString(), StringComparison.CurrentCultureIgnoreCase))//过渡
                                        //((LabelControl)control).Text = modus.grTemp_SPArray[i].ToString();

                                    }
                                    if (control is TextBox)
                                    {
                                        if (control.Name.Equals("txtZoneSV" + (i + 1).ToString(), StringComparison.CurrentCultureIgnoreCase))//设定值
                                            ((TextBox)control).Text = PlcVar.Tube[frmID.Unit].stTempZone[i].rCurrent_SV.ToString();
                                    }
                                    //水冷
                                    //lblWaterCooling1.Text = modus.grCooling_PV1.ToString();//水冷1
                                    //lblWaterCooling2.Text = modus.grCooling_PV2.ToString();//水冷2
                                }
                            }
                            if (item is View.Tube.UCRoad)
                            {
                                var roadInfo = item as View.Tube.UCRoad;
                                foreach (Control control in roadInfo.Controls)
                                {
                                    int i = Convert.ToInt16(System.Text.RegularExpressions.Regex.Replace(control.Name, @"[^0-9]+", "0")) - 1;
                                    if (control is PictureBox)
                                    {
                                        if (control.Name.Equals("picMFC" + (i + 1).ToString(), StringComparison.CurrentCultureIgnoreCase))
                                        {
                                            if (PlcVar.Tube[frmID.Unit].stMFC_Value[i].bAlarm)
                                                ((PictureBox)control).Image = global::Test.Properties.Resources.流量计红1;
                                            else
                                                ((PictureBox)control).Image = global::Test.Properties.Resources.流量计蓝1;
                                        }
                                    }
                                    if (control is TextBox)
                                    {
                                        if (control.Name.Equals("txtMFCSV" + (i + 1).ToString(), StringComparison.CurrentCultureIgnoreCase))
                                        {
                                            ((TextBox)control).Text = PlcVar.Tube[frmID.Unit].stMFC_Value[i].SV.ToString();
                                        }
                                    }
                                    if (control is Label)
                                    {
                                        if (control.Name.Equals("lblMFCPV" + (i + 1).ToString(), StringComparison.CurrentCultureIgnoreCase))
                                        {
                                            ((Label)control).Text = PlcVar.Tube[frmID.Unit].stMFC_Value[i].PV.ToString();
                                        }
                                    }
                                    if (control is UCValve)
                                    {
                                        if (control.Name.Equals("ucV" + (i + 1).ToString(), StringComparison.CurrentCultureIgnoreCase))
                                        {
                                            if (PlcVar.Tube[frmID.Unit].stValve_Ctrl[i].bDO_Open)
                                                ((UCValve)control).SwitchColor = System.Drawing.Color.LightGreen;
                                            else
                                                ((UCValve)control).SwitchColor = System.Drawing.Color.Black;
                                        }
                                    }
                                }
                            }
                        }
                    break;
                case "配方":

                    break;
                case "I/O":
                    var bodyIO = this.panControl.Controls.Find("UCIO", false);
                    if (bodyIO != null && bodyIO[0].Controls.Owner is View.Tube.UCIO)
                    {
                        var ioInfo = bodyIO[0].Controls.Owner as View.Tube.UCIO;
                        foreach (Control control in ioInfo.Controls)
                        {
                            if (control is View.Common.UCIOModule)
                            {
                                int i = Convert.ToInt16(System.Text.RegularExpressions.Regex.Replace(control.Name, @"[^0-9]+", "")) - 1;
                                foreach (Control ctl in control.Controls)
                                {
                                    if (ctl is Label)
                                    {
                                        ctl.Text = "";
                                    }
                                    if (ctl is UCSignalLamp)
                                    {
                                        //ctl.LampColor[0] = Color.Green;
                                    }
                                }
                            }
                        }
                    }
                    if (bodyIO != null && bodyIO[0].Controls.Owner is View.Loader.UCIO)
                    {

                    }
                    break;
                case "图表":
                    break;
                case "曲线":
                    break;
                case "配置":
                case "初始化":
                    if (frmID.Unit != 0)
                    {
                        var bobyInit = this.panControl.Controls.Find("UCInit", false);
                        if (bobyInit != null && bobyInit[0].Controls.Owner is View.Tube.UCInit)
                        {
                            var initInfo = bobyInit[0].Controls.Owner as View.Tube.UCInit;
                            help.SetbtnClickBackColor(initInfo.btnProcessInit, Color.Lime, PlcVar.Tube[frmID.Unit].gbProcess_InitDone);
                            help.SetbtnClickBackColor(initInfo.btnHeatingInit, Color.Lime, PlcVar.Tube[frmID.Unit].gbHeating_InitDone);
                            help.SetbtnClickBackColor(initInfo.btnGasInit, Color.Lime, PlcVar.Tube[frmID.Unit].gbGas_InitDone);
                            help.SetbtnClickBackColor(initInfo.btnBoatPushInit, Color.Lime, PlcVar.Tube[frmID.Unit].gbBoatPush_InitDone);
                            help.SetbtnClickBackColor(initInfo.btnVacuumInit, Color.Lime, PlcVar.Tube[frmID.Unit].gbVacuum_InitDone);
                        }
                    }
                    else
                    {
                        var bobySetInit = this.panControl.Controls.Find("UCSetInit", false);
                        if (bobySetInit != null && bobySetInit[0].Controls.Owner is View.Loader.UCSetInit)
                        {

                        }
                    }
                    break;
                case "气路":
                    var gasInit = this.panControl.Controls.Find("UCSetMFC", false);
                    if (gasInit != null && gasInit[0].Controls.Owner is View.Tube.UCSetMFC)
                    {
                        var gasInfo = gasInit[0].Controls.Owner as View.Tube.UCSetMFC;
                        foreach (Control control in gasInfo.Controls)
                        {
                            if (control is View.Common.UCSetMFCModule)
                            {
                                int i = Convert.ToInt16(System.Text.RegularExpressions.Regex.Replace(control.Name, @"[^0-9]+", "0")) - 1;
                                foreach (Control ctl in control.Controls)
                                {
                                    if (ctl is TextBox)
                                    {
                                        if (ctl.Name.Equals("txtWarnValue", StringComparison.CurrentCultureIgnoreCase))
                                            ((TextBox)ctl).Text = PlcVar.Tube[frmID.Unit].stMFC_Para[i].rWarnDiff_Persent.ToString();
                                        if (ctl.Name.Equals("txtAlmValue", StringComparison.CurrentCultureIgnoreCase))
                                            ((TextBox)ctl).Text = PlcVar.Tube[frmID.Unit].stMFC_Para[i].rAlmDiff_Persent.ToString();
                                        if (ctl.Name.Equals("txtMaxRange", StringComparison.CurrentCultureIgnoreCase))
                                            ((TextBox)ctl).Text = PlcVar.Tube[frmID.Unit].stMFC_Para[i].nMaxRange.ToString();
                                    }
                                    if (ctl is Button)
                                    {
                                        if (ctl.Name.Equals("btnSheild", StringComparison.CurrentCultureIgnoreCase))
                                        {
                                            if (PlcVar.Tube[frmID.Unit].stMFC_Para[i].bShield)
                                            {
                                                ((Button)ctl).BackColor = System.Drawing.Color.LightCoral;
                                            }
                                            else
                                            {
                                                ((Button)ctl).BackColor = System.Drawing.Color.Transparent;
                                                ((Button)ctl).FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    break;
                case "温控":
                    var bobySetZone = this.panControl.Controls.Find("UCSetTemp", false);
                    if (bobySetZone != null && bobySetZone[0].Controls.Owner is View.Tube.UCSetTemp)
                    {
                        var setZoneInfo = bobySetZone[0].Controls.Owner as View.Tube.UCSetTemp;
                        foreach (Control control in setZoneInfo.Controls)
                        {
                            int i = Convert.ToInt16(System.Text.RegularExpressions.Regex.Replace(control.Name, @"[^0-9]+", "0"));
                            if (control is TextBox)
                            {
                                if (control.Name.Equals("txtBreakPV" + i.ToString(), StringComparison.CurrentCultureIgnoreCase))//断线值
                                    ((TextBox)control).Text = PlcVar.Tube[frmID.Unit].stTempPara[i - 1].nBreakPV.ToString();
                                else if (control.Name.Equals("txtAlmPV" + i.ToString(), StringComparison.CurrentCultureIgnoreCase))//极限值
                                    ((TextBox)control).Text = PlcVar.Tube[frmID.Unit].stTempPara[i - 1].nAlmPV.ToString();
                                else if (control.Name.Equals("txtKp" + i.ToString(), StringComparison.CurrentCultureIgnoreCase))//Kp
                                    ((TextBox)control).Text = PlcVar.Tube[frmID.Unit].stTempPara[i - 1].nKp.ToString();
                                else if (control.Name.Equals("txtKi" + i.ToString(), StringComparison.CurrentCultureIgnoreCase))//Ki
                                    ((TextBox)control).Text = PlcVar.Tube[frmID.Unit].stTempPara[i - 1].nKi.ToString();
                                else if (control.Name.Equals("txtKd" + i.ToString(), StringComparison.CurrentCultureIgnoreCase))//Kd
                                    ((TextBox)control).Text = PlcVar.Tube[frmID.Unit].stTempPara[i - 1].nKd.ToString();
                                else if (control.Name.Equals("txtWarnDiff" + i.ToString(), StringComparison.CurrentCultureIgnoreCase))//警示偏差值
                                    ((TextBox)control).Text = PlcVar.Tube[frmID.Unit].stTempPara[i - 1].nWarnDiff.ToString();
                                else if (control.Name.Equals("txtAlmDiff" + i.ToString(), StringComparison.CurrentCultureIgnoreCase))//报警偏差值
                                    ((TextBox)control).Text = PlcVar.Tube[frmID.Unit].stTempPara[i - 1].nAlmDiff.ToString();

                                if (control.Name.Equals("txtIP", StringComparison.CurrentCultureIgnoreCase))//IP地址
                                    ((TextBox)control).Text = PlcVar.Tube[frmID.Unit].stSysPara.TempModule1_IP.ToString();
                            }
                            if (control is Button)
                            {
                                if (control.Name.Equals("btnShield" + i.ToString(), StringComparison.CurrentCultureIgnoreCase))//屏蔽
                                    help.SetbtnClickBackColor((Button)control, Color.LightCoral, PlcVar.Tube[frmID.Unit].stTempPara[i - 1].bShield);

                                if (control.Name.Equals("btnCutExAndIn", StringComparison.CurrentCultureIgnoreCase))//内外偶切换
                                {
                                    bool mini8_Ctrl_Type = false;
                                    Button btn = (Button)control;
                                    if (PlcVar.Tube[frmID.Unit].gnMini8_Ctrl_Type == 0)
                                    {
                                        mini8_Ctrl_Type = false;
                                        btn.Text = "内偶控温";
                                    }
                                    else
                                    {
                                        mini8_Ctrl_Type = true;
                                        btn.Text = "外偶控温";
                                    }
                                    help.SetbtnClickBackColor((Button)control, Color.LightCoral, mini8_Ctrl_Type);
                                }
                            }
                        }
                    }
                    break;
                case "真空":
                    var bobySetVacuum = this.panControl.Controls.Find("UCSetVacuum", false);
                    if (bobySetVacuum != null && bobySetVacuum[0].Controls.Owner is View.Tube.UCSetVacuum)
                    {
                        var setVacuumInfo = bobySetVacuum[0].Controls.Owner as View.Tube.UCSetVacuum;
                        setVacuumInfo.txtPump_IP.Text = PlcVar.Tube[frmID.Unit].stSysPara.Pump_IP;
                        setVacuumInfo.txtWarnDiff_Persent.Text = PlcVar.Tube[frmID.Unit].stPump_Para.rWarnDiff_Persent.ToString();
                        setVacuumInfo.txtAlmDiff_Persent.Text = PlcVar.Tube[frmID.Unit].stPump_Para.rAlmDiff_Persent.ToString();
                        setVacuumInfo.txtCheckValue.Text = PlcVar.Tube[frmID.Unit].stPump_Para.rCheckValue.ToString();
                        setVacuumInfo.txtCheckTime.Text = PlcVar.Tube[frmID.Unit].stPump_Para.nCheckTime.ToString();
                        setVacuumInfo.txtNormal_Pressure.Text = PlcVar.Tube[frmID.Unit].stSysPara.rNormal_Pressure.ToString();
                        setVacuumInfo.txtAlmTail_Temp.Text = PlcVar.Tube[frmID.Unit].stSysPara.rAlmTail_Temp.ToString();
                        setVacuumInfo.txtSetSpeed.Text = PlcVar.Tube[frmID.Unit].stPump_Ctrl.rSetSpeed.ToString();

                        setVacuumInfo.txtAI_Para_FilterN.Text = PlcVar.Tube[frmID.Unit].stAI_Para.FilterN.ToString();
                        setVacuumInfo.txtAI_Para_rMinAct.Text = PlcVar.Tube[frmID.Unit].stAI_Para.rMinAct.ToString();
                        setVacuumInfo.txtAI_Para_rMinOriginal.Text = PlcVar.Tube[frmID.Unit].stAI_Para.rMinOriginal.ToString();
                        setVacuumInfo.txtAI_Para_rMaxAct.Text = PlcVar.Tube[frmID.Unit].stAI_Para.rMaxAct.ToString();
                        setVacuumInfo.txtAI_Para_rMaxOriginal.Text = PlcVar.Tube[frmID.Unit].stAI_Para.rMaxOriginal.ToString();
                    }
                    break;
                case "轴控":
                    var bobySetAxis = this.panControl.Controls.Find("UCSetBoatPush", false);
                    if (bobySetAxis != null && bobySetAxis[0].Controls.Owner is View.Tube.UCSetBoatPush)
                    {
                        var setAxisInfo = bobySetAxis[0].Controls.Owner as View.Tube.UCSetBoatPush;
                        setAxisInfo.txtAbs_Pos1.Text = PlcVar.Tube[frmID.Unit].BoatPush_SV_Para.rAbs_Pos[1].ToString();
                        setAxisInfo.txtAbs_Pos4.Text = PlcVar.Tube[frmID.Unit].BoatPush_SV_Para.rAbs_Pos[4].ToString();
                        setAxisInfo.txtAbs_Pos6.Text = PlcVar.Tube[frmID.Unit].BoatPush_SV_Para.rAbs_Pos[6].ToString();
                        setAxisInfo.txtAbs_Speed1.Text = PlcVar.Tube[frmID.Unit].BoatPush_SV_Para.rAbs_Speed[1].ToString();
                        setAxisInfo.txtAbs_Speed4.Text = PlcVar.Tube[frmID.Unit].BoatPush_SV_Para.rAbs_Speed[4].ToString();
                        setAxisInfo.txtAbs_Speed6.Text = PlcVar.Tube[frmID.Unit].BoatPush_SV_Para.rAbs_Speed[6].ToString();
                        help.SetbtnClickBackColor(setAxisInfo.btnHome_Excute, Color.Green, PlcVar.Tube[frmID.Unit].BoatPush_SV_Para.bHome_OK);
                        setAxisInfo.txtAcc.Text = PlcVar.Tube[frmID.Unit].BoatPush_SV_Para.rAcc.ToString();
                        setAxisInfo.txtBoatPush_SV_MaxT.Text = PlcVar.Tube[frmID.Unit].AxisParaEx.rBoatPush_SV_MaxT.ToString();
                        setAxisInfo.txtMaxPos.Text = PlcVar.Tube[frmID.Unit].BoatPush_SV_Para.rMaxPos.ToString();
                        setAxisInfo.txtMinPos.Text = PlcVar.Tube[frmID.Unit].BoatPush_SV_Para.rMinPos.ToString();
                        help.SetbtnClickBackColor(setAxisInfo.btnEnableT_Protect, Color.LightCoral, PlcVar.Tube[frmID.Unit].BoatPush_SV_Para.bEnableT_Protect);
                        setAxisInfo.txtBoatOut_OffsetPos.Text = PlcVar.Tube[frmID.Unit].AxisParaEx.rBoatOut_OffsetPos.ToString();
                        setAxisInfo.txtBoatOutAlmOffsetPos.Text = PlcVar.Tube[frmID.Unit].AxisParaEx.rBoatOut_AlmOffsetPos.ToString();
                    }
                    break;
                case "限幅":
                    break;
                case "舟管理":

                    break;
                case "日志":
                case "事件":
                    var bodyEvent = this.panControl.Controls.Find("UCJournal", false);
                    if (bodyEvent != null && bodyEvent[0].Controls.Owner is View.Common.UCJournal)
                    {
                        var enevtInfo = bodyEvent[0].Controls.Owner as View.Common.UCJournal;
                        if (frmID.Unit == 0)
                            enevtInfo.dgvJournal.DataSource = com.TubeServices.TubeEventService.Instance.GetLoaderEventList(DateTime.Now.AddHours(-2), DateTime.Now);
                        else
                            enevtInfo.dgvJournal.DataSource = com.TubeServices.TubeEventService.Instance.GetEventList(frmID.Unit, DateTime.Now.AddHours(-2), DateTime.Now);
                    }
                    break;
                case "报警":
                    var bodyAlarm = this.panControl.Controls.Find("UCJournal", false);
                    if (bodyAlarm != null && bodyAlarm[0].Controls.Owner is View.Common.UCJournal)
                    {
                        var alarmInfo = bodyAlarm[0].Controls.Owner as View.Common.UCJournal;
                        if (frmID.Unit == 0)
                            alarmInfo.dgvJournal.DataSource = com.TubeServices.TubeAlarmService.Instance.GetLoaderAlarmList(DateTime.Now.AddHours(-2), DateTime.Now);
                        else
                            alarmInfo.dgvJournal.DataSource = com.TubeServices.TubeAlarmService.Instance.GetTubeAlarmList(frmID.Unit, DateTime.Now.AddHours(-2), DateTime.Now);
                    }
                    break;
                case "关于":
                    var bodyAbout = this.panControl.Controls.Find("UCAbout", false);
                    if (bodyAbout != null && bodyAbout[0].Controls.Owner is View.Common.UCAbout)
                    {
                        var aboutInfo = bodyAbout[0].Controls.Owner as View.Common.UCAbout;
                        foreach (Control control in aboutInfo.Controls)
                        {
                            int i = Convert.ToInt16(System.Text.RegularExpressions.Regex.Replace(control.Name, @"[^0-9]+", "0"));
                            if (control is TextBox)
                            {
                                if (control.Name.Equals("txtVerison" + i.ToString(), StringComparison.CurrentCultureIgnoreCase))
                                    ((TextBox)control).Text = PlcVar.Tube[frmID.Unit].gsVersion;
                                if (control.Name.Equals("txtRegister" + i.ToString(), StringComparison.CurrentCultureIgnoreCase))
                                    ((TextBox)control).Text = PlcVar.Tube[frmID.Unit].giLicense_Code.ToString();
                                if (control.Name.Equals("txtSerial" + i.ToString(), StringComparison.CurrentCultureIgnoreCase))
                                    ((TextBox)control).Text = PlcVar.Tube[frmID.Unit].giSN.ToString();
                            }
                        }
                        aboutInfo.txtVerison6.Text = PlcVar.Jht.gsVersion;
                        aboutInfo.txtRegister6.Text = PlcVar.Jht.giLicense_Code.ToString();
                        aboutInfo.txtSerial6.Text = PlcVar.Jht.giSN.ToString();
                    }
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tsTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void tsCompanyName_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.laplace-tech.cn/");
        }
    }
}
