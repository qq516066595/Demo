using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.DataBaseModels.Tube.recipe
{
  public  class TubeRecipeModifyViewModel : Demo.ViewModel
    {
        private int    zID;
        private string zStepID;
        private string zDescription;
        private string zOldValue;
        private string zNewValue;

        public TubeRecipeModifyViewModel(int value)
        {
            zID = value;
        }
        public TubeRecipeModifyViewModel()
        {
        }
        public int ID
        {
            get { return zID; }
            set
            {
                zID = value;
                Notify("ID");
                this.NotifyPropertyChanged(p => p.ID);
            }
        }

        public string StepID
        {
            get { return zStepID; }
            set
            {
                zStepID = value;
                Notify("StepID");

            }
        }

        public string Description
        {
            get { return zDescription; }
            set
            {
                zDescription = value;
                Notify("Description");
            }
        }

        public string OldValue
        {
            get { return zOldValue; }
            set
            {
                zOldValue = value;
                Notify("OldValue");
            }
        }

        public string NewValue
        {
            get { return zNewValue; }
            set
            {
                zNewValue = value;
                Notify("NewValue");
            }
        }




    }
}
