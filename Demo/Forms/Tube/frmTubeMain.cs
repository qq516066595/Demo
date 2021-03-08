using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using com.DataBaseModels;
using DevExpress.XtraGrid.Views.Base;
using com.TubeServices;
using System.Threading;
using com.CommunicationDAL;
using com.CommunicationModels;
using LaplaceCIP;
using System.Text.RegularExpressions;
/*
* namespace：Demo.Forms
* className：frmHomePage
* 
* Version：HMI_RPxx_V001_202012
* Author：hehf
* Date：2020-12-12 11:57:58
* Desc：炉管页面
* 
* Remarks：
*/
namespace Demo.Forms.Tube
{
    public partial class frmTubeMain : DevExpress.XtraEditors.XtraForm
    {
        public TubeHelpClass help = new TubeHelpClass();
        public TubeModelClass tubeModelClass = new TubeModelClass();
        public frmTubeMain()
        {
            InitializeComponent();

            lblZoneEx1.Text = this.Tag.ToString();
            this.gridRecipeView.InitNewRow += GridRecipeView_InitNewRow;
        }
        #region 获取炉管号
        /// <summary>
        /// 将本窗体的tag值传递出去
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        PlcModels myModus1 = new PlcModels();
        PlcModels myModus2 = new PlcModels();
        PlcModels myModus3 = new PlcModels();
        PlcModels myModus4 = new PlcModels();
        PlcModels myModus5 = new PlcModels();
        PlcModels mys = new PlcModels();
        private void frmTubeMain_Load(object sender, EventArgs e)
        {


            ////int a = (Int32)this.Tag;
            ////if (a == 1)//炉管一
            ////    gettag(1);
            ////else if (a == 2)//炉管二
            ////    gettag(2);
            ////else if (a == 3)//炉管三
            ////    gettag(3);
            ////else if (a == 4)//炉管四
            ////    gettag(4);
            ////else if (a == 5)//炉管五
            ////    gettag(5);


            ////2020-12-29 hhf 测试使用；需写到委托事件中实时刷新数据
            ////MyModus[] myModus = new MyModus[5];
            ////MyModus mys = new MyModus();
            ////int index = Convert.ToInt32(this.Tag) - 1;
            ////myModus[index] = mys;
            //myModus1.giRecipe_ID = 1;
            //myModus2.giRecipe_ID = 2;
            //myModus3.giRecipe_ID = 3;
            //myModus4.giRecipe_ID = 4;
            //myModus5.giRecipe_ID = 5;

            //int index = Convert.ToInt32(this.Tag);
            //if (index == 1)
            //    mys = myModus1;
            //else if (index == 2)
            //    mys = myModus2;
            //else if (index == 3)
            //    mys = myModus3;
            //else if (index == 4)
            //    mys = myModus4;
            //else if (index == 5)
            //    mys = myModus5;
            //else
            //    return;

            //myModus1.grTemp_SPArray[0] = 91;
            //myModus1.grTemp_SPArray[1] = 92;
            //myModus1.grTemp_SPArray[2] = 93;
            //myModus1.grTemp_SPArray[3] = 94;
            //myModus1.grTemp_SPArray[4] = 95;
            //myModus1.grTemp_SPArray[5] = 96;
            //myModus1.grTemp_SPArray[6] = 97;
            //myModus1.StTempZoneArray[0].rMV = 11;
            //myModus1.StTempZoneArray[0].rSet_Temp = 500;
            //myModus1.StTempZoneArray[0].rExternal_Temp = 300;
            //myModus1.StTempZoneArray[0].rInternal_Temp = 289.4F;

            ////温区值绑定
            //TempBindings(mys);
            ////工艺信息
            //ucRecipeInfo1.ucRecipe(mys);
            ////轴信息
            //ucAxisX1.ucAxis(mys);
            //配方数据源绑定
            addGridBindings();
            repositoryItemButtonEdit1.Click += RepositoryItemButtonEdit1_Click;
            repositoryItemCheckEdit1.QueryCheckStateByValue += new DevExpress.XtraEditors.Controls.QueryCheckStateByValueEventHandler(repositoryItemCheckEdit1_QueryCheckStateByValue);
            //图表加载
            spcChart.Panel1Collapsed = false;
            spcChart.Panel2Collapsed = true;
            //设置-初始化
            SettingDataBings();
            btnProcessInit.Click += OnMouseDown_Click;
            btnProcessInit.Click += OnMouseUp_Click;
            btnHeatingInit.Click += OnMouseDown_Click;
            btnHeatingInit.Click += OnMouseUp_Click;
            btnGasInit.Click += OnMouseDown_Click;
            btnGasInit.Click += OnMouseUp_Click;
            btnBoatPushInit.Click += OnMouseDown_Click;
            btnBoatPushInit.Click += OnMouseUp_Click;
            btnVacuumInit.Click += OnMouseDown_Click;
            btnVacuumInit.Click += OnMouseUp_Click;
            tubeModelClass.InitDoneChanged += OnInitDone_Changed;
        }

