namespace ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    public class ApplianceEnergySources : ResourceList
    {
        public static readonly ApplianceEnergySources Electric = new ApplianceEnergySources("1", "Electric", "\x00c9lectricit\x00e9", false);
        public static readonly ApplianceEnergySources NaturalGas = new ApplianceEnergySources("2", "Natural Gas", "Gaz naturel", false);
        public static readonly ApplianceEnergySources Propane = new ApplianceEnergySources("4", "Propane", "Propane", false);

        private ApplianceEnergySources()
        {
        }

        private ApplianceEnergySources(string code, string englishText, string frenchText, bool isUserSpecified = false) : base(code, englishText, frenchText, isUserSpecified)
        {
        }

        public static List<ApplianceEnergySources> All
        {
            get
            {
                List<ApplianceEnergySources> list1 = new List<ApplianceEnergySources>();
                list1.Add(Electric);
                list1.Add(NaturalGas);
                list1.Add(Propane);
                return list1;
            }
        }
    }
}

