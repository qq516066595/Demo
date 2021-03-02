using DevExpress.XtraEditors;
using log4net;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Aspose.Cells;
using System.IO;
using System.Text;

/*
* namespace：Demo.Forms.Tube
* className：FormatHelpClass
* 
* Version：HMI_RPxx_V001_202012
* Author：hehf
* Date：2020/12/31 14:49:18
* Desc：存放所有需要数值转换的内容
* 
* Remarks：
*/
namespace Demo.Forms.Tube
{
    public class TubeHelpClass
    {

        public static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        #region 格式转换

        /// <summary>
        /// 将时间秒转换为分钟
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        public string timeFormatFloatToString(float time)
        {
            try
            {
                string newTime = ((float)time / 60).ToString() + " Min " + ((float)time % 60).ToString() + " s";
                return newTime;
            }
            catch (Exception e)
            {
                log.Error("秒转分钟", e);
                return "";
            }
        }
        public string timeFormatUshortToString(ushort time)
        {
            try
            {
                string newTime = ((ushort)time / 60).ToString() + " Min " + ((ushort)time % 60).ToString() + " s";
                return newTime;
            }
            catch (Exception e)
            {
                log.Error("秒转分钟", e);
                return "";
            }
        }

        /// <summary>
        /// 扩散配方名称转换：数字转文字
        /// </summary>
        /// <param name="eName">下标值</param>
        /// <returns></returns>
        public string KSrecipeNameFormatIntToString(int eName)
        {
            string stepName = "";
            switch (eName)
            {
                case 0:
                    stepName = "无";
                    break;
                case 1:
                    stepName = "开始";
                    break;
                case 2:
                    stepName = "进舟";
                    break;
                case 3:
                    stepName = "升温";
                    break;
                case 4:
                    stepName = "抽真空";
                    break;
                case 5:
                    stepName = "检漏";
                    break;
                case 6:
                    stepName = "恒温";
                    break;
                case 7:
                    stepName = "恒压";
                    break;
                case 8:
                    stepName = "预沉积";
                    break;
                case 9:
                    stepName = "沉积";
                    break;
                case 10:
                    stepName = "抽空";
                    break;
                case 11:
                    stepName = "降温";
                    break;
                case 12:
                    stepName = "破真空";
                    break;
                case 13:
                    stepName = "等待";
                    break;
                case 14:
                    stepName = "出舟";
                    break;
                case 15:
                    stepName = "清洗";
                    break;
                case 16:
                    stepName = "结束";
                    break;
                default:
                    stepName = "无";
                    break;
            }
            return stepName;
        }

        /// <summary>
        /// 扩散配方名称转换：文字转数字
        /// </summary>
        /// <param name="recipeName">步名称</param>
        /// <returns></returns>
        public int recipeNameFormatStringToInt(string stepName)
        {
            int eName = 0;
            switch (stepName)
            {
                case "无":
                    eName = 0;
                    break;
                case "开始":
                    eName = 1;
                    break;
                case "进舟":
                    eName = 2;
                    break;
                case "升温":
                    eName = 3;
                    break;
                case "抽真空":
                    eName = 4;
                    break;
                case "检漏":
                    eName = 5;
                    break;
                case "恒温":
                    eName = 6;
                    break;
                case "恒压":
                    eName = 7;
                    break;
                case "预沉积":
                    eName = 8;
                    break;
                case "沉积":
                    eName = 9;
                    break;
                case "抽空":
                    eName = 10;
                    break;
                case "降温":
                    eName = 11;
                    break;
                case "破真空":
                    eName = 12;
                    break;
                case "等待":
                    eName = 13;
                    break;
                case "出舟":
                    eName = 14;
                    break;
                case "清洗":
                    eName = 15;
                    break;
                case "结束":
                    eName = 16;
                    break;
                default:
                    eName = 0;
                    break;
            }
            return eName;
        }

        /// <summary>
        /// PE配方名称转换:数字转文字
        /// </summary>
        /// <param name="eName"></param>
        /// <returns></returns>
        public string PErecipeNameFormatIntToString(int eName)
        {
            string stepName = "";
            return stepName;
        }

        /// <summary>
        /// PE配方名称转换：文字转数字
        /// </summary>
        /// <param name="eName"></param>
        /// <returns></returns>
        public int PErecipeNameFormatStringToInt(string stepName)
        {
            int eName = 0;
            return eName;
        }

