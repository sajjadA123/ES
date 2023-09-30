namespace ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    public class AirDistributionFanPowerLevels : ResourceValueList
    {
        public static readonly AirDistributionFanPowerLevels Default = new AirDistributionFanPowerLevels("1", "Default", "Par d\x00e9faut", 0M, false);

        private AirDistributionFanPowerLevels()
        {
        }

        private AirDistributionFanPowerLevels(string code, string englishText, string frenchText, decimal value = 0M, bool isUserSpecified = false) : base(code, englishText, frenchText, value, isUserSpecified)
        {
        }

        public static AirDistributionFanPowerLevels UserSpecified =>
            new AirDistributionFanPowerLevels("0", "User specified", "Prescrit par l'utilisateur", 0M, true);

        public static List<AirDistributionFanPowerLevels> All
        {
            get
            {
                List<AirDistributionFanPowerLevels> list1 = new List<AirDistributionFanPowerLevels>();
                list1.Add(UserSpecified);
                list1.Add(Default);
                return list1;
            }
        }
    }
}

