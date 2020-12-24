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

namespace Demo.Forms.Tube
{
    public partial class frmHeating : DevExpress.XtraEditors.XtraForm
    {
      public  int frmIndex;

        public frmHeating()
        {
            InitializeComponent();
        }

        private void frmHeating_Load(object sender, EventArgs e)
        {
            labelControl1.Text = frmIndex.ToString();
        }
    }
}