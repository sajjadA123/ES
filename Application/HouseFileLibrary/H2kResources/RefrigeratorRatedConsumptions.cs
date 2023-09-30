namespace ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    public class RefrigeratorRatedConsumptions : ResourceValueList
    {
        public static readonly RefrigeratorRatedConsumptions Default = new RefrigeratorRatedConsumptions("1", "Default", "Par d\x00e9faut", 639M, false);

        private RefrigeratorRatedConsumptions()
        {
        }

        private RefrigeratorRatedConsumptions(string code, string englishText, string frenchText, decimal value = 0M, bool isUserSpecified = false) : base(code, englishText, frenchText, value, isUserSpecified)
        {
        }

        public static RefrigeratorRatedConsumptions UserSpecified =>
            new RefrigeratorRatedConsumptions("0", "User Specified", "Prescrit par l'utilisateur", 0M, true);

        public static List<RefrigeratorRatedConsumptions> All
        {
            get
            {
                List<RefrigeratorRatedConsumptions> list1 = new List<RefrigeratorRatedConsumptions>();
                list1.Add(Default);
                list1.Add(UserSpecified);
                return list1;
            }
        }
    }
}