        //读取
        //TUBEisTEST tube = new TUBEisTEST();
        LaplaceCIP.PlcOmronCip plcOmronCip = new LaplaceCIP.PlcOmronCip();
        string test1;
        private void intIT()
        {
            if (Convert.ToInt32(this.Tag) == 1)
            {
                test1 = plcOmronCip.GetVariableInfo(1, "OP_Mode");
            }
        }
        Thread th1;
        //线程读取
        private void timer1_Tick(object sender, EventArgs e)
        {
            //if (th1 == null)
            //{
            //    th1 = new Thread(intIT);
            //    th1.Start();
            //}
            //else
            //{
            //    if (th1.ThreadState == System.Threading.ThreadState.Stopped)
            //    {
            //        th1 = new Thread(intIT);
            //        th1.Start();
            //    }
            //}
            //txtPumpSpeed.Text = test1;
        }

        //写入
        private void txtPumpSpeed_Click(object sender, EventArgs e)
        {
            try
            {
                键盘.DefaultInstance.Text = "测试";
                MyModu.MinSet = 0;
                MyModu.MaxSet = 1200;
                键盘.DefaultInstance.ShowDialog();
                if (MyModu.Gyedit != "cancel")
                {
                    plcOmronCip.WiteVariable(1, "OP_Mode", MyModu.Gyedit);
                }
                MyModu.LogEvent(6, "测试", MyModu.Gyedit);
                return;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Set Failed:" + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region 主界面
        private void MianDataBindings()
        {
            //温区
            foreach (Control control in this.pcTempZone.Controls)
            {
                if (control is LabelControl)
                {
                    for (int i = 1; i <= 7; i++)
                    {
                        if (control.Name.Equals("lblZoneEx" + i.ToString(), StringComparison.CurrentCultureIgnoreCase))//外偶
                            ((LabelControl)control).Text = PlcVar.Tube[frmID.Unit].stTempZone[i].rExternal_Temp.ToString();
                        else if (control.Name.Equals("lblZoneIn" + i.ToString(), StringComparison.CurrentCultureIgnoreCase))//内偶
                            ((LabelControl)control).Text = PlcVar.Tube[frmID.Unit].stTempZone[i].rInternal_Temp.ToString();
                        else if (control.Name.Equals("lblZoneMV" + i.ToString(), StringComparison.CurrentCultureIgnoreCase))//功率
                            ((LabelControl)control).Text = PlcVar.Tube[frmID.Unit].stTempZone[i].rMV.ToString();
                        //else if (control.Name.Equals("lblZoneSP" + i.ToString(), StringComparison.CurrentCultureIgnoreCase))//过渡
                        //((LabelControl)control).Text = modus.grTemp_SPArray[i].ToString();
                    }
                    //水冷
                    //lblWaterCooling1.Text = modus.grCooling_PV1.ToString();
                    //lblWaterCooling2.Text = modus.grCooling_PV2.ToString();
                }
                //设定值
                if (control is TextEdit)
                {
                    for (int i = 1; i < 7; i++)
                    {
                        if (control.Name.Equals("txtZoneSV" + i.ToString(), StringComparison.CurrentCultureIgnoreCase))//设定值
                            ((TextEdit)control).Text = PlcVar.Tube[frmID.Unit].stTempZone[i].rCurrent_SV.ToString();
                    }
                }
            }
            //恒温槽
            PlcJht jht = new PlcJht();
            lblHWCTempPV.Text = jht.stHWCs_Ctrl.rActTemperature.ToString();//实际温度
            txtHWCTempSV.Text = jht.stHWCs_Ctrl.rSetTemperature.ToString();//设定温度
            string nNetWeight = "0";
            int frmtag = (Int32)this.Tag;
            switch (frmtag)
            {
                case 1:
                    nNetWeight = jht.stHWCs_Ctrl.nNetWeight_1.ToString();//液位重量
                    break;
                case 2:
                    nNetWeight = jht.stHWCs_Ctrl.nNetWeight_2.ToString();//液位重量
                    break;
                case 3:
                    nNetWeight = jht.stHWCs_Ctrl.nNetWeight_3.ToString();//液位重量
                    break;
                case 4:
                    nNetWeight = jht.stHWCs_Ctrl.nNetWeight_4.ToString();//液位重量
                    break;
                case 5:
                    nNetWeight = jht.stHWCs_Ctrl.nNetWeight_5.ToString();//液位重量
                    break;
                default:
                    break;
            }
            lblHWCWeight.Text = nNetWeight;//液位重量
            //help.SetlblSignalBackColor(lblHWCWorkState,Color.Green, jht.stHWCs_Ctrl.nRunningState); //恒温槽工作状态
            help.SetbtnClickBackColor(btnHWCLeakCheck,Color.DeepSkyBlue, PlcVar.Tube[frmID.Unit].gbHMI_LeakCheck);

            //真空
            txtPumpSpeed.Text = PlcVar.Tube[frmID.Unit].stPump_Ctrl.rActSpeed.ToString();
            lblButterfly.Text = PlcVar.Tube[frmID.Unit].grMKS_ActPos.ToString();
            txtLeakRate.Text = PlcVar.Tube[frmID.Unit].grActLeakRate.ToString();
            help.SetbtnClickBackColor(btnStartAndStop,Color.DeepSkyBlue, PlcVar.Tube[frmID.Unit].stPump_Ctrl.bStartPump);

            txtSourceBottleUseCount.Text = PlcVar.Tube[frmID.Unit].giSource_Counter.ToString();
            help.SetbtnClickBackColor(btnSourceBottleLeakCheck,Color.DeepSkyBlue, PlcVar.Tube[frmID.Unit].gbSourceBottle_LeakCheck);
            //气路

            //轴控
        }
        #region 温区
        /// <summary>
        /// 主界面--过渡值与功率输出显示与隐藏
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShowMVAndSP_Click(object sender, EventArgs e)
        {
            Fold(165, 115, "上下", pcTempZone, btnShowMVAndSP);
        }

        /// <summary>
        /// 开启加热弹窗
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblHeating_Click(object sender, EventArgs e)
        {
            frmHeating frmheat = new frmHeating();
            frmheat.frmIndex = (int)this.Tag;
            frmheat.ShowDialog();
        }
        #endregion

        #region 轴控
        /// <summary>
        /// 主界面--轴控单元操作按钮显示与隐藏
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShowAxis_Click(object sender, EventArgs e)
        {
            Fold(490, 115, "上下", pcAxis, btnShowAxis);
        }
        #endregion

        #region 恒温槽
        /// <summary>
        /// 一键检漏
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHWCLeakCheck_Click(object sender, EventArgs e)
        {
            PlcVar.Tube[frmID.Unit].gbHMI_LeakCheck = true;
            help.SetbtnClickBackColor(btnHWCLeakCheck, Color.Lime, PlcVar.Tube[frmID.Unit].gbHMI_LeakCheck);
        }
        #endregion

        #region 真空

        #endregion

        #region 气路

        #endregion

        #endregion

        #region 配方
        /// <summary>
        /// 刷新配方
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picRefreshRecipe_Click(object sender, EventArgs e)
        {
            this.gridRecipe.RefreshDataSource();
        }
        /// <summary>
        /// 新建配方
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picAddRecipe_Click(object sender, EventArgs e)
        {
            lblRecipeName.Text = "NewRecipe";
            dt.Rows.Clear();
            gridRecipe.DataSource = dt;
            for (int i = 0; i < 40; i++)
            {
                this.gridRecipeView.AddNewRow();//新增一行数据
            }
        }
        /// <summary>
        /// 添加行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GridRecipeView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            foreach (DevExpress.XtraGrid.Columns.GridColumn column in gridRecipeView.Columns)
            {
                string value = "";
                if (column.FieldName == "步号")
                { value = gridRecipeView.RowCount.ToString(); column.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left; column.OptionsColumn.AllowEdit = false; }
                if (column.FieldName == "执行动作")
                { column.ColumnEdit = repositoryItemComboBox1; column.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left; }
                if (column.FieldName == "阀开关")
                    column.ColumnEdit = repositoryItemButtonEdit1;
                gridRecipeView.SetRowCellValue(e.RowHandle, gridRecipeView.Columns[column.FieldName], value);
            }
        }
        /// <summary>
        /// 为gridControl绑定数据源
        /// </summary>
        DataTable dt = new DataTable();
        public void addGridBindings()
        {
            //配方
            //设置数据结构
            foreach (DevExpress.XtraGrid.Columns.GridColumn groupColumn in this.gridRecipeView.Columns)
            {
                string type = "";
                if (groupColumn.ColumnEdit == repositoryItemCheckEdit1)
                    type = "System.Boolean";
                else if (groupColumn.ColumnEdit == repositoryItemComboBox1)
                    type = "System.String";
                else
                    type = "System.String";
                dt.Columns.Add(groupColumn.Caption, Type.GetType(type));
            }
            this.gridRecipe.DataSource = dt;
            gridRecipe.MainView.PopulateColumns();
        }
        /// <summary>
        /// 打开配方文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picOpenFile_Click(object sender, EventArgs e)
        {
            gridRecipeView.OptionsSelection.MultiSelect = true;
            string fileTypeName = "\\recipe\\Tube" + this.Tag.ToString();
            DataTable dt = help.AsposeCells(fileTypeName);
            if (dt.Rows.Count > 0)
            {
                string val = TubeHelpClass.fileName.Substring(TubeHelpClass.fileName.LastIndexOf("\\") + 1, TubeHelpClass.fileName.Length - TubeHelpClass.fileName.LastIndexOf("\\") - 5);
                lblRecipeName.Text = val;
                gridRecipeView.Columns.Clear();
                gridRecipe.DataMember = dt.TableName;
                gridRecipe.DataSource = dt;
                foreach (DevExpress.XtraGrid.Columns.GridColumn column in gridRecipeView.Columns)
                {
                    if (column.FieldName == "步号")
                    { column.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left; column.OptionsColumn.AllowEdit = false; }
                    if (column.FieldName == "执行动作")
                    { column.ColumnEdit = repositoryItemComboBox1; column.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left; }
                    if (column.FieldName == "阀开关")
                        column.ColumnEdit = repositoryItemButtonEdit1;
                    if (column.FieldName == "条件")
                        column.ColumnEdit = repositoryItemCheckEdit1;
                    if (column.FieldName.Contains("V") || column.FieldName.Contains("监控"))
                        column.ColumnEdit = repositoryItemCheckEdit1;
                }
            }
        }
        /// <summary>
        /// 保存配方
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picSaveRecipe_Click(object sender, EventArgs e)
        {
            //自己写的方法导出，导出打开文件夹填写配方名
            string filerecipeName = lblRecipeName.Text;
            string fileTypeName = "\\recipe\\Tube" + Tag.ToString();
            help.ExportGridToFile(this.gridRecipeView, filerecipeName, fileTypeName, null);
            lblRecipeName.Text = TubeHelpClass.fileName.Substring(TubeHelpClass.fileName.LastIndexOf("\\") + 1, TubeHelpClass.fileName.Length - TubeHelpClass.fileName.LastIndexOf("\\") - 5);
        }
        /// <summary>
        /// 写入设备
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        object obj;
        byte[] b1 = new byte[] { 1, 2, 3, 4, 5 };
        private void picDownloadRecipe_Click(object sender, EventArgs e)
        {
            this.ShowWait();
            obj = 77;
            b1 = help.SerializeObject(obj);
            MessageBox.Show(b1.ToString());
            this.CloseWait();
        }
        /// <summary>
        /// 读取设备
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picUploadRecipe_Click(object sender, EventArgs e)
        {
            obj = help.DeserializeObject<int>(b1);
            MessageBox.Show(obj.ToString());
        }
        /// <summary>
        /// 配方校验
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picCheckRecipe_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 默认配方
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picDefaultRecipe_Click(object sender, EventArgs e)
        {
            frmDefaultRecipe frmDeRec = new frmDefaultRecipe(this.Tag.ToString(), mys);
            frmDeRec.ShowDialog();
        }
        /// <summary>
        /// 打开气路图
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RepositoryItemButtonEdit1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(gridRecipeView.GetFocusedDataSourceRowIndex().ToString());
        }
#pragma warning disable IDE1006 // 命名样式
        /// <summary>
        /// 复选框多选
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void repositoryItemCheckEdit1_QueryCheckStateByValue(object sender, DevExpress.XtraEditors.Controls.QueryCheckStateByValueEventArgs e)
#pragma warning restore IDE1006 // 命名样式
        {
            string val = "";
            if (e.Value != null)
            {
                val = e.Value.ToString();
            }
            else
            {
                val = "Flase";//默认为选中
            }
            switch (val)
            {
                case "True":
                    e.CheckState = CheckState.Checked;
                    break;
                case "False":
                    e.CheckState = CheckState.Unchecked;
                    break;
                case "Yes":
                    goto
                        case "True";
                case "No":
                    goto
                        case "False";
                case "1":
                    goto
                        case "True";
                case "0":
                    goto
                        case "False";
                default:
                    e.CheckState = CheckState.Unchecked;
                    break;
            }
            e.Handled = true;
        }

