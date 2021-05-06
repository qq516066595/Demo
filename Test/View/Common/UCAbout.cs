using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using com.DataBaseModels;

namespace Test.View.Common
{
    public partial class UCAbout : UserControl
    {
        public UCAbout()
        {
            InitializeComponent();
        }

        private void txtValue_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            int num = Convert.ToInt16(System.Text.RegularExpressions.Regex.Replace(txt.Name, @"[^0-9]+", "0")) - 1;
            if (txt.Name.Contains("txtVerison"))
                PlcVar.Tube[frmID.Unit].gsVersion = txt.Text;
            else if (txt.Name.Contains("txtSerial"))
                PlcVar.Tube[frmID.Unit].giLicense_Code = Convert.ToInt32(txt.Text);
            else if (txt.Name.Contains("txtRegister"))
                PlcVar.Tube[frmID.Unit].giSN = Convert.ToInt32(txt.Text);
        }

    }
}