        /// <summary>
        /// 舟状态名称转换：数字转文字
        /// </summary>
        /// <param name="iboatState"></param>
        /// <returns></returns>
        public string boatStateFormatIntToString(int iboatState)
        {
            string sboatState = "";
            switch (iboatState)
            {
                case 0:
                    sboatState = " -- ";
                    break;
                case 1:
                    sboatState = "无舟";
                    break;
                case 2:
                    sboatState = "空舟";
                    break;
                case 3:
                    sboatState = "未工艺舟";
                    break;
                case 4:
                    sboatState = "已工艺舟";
                    break;
                case 5:
                    sboatState = "异常舟";
                    break;
                case 6:
                    sboatState = "实验舟";
                    break;
                case 7:
                    sboatState = "空桨饱和";
                    break;
                case 8:
                    sboatState = "饱和完成";
                    break;
                case 9:
                    sboatState = "正在工艺";
                    break;
                case 10:
                    sboatState = "待清洗舟";
                    break;
                default:
                    sboatState = " -- ";
                    break;
            }
            return sboatState;
        }

        /// <summary>
        /// 舟状态名称转换：文字转数字
        /// </summary>
        /// <param name="iboatState"></param>
        /// <returns></returns>
        public int boatStateFormatStringToInt(string sboatState)
        {
            int iboatState = 0;
            switch (sboatState)
            {
                case " -- ":
                    iboatState = 0;
                    break;
                case "无舟":
                    iboatState = 1;
                    break;
                case "空舟":
                    iboatState = 2;
                    break;
                case "未工艺舟":
                    iboatState = 3;
                    break;
                case "已工艺舟":
                    iboatState = 4;
                    break;
                case "异常舟":
                    iboatState = 5;
                    break;
                case "实验舟":
                    iboatState = 6;
                    break;
                case "空桨饱和":
                    iboatState = 7;
                    break;
                case "饱和完成":
                    iboatState = 8;
                    break;
                case "正在工艺":
                    iboatState = 9;
                    break;
                case "待清洗舟":
                    iboatState = 10;
                    break;
                default:
                    iboatState = 0;
                    break;
            }
            return iboatState;
        }

        /// <summary>
        /// 系统操作模式转换
        /// </summary>
        /// <param name="imode"></param>
        /// <returns></returns>
        public string imodeFormatIntToString(int imode)
        {
            string smode = "";
            switch (imode)
            {
                case 0:
                    smode = "未联机";
                    break;
                case 1:
                    smode = "手动模式";
                    break;
                case 2:
                    smode = "待机模式";
                    break;
                case 3:
                    smode = "运行模式";
                    break;
                case 4:
                    smode = "暂停模式";
                    break;
                case 5:
                    smode = "故障模式";
                    break;
                default:
                    break;
            }
            return smode;
        }

        #endregion

        #region 按钮文本颜色变化
        /// <summary>
        /// 操作按钮背景色变化
        /// </summary>
        /// <param name="button">按钮</param>
        /// <param name="color">颜色</param>
        /// <param name="btnValue">变化值</param>
        public void SetbtnClickBackColor(SimpleButton button, Color color, bool btnValue)
        {
            button.Appearance.Options.UseBackColor = true;

            if (btnValue)
            {
                button.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                button.BackColor = color;
            }
            else
            {
                button.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
                button.BackColor = Color.Transparent;
            }
        }
        #endregion

        #region Aspose.Cells方式
        /// <summary>
        /// 本机无需安装Microsoft Excel
        /// 1、将Excel文件数据(多个sheet页分为不同的表)导入到DataSet临时表中
        /// 2、解析Excel表格列和行的格式
        /// </summary>
        /// <param name="fileTypeName">文件类型名称：如recipe、report、chart</param>
        /// <returns>DataSet</returns>
        public static string fileName = string.Empty;
        public DataTable AsposeCells(string fileTypeName)
        {
            DataTable dt = new DataTable();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Application.StartupPath + fileTypeName;//注意这里写路径时要用c:\\而不是c:\
            openFileDialog.Filter = "CSV文件|*.csv"; // Excel文件 | *.xls; *.xlsx
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //中文乱码
                Aspose.Cells.TxtLoadOptions lo = new TxtLoadOptions();
                lo.Encoding = Encoding.Default;

                fileName = openFileDialog.FileName;
                Workbook workbook = new Workbook(fileName, lo);

                Cells cells = workbook.Worksheets[0].Cells;
                //DataTable dataTable = cells.ExportDataTable(1, 0, cells.MaxDataRow, cells.MaxColumn);//没有列名
                if (cells.Count >0 )
                    dt = cells.ExportDataTable(0, 0, cells.MaxDataRow + 1, cells.MaxColumn + 1, true);//有列名
                else
                    MessageBox.Show("文件内容为空！");
            }
            else
            {
                MessageBox.Show("导入失败！");
            }
            return dt;
        }