        #region 配方右键菜单
        /// <summary>
        /// 插入行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InsertRow_Click(object sender, EventArgs e)
        {
            int index = gridRecipeView.GetFocusedDataSourceRowIndex();
            if (index >= 0)
            {
                DataRow dr1 = dt.NewRow();
                dt.Rows.InsertAt(dr1, index);
                dt.Rows.Remove(dt.Rows[34]);
                for (int i = index; i <= 34; i++)
                {
                    dt.Rows[i]["步号"] = i + 1;
                }
            }
            else
            {
                MessageBox.Show("当前未选中任何行！");
            }
        }
        /// <summary>
        /// 删除行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteRow_Click(object sender, EventArgs e)
        {
            int index = gridRecipeView.GetFocusedDataSourceRowIndex();
            if (index >= 0)
            {
                dt.Rows.Remove(dt.Rows[index]);
                dt.Rows.Add(34);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dt.Rows[i]["步号"] = i + 1;
                }
            }
            else
            {
                MessageBox.Show("当前未选中任何行！");
            }
        }
        /// <summary>
        /// 复制行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        DataRow copyRow = null;
        private void CopyRow_Click(object sender, EventArgs e)
        {
            int index = gridRecipeView.GetFocusedDataSourceRowIndex();
            if (index >= 0)
            {
                copyRow = dt.Rows[index];
            }
            else
            {
                MessageBox.Show("当前未选中任何行！");
            }
        }
        /// <summary>
        /// 粘贴行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PasteRow_Click(object sender, EventArgs e)
        {
            int index = gridRecipeView.GetFocusedDataSourceRowIndex();
            if (index >= 0 && copyRow != null)
            {
                for (int i = 0; i < dt.Columns.Count; i++)
                {

                    if (dt.Columns[i].ColumnName != "步号")
                    {
                        dt.Rows[index][i] = copyRow[i];
                    }
                }
                gridRecipeView.RefreshData();
            }
            else
            {
                if (index < 0)
                    MessageBox.Show("当前未选中任何行！");
                else
                    MessageBox.Show("请先复制行,再进行粘贴行操作！");
            }
        }
        #endregion

