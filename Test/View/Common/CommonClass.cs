using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test.View.Common
{
    public class CommonClass
    {
        private int num;

        public int Num
        {
            get => num;
            set
            {
                if (num != value)
                {
                    num = value;
                    if (OnNumChanged != null)
                        OnNumChanged(this, null);
                }
            }
        }

        public event EventHandler OnNumChanged = null;
    }
}
