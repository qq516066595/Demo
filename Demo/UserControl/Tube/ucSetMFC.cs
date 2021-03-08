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
        Forms.Tube.TubeHelpClass help = new Forms.Tube.TubeHelpClass();
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

        private void ucSetMFC_Load(object sender, EventArgs e)
        {
            txtSetGasWarnDiff.Text = PlcVar.Tube[frmID.Unit].stMFC_Para[MFC_ID].rWarnDiff_Persent.ToString();
            txtSetGasAlmDiff.Text = PlcVar.Tube[frmID.Unit].stMFC_Para[MFC_ID].rAlmDiff_Persent.ToString();
            txtSetGasMaxRange.Text = PlcVar.Tube[frmID.Unit].stMFC_Para[MFC_ID].nMaxRange.ToString();
            help.SetbtnClickBackColor(btnSetGasShield, Color.LightCoral, PlcVar.Tube[frmID.Unit].stMFC_Para[MFC_ID].bShield);
        }
        private void txtSetGasWarnDiff_TextChanged(object sender, EventArgs e)
        {
            //stMFC_Para1.rWarnDiff_Persent = (float)Convert.ToDouble(txtSetGasWarnDiff.Text);
            //stMFC_Para.Add(stMFC_Para1);
            PlcVar.Tube[frmID.Unit].stMFC_Para[MFC_ID].rWarnDiff_Persent = (float)Convert.ToDouble(txtSetGasWarnDiff.Text);
        }
        private void txtSetGasAlmDiff_TextChanged(object sender, EventArgs e)
        {
            PlcVar.Tube[frmID.Unit].stMFC_Para[MFC_ID].rAlmDiff_Persent = (float)Convert.ToDouble(txtSetGasAlmDiff.Text);
        }

        private void txtSetGasMaxRange_TextChanged(object sender, EventArgs e)
        {
            PlcVar.Tube[frmID.Unit].stMFC_Para[MFC_ID].nMaxRange = (ushort)Convert.ToDouble(txtSetGasMaxRange.Text);
        }

        private void btnSetGasShield_Click(object sender, EventArgs e)
        {
            PlcVar.Tube[frmID.Unit].stMFC_Para[MFC_ID].bShield = !PlcVar.Tube[frmID.Unit].stMFC_Para[MFC_ID].bShield;
            help.SetbtnClickBackColor(btnSetGasShield, Color.LightCoral, PlcVar.Tube[frmID.Unit].stMFC_Para[MFC_ID].bShield);
        }
    }
}
