namespace ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    public class ApplianceEnergySourceSpecified : ResourceValueList
    {
        private ApplianceEnergySourceSpecified()
        {
        }

        private ApplianceEnergySourceSpecified(string code, string englishText, string frenchText, decimal value = 0M, bool isUserSpecified = false) : base(code, englishText, frenchText, value, isUserSpecified)
        {
        }

        public static ApplianceEnergySourceSpecified NaturalGas =>
            new ApplianceEnergySourceSpecified("2", "Natural Gas", "Gaz naturel", 0M, true);

        public static ApplianceEnergySourceSpecified Propane =>
            new ApplianceEnergySourceSpecified("4", "Propane", "Propane", 0M, true);

        public static List<ApplianceEnergySourceSpecified> All
        {
            get
            {
                List<ApplianceEnergySourceSpecified> list1 = new List<ApplianceEnergySourceSpecified>();
                list1.Add(NaturalGas);
                list1.Add(Propane);
                return list1;
            }
        }
    }
}

