using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.model
{
   public class TubeViewModelFactory
    {
        private static TubeViewModelFactory mInstance;


        private Dictionary<string, List<TubeDoConfViewModel>> doConfModelMap;


        private TubeViewModelFactory()
        {
            doConfModelMap = new Dictionary<string, List<TubeDoConfViewModel>>();


        } 
        public static TubeViewModelFactory Instance
        {
            get
            {
                if (mInstance == null)
                {
                    mInstance = new TubeViewModelFactory();
                }
                return mInstance;
            }

        }

        public List<TubeDoConfViewModel> GetDoConfViewModel(string viewName)
        {
            if (doConfModelMap.ContainsKey(viewName))
            {
                return doConfModelMap[viewName];
            }
            else
            {
                List<TubeDoConfViewModel> doConfModels = new List<TubeDoConfViewModel>();
                for (int i = 0; i < 32; ++i)
                {
                    doConfModels.Add(new TubeDoConfViewModel(i + 1));
                }
                doConfModelMap.Add(viewName, doConfModels);
                return doConfModels;
            }
        }



    }
}
