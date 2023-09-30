namespace ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    public class DuctSealingCharacteristics : ResourceList
    {
        public static readonly DuctSealingCharacteristics VeryTight = new DuctSealingCharacteristics("1", "Very tight", "Tr\x00e8s \x00e9tanche", false);
        public static readonly DuctSealingCharacteristics Sealed = new DuctSealingCharacteristics("2", "Sealed", "Scell\x00e9", false);
        public static readonly DuctSealingCharacteristics Unsealed = new DuctSealingCharacteristics("3", "Unsealed", "Non scell\x00e9", false);

        private DuctSealingCharacteristics()
        {
        }

        private DuctSealingCharacteristics(string code, string englishText, string frenchText, bool isUserSpecified = false) : base(code, englishText, frenchText, isUserSpecified)
        {
        }

        public static List<DuctSealingCharacteristics> All
        {
            get
            {
                List<DuctSealingCharacteristics> list1 = new List<DuctSealingCharacteristics>();
                list1.Add(VeryTight);
                list1.Add(Sealed);
                list1.Add(Unsealed);
                return list1;
            }
        }
    }
}

