using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.FunctionModels
{
  public  class TubeMaintControlViewModel
    {
        private int mLoaderIndex;
        private List<string> mDiLabels;
        private List<string> mDoLabels;



        public TubeMaintControlViewModel()
        {
            mDiLabels = new List<string>();
            mDoLabels = new List<string>();
            for (int i = 0; i < 8; ++i)
            {
                mDiLabels.Add("");
                mDoLabels.Add("");
            }
            mDiLabels[0] = "Di1,Di2,Di3,Di4,Di5,Di6,Di7,Di8,Di9,Di10,Di11,Di12,Di13,Di14,Di15,Di16";
            mDiLabels[1] = "Di1,Di2,Di3,Di4,Di5,Di6,Di7,Di8,Di9,Di10,Di11,Di12,Di13,Di14,Di15,Di16";
            mDiLabels[2] = "Di1,Di2,Di3,Di4,Di5,Di6,Di7,Di8,Di9,Di10,Di11,Di12,Di13,Di14,Di15,Di16";
            mDiLabels[3] = "Di1,Di2,Di3,Di4,Di5,Di6,Di7,Di8,Di9,Di10,Di11,Di12,Di13,Di14,Di15,Di16";
            mDiLabels[4] = "Di1,Di2,Di3,Di4,Di5,Di6,Di7,Di8,Di9,Di10,Di11,Di12,Di13,Di14,Di15,Di16";
            mDiLabels[5] = "Di1,Di2,Di3,Di4,Di5,Di6,Di7,Di8,Di9,Di10,Di11,Di12,Di13,Di14,Di15,Di16";
            mDoLabels[0] = "Do1,Do2,Do3,Do4,Do5,Do6,Do7,Do8,Do9,Do10,Do11,Do12,Do13,Do14,Do15,Do16";
            mDoLabels[1] = "Do1,Do2,Do3,Do4,Do5,Do6,Do7,Do8,Do9,Do10,Do11,Do12,Do13,Do14,Do15,Do16";
            mDoLabels[3] = "Do1,Do2,Do3,Do4,Do5,Do6,Do7,Do8,Do9,Do10,Do11,Do12,Do13,Do14,Do15,Do16";
            mDoLabels[4] = "Do1,Do2,Do3,Do4,Do5,Do6,Do7,Do8,Do9,Do10,Do11,Do12,Do13,Do14,Do15,Do16";
            mDoLabels[5] = "Do1,Do2,Do3,Do4,Do5,Do6,Do7,Do8,Do9,Do10,Do11,Do12,Do13,Do14,Do15,Do16";
             
        }
        public int LoaderIndex
        {
            get { return mLoaderIndex; }
            set
            {
                mLoaderIndex = value;
              
            }
        }

        public List<string> DiLabels
        {
            get
            {
                return mDiLabels;
            }
        }

        public List<string> DoLabels
        {
            get
            {
                return mDoLabels;
            }
        }



    }
}
