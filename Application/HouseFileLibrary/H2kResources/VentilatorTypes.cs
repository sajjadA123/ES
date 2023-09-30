namespace ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    public class VentilatorTypes : ResourceList
    {
        public static readonly VentilatorTypes NotApplicable = new VentilatorTypes("0", "N/A", "S/O", false);
        public static readonly VentilatorTypes Hrv = new VentilatorTypes("1", "HRV", "VRC", false);
        public static readonly VentilatorTypes RangeHood = new VentilatorTypes("2", "Range hood", "Hotte aspirante", false);
        public static readonly VentilatorTypes Bathroom = new VentilatorTypes("3", "Bathroom", "Salle de bains", false);
        public static readonly VentilatorTypes Utility = new VentilatorTypes("4", "Utility", "Utilit\x00e9", false);
        public static readonly VentilatorTypes Dryer = new VentilatorTypes("5", "Dryer", "S\x00e9cheuse", false);

        private VentilatorTypes()
        {
        }

        private VentilatorTypes(string code, string englishText, string frenchText, bool isUserSpecified = false) : base(code, englishText, frenchText, isUserSpecified)
        {
        }

        public static List<VentilatorTypes> All
        {
            get
            {
                List<VentilatorTypes> list1 = new List<VentilatorTypes>();
                list1.Add(NotApplicable);
                list1.Add(Hrv);
                list1.Add(RangeHood);
                list1.Add(Bathroom);
                list1.Add(Utility);
                list1.Add(Dryer);
                return list1;
            }
        }
    }
}

