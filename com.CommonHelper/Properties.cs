using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.CommonHelper
{
    public class Properties
    {

        public static object locker = new object();

        private Dictionary<String, String> list;
        private String filename;
        //初始化文件
        public Properties(String file)
        {
            reload(file);
        }

        public String get(String field, String defValue)
        {
            return (get(field) == null) ? (defValue) : (get(field));
        }
        //获取键
        public String get(String field)
        {
            return (list.ContainsKey(field)) ? (list[field]) : (null);
        }

        public void set(String field, Object value)
        {
            if (!list.ContainsKey(field))
            {
                if (value != null)
                {
                    list.Add(field, value.ToString());
                }
            }
            else
            {
                if (value != null)
                {
                    list[field] = value.ToString();
                }
            }

        }

        public void Save()
        {
            try
            {
                Save(this.filename);
            }
            catch (Exception e)
            {
                //  log.Error("save file error");
            }
        }

        public void Save(String filename)
        {
            this.filename = filename;

            lock (locker)
            {
                System.IO.StreamWriter file = new System.IO.StreamWriter(filename);
                foreach (String prop in list.Keys.ToArray())
                {
                    if (!String.IsNullOrWhiteSpace(list[prop]))
                    {
                        string strValue = list[prop];
                        strValue = strValue.Replace("\n", "mk$10$");
                        file.WriteLine(prop + "=" + strValue);
                    }

                }

                file.Close();
            }

        }

        public void reload()
        {
            reload(this.filename);
        }

        public void reload(String filename)
        {
            this.filename = filename;
            list = new Dictionary<String, String>();

            if (System.IO.File.Exists(filename))
                loadFromFile(filename);
            else
            {
                System.IO.FileStream file = System.IO.File.Create(filename);
                file.Close();
            }
        }

        private void loadFromFile(String file)
        {
            lock (locker)
            {
                foreach (String line in System.IO.File.ReadAllLines(file))
                {
                    if ((!String.IsNullOrEmpty(line)) &&
                        (!line.StartsWith(";")) &&
                        (!line.StartsWith("#")) &&
                        (!line.StartsWith("'")) &&
                        (line.Contains('=')))
                    {
                        int index = line.IndexOf('=');
                        String key = line.Substring(0, index).Trim();
                        String value = line.Substring(index + 1).Trim();

                        if ((value.StartsWith("\"") && value.EndsWith("\"")) ||
                            (value.StartsWith("'") && value.EndsWith("'")))
                        {
                            value = value.Substring(1, value.Length - 2);
                        }

                        try
                        {
                            value = value.Replace("mk$10$", "\n");
                            //ignore dublicates
                            list.Add(key, value);
                        }
                        catch { }
                    }
                }
            }
        }
    }
}
