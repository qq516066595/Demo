 
using com.LoaderServices;
using Demo.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.FunctionModels
{
   public  class ModelHelper
    {

        private static ModelHelper instance;
        private ModelHelper() { }
        public static ModelHelper Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ModelHelper();
                }
                return instance;
            }
        }



        public void UpdateConfigNameEdit(int tubeIndex) 
        {

            List<TubeDoConfViewModel> doModels = TubeViewModelFactory.Instance.GetDoConfViewModel("TubeConfPage");

            List<DoConf> doConfVOs = new List<DoConf>();
            for (int i = 0; i < doModels.Count; ++i)
            {
                DoConf doConf = new DoConf();
                doConf.DoName = doModels[i].DoName;
                doConf.NameIndex = doModels[i].NameIndex;
                doConf.DoAliaName = doModels[i].DoAliaName;
                doConf.DoShow = doModels[i].DoShow;
                doConfVOs.Add(doConf);
            }
            TubeDoService.Instance.PutDoConfInfo(tubeIndex, doConfVOs);


        }


    }
}
