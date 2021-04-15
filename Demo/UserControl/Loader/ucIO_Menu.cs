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
using Demo.Forms.Loader;

namespace Demo.UserControl.Loader
{
    public partial class ucIO_Menu : DevExpress.XtraEditors.XtraUserControl
    {
        public event EventHandler InputClick;
        public event EventHandler OutputClick;
        public event EventHandler CommClick;
        public event EventHandler MenuEnter;

        public ucIO_Menu()
        {
            InitializeComponent();
        }

        private void picInput_Click(object sender, EventArgs e)
        {
            if(InputClick!=null)
            {
                InputClick(this, new EventArgs());
            }
        }

        private void picOutput_Click(object sender, EventArgs e)
        {
            if (OutputClick != null)
            {
                OutputClick(this, new EventArgs());
            }
        }

        private void picComm_Click(object sender, EventArgs e)
        {
            if (CommClick != null)
            {
                CommClick(this, new EventArgs());
            }
        }

        private void picMenu_MouseEnter(object sender, EventArgs e)
        {
            if (MenuEnter != null)
            {
                MenuEnter(this, new EventArgs());
            }
        }
    }
}
