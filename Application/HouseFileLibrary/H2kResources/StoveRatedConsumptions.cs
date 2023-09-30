namespace ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    public class StoveRatedConsumptions : ResourceValueList
    {
        public static readonly StoveRatedConsumptions Default = new StoveRatedConsumptions("1", "Default", "Par d\x00e9faut", 565M, false);

        private StoveRatedConsumptions()
        {
        }

        private StoveRatedConsumptions(string code, string englishText, string frenchText, decimal value = 0M, bool isUserSpecified = false) : base(code, englishText, frenchText, value, isUserSpecified)
        {
        }

        public static StoveRatedConsumptions UserSpecified =>
            new StoveRatedConsumptions("0", "User Specified", "Prescrit par l'utilisateur", 0M, true);

        public static List<StoveRatedConsumptions> All
        {
            get
            {
                List<StoveRatedConsumptions> list1 = new List<StoveRatedConsumptions>();
                list1.Add(Default);
                list1.Add(UserSpecified);
                return list1;
            }
        }
    }
}