        #endregion

        #region 设置
        /// <summary>
        /// 设置--初始化和温控系统
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShowInit_Click(object sender, EventArgs e)
        {
            Fold(290, 25, "上下", pcInit, btnShowInit);
        }
        private void OnInitDone_Changed(object sender, EventArgs e)
        {
            tubeModelClass = (TubeModelClass)sender;
            //工艺初始化
            help.SetbtnClickBackColor(btnProcessInit, Color.Green, tubeModelClass.GbProcess_InitDone);
            help.SetbtnClickBackColor(btnBoatPushInit, Color.Green, tubeModelClass.GbBoatPush_InitDone);
            help.SetbtnClickBackColor(btnHeatingInit, Color.Green, tubeModelClass.GbHeating_InitDone);
            help.SetbtnClickBackColor(btnGasInit, Color.Green, tubeModelClass.GbGas_InitDone);
            help.SetbtnClickBackColor(btnVacuumInit, Color.Green, tubeModelClass.GbVacuum_InitDone);
        }
        public void OnMouseDown_Click(object sender, EventArgs e)
        {
            SimpleButton btn = (SimpleButton)sender;

            if (btn.Text == "工艺单元初始化")
                PlcVar.Tube[frmID.Unit].gbProcess_InitStart = true;
            else if (btn.Text == "加热系统初始化")
                PlcVar.Tube[frmID.Unit].gbHeating_InitStart = true;
            else if (btn.Text == "气路系统初始化")
                PlcVar.Tube[frmID.Unit].gbGas_InitStart = true;
            else if (btn.Text == "推舟系统初始化")
                PlcVar.Tube[frmID.Unit].gbBoatPush_InitStart = true;
            else if (btn.Text == "真空系统初始化")
                PlcVar.Tube[frmID.Unit].gbVacuum_InitStart = true;
        }
        public void OnMouseUp_Click(object sender, EventArgs e)
        {
            SimpleButton btn = (SimpleButton)sender;

            if (btn.Text == "工艺单元初始化")
                PlcVar.Tube[frmID.Unit].gbProcess_InitStart = false;
            else if (btn.Text == "加热系统初始化")
                PlcVar.Tube[frmID.Unit].gbHeating_InitStart = false;
            else if (btn.Text == "气路系统初始化")
                PlcVar.Tube[frmID.Unit].gbGas_InitStart = false;
            else if (btn.Text == "推舟系统初始化")
                PlcVar.Tube[frmID.Unit].gbBoatPush_InitStart = false;
            else if (btn.Text == "真空系统初始化")
                PlcVar.Tube[frmID.Unit].gbVacuum_InitStart = false;
        }
        public void btnbShield_Click(object sender, EventArgs e)
        {
            SimpleButton btn = (SimpleButton)sender;
            MatchCollection vMatchs = Regex.Matches(btn.Name, @"(\d+)");
            int[] vInts = new int[vMatchs.Count];
            PlcVar.Tube[frmID.Unit].stTempPara[int.Parse(vMatchs[0].Value) - 1].bShield = !PlcVar.Tube[frmID.Unit].stTempPara[int.Parse(vMatchs[0].Value) - 1].bShield;
            help.SetbtnClickBackColor(btn, Color.LightCoral, PlcVar.Tube[frmID.Unit].stTempPara[int.Parse(vMatchs[0].Value) - 1].bShield);
        }
        public void OnSetTextChanged(object sender, EventArgs e)
        {
            SettingDataBings();
        }
        public void SettingDataBings()
        {
            //单元初始化设置
            help.SetbtnClickBackColor(btnProcessInit, Color.LightCoral, PlcVar.Tube[frmID.Unit].gbProcess_InitStart);
            help.SetbtnClickBackColor(btnHeatingInit, Color.LightCoral, PlcVar.Tube[frmID.Unit].gbHeating_InitStart);
            help.SetbtnClickBackColor(btnGasInit, Color.LightCoral, PlcVar.Tube[frmID.Unit].gbGas_InitStart);
            help.SetbtnClickBackColor(btnBoatPushInit, Color.LightCoral, PlcVar.Tube[frmID.Unit].gbBoatPush_InitStart);
            help.SetbtnClickBackColor(btnVacuumInit, Color.LightCoral, PlcVar.Tube[frmID.Unit].gbVacuum_InitStart);
            //PID参数设置
            foreach (Control control in this.pcInit.Controls)
            {
                if (control is TextEdit)
                {
                    for (int i = 1; i <= 8; i++)
                    {
                        if (control.Name.Equals("txtBreakPV" + i.ToString(), StringComparison.CurrentCultureIgnoreCase))//断线值
                            ((TextEdit)control).Text = PlcVar.Tube[frmID.Unit].stTempPara[i - 1].nBreakPV.ToString();
                        else if (control.Name.Equals("txtAlmPV" + i.ToString(), StringComparison.CurrentCultureIgnoreCase))//极限值
                            ((TextEdit)control).Text = PlcVar.Tube[frmID.Unit].stTempPara[i - 1].nAlmPV.ToString();
                        else if (control.Name.Equals("txtKp" + i.ToString(), StringComparison.CurrentCultureIgnoreCase))//Kp
                            ((TextEdit)control).Text = PlcVar.Tube[frmID.Unit].stTempPara[i - 1].nKp.ToString();
                        else if (control.Name.Equals("txtKi" + i.ToString(), StringComparison.CurrentCultureIgnoreCase))//Ki
                            ((TextEdit)control).Text = PlcVar.Tube[frmID.Unit].stTempPara[i - 1].nKi.ToString();
                        else if (control.Name.Equals("txtKd" + i.ToString(), StringComparison.CurrentCultureIgnoreCase))//Kd
                            ((TextEdit)control).Text = PlcVar.Tube[frmID.Unit].stTempPara[i - 1].nKd.ToString();
                        else if (control.Name.Equals("txtWarnDiff" + i.ToString(), StringComparison.CurrentCultureIgnoreCase))//警示偏差值
                            ((TextEdit)control).Text = PlcVar.Tube[frmID.Unit].stTempPara[i - 1].nWarnDiff.ToString();
                        else if (control.Name.Equals("txtAlmDiff" + i.ToString(), StringComparison.CurrentCultureIgnoreCase))//报警偏差值
                            ((TextEdit)control).Text = PlcVar.Tube[frmID.Unit].stTempPara[i - 1].nAlmDiff.ToString();
                    }
                    if (control.Name.Equals("txtSetTempIP", StringComparison.CurrentCultureIgnoreCase))//IP地址
                        ((TextEdit)control).Text = PlcVar.Tube[frmID.Unit].stSysPara.TempModule1_IP.ToString();
                    else if (control.Name.Equals("txtSetTempZd", StringComparison.CurrentCultureIgnoreCase))//站号
                        ((TextEdit)control).Text = PlcVar.Tube[frmID.Unit].gnMini8_Ctrl_Type.ToString();
                }
                if (control is SimpleButton)
                {
                    for (int i = 1; i <= 8; i++)
                    {
                        if (control.Name.Equals("btnbShield" + i.ToString(), StringComparison.CurrentCultureIgnoreCase))//屏蔽
                            help.SetbtnClickBackColor((SimpleButton)control, Color.LightCoral, PlcVar.Tube[frmID.Unit].stTempPara[i - 1].bShield);
                    }
                    if (control.Name.Equals("btnCutExAndIn", StringComparison.CurrentCultureIgnoreCase))//内外偶切换
                    {
                        bool mini8_Ctrl_Type = false;
                        SimpleButton btn = (SimpleButton)control;
                        if (PlcVar.Tube[frmID.Unit].gnMini8_Ctrl_Type == 1)
                        {
                            mini8_Ctrl_Type = true;
                            btn.Text = "内偶控温";
                        }
                        else
                        {
                            mini8_Ctrl_Type = false;
                            btn.Text = "外偶控温";
                        }
                        help.SetbtnClickBackColor((SimpleButton)control, Color.LightCoral, mini8_Ctrl_Type);

                    }
                }
            }
            //真空参数设置
            txtPump_IP.Text = PlcVar.Tube[frmID.Unit].stSysPara.Pump_IP;
            txtWarnDiff_Persent.Text = PlcVar.Tube[frmID.Unit].stPump_Para.rWarnDiff_Persent.ToString();
            txtAlmDiff_Persent.Text = PlcVar.Tube[frmID.Unit].stPump_Para.rAlmDiff_Persent.ToString();
            txtCheckValue.Text = PlcVar.Tube[frmID.Unit].stPump_Para.rCheckValue.ToString();
            txtCheckTime.Text = PlcVar.Tube[frmID.Unit].stPump_Para.nCheckTime.ToString();
            txtNormal_Pressure.Text = PlcVar.Tube[frmID.Unit].stSysPara.rNormal_Pressure.ToString();
            txtAlmTail_Temp.Text = PlcVar.Tube[frmID.Unit].stSysPara.rAlmTail_Temp.ToString();
            txtSetSpeed.Text = PlcVar.Tube[frmID.Unit].stPump_Ctrl.rSetSpeed.ToString();
            //推舟参数设置
            txtAbs_Pos1.Text = PlcVar.Tube[frmID.Unit].BoatPush_SV_Para.rAbs_Pos[1].ToString();
            txtAbs_Pos4.Text = PlcVar.Tube[frmID.Unit].BoatPush_SV_Para.rAbs_Pos[4].ToString();
            txtAbs_Pos6.Text = PlcVar.Tube[frmID.Unit].BoatPush_SV_Para.rAbs_Pos[6].ToString();
            txtAbs_Speed1.Text = PlcVar.Tube[frmID.Unit].BoatPush_SV_Para.rAbs_Speed[1].ToString();
            txtAbs_Speed4.Text = PlcVar.Tube[frmID.Unit].BoatPush_SV_Para.rAbs_Speed[4].ToString();
            txtAbs_Speed6.Text = PlcVar.Tube[frmID.Unit].BoatPush_SV_Para.rAbs_Speed[6].ToString();
            help.SetbtnClickBackColor(btnHome_Excute, Color.Green, PlcVar.Tube[frmID.Unit].BoatPush_SV_Para.bHome_OK);
            txtAcc.Text = PlcVar.Tube[frmID.Unit].BoatPush_SV_Para.rAcc.ToString();
            txtBoatPush_SV_MaxT.Text = PlcVar.Tube[frmID.Unit].AxisParaEx.rBoatPush_SV_MaxT.ToString();
            txtMaxPos.Text = PlcVar.Tube[frmID.Unit].BoatPush_SV_Para.rMaxPos.ToString();
            txtMinPos.Text = PlcVar.Tube[frmID.Unit].BoatPush_SV_Para.rMinPos.ToString();
            help.SetbtnClickBackColor(btnEnableT_Protect, Color.LightCoral, PlcVar.Tube[frmID.Unit].BoatPush_SV_Para.bEnableT_Protect);
            txtBoatOut_OffsetPos.Text = PlcVar.Tube[frmID.Unit].AxisParaEx.rBoatOut_OffsetPos.ToString();
            txtBoatOutAlmOffsetPos.Text = PlcVar.Tube[frmID.Unit].AxisParaEx.rBoatOut_AlmOffsetPos.ToString();
            //流量计参数设置
            ucSetMFC1.MFC_ID = 1;
            ucSetMFC2.MFC_ID = 2;
            ucSetMFC3.MFC_ID = 3;
            ucSetMFC4.MFC_ID = 4;
            ucSetMFC5.MFC_ID = 5;
            ucSetMFC6.MFC_ID = 6;
            ucSetMFC7.MFC_ID = 7;
            ucSetMFC8.MFC_ID = 8;
            ucSetMFC9.MFC_ID = 9;
            ucSetMFC10.MFC_ID = 10;
            ucSetMFC11.MFC_ID = 11;
            ucSetMFC12.MFC_ID = 12;
        }

