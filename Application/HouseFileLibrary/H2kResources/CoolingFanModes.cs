namespace ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    public class CoolingFanModes : ResourceList
    {
        public static readonly CoolingFanModes Auto = new CoolingFanModes("1", "Auto", "Auto", false);
        public static readonly CoolingFanModes Continuous = new CoolingFanModes("2", "Continuous", "Continu", false);

        private CoolingFanModes()
        {
        }

        private CoolingFanModes(string code, string englishText, string frenchText, bool isUserSpecified = false) : base(code, englishText, frenchText, isUserSpecified)
        {
        }

        public static List<CoolingFanModes> All
        {
            get
            {
                List<CoolingFanModes> list1 = new List<CoolingFanModes>();
                list1.Add(Auto);
                list1.Add(Continuous);
                return list1;
            }
        }
    }
}

