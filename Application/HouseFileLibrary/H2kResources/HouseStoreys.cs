namespace ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    public class HouseStoreys : ResourceList
    {
        public static readonly HouseStoreys OneStorey = new HouseStoreys("1", "One storey", "Un \x00e9tage", false);
        public static readonly HouseStoreys OneAndAHalf = new HouseStoreys("2", "One and a half", "Un \x00e9tage et demi", false);
        public static readonly HouseStoreys TwoStoreys = new HouseStoreys("3", "Two storeys", "Deux \x00e9tages", false);
        public static readonly HouseStoreys TwoAndAHalf = new HouseStoreys("4", "Two and a half", "Deux \x00e9tages et demi", false);
        public static readonly HouseStoreys ThreeStoreys = new HouseStoreys("5", "Three storeys", "Trois \x00e9tages", false);
        public static readonly HouseStoreys SplitLevel = new HouseStoreys("6", "Split level", "Mi-niveau", false);
        public static readonly HouseStoreys SplitEntryRaisedBase = new HouseStoreys("7", "Split entry/Raised base.", "Entr\x00e9e mi-niv/demi s-s", false);

        private HouseStoreys()
        {
        }

        private HouseStoreys(string code, string englishText, string frenchText, bool isUserSpecified = false) : base(code, englishText, frenchText, isUserSpecified)
        {
        }

        public static List<HouseStoreys> All
        {
            get
            {
                List<HouseStoreys> list1 = new List<HouseStoreys>();
                list1.Add(OneStorey);
                list1.Add(OneAndAHalf);
                list1.Add(TwoStoreys);
                list1.Add(TwoAndAHalf);
                list1.Add(ThreeStoreys);
                list1.Add(SplitLevel);
                list1.Add(SplitEntryRaisedBase);
                return list1;
            }
        }
    }
}