        /// <summary>
        /// 设置--气路系统
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShowSetMFC_Click(object sender, EventArgs e)
        {
            Fold(445, 25, "上下", pcSetMFC, btnShowSetMFC);
        }
        /// <summary>
        /// 设置--真空系统和运动控制
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSetAxisPara_Click(object sender, EventArgs e)
        {
            Fold(360, 25, "上下", pcSetAxisPara, btnSetAxisPara);
        }

        #endregion

        #region 报表

        //待完善项：①X轴设置为时间轴；②显示与隐藏曲线：修改属性即可useCheckItem；③曲线缩小放大
        private void picChart_Click(object sender, EventArgs e)
        {
            spcChart.Panel1Collapsed = false;
            spcChart.Panel2Collapsed = true;
            if (txtFilePath.Text == "C:\\\\")
            {
                MessageBox.Show("当前未选中文件！");
                return;
            }
            // DataTable _dt = ChartBingingData();

            chartTube.Series.Clear();
            chartTube.Titles.Clear();

            string colName = "";
            for (int i = 0; i < dtchartOrtable.Columns.Count; i++)
            {
                colName = dtchartOrtable.Columns[i].ColumnName;
                if (colName != "时间" && colName != "步号" && colName != "步名称")//判断数据类型
                {
                    Common.CreateSeries(chartTube, colName, DevExpress.XtraCharts.ViewType.Spline, dtchartOrtable, "时间", colName, null);
                }
            }

        }

