namespace ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    public class SupplementaryEnergySources : ResourceList
    {
        public static readonly SupplementaryEnergySources Electric = new SupplementaryEnergySources("1", "Electric", "\x00c9lectricit\x00e9", false);
        public static readonly SupplementaryEnergySources NaturalGas = new SupplementaryEnergySources("2", "Natural gas", "Gaz naturel", false);
        public static readonly SupplementaryEnergySources Oil = new SupplementaryEnergySources("3", "Oil", "Mazout", false);
        public static readonly SupplementaryEnergySources Propane = new SupplementaryEnergySources("4", "Propane", "Propane", false);
        public static readonly SupplementaryEnergySources MixedWood = new SupplementaryEnergySources("5", "Mixed Wood", "Bois m\x00e9lang\x00e9", false);
        public static readonly SupplementaryEnergySources Hardwood = new SupplementaryEnergySources("6", "Hardwood", "Bois dur", false);
        public static readonly SupplementaryEnergySources Softwood = new SupplementaryEnergySources("7", "Softwood", "Bois mou", false);
        public static readonly SupplementaryEnergySources WoodPellets = new SupplementaryEnergySources("8", "Wood Pellets", "Granules de bois", false);

        private SupplementaryEnergySources()
        {
        }

        private SupplementaryEnergySources(string code, string englishText, string frenchText, bool isUserSpecified = false) : base(code, englishText, frenchText, isUserSpecified)
        {
        }

        public static List<SupplementaryEnergySources> All
        {
            get
            {
                List<SupplementaryEnergySources> list1 = new List<SupplementaryEnergySources>();
                list1.Add(Electric);
                list1.Add(NaturalGas);
                list1.Add(Oil);
                list1.Add(Propane);
                list1.Add(MixedWood);
                list1.Add(Hardwood);
                list1.Add(Softwood);
                list1.Add(WoodPellets);
                return list1;
            }
        }
    }
}