        /// <summary>
        /// 导出单个表格为不同文件格式
        /// </summary>
        /// <param name="gridView"></param>
        /// <param name="reportName"></param>
        /// <param name="fileTypeName">文件类型名称：如recipe、report、chart</param>
        /// <param name="fullFileName"></param>
        public void ExportGridToFile(DevExpress.XtraGrid.Views.Base.BaseView gridView, string reportName, string fileTypeName, string fullFileName = null)
        {
            //string fileName = string.Empty;
            if (string.IsNullOrEmpty(fullFileName))
            {
                System.Windows.Forms.SaveFileDialog dlg = new System.Windows.Forms.SaveFileDialog();
                dlg.DefaultExt = ".csv";//xls
                dlg.FileName = reportName;
                dlg.AddExtension = true;
                dlg.InitialDirectory = Application.StartupPath + fileTypeName;//注意这里写路径时要用c:\\而不是c:\
                dlg.Filter = "CSV文件(*.csv)|*.csv|Excel2000-2003(*.xls)|*.xls|Excel2007以上(*.xlsx)|*.xlsx|PDF文件(*.pdf)|*.pdf|网页文件(*.html)|*.html|RTF文件(*.rtf)|*.rtf|文本文件(*.txt)|*.txt";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    fileName = dlg.FileName;
                }
                else
                {
                    return;
                }
            }
            //if (fileName == string.Empty)
            //{
            //    return;
            //}
            string extFileName = System.IO.Path.GetExtension(fileName).ToUpper();
            switch (extFileName)
            {
                case ".XLSX":
                    gridView.ExportToXlsx(fileName);
                    break;
                case ".PDF":
                    gridView.ExportToPdf(fileName);
                    break;
                case ".HTML":
                    gridView.ExportToHtml(fileName);
                    break;
                case ".RTF":
                    gridView.ExportToRtf(fileName);
                    break;
                case ".TXT":
                    gridView.ExportToText(fileName);
                    break;
                case ".CSV":
                    gridView.ExportToCsv(fileName);
                    break;
                default:
                    gridView.ExportToXls(fileName);
                    break;
            }
            if (DevExpress.XtraEditors.XtraMessageBox.Show("保存成功，是否打开文件？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                System.Diagnostics.Process.Start(fileName);//打开指定路径下的文件
        }
        #endregion

        #region 二进制序列化与反序列化
        /// <summary>
        /// 将Int32转化成字节数组加入字节流
        /// </summary>
        /// <param name="num">要转化的Int32</param>
        public byte[] SerializeObject(object obj)
        {
            if (obj == null)
                return null;
            //内存实例
            MemoryStream ms = new MemoryStream();
            //创建序列化的实例
            System.Runtime.Serialization.Formatters.Binary.BinaryFormatter formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            formatter.Serialize(ms, obj);//序列化对象，写入ms流中  
            byte[] bytes = ms.GetBuffer();
            return bytes;
        }
        public T DeserializeObject<T>(byte[] bytes)
        {
            T obj = default;//C# 7.0 中不支持功能“默认文本”。请使用 7.1 或更高的语言版本。Demo右键属性-->生成-->高级-->常规-->语言版本-->选7.1及以上的版本
            if (bytes == null)
                return obj;
            //利用传来的byte[]创建一个内存流
            MemoryStream ms = new MemoryStream(bytes);
            ms.Position = 0;
            System.Runtime.Serialization.Formatters.Binary.BinaryFormatter formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            obj = (T)formatter.Deserialize(ms);//把内存流反序列成对象  
            ms.Close();
            return obj;
        }
        #endregion

    }
    public static class Common
    {
        #region 等待窗体
        private static DevExpress.XtraSplashScreen.SplashScreenManager splashScreen;
        public static void ShowWait(this XtraForm form, string caption = "请等待", string description = "下载中...")
        {
            splashScreen = new DevExpress.XtraSplashScreen.SplashScreenManager(form, typeof(frmWaitForm), true, true);
            splashScreen.ShowWaitForm();
            splashScreen.SetWaitFormCaption(caption);
            splashScreen.SetWaitFormDescription(description);
        }

