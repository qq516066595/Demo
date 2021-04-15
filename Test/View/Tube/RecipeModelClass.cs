using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ReactiveUI;

namespace Test.View.Tube
{
    public class RecipeModelClass : ReactiveObject
    {
        public int step { get; set; }
        public string stepName { get; set; }
        public bool bCondition { get; set; }
        public int stepTime { get; set; }
        public float Zone1 { get; set; }
        public float Zone2 { get; set; }
        public float Zone3 { get; set; }
        public int GiRecipe_ID { get => giRecipe_ID; set => this.RaiseAndSetIfChanged(ref giRecipe_ID, value); }
        public bool GbHMI_Recipe_Start { get => gbHMI_Recipe_Start; set => this.RaiseAndSetIfChanged(ref gbHMI_Recipe_Start, value); }
        public ushort EName { get => eName; set => this.RaiseAndSetIfChanged(ref eName, value); }

        private UInt16 eName;
        int giRecipe_ID;
        bool gbHMI_Recipe_Start;

        //[Serializable]
        //[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 1)]
        //public struct RecipeCtrl
        //{
        //    private UInt16 eName;                   //步名称
        //    private float nDuration;                //步总时间
        //    private float nWorking_Time;            //步进行时间
        //    private float nRemain_Time;             //步剩余时间
        //    private bool bFinish;                   //当前步完成

        //    public ushort EName { get => eName; set => this.RaiseAndSetIfChanged(ref eName, value); }
        //    public float NDuration { get => nDuration; set => this.RaiseAndSetIfChanged(ref nDuration, value); }
        //    public float NWorking_Time { get => nWorking_Time; set => this.RaiseAndSetIfChanged(ref nWorking_Time, value); }
        //    public float NRemain_Time { get => nRemain_Time; set => this.RaiseAndSetIfChanged(ref nRemain_Time, value); }
        //    public bool BFinish { get => bFinish; set => this.RaiseAndSetIfChanged(ref bFinish, value); }
        //}
    }
}