        private void picTable_Click(object sender, EventArgs e)
        {
            spcChart.Panel1Collapsed = true;
            spcChart.Panel2Collapsed = false;
            gridViewReport.Columns.Clear();
            if (txtFilePath.Text == "C:\\\\")
            {
                MessageBox.Show("当前未选中文件！");
                return;
            }
            gridReport.DataMember = dtchartOrtable.TableName;
            gridReport.DataSource = dtchartOrtable;
            gridReport.MainView.PopulateColumns();
        }

        public DataTable dtchartOrtable;
        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            string fileTypeName = "\\工艺历史数据\\Tube" + this.Tag.ToString();
            dtchartOrtable = help.AsposeCells(fileTypeName);
            txtFilePath.Text = Application.StartupPath + fileTypeName;
            chartTube.DataSource = dtchartOrtable;
            gridReport.DataSource = dtchartOrtable;
        }

        public DataTable ChartBingingData()
        {
            DataTable _testData = new DataTable();
            _testData.Columns.Add(new DataColumn("time", typeof(string)));
            _testData.Columns.Add(new DataColumn("Power", typeof(decimal)));
            _testData.Columns.Add(new DataColumn("ActulPower", typeof(decimal)));
            Random _rm = new Random();
            for (int i = 0; i < 24; i++)
            {
                DataRow _drNew = _testData.NewRow();
                _drNew["time"] = string.Format(DateTime.Now.ToString("yyyy-MM-dd") + " {0}:00", i);
                _drNew["Power"] = _rm.Next(150, 350);
                _drNew["ActulPower"] = _rm.Next(220, 245);
                _testData.Rows.Add(_drNew);
            }
            return _testData;
        }
        #endregion

        #region 调用方法
        /// <summary>
        /// 收缩与展开
        /// </summary>
        /// <param name="showHight">展开高度</param>
        /// <param name="hideHight">收缩高度</param>
        /// <param name="direction">方向（上下 或 左右）</param>
        private void Fold(int showHight, int hideHight, string direction, PanelControl pannelName, SimpleButton btnName)
        {
            if (direction == "上下")
            {
                if (pannelName.Height == hideHight)
                {
                    pannelName.Height = showHight;
                    btnName.Text = "︽";
                }
                else
                {
                    pannelName.Height = hideHight;
                    btnName.Text = "︾";
                }
            }
            if (direction == "左右")
            {
                if (pannelName.Height == hideHight)
                {
                    pannelName.Height = showHight;
                    btnName.Text = "<<";
                }
                else
                {
                    pannelName.Height = hideHight;
                    btnName.Text = ">>";
                }
            }
        }

        #endregion
    }

}









