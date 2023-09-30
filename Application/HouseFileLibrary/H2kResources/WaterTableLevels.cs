namespace ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    public class WaterTableLevels : ResourceList
    {
        public static readonly WaterTableLevels Shallow = new WaterTableLevels("1", "Shallow (5-7m/16-23ft)", "Peu profond (5-7m/16-23pi)", false);
        public static readonly WaterTableLevels Normal = new WaterTableLevels("2", "Normal (7-10m/23-33ft)", "Normal (7-10m/23-33pi)", false);
        public static readonly WaterTableLevels Deep = new WaterTableLevels("3", "Deep (>10M/>33ft)", "Profond (>10M/>33pi)", false);

        private WaterTableLevels()
        {
        }

        private WaterTableLevels(string code, string englishText, string frenchText, bool isUserSpecified = false) : base(code, englishText, frenchText, isUserSpecified)
        {
        }

        public static List<WaterTableLevels> All
        {
            get
            {
                List<WaterTableLevels> list1 = new List<WaterTableLevels>();
                list1.Add(Shallow);
                list1.Add(Normal);
                list1.Add(Deep);
                return list1;
            }
        }
    }
}

