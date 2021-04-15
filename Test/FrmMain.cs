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

namespace Test
{
    public partial class FrmMain : FrmWithTitle
    {
        public static View.Common.CommonClass comm = null;
        public static View.Tube.UCMain ucMain = null;
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
                TreeConentLoad();
                AddControl(new View.Tube.UCMain());
            }
            finally
            {
                ControlHelper.FreezeControl(this, false);
            }

            PlcVar.Tube[0].gnProcessWorkingTime = 1;
            PlcVar.Tube[1].gnProcessWorkingTime = 2;
            PlcVar.Tube[2].gnProcessWorkingTime = 3;
            PlcVar.Tube[3].gnProcessWorkingTime = 4;
            PlcVar.Tube[4].gnProcessWorkingTime = 5;
            comm.OnNumChanged += recipeInfo.Identify1_OnIdentifyTimeChanged;
        }
        public void TreeConentLoad()
        {
            this.tvMenu.Nodes.Clear();
            ControlHelper.FreezeControl(this, true);
            this.tvMenu.Nodes.Add(" 用户");
            this.tvMenu.Nodes.Add(" 首页");
            this.tvMenu.Nodes.Add(" 主页");
            if (comm.Num != 5)
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
            if (comm.Num == 5)
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
            if (comm.Num == 5)
                this.tvMenu.Nodes.Add(" 舟管理");
            TreeNode tnJournal = new TreeNode(" 日志");
            tnJournal.Nodes.Add("事件");
            tnJournal.Nodes.Add("报警");
            this.tvMenu.Nodes.Add(tnJournal);
            this.tvMenu.Nodes.Add(" 关于");
        }
        private void tvMenu_AfterSelect(object sender, TreeViewEventArgs e)
        {
            panControl.Controls.Clear();
            string strName = e.Node.Text.Trim();
            this.Title = "磷扩散控制系统--" + strName;
            if (comm.Num == 0 || comm.Num == 1 || comm.Num == 2 || comm.Num == 3 || comm.Num == 4)
            {
                switch (strName)
                {
                    case "首页":
                        AddControl(new UCShouQuan());
                        pnlMenu.Visible = false;
                        break;
                    case "用户":
                        AddControl(new View.Common.UCUserInfo());
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
                        AddControl(new View.Tube.UCRecipe());
                        break;
                    case "I/O":
                        pnlMenu.Visible = true;
                        AddControl(new View.Tube.UCIO());
                        break;
                    case "数据":
                    case "图表":
                        pnlMenu.Visible = true;
                        AddControl(new View.Tube.UCChart());
                        break;
                    case "报表":
                        pnlMenu.Visible = true;
                        AddControl(new View.Tube.UCReport());
                        break;
                    case "配置":
                    case "初始化":
                        pnlMenu.Visible = true;
                        AddControl(new View.Tube.UCInit());
                        break;
                    case "气路":
                        pnlMenu.Visible = true;
                        AddControl(new View.Tube.UCSetMFC());
                        break;
                    case "温控":
                        pnlMenu.Visible = true;
                        AddControl(new View.Tube.UCSetTemp());
                        break;
                    case "真空":
                        pnlMenu.Visible = true;
                        AddControl(new View.Tube.UCSetVacuum());
                        break;
                    case "轴控":
                        pnlMenu.Visible = true;
                        AddControl(new View.Tube.UCSetBoatPush());
                        break;
                    case "日志":
                    case "报警":
                    case "事件":
                        pnlMenu.Visible = true;
                        AddControl(new View.Common.UCJournal());
                        break;
                    case "关于":
                        pnlMenu.Visible = false;
                        AddControl(new View.Common.UCAbout());
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
                        AddControl(new UCShouQuan());
                        pnlMenu.Visible = false;
                        break;
                    case "用户":
                        AddControl(new View.Common.UCUserInfo());
                        pnlMenu.Visible = false;
                        break;
                    case "主页":
                        pnlMenu.Visible = true;
                        AddControl(new View.Loader.UCMain());
                        break;
                    case "I/O":
                        pnlMenu.Visible = true;
                        AddControl(new View.Loader.UCIO());
                        break;
                    case "通讯":
                        pnlMenu.Visible = true;
                        AddControl(new View.Loader.UCCommIO());
                        break;
                    case "配置":
                    case "初始化":
                        pnlMenu.Visible = true;
                        AddControl(new View.Loader.UCSetInit());
                        break;
                    case "轴控":
                        pnlMenu.Visible = true;
                        AddControl(new View.Loader.UCSetAxisPara());
                        break;
                    case "工位":
                        pnlMenu.Visible = true;
                        AddControl(new View.Loader.UCSetStation());
                        break;
                    case "舟管理":
                        pnlMenu.Visible = false;
                        AddControl(new View.Loader.UCBoatManager());
                        break;
                    case "日志":
                    case "报警":
                    case "事件":
                        pnlMenu.Visible = true;
                        AddControl(new View.Common.UCJournal());
                        break;
                    case "关于":
                        pnlMenu.Visible = false;
                        AddControl(new View.Common.UCAbout());
                        break;
                    default:
                        MessageBox.Show("打开画面异常！");
                        break;
                }
            }

        }

        private void AddControl(Control c)
        {
            c.Dock = DockStyle.Fill;
            this.panControl.Controls.Add(c);
        }

        View.Tube.UCRecipeInfo recipeInfo = new View.Tube.UCRecipeInfo();
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
            switch (num)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    frmID.Unit = num - 1; comm.Num = num - 1;
                    break;
                case 6:
                    comm.Num = 5;
                    TreeConentLoad();
                    ControlHelper.FreezeControl(this, false);
                    break;
                default:
                    comm.Num = 0;
                    break;
            }
            DataBings();
            #endregion
        }

        public void DataBings()
        {
            View.Common.TubeHelpClass help = new View.Common.TubeHelpClass();

            var bodyManin = this.panControl.Controls.Find("UCMain", false);
            foreach (var item in bodyManin[0].Controls)
            {
                if (item is View.Tube.UCRecipeInfo)//工艺信息
                {
                    var recipeInfo = item as View.Tube.UCRecipeInfo;
                    //lblRecipeInfoTitle.lblRecipeInfoTitle.Text = num.ToString();
                    recipeInfo.lblRecipeInfoTitle.Text = PlcVar.Tube[frmID.Unit].giRecipe_ID.ToString();
                    recipeInfo.ucSwitch.Checked = PlcVar.Tube[frmID.Unit].OP_Cmd.bAutoSelect;
                    //recipeInfo.lblRecipeName.Text = PlcVar.Tube[frmID.Unit].stCurrentRecipeName;
                    recipeInfo.lblRecipeTotalTime.Text = help.timeFormatUshortToString(PlcVar.Tube[frmID.Unit].gnProcessWorkingTime);
                    recipeInfo.lblRecipeWorkTime.Text = help.timeFormatUshortToString(PlcVar.Tube[frmID.Unit].gnProcessWorkingTime);
                    recipeInfo.lblRecipeRemainTime.Text = help.timeFormatUshortToString(PlcVar.Tube[frmID.Unit].gnProcessRemainTime);
                    recipeInfo.lblStepId.Text = PlcVar.Tube[frmID.Unit].giRecipe_ID.ToString();
                    recipeInfo.lblStepName.Text = help.KSrecipeNameFormatIntToString(PlcVar.Tube[frmID.Unit].stCurrentRecipeCtrl.eName);
                    recipeInfo.lblStepTotalTime.Text = help.timeFormatFloatToString(PlcVar.Tube[frmID.Unit].stCurrentRecipeCtrl.nDuration);
                    recipeInfo.lblStepWorkTime.Text = help.timeFormatFloatToString(PlcVar.Tube[frmID.Unit].stCurrentRecipeCtrl.nWorking_Time);
                    recipeInfo.lblStepRemainTime.Text = help.timeFormatFloatToString(PlcVar.Tube[frmID.Unit].stCurrentRecipeCtrl.nRemain_Time);
                }
                if (item is View.Tube.UCBoatPush)//推舟
                {

                }
                if (item is View.Tube.UCZone)//温区
                {

                }
                if (item is View.Tube.UCRoad)//气路
                {

                }
            }
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.laplace-tech.cn/");
        }

    }
}
