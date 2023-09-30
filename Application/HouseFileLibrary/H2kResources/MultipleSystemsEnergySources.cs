namespace ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    public class MultipleSystemsEnergySources : ResourceList
    {
        public static readonly MultipleSystemsEnergySources Electric = new MultipleSystemsEnergySources("1", "Electric", "\x00c9lectricit\x00e9", false);
        public static readonly MultipleSystemsEnergySources NaturalGas = new MultipleSystemsEnergySources("2", "Natural gas", "Gaz naturel", false);
        public static readonly MultipleSystemsEnergySources Oil = new MultipleSystemsEnergySources("3", "Oil", "Mazout", false);
        public static readonly MultipleSystemsEnergySources Propane = new MultipleSystemsEnergySources("4", "Propane", "Propane", false);
        public static readonly MultipleSystemsEnergySources MixedWood = new MultipleSystemsEnergySources("5", "Mixed Wood", "Bois m\x00e9lang\x00e9", false);
        public static readonly MultipleSystemsEnergySources Hardwood = new MultipleSystemsEnergySources("6", "Hardwood", "Bois dur", false);
        public static readonly MultipleSystemsEnergySources Softwood = new MultipleSystemsEnergySources("7", "Softwood", "Bois mou", false);
        public static readonly MultipleSystemsEnergySources WoodPellets = new MultipleSystemsEnergySources("8", "Wood Pellets", "Granules de bois", false);

        private MultipleSystemsEnergySources()
        {
        }

        private MultipleSystemsEnergySources(string code, string englishText, string frenchText, bool isUserSpecified = false) : base(code, englishText, frenchText, isUserSpecified)
        {
        }

        public static List<MultipleSystemsEnergySources> All
        {
            get
            {
                List<MultipleSystemsEnergySources> list1 = new List<MultipleSystemsEnergySources>();
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

