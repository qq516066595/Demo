using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;


namespace Demo.Forms.Loader
{
    class AssistTool
    {
       
    }
    class Button
    {
        public bool Btn
        {
            get;
            set;
        }

        public string Path1
        {
            get;
            set;
        }
        public string Path2
        {
            get;
            set;
        }

        public PictureEdit Pic
        {
            get;
            set;
        }
        public Button(bool button, string path1, string path2, PictureEdit pic)
        {
            this.Btn = button;
            this.Path1 = path1;
            this.Path2 = path2;
            this.Pic = pic;
        }

        public void Click()
        {
            Btn = !Btn;
            if (Btn)
            {
                Pic.Image = Image.FromFile(@Path1);

            }
            else
            {
                Pic.Image = Image.FromFile(Path2);
            }
        }
    }
}
