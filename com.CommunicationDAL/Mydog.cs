using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.CommunicationDAL
{
    [StandardModule]
    public sealed class Mydog
    {
        public static string PassWord_ = "";

        internal static bool IsPasswordWrong()
        {
            return string.Compare(Mydog.PassWord_, "dog") != 0;
        }

        internal static bool IsPasswordWrong(string pass)
        {
            return string.Compare(pass, "dog") != 0;
        }
    }
}
