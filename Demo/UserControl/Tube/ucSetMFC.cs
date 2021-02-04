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
namespace Demo.UserControl.Tube
{
    public partial class ucSetMFC : DevExpress.XtraEditors.XtraUserControl
    {
        public ucSetMFC()
        {
            InitializeComponent();
        }
        //public List<PlcModels.MFC_Para> stMFC_Para
        // {
        //     get { return stMFC_Para; }
        //     set { stMFC_Para = value; }
        // }
        public int MFC_ID { get; set; }
        //PlcModels.MFC_Para stMFC_Para1 = new PlcModels.MFC_Para();
        private void txtSetGasWarnDiff_TextChanged(object sender, EventArgs e)
        {
            //stMFC_Para1.rWarnDiff_Persent = (float)Convert.ToDouble(txtSetGasWarnDiff.Text);
            //stMFC_Para.Add(stMFC_Para1);
            PlcVar.Tube[Global.TubeID].stMFC_Para[MFC_ID].rAlmDiff_Persent = (float)Convert.ToDouble(txtSetGasWarnDiff.Text);
        }
    }    
}
