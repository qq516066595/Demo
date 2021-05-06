using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.VisualBasic;
using com.DataBaseModels;

namespace Test.View.Tube
{
    public partial class UCRecipe : UserControl
    {
        public UCRecipe()
        {
            InitializeComponent();
        }
        public int Mynum;
        private string Path;
        private double[] Range = new double[30];
        private bool[] Ve = new bool[24]; //阀的状态

        Common.TubeHelpClass help = new Common.TubeHelpClass();
        Button btn = new Button();
        private void 设置工艺参数_Load(object sender, System.EventArgs e)
        {
            this.Text = "工艺编辑";
            名字.Text = "";// "炉管-" + Mynum.ToString();
            GridFormat();
            ValveGroup.Visible = false;
            AddandSub.Visible = true;

            string iniPath = Application.StartupPath + "\\工艺\\";
            if (Microsoft.VisualBasic.FileSystem.Dir(iniPath, Microsoft.VisualBasic.Constants.vbDirectory) == "")
            {
                System.IO.Directory.CreateDirectory(iniPath);
            }
            if (Microsoft.VisualBasic.FileSystem.Dir(iniPath + "1", Microsoft.VisualBasic.Constants.vbDirectory) == "")
            {
                System.IO.Directory.CreateDirectory(iniPath + "1");
            }
            if (Microsoft.VisualBasic.FileSystem.Dir(iniPath + "2", Microsoft.VisualBasic.Constants.vbDirectory) == "")
            {
                System.IO.Directory.CreateDirectory(iniPath + "2");
            }
            if (Microsoft.VisualBasic.FileSystem.Dir(iniPath + "3", Microsoft.VisualBasic.Constants.vbDirectory) == "")
            {
                System.IO.Directory.CreateDirectory(iniPath + "3");
            }
            if (Microsoft.VisualBasic.FileSystem.Dir(iniPath + "4", Microsoft.VisualBasic.Constants.vbDirectory) == "")
            {
                System.IO.Directory.CreateDirectory(iniPath + "4");
            }
            if (Microsoft.VisualBasic.FileSystem.Dir(iniPath + "5", Microsoft.VisualBasic.Constants.vbDirectory) == "")
            {
                System.IO.Directory.CreateDirectory(iniPath + "5");
            }

            string list = "";
            string p = null;
            MyModu.Config.Section = "信息表";

            for (int i = 0; i <= 23; i++)
            {
                p = MyModu.Config.ReadItem(i.ToString());
                if (p.Length > 0)
                {
                    list = list + "|" + p;
                }
            }
            FG.Cols[1].ComboList = list;

            for (int i = 1; i < FG.Cols.Count; i++)
            {
                FG.Cols[i].AllowSorting = false;
                FG.Cols[i].AllowEditing = true;
            }

            Range[0] = 0; //步号
            Range[1] = 0; //步名称
            Range[2] = 0; //步时间

            Range[3] = 1100; //温区1
            Range[4] = 1100; //温区2
            Range[5] = 1100; //温区3
            Range[6] = 1100; //温区4
            Range[7] = 1100; //温区5
            Range[8] = 1100; //温区6
            Range[9] = 1100; //温区7
            Range[10] = 1100; //温区8
            Range[11] = 0; //斜率
            Range[12] = 0; //压力
            Range[13] = 0; //漏率
            Range[14] = 0; //阀门
            Range[15] = 10000;//MFC1
            Range[16] = 10000;//MFC2
            Range[17] = 10000;//MFC3
            Range[18] = 10000;//MFC4
            Range[19] = 10000;//MFC5
            Range[20] = 10000;//MFC6
            Range[21] = 10000;//MFC7
            Range[22] = 10000;//MFC8
            Range[23] = 10000;//MFC9
            Range[24] = 10000;//MFC10
            Range[25] = 10000;//MFC11
            Range[26] = 10000;//MFC12
            Range[27] = 0;//温度监控
            Range[28] = 0;//流量监控
            Range[29] = 0;//压力监控

            //if (MyModu.PLC[Mynum].PortOpenState)
            //{
            //    try
            //    {
            //        Range[9] = MyModu.PLC[Mynum].Dread16(160); //gas
            //        Range[10] = MyModu.PLC[Mynum].Dread16(161); //gas
            //        Range[11] = MyModu.PLC[Mynum].Dread16(162); //gas
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //}
            //else
            //{
            //    Range[9] = Microsoft.VisualBasic.Conversion.Val(MyModu.Config.ReadItem("MFC量程" + Mynum.ToString(), 0.ToString())); //gas
            //    Range[10] = Microsoft.VisualBasic.Conversion.Val(MyModu.Config.ReadItem("MFC量程" + Mynum.ToString(), 1.ToString())); //gas
            //    Range[11] = Microsoft.VisualBasic.Conversion.Val(MyModu.Config.ReadItem("MFC量程" + Mynum.ToString(), 2.ToString())); //gas
            //}

        }

