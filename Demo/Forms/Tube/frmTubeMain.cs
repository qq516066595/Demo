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
        TubeHelpClass help = new TubeHelpClass();
        public frmTubeMain()
        {
            InitializeComponent();

            lblZoneEx1.Text = this.Tag.ToString();
            this.gridRecipeView.InitNewRow += GridRecipeView_InitNewRow;
        }

        #region 主界面
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
        /// 温度内容绑定
        /// </summary>
        private void TempBindings(MyModus modus)
        {
            foreach (Control control in this.pcTempZone.Controls)
            {
                if (control is LabelControl)
                {
                    for (int i = 1; i <= 7; i++)
                    {
                        if (control.Name.Equals("lblZoneEx" + i.ToString(), StringComparison.CurrentCultureIgnoreCase))//外偶
                            ((LabelControl)control).Text = modus.StTempZoneArray[i].rExternal_Temp.ToString();
                        else if (control.Name.Equals("lblZoneIn" + i.ToString(), StringComparison.CurrentCultureIgnoreCase))//内偶
                            ((LabelControl)control).Text = modus.StTempZoneArray[i].rInternal_Temp.ToString();
                        else if (control.Name.Equals("lblZoneMV" + i.ToString(), StringComparison.CurrentCultureIgnoreCase))//功率
                            ((LabelControl)control).Text = modus.StTempZoneArray[i].rMV.ToString();
                        else if (control.Name.Equals("lblZoneSP" + i.ToString(), StringComparison.CurrentCultureIgnoreCase))//过渡
                            ((LabelControl)control).Text = modus.grTemp_SPArray[i].ToString();
                    }
                    //水冷
                    lblWaterCooling1.Text = modus.grCooling_PV1.ToString();
                    lblWaterCooling2.Text = modus.grCooling_PV2.ToString();
                }
                //设定值
                if (control is TextEdit)
                {
                    for (int i = 1; i < 7; i++)
                    {
                        if (control.Name.Equals("txtZoneSV" + i.ToString(), StringComparison.CurrentCultureIgnoreCase))//设定值
                            ((TextEdit)control).Text = modus.StTempZoneArray[i].rSet_Temp.ToString();
                    }
                }
            }
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
            mys.gbHMI_LeakCheck = true;
            help.SetbtnClickBackColor(btnHWCLeakCheck, Color.Lime, mys.gbHMI_LeakCheck);
        }
        public void HWCsDataBinding()
        {
            lblHWCTempPV.Text = mys.stHWCs_Ctrl.rActTemperature.ToString();//实际温度
            txtHWCTempSV.Text = mys.stHWCs_Ctrl.rSetTemperature.ToString();//设定温度
            lblHWCWeight.Text = mys.Comm_rHCSPV.ToString();//液位重量
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
        byte[] b1 = new byte[] { 1,2,3,4,5};
        private void picDownloadRecipe_Click(object sender, EventArgs e)
        {
            obj = 77;
            b1 = help.SerializeObject(obj);
            MessageBox.Show(b1.ToString());
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
            frmDefaultRecipe frmDeRec = new frmDefaultRecipe(this.Tag.ToString(),mys);
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
        /// <summary>
        /// 复选框多选
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void repositoryItemCheckEdit1_QueryCheckStateByValue(object sender, DevExpress.XtraEditors.Controls.QueryCheckStateByValueEventArgs e)
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

        #region 获取炉管号
        /// <summary>
        /// 将本窗体的tag值传递出去
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        MyModus myModus1 = new MyModus();
        MyModus myModus2 = new MyModus();
        MyModus myModus3 = new MyModus();
        MyModus myModus4 = new MyModus();
        MyModus myModus5 = new MyModus();
        MyModus mys = new MyModus();
        private void frmTubeMain_Load(object sender, EventArgs e)
        {
            //int a = (Int32)this.Tag;
            //if (a == 1)//炉管一
            //    gettag(1);
            //else if (a == 2)//炉管二
            //    gettag(2);
            //else if (a == 3)//炉管三
            //    gettag(3);
            //else if (a == 4)//炉管四
            //    gettag(4);
            //else if (a == 5)//炉管五
            //    gettag(5);


            //2020-12-29 hhf 测试使用；需写到委托事件中实时刷新数据
            //MyModus[] myModus = new MyModus[5];
            //MyModus mys = new MyModus();
            //int index = Convert.ToInt32(this.Tag) - 1;
            //myModus[index] = mys;
            myModus1.giRecipe_ID = 1;
            myModus2.giRecipe_ID = 2;
            myModus3.giRecipe_ID = 3;
            myModus4.giRecipe_ID = 4;
            myModus5.giRecipe_ID = 5;

            int index = Convert.ToInt32(this.Tag);
            if (index == 1)
                mys = myModus1;
            else if (index == 2)
                mys = myModus2;
            else if (index == 3)
                mys = myModus3;
            else if (index == 4)
                mys = myModus4;
            else if (index == 5)
                mys = myModus5;
            else
                return;

            myModus1.grTemp_SPArray[0] = 91;
            myModus1.grTemp_SPArray[1] = 92;
            myModus1.grTemp_SPArray[2] = 93;
            myModus1.grTemp_SPArray[3] = 94;
            myModus1.grTemp_SPArray[4] = 95;
            myModus1.grTemp_SPArray[5] = 96;
            myModus1.grTemp_SPArray[6] = 97;
            myModus1.StTempZoneArray[0].rMV = 11;
            myModus1.StTempZoneArray[0].rSet_Temp = 500;
            myModus1.StTempZoneArray[0].rExternal_Temp = 300;
            myModus1.StTempZoneArray[0].rInternal_Temp = 289.4F;

            //温区值绑定
            TempBindings(mys);
            //工艺信息
            ucRecipeInfo1.ucRecipe(mys);
            //轴信息
            ucAxisX1.ucAxis(mys);
            //配方数据源绑定
            addGridBindings();
            repositoryItemButtonEdit1.Click += RepositoryItemButtonEdit1_Click;
            repositoryItemCheckEdit1.QueryCheckStateByValue += new DevExpress.XtraEditors.Controls.QueryCheckStateByValueEventHandler(repositoryItemCheckEdit1_QueryCheckStateByValue);
        }


        #endregion

    }
}