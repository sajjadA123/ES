namespace ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    public class AllowableRise : ResourceList
    {
        public static readonly AllowableRise Low = new AllowableRise("1", "Low (0 deg)", "Basse (0 Deg)", false);
        public static readonly AllowableRise Medium = new AllowableRise("2", "Medium (2.8 C = 5 F)", "Moyenne (2.8 C = 5 F)", false);
        public static readonly AllowableRise High = new AllowableRise("3", "High (5.5 C = 9.9 F)", "Haute (5.5 C = 9.9 F)", false);

        private AllowableRise()
        {
        }

        private AllowableRise(string code, string englishText, string frenchText, bool isUserSpecified = false) : base(code, englishText, frenchText, isUserSpecified)
        {
        }

        public static List<AllowableRise> All
        {
            get
            {
                List<AllowableRise> list1 = new List<AllowableRise>();
                list1.Add(Low);
                list1.Add(Medium);
                list1.Add(High);
                return list1;
            }
        }
    }
}

