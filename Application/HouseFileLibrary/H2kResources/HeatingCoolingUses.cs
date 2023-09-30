namespace ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    public class HeatingCoolingUses : ResourceList
    {
        public static readonly HeatingCoolingUses Calculated = new HeatingCoolingUses("2", "Calculated", "Calcul\x00e9", false);

        private HeatingCoolingUses()
        {
        }

        private HeatingCoolingUses(string code, string englishText, string frenchText, bool isUserSpecified = false) : base(code, englishText, frenchText, isUserSpecified)
        {
        }

        public static HeatingCoolingUses UserSpecified =>
            new HeatingCoolingUses("1", "User specified", "Sp\x00e9cifi\x00e9 par l'util.", true);

        public static List<HeatingCoolingUses> All
        {
            get
            {
                List<HeatingCoolingUses> list1 = new List<HeatingCoolingUses>();
                list1.Add(UserSpecified);
                list1.Add(Calculated);
                return list1;
            }
        }
    }
}

