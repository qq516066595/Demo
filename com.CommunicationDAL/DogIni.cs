using Microsoft.VisualBasic;
using System.Runtime.InteropServices;
using System.Text;

namespace com.CommunicationDAL
{
    public class DogIni
    {
        public string FileName;

        public string Section;

        [DllImport("kernel32")]
        private static extern int WritePrivateProfileString(string section, string key, string val, string filePath);

        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

        public DogIni(string File_Name)
        {
            this.FileName = File_Name;
        }

        public DogIni()
        {
        }

        public string ReadItem(string strSection, string strKey)
        {
            StringBuilder stringBuilder = new StringBuilder(1024);
            long num = (long)DogIni.GetPrivateProfileString(strSection, strKey, null, stringBuilder, 1024, this.FileName);
            return stringBuilder.ToString();
        }

        public string ReadItem(string strKey)
        {
            StringBuilder stringBuilder = new StringBuilder(1024);
            long num = (long)DogIni.GetPrivateProfileString(this.Section, strKey, null, stringBuilder, 1024, this.FileName);
            return stringBuilder.ToString();
        }

        public void WriteItem(string strSection, string strKey, string value)
        {
            string val = value + "\0";
            long num = (long)DogIni.WritePrivateProfileString(strSection, strKey, val, this.FileName);
            if (num == 0L)
            {
                Information.Err().Raise(532, null, "INI file write error!", null, null);
            }
        }

        public void WriteItem(string strKey, string value)
        {
            string val = value + "\0";
            long num = (long)DogIni.WritePrivateProfileString(this.Section, strKey, val, this.FileName);
            if (num == 0L)
            {
                Information.Err().Raise(532, null, "INI file write error!", null, null);
            }
        }

        public void DelKey(string strSection, string strKey)
        {
            string val = "\0";
            long num = (long)DogIni.WritePrivateProfileString(strSection, strKey, val, this.FileName);
            if (num == 0L)
            {
                Information.Err().Raise(532, null, "INI file write error!", null, null);
            }
        }


    }
}
