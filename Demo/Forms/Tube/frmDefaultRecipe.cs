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
using System.IO;

namespace Demo.Forms.Tube
{
    public partial class frmDefaultRecipe : DevExpress.XtraEditors.XtraForm
    {
        public frmDefaultRecipe()
        {
            InitializeComponent();
        }
        string tubeID = "1";
        com.DataBaseModels.MyModus modus;
        public frmDefaultRecipe(string tubeId, com.DataBaseModels.MyModus mys)
        {
            InitializeComponent();
            tubeID = tubeId;
            modus = mys;
        }
        private void frmDefaultRecipe_Load(object sender, EventArgs e)
        {
            //获取文件名列表
            string path = Application.StartupPath + "\\recipe\\Tube" + tubeID;
            DirectoryInfo folder = new DirectoryInfo(path);
            foreach (FileInfo file in folder.GetFiles("*.csv"))
            {
                cmbDefaultRecipe.Properties.Items.Add(Path.GetFileNameWithoutExtension(file.FullName).ToString());
            }
        }
        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 确定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            //备份值
            modus.defaultRecipeName = cmbDefaultRecipe.Text;
            this.Close();
        }
    }
}