        private void GridFormat()
        {
            FG.Rows.Count = 41;
            for (int i = 1; i <= 40; i++)
            {
                FG[i, 0] = i.ToString();
            }
        }

        private void button9_Click(object sender, System.EventArgs e)
        {

            //Debug.Print("Row,Col:" & FG.Row & "," & FG.Col)

            if (FG.Row >= 1 && FG.Col >= 3 && FG.Col <= 15 && FG.Col != 16)
            {
                ToolStripButton bt = (ToolStripButton)sender;
                double value = Microsoft.VisualBasic.Conversion.Val(bt.Text);
                double value2 = Microsoft.VisualBasic.Conversion.Val(FG[FG.Row, FG.Col]);
                double value3 = value2 + value;

                //Debug.Print("Value3:" & value3)
                //Debug.Print("Range:" & Range(FG.Col))

                if (value3 > Range[FG.Col])
                {
                    FG[FG.Row, FG.Col] = Range[FG.Col];
                }
                else if (value3 < 0)
                {
                    FG[FG.Row, FG.Col] = 0;
                }
                else
                {
                    FG[FG.Row, FG.Col] = value3;
                }
            }
            else if (FG.Col == 16)
            {
                ToolStripButton bt = (ToolStripButton)sender;
                if (bt == button6)
                {
                    FG[FG.Row, FG.Col] = "进炉";
                }
                else if (bt == button3)
                {
                    FG[FG.Row, FG.Col] = "出炉";
                }

            }


        }

        private void button10_Click(object sender, System.EventArgs e)
        {
            if (FG.Row >= 1 && FG.Col >= 2 && FG.Col != 16)
            {
                FG[FG.Row, FG.Col] = "0";
            }
            else if (FG.Col == 16)
            {
                FG[FG.Row, FG.Col] = "停";
            }
        }

        private void 参数配置_Click(object sender, System.EventArgs e)
        {
            //信息表 n = new 信息表();

            //n.ShowDialog();

            string list = "";
            string p = null;
            MyModu.Config.Section = "信息表";

            for (int i = 0; i <= 23; i++)
            {
                p = MyModu.Config.ReadItem(i.ToString());
                if (p.Length > 0)
                {
                    list = list + "|" + p;
                }
            }
            FG.Cols[1].ComboList = list;
        }


        private void 下载_Click(object sender, System.EventArgs e)
        {
            try
            {
                int i = 0;
                double j = 0;
                string str = "";

                if (MessageBox.Show("确定要下载此工艺文件吗？", this.Text, MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                {
                    return;
                }


                //for (i = 1; i <= 30; i++)
                //{

                //    MyModu.PLC[Mynum].Dwrite16(516 + i * 20, (short)(BinToDec(Convert.ToString(FG[i, 2])))); //阀门

                //    j = Conversion.Val(FG[i, 3]); //时间
                //    MyModu.PLC[Mynum].Dwrite32(500 + i * 20, (int)j);

                //    j = Conversion.Val(FG[i, 4]) * 10; //温度
                //    MyModu.PLC[Mynum].Dwrite16(503 + i * 20, (short)j);

                //    j = Conversion.Val(FG[i, 5]) * 10; //温度
                //    MyModu.PLC[Mynum].Dwrite16(504 + i * 20, (short)j);


                //    j = Conversion.Val(FG[i, 6]) * 10; //温度
                //    MyModu.PLC[Mynum].Dwrite16(505 + i * 20, (short)j);


                //    j = Conversion.Val(FG[i, 7]) * 10; //温度
                //    MyModu.PLC[Mynum].Dwrite16(506 + i * 20, (short)j);


                //    j = Conversion.Val(FG[i, 8]) * 10; //温度
                //    MyModu.PLC[Mynum].Dwrite16(507 + i * 20, (short)j);
                //    //---------------------------------------------------------

                //    j = Conversion.Val(FG[i, 9]); //气体
                //    MyModu.PLC[Mynum].Dwrite16(510 + i * 20, (short)j);

                //    j = Conversion.Val(FG[i, 10]); //气体
                //    MyModu.PLC[Mynum].Dwrite16(511 + i * 20, (short)j);

                //    j = Conversion.Val(FG[i, 11]); //气体
                //    MyModu.PLC[Mynum].Dwrite16(512 + i * 20, (short)j);

                //    j = Conversion.Val(FG[i, 12]); //压力
                //    MyModu.PLC[Mynum].Dwrite16(509 + i * 20, (short)j);

                //    j = Conversion.Val(FG[i, 13]); //功率
                //    MyModu.PLC[Mynum].Dwrite16(514 + i * 20, (short)j);

                //    j = Conversion.Val(FG[i, 14]); //占空比分子
                //    MyModu.PLC[Mynum].Dwrite16(518 + i * 20, (short)j);

                //    j = Conversion.Val(FG[i, 15]); //占空比分母
                //    MyModu.PLC[Mynum].Dwrite16(519 + i * 20, (short)j);

                //    //--------------------------------------------------------------------------------

                //    str = Convert.ToString(FG[i, 16]);
                //    if (str == "进炉")
                //        j = 1;
                //    else if (str == "出炉")
                //        j = 2;
                //    else
                //        j = 0;
                //    MyModu.PLC[Mynum].Dwrite16(517 + i * 20, (short)j);//进出炉

                //    j = (Convert.ToString((FG[i, 17])) == "True") ? 1 : 0; //检漏
                //    MyModu.PLC[Mynum].Dwrite16(515 + i * 20, (short)j);

                //    j = (Convert.ToString((FG[i, 18])) == "True") ? 0 : 2;  //净化风机
                //    MyModu.PLC[Mynum].Dwrite16(502 + i * 20, (short)j);

                //    //j = (Convert.ToString((FG[i, 17])) == "True") ? 1 : 0; //吹扫
                //    //MyModu.PLC[Mynum].Dwrite16(509 + i * 20, (short)j);

                //}

                //j = 0;
                //for (int p = 1; p <= 30; p++)
                //{
                //    j = j + Conversion.Val(FG[p, 3]); //总时间/s
                //}
                //MyModu.Infor[Mynum].TotalTime = (int)j;
                //MyModu.Config.WriteItem(Mynum.ToString(), "totaltime", j.ToString());
                //MyModu.Infor[Mynum].RecName = System.IO.Path.GetFileNameWithoutExtension(Path);
                //MyModu.Config.WriteItem(Mynum.ToString(), "recname", MyModu.Infor[Mynum].RecName);
                //MyModu.Config.WriteItem(Mynum.ToString(), "path", Path);
                //---------------------------------------------------------------------
                Application.DoEvents();
                MessageBox.Show("Send Complete.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.DoEvents();

                LoadRec();

                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void LoadRec()
        {
            //MyModu.Infor[Mynum].RecName = MyModu.Config.ReadItem(Mynum.ToString(), "recname");
            //MyModu.Infor[Mynum].TotalTime = (int)Microsoft.VisualBasic.Conversion.Val(MyModu.Config.ReadItem(Mynum.ToString(), "totaltime"));
            //MyModu.Infor[Mynum].Product_Num = (long)Microsoft.VisualBasic.Conversion.Val(MyModu.Config.ReadItem(Mynum.ToString(), "ProdNum"));

            string path = MyModu.Config.ReadItem(Mynum.ToString(), "path");

            if (path.Length > 0)
            {
                MyModu.GongyiIni.FileName = path;
                for (int i = 1; i <= 40; i++)
                {
                    PlcVar.Tube[frmID.Unit].stRecipePara[i].eName = help.recipeNameFormatStringToInt(MyModu.GongyiIni.ReadItem(i.ToString(), "段名称"));
                    //MyModu.Infor[Mynum].POnOff_SV[i] = MyModu.GongyiIni.ReadItem(i.ToString(), "POn") + "/" + MyModu.GongyiIni.ReadItem(i.ToString(), "POnOff");
                    //MyModu.Infor[Mynum].StepTime[i] = MyModu.GongyiIni.ReadItem(i.ToString(), "时间/s");
                }
            }
        }

        public int BinToDec(string Bin) // 阀门换算
        {
            int c = 0;

            if (Bin.Length != 16)
            {
                return c;
            }
            for (int i = 1; i <= 16; i++)
            {
                c = (int)(int.Parse(Bin.Substring(i - 1, 1)) * Math.Pow(2, (i - 1))) + c;
            }
            return c;
        }

        private void 复制_Click(object sender, System.EventArgs e)
        {
            try
            {

                System.Windows.Forms.Clipboard.Clear();

                string s = "flag2";
                for (int i = 0; i < FG.Cols.Count; i++)
                {
                    s = s + Convert.ToString(FG[FG.Row, i]) + ";";
                    //s = s + FG[FG.Row, i].ToString() + ";";
                }
                System.Windows.Forms.Clipboard.SetText(s);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void 粘贴_Click(object sender, System.EventArgs e)
        {
            try
            {

                string s = System.Windows.Forms.Clipboard.GetText();
                if (s.Substring(0, 5) != "flag2")
                {
                    return;
                }
                s = s.Substring(5, s.Length - 5);
                string[] value = s.Split(';');
                if (value.GetUpperBound(0) < (FG.Cols.Count - 1)) //长度不匹配
                {
                    return;
                }
                int j = 0;
                for (j = 0; j < FG.Cols.Count; j++)
                {
                    FG[FG.Row, j] = value[j];
                }

                GridFormat();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void 全部删除_Click(object sender, System.EventArgs e)
        {
            FG.GetCellRange(1, 1, FG.Rows.Count - 1, FG.Cols.Count - 1).Clear(C1.Win.C1FlexGrid.ClearFlags.Content);
        }

        private void 删除步_Click(object sender, System.EventArgs e)
        {
            try
            {
                FG.RemoveItem(FG.Row);
                GridFormat();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void 打开_Click(object sender, System.EventArgs e)
        {
            try
            {
                全部删除_Click(全部删除, new EventArgs());
                FG.Row = 1;
                FG.Col = 1;

                OFD1.Filter = "Text Files|*.txt";
                OFD1.Title = "Open";
                OFD1.DefaultExt = "txt";
                OFD1.FileName = "";
                OFD1.InitialDirectory = Application.StartupPath + "\\工艺\\" + frmID.Unit.ToString();
                OFD1.ShowDialog();
                if (OFD1.FileName == "")
                {
                    return;
                }

                名字.Text = OFD1.FileName; //"炉管-" + Mynum.ToString() + "  Path:" + OFD1.FileName;
                Path = OFD1.FileName;
                MyModu.GongyiIni.FileName = Path;
                //FG.LoadExcel(Cdlg1Save.FileName, C1.Win.C1FlexGrid.FileFlags.IncludeFixedCells);

                int i = 0;
                int j = 0;

                for (i = 1; i < FG.Rows.Count; i++)
                {
                    for (j = 1; j < FG.Cols.Count; j++)
                    {
                        FG[i, j] = MyModu.GongyiIni.ReadItem(i.ToString(), (FG[0, j]).ToString()); //行号,列头,item
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void 保存_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (名字.Text == "")
                {
                    Cdlg1Save.Filter = "Text Files|*.txt";
                    Cdlg1Save.Title = "Save";
                    Cdlg1Save.DefaultExt = "txt";
                    Cdlg1Save.FileName = "";
                    Cdlg1Save.InitialDirectory = Application.StartupPath + "\\工艺\\" + frmID.Unit.ToString();
                    Cdlg1Save.ShowDialog();
                    if (Cdlg1Save.FileName == "")
                    {
                        return;
                    }

                    名字.Text = Cdlg1Save.FileName; //"炉管-" + Mynum.ToString() + "  Path:" + Cdlg1Save.FileName;
                    Path = Cdlg1Save.FileName;
                    MyModu.GongyiIni.FileName = Cdlg1Save.FileName;

                }
                else
                    MyModu.GongyiIni.FileName = 名字.Text;
                //FG.SaveExcel(Cdlg1Save.FileName, C1.Win.C1FlexGrid.FileFlags.IncludeFixedCells);

                int i = 0;
                int j = 0;

                for (i = 1; i < FG.Rows.Count; i++)
                {
                    for (j = 1; j < FG.Cols.Count; j++)
                    {

                        //MyModu.GongyiIni.WriteItem(i.ToString(), Convert.ToString(FG[0, j]), Convert.ToString(FG[i, j])); //行号,列头,item
                        MyModu.GongyiIni.WriteItem(i.ToString(), FG[0, j].ToString(), (Convert.ToInt16(FG[i, j])).ToString()); //行号,列头,item
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void 导出Excel_Click(object sender, System.EventArgs e)
        {
            try
            {
                Cdlg1Save.Filter = "Text Files|*.xls";
                Cdlg1Save.Title = "Save";
                Cdlg1Save.DefaultExt = "xls";
                Cdlg1Save.FileName = "";
                Cdlg1Save.InitialDirectory = Application.StartupPath + "\\工艺";
                Cdlg1Save.ShowDialog();
                if (Cdlg1Save.FileName == "")
                {
                    return;
                }

                FG.SaveGrid(Cdlg1Save.FileName, C1.Win.C1FlexGrid.FileFormatEnum.Excel, C1.Win.C1FlexGrid.FileFlags.IncludeFixedCells);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FG_Click(object sender, System.EventArgs e)
        {
            if (FG.Col == 14 && FG.Row > 0)
            {
                AddandSub.Visible = false;
                ValveGroup.Visible = true;

                if (FG[FG.Row, FG.Col] != null)
                {
                    MyModu.Gyedit = FG[FG.Row, FG.Col].ToString();
                }
                else
                {
                    MyModu.Gyedit = "";
                }

                //v0-v24
                if (MyModu.Gyedit.Length == 24)
                {
                    for (int i = 0; i <= 23; i++)
                    {
                        Ve[i] = Convert.ToBoolean(int.Parse(MyModu.Gyedit.Substring(i, 1))); //Valve
                                                                                             //Ve[i] = Convert.ToBoolean(MyModu.Gyedit.Substring(i, 1)); //Valve
                    }

                    Valve0.BackColor = (Ve[0]) ? Color.Lime : System.Drawing.SystemColors.Control;
                    Valve1.BackColor = (Ve[1]) ? Color.Lime : System.Drawing.SystemColors.Control;
                    Valve2.BackColor = (Ve[2]) ? Color.Lime : System.Drawing.SystemColors.Control;
                    Valve3.BackColor = (Ve[3]) ? Color.Lime : System.Drawing.SystemColors.Control;
                    Valve4.BackColor = (Ve[4]) ? Color.Lime : System.Drawing.SystemColors.Control;
                    Valve5.BackColor = (Ve[5]) ? Color.Lime : System.Drawing.SystemColors.Control;
                    Valve6.BackColor = (Ve[6]) ? Color.Lime : System.Drawing.SystemColors.Control;
                    Valve7.BackColor = (Ve[7]) ? Color.Lime : System.Drawing.SystemColors.Control;
                    Valve8.BackColor = (Ve[8]) ? Color.Lime : System.Drawing.SystemColors.Control;
                }
                else
                {
                    Valve0.BackColor = System.Drawing.SystemColors.Control;
                    Valve1.BackColor = System.Drawing.SystemColors.Control;
                    Valve2.BackColor = System.Drawing.SystemColors.Control;
                    Valve3.BackColor = System.Drawing.SystemColors.Control;
                    Valve4.BackColor = System.Drawing.SystemColors.Control;
                    Valve5.BackColor = System.Drawing.SystemColors.Control;
                    Valve6.BackColor = System.Drawing.SystemColors.Control;
                    Valve7.BackColor = System.Drawing.SystemColors.Control;
                    Valve8.BackColor = System.Drawing.SystemColors.Control;
                }

            }

            else if (FG.Col == 24 && FG.Row > 0)
            {
                button0.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = true;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = true;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
            }
            else
            {
                button0.Enabled = true;
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;
                ValveGroup.Visible = false;
                AddandSub.Visible = true;
            }

        }

        private void ValveOK_Click(object sender, System.EventArgs e)
        {
            Ve[0] = (Valve0.BackColor == Color.Lime) ? true : false;
            Ve[1] = (Valve1.BackColor == Color.Lime) ? true : false;
            Ve[2] = (Valve2.BackColor == Color.Lime) ? true : false;
            Ve[3] = (Valve3.BackColor == Color.Lime) ? true : false;
            Ve[4] = (Valve4.BackColor == Color.Lime) ? true : false;
            Ve[5] = (Valve5.BackColor == Color.Lime) ? true : false;
            Ve[6] = (Valve6.BackColor == Color.Lime) ? true : false;
            Ve[7] = (Valve7.BackColor == Color.Lime) ? true : false;
            Ve[8] = (Valve8.BackColor == Color.Lime) ? true : false;

            MyModu.Gyedit = "";
            for (int i = 0; i <= 23; i++)
            {
                MyModu.Gyedit = MyModu.Gyedit + ((Ve[i]) ? "1" : "0"); //Valve
            }

            FG[FG.Row, FG.Col] = MyModu.Gyedit;
            ValveOK.BackColor = System.Drawing.SystemColors.Control;

        }

        private void ValveGroup_ItemClicked(object sender, System.Windows.Forms.ToolStripItemClickedEventArgs e)
        {
            Color p = e.ClickedItem.BackColor;
            e.ClickedItem.BackColor = (p == Color.Lime) ? System.Drawing.SystemColors.Control : Color.Lime;
        }

        private void FG_CellChanged(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            if (FG.Row >= 1 && (FG.Col >= 3 && FG.Col <= 13) || (FG.Col >= 15 && FG.Col <= 26))
            {
                double value2 = Microsoft.VisualBasic.Conversion.Val(FG[FG.Row, FG.Col]);

                if (value2 > Range[FG.Col])
                {
                    FG[FG.Row, FG.Col] = Range[FG.Col];
                }
                else if (value2 < 0)
                {
                    FG[FG.Row, FG.Col] = 0;
                }
                else
                {
                    FG[FG.Row, FG.Col] = value2;
                }
            }
        }

        private void 插入步_Click(object sender, EventArgs e)
        {
            int rowsel = 0;
            if (FG.Row >= 1)
            {
                rowsel = FG.Row;
                FG.Rows.Insert(FG.Row);
                GridFormat();
                FG.Row = rowsel;

            }
        }

        private void 另存为_Click(object sender, EventArgs e)
        {
            try
            {
                Cdlg1Save.Filter = "Text Files|*.txt";
                Cdlg1Save.Title = "Save";
                Cdlg1Save.DefaultExt = "txt";
                Cdlg1Save.FileName = "";
                Cdlg1Save.InitialDirectory = Application.StartupPath + "\\工艺";
                Cdlg1Save.ShowDialog();
                if (Cdlg1Save.FileName == "")
                {
                    return;
                }

                名字.Text = Cdlg1Save.FileName;// "炉管-" + Mynum.ToString() + "  Path:" + Cdlg1Save.FileName;
                Path = Cdlg1Save.FileName;

                //FG.SaveGrid(Cdlg1Save.FileName, C1.Win.C1FlexGrid.FileFormatEnum.TextComma, C1.Win.C1FlexGrid.FileFlags.None, System.Text.Encoding.Unicode);

                MyModu.GongyiIni.FileName = Cdlg1Save.FileName;
                int i = 0;
                int j = 0;

                for (i = 1; i < FG.Rows.Count; i++)
                {
                    for (j = 1; j < FG.Cols.Count; j++)
                    {

                        MyModu.GongyiIni.WriteItem(i.ToString(), Convert.ToString(FG[0, j]), Convert.ToString(FG[i, j])); //行号,列头,item
                        MyModu.GongyiIni.WriteItem(i.ToString(), (FG[0, j]).ToString(), (Convert.ToInt16(FG[i, j])).ToString()); //行号,列头,item
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void 新建_Click(object sender, EventArgs e)
        {
            全部删除_Click(全部删除, new EventArgs());
            名字.Text = "";
        }

        private void 名字_Click(object sender, EventArgs e)
        {

        }

        private void Cdlg1Save_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void OFD1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
    internal static class MyModu
    {
        public static DogIni Config = new DogIni(Application.StartupPath + "\\config.ini"); //配置所有公共参数
        public static DogIni GongyiIni = new DogIni();
        public static string Gyedit;

    }
    public class DogIni
    {
        public string FileName;
        public string Section;

        [System.Runtime.InteropServices.DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

        [System.Runtime.InteropServices.DllImport("kernel32")]
        private static extern int WritePrivateProfileString(string section, string key, string val, string filePath);

        public DogIni(string File_Name)
        {
            this.FileName = File_Name;
        }
        public DogIni()
        {
        }

        public string ReadItem(string strSection, string strKey)
        {
            StringBuilder stringBuilder = new StringBuilder(1024);
            long num = (long)DogIni.GetPrivateProfileString(strSection, strKey, null, stringBuilder, 1024, this.FileName);
            return stringBuilder.ToString();
        }

        public string ReadItem(string strKey)
        {
            StringBuilder stringBuilder = new StringBuilder(1024);
            long num = (long)DogIni.GetPrivateProfileString(this.Section, strKey, null, stringBuilder, 1024, this.FileName);
            return stringBuilder.ToString();
        }

        public void WriteItem(string strSection, string strKey, string value)
        {
            string val = value + "\0";
            long num = (long)DogIni.WritePrivateProfileString(strSection, strKey, val, this.FileName);
            if (num == 0L)
            {
                Information.Err().Raise(532, null, "INI file write error!", null, null);
            }
        }

        public void WriteItem(string strKey, string value)
        {
            string val = value + "\0";
            long num = (long)DogIni.WritePrivateProfileString(this.Section, strKey, val, this.FileName);
            if (num == 0L)
            {
                Information.Err().Raise(532, null, "INI file write error!", null, null);
            }
        }

    }
}
