namespace ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    public class ClothesWasherTemperatures : ResourceList
    {
        public static readonly ClothesWasherTemperatures Hot = new ClothesWasherTemperatures("0", "Hot", "Chaude", false);
        public static readonly ClothesWasherTemperatures Cold = new ClothesWasherTemperatures("1", "Cold", "Froid", false);

        private ClothesWasherTemperatures()
        {
        }

        private ClothesWasherTemperatures(string code, string englishText, string frenchText, bool isUserSpecified = false) : base(code, englishText, frenchText, isUserSpecified)
        {
        }

        public static List<ClothesWasherTemperatures> All
        {
            get
            {
                List<ClothesWasherTemperatures> list1 = new List<ClothesWasherTemperatures>();
                list1.Add(Hot);
                list1.Add(Cold);
                return list1;
            }
        }
    }
}