        public static void ShowWait<T>(this XtraForm form, string caption = "请等待", string description = "下载中...")
        {
            //打开等待窗体
            splashScreen = new DevExpress.XtraSplashScreen.SplashScreenManager(form, typeof(frmWaitForm), true, true);
            splashScreen.ShowWaitForm();
            splashScreen.SetWaitFormCaption(caption);
            splashScreen.SetWaitFormDescription(description);

            Type type = typeof(T);//检测类型
            XtraForm f = (XtraForm)Activator.CreateInstance(type);//new
            f.ShowDialog();
            splashScreen.CloseWaitForm();
        }

        public static void CloseWait(this XtraForm form)
        {
            splashScreen.CloseWaitForm();
        }

        #endregion

        #region 历史曲线
        /// <summary>
        /// 创建Series
        /// </summary>
        /// <param name="chat">ChartControl</param>
        /// <param name="seriesName">Series名字『诸如：理论电量』</param>
        /// <param name="seriesType">seriesType『枚举』</param>
        /// <param name="dataSource">数据源</param>
        /// <param name="xBindName">ChartControl的X轴绑定</param>
        /// <param name="yBindName">ChartControl的Y轴绑定</param>
        /// <param name="createSeriesRule">Series自定义『委托』</param>
        public static void CreateSeries(this DevExpress.XtraCharts.ChartControl chart, string seriesName, DevExpress.XtraCharts.ViewType seriesType, object dataSource, string xBindName, string yBindName, Action<DevExpress.XtraCharts.Series> createSeriesRule)
        {
            if (chart == null)
                throw new ArgumentNullException("chat");
            if (string.IsNullOrEmpty(seriesName))
                throw new ArgumentNullException("seriesType");
            if (string.IsNullOrEmpty(xBindName))
                throw new ArgumentNullException("xBindName");
            if (string.IsNullOrEmpty(yBindName))
                throw new ArgumentNullException("yBindName");

            DevExpress.XtraCharts.Series _series = new DevExpress.XtraCharts.Series(seriesName, seriesType);
            _series.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative;
            _series.ArgumentDataMember = xBindName;
            _series.ValueDataMembers[0] = yBindName;
            
            _series.DataSource = dataSource;
            if (createSeriesRule != null)
                createSeriesRule(_series);
            chart.Series.Add(_series);
        }
        #endregion
    }

    public static class FileHelp
    {
        #region 数据备份与还原
        /// <summary>
        /// 文件备份
        /// </summary>
        /// <param name="Content"></param>
        /// <param name="FilePath"></param>
        public static void FileWrite(string Content,string FilePath)
        {
            SaveFileDialog file = new SaveFileDialog();//定义新的文件保存位置控件
            file.Filter = "txt文件(*.txt)|*.txt";//设置文件后缀的过滤
            FileStream aFile = new FileStream(FilePath, FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
            StreamWriter sw = new StreamWriter(aFile);

            sw.Write(Content);  //写入文件中
            sw.Flush();//清理缓冲区
            sw.Close();//关闭文件
        }

        public static string FileRead(string FilePath)
        {
            string Content = "";
            OpenFileDialog ReadAddr = new OpenFileDialog();
            ReadAddr.Filter = "文本文件.txt|*.txt";
            ReadAddr.FileName = FilePath;
            if (ReadAddr.FileName == "") return null;//如果地址为空，直接退出

            if (!File.Exists(ReadAddr.FileName))//验证所选文件是否存在
            {
                MessageBox.Show("文件不存在");
                return null;
            }
            StreamReader sr = new StreamReader(ReadAddr.FileName, Encoding.Default);
            string content;
            while ((content = sr.ReadLine()) != null)
            {
                //Content += content.ToString();
                Content = content.ToString();
            }
            sr.Close();
            return Content;
        }
        #endregion
    }

}
