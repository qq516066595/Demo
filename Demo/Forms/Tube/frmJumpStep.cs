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
using Aspose.Cells;

namespace Demo.Forms.Tube
{
    public partial class frmJumpStep : DevExpress.XtraEditors.XtraForm
    {
        public frmJumpStep()
        {
            InitializeComponent();
        }
        public int index = 1;
        public frmJumpStep(int index, string currentRecipeName)
        {
            InitializeComponent();
            DataTable dt = new DataTable();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Application.StartupPath + "\\recipe\\Tube" + index.ToString();//注意这里写路径时要用c:\\而不是c:\
            openFileDialog.Filter = "CSV文件|*.csv"; // Excel文件 | *.xls; *.xlsx
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;

            //中文乱码
            Aspose.Cells.TxtLoadOptions lo = new Aspose.Cells.TxtLoadOptions();
            lo.Encoding = Encoding.Default;

            Aspose.Cells.Workbook workbook = new Aspose.Cells.Workbook(openFileDialog.InitialDirectory+"\\"+ currentRecipeName+".csv", lo);

            Cells cells = workbook.Worksheets[0].Cells;
            if (cells.Count > 0)
            {
                dt = cells.ExportDataTable(0, 0, cells.MaxDataRow + 1, 2, true);
                lookupStep.Properties.ValueMember = dt.Columns[0].ColumnName;
                lookupStep.Properties.DisplayMember = dt.Columns[1].ColumnName;
                lookupStep.Properties.DataSource = dt;
                lookupStep.Properties.NullText = "-- 请选择 --";
            }
            else
                MessageBox.Show("文件内容为空！");
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            com.DataBaseModels.PlcVar.Tube[com.DataBaseModels.frmID.Unit].giRecipe_ID = Convert.ToInt16(lookupStep.EditValue);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}