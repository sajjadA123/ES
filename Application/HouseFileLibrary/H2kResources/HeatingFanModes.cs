namespace ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    public class HeatingFanModes : ResourceList
    {
        public static readonly HeatingFanModes NA = new HeatingFanModes("0", "N/A", "S/O", false);
        public static readonly HeatingFanModes Auto = new HeatingFanModes("1", "Auto", "Auto", false);
        public static readonly HeatingFanModes Continuous = new HeatingFanModes("2", "Continuous", "Continu", false);
        public static readonly HeatingFanModes TwoSpeed = new HeatingFanModes("3", "Two Speed", "Deux Vitesses", false);

        private HeatingFanModes()
        {
        }

        private HeatingFanModes(string code, string englishText, string frenchText, bool isUserSpecified = false) : base(code, englishText, frenchText, isUserSpecified)
        {
        }

        public static List<HeatingFanModes> All
        {
            get
            {
                List<HeatingFanModes> list1 = new List<HeatingFanModes>();
                list1.Add(NA);
                list1.Add(Auto);
                list1.Add(Continuous);
                list1.Add(TwoSpeed);
                return list1;
            }
        }
    }
}

