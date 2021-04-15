using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Test.View.Tube
{
    public partial class UCZone : UserControl
    {
        public UCZone()
        {
            InitializeComponent();
        }

        private void lblOnHeating_Click(object sender, EventArgs e)
        {
            new FrmHeating().ShowDialog(this);
        }

        private void UCZone_Load(object sender, EventArgs e)
        {

        }
    }
}
