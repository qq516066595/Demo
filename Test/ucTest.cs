using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Test
{
    public partial class ucTest : UserControl
    {
        public ucTest()
        {
            InitializeComponent();
        }

        private void ucNavigationMenu1_ClickItemed(object sender, EventArgs e)
        {
            lblCurrentLocation.Text = "当前位置：" + ucNavigationMenu1.SelectItem.Text;
            //MessageBox.Show(ucNavigationMenu1.SelectItem.Text);
        }
    }
}
