using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.ToolHelper
{
    public class ToolHelper
    {



        //呼出键盘
      public  void Callkeyboard() {

            try
            {
               // Microsoft.VisualBasic.Interaction.Shell(System.Net.Mime.MediaTypeNames.Application.StartupPath + "\\softboard.exe", Microsoft.VisualBasic.AppWinStyle.NormalNoFocus, false, -1);
            }
            catch (Exception ex)
            {
              //  MessageBox.Show(ex.Message);
            }

        }




    }
}
