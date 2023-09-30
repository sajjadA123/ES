namespace ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    public class P9EnergySources : ResourceList
    {
        public static readonly P9EnergySources NaturalGas = new P9EnergySources("2", "Natural gas", "Gaz naturel", false);
        public static readonly P9EnergySources Oil = new P9EnergySources("3", "Oil", "Mazout", false);
        public static readonly P9EnergySources Propane = new P9EnergySources("4", "Propane", "Propane", false);

        private P9EnergySources()
        {
        }

        private P9EnergySources(string code, string englishText, string frenchText, bool isUserSpecified = false) : base(code, englishText, frenchText, isUserSpecified)
        {
        }

        public static List<P9EnergySources> All
        {
            get
            {
                List<P9EnergySources> list1 = new List<P9EnergySources>();
                list1.Add(NaturalGas);
                list1.Add(Oil);
                list1.Add(Propane);
                return list1;
            }
        }
    }
}

