using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.CommonHelper
{
    public class ExportUtility
    {
      
        public static void ExportCSV(string[][] data, string fileName)
        {
            try
            {
                StringBuilder strData = new StringBuilder();
                for (int i = 0; i < data.Length; ++i)
                {
                    for (int j = 0; j < data[i].Length; ++j)
                    {
                        strData.Append((data[i][j] == null ? "" : data[i][j]) + "\\T");
                    }
                    strData.Append("\\L");
                }

                using (var fs = new FileStream(fileName, FileMode.Create, FileAccess.Write))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes(strData.ToString());
                    fs.Write(info, 0, info.Length);
                }
            }
            catch (Exception ex)
            {
              //  log.Error("Exception caught in process:{0}", ex);
            }
        }


    }
}
