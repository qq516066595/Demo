using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.TubeServices
{
   public  class ModelHelperService
    {
        public static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private static ModelHelperService instance;

        private ModelHelperService() { }

        public static ModelHelperService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ModelHelperService();
                }
                return instance;
            }
        }





    }
}
