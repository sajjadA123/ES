namespace ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    public class VentilationUses : ResourceList
    {
        public static readonly VentilationUses F326 = new VentilationUses("1", "F326", "F326", false);
        public static readonly VentilationUses Ach = new VentilationUses("2", "ACH", "CAH", false);
        public static readonly VentilationUses FlowRate = new VentilationUses("3", "Flow rate", "D\x00e9bit", false);
        public static readonly VentilationUses NotApplicable = new VentilationUses("4", "Not applicable", "Sans objet", false);

        private VentilationUses()
        {
        }

        private VentilationUses(string code, string englishText, string frenchText, bool isUserSpecified = false) : base(code, englishText, frenchText, isUserSpecified)
        {
        }

        public static List<VentilationUses> All
        {
            get
            {
                List<VentilationUses> list1 = new List<VentilationUses>();
                list1.Add(F326);
                list1.Add(Ach);
                list1.Add(FlowRate);
                list1.Add(NotApplicable);
                return list1;
            }
        }
    }
}

