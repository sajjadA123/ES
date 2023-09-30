namespace ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    public class VentilationTypes : ResourceList
    {
        public static readonly VentilationTypes Vented = new VentilationTypes("1", "Vented", "Ventil\x00e9", false);
        public static readonly VentilationTypes Open = new VentilationTypes("2", "Open", "Ouvert", false);
        public static readonly VentilationTypes Closed = new VentilationTypes("3", "Closed", "Ferm\x00e9", false);

        private VentilationTypes()
        {
        }

        private VentilationTypes(string code, string englishText, string frenchText, bool isUserSpecified = false) : base(code, englishText, frenchText, isUserSpecified)
        {
        }

        public static List<VentilationTypes> All
        {
            get
            {
                List<VentilationTypes> list1 = new List<VentilationTypes>();
                list1.Add(Vented);
                list1.Add(Open);
                list1.Add(Closed);
                return list1;
            }
        }
    }
}

