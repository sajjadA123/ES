namespace ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    public class DryerRatedConsumptions : ResourceValueList
    {
        public static readonly DryerRatedConsumptions Default = new DryerRatedConsumptions("1", "Default", "D\x00e9faut", 916M, false);

        private DryerRatedConsumptions()
        {
        }

        private DryerRatedConsumptions(string code, string englishText, string frenchText, decimal value = 0M, bool isUserSpecified = false) : base(code, englishText, frenchText, value, isUserSpecified)
        {
        }

        public static DryerRatedConsumptions UserSpecified =>
            new DryerRatedConsumptions("0", "User Specified", "Sp\x00e9cifi\x00e9 par l'utilisateur", 0M, true);

        public static List<DryerRatedConsumptions> All
        {
            get
            {
                List<DryerRatedConsumptions> list1 = new List<DryerRatedConsumptions>();
                list1.Add(Default);
                list1.Add(UserSpecified);
                return list1;
            }
        }
    }
}

