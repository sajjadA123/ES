namespace ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    public class DhwEnergySources : ResourceList
    {
        public static readonly DhwEnergySources Electricity = new DhwEnergySources("1", "Electricity", "\x00c9lectricit\x00e9", false);
        public static readonly DhwEnergySources NaturalGas = new DhwEnergySources("2", "Natural gas", "Gaz naturel", false);
        public static readonly DhwEnergySources Oil = new DhwEnergySources("3", "Oil", "Mazout", false);
        public static readonly DhwEnergySources Propane = new DhwEnergySources("4", "Propane", "Propane", false);
        public static readonly DhwEnergySources MixedWood = new DhwEnergySources("5", "Mixed Wood", "Bois m\x00e9lang\x00e9", false);
        public static readonly DhwEnergySources Hardwood = new DhwEnergySources("8", "Hardwood", "Bois dur", false);
        public static readonly DhwEnergySources Softwood = new DhwEnergySources("9", "Softwood", "Bois mou", false);
        public static readonly DhwEnergySources WoodPellets = new DhwEnergySources("10", "Wood Pellets", "Granules de bois", false);
        public static readonly DhwEnergySources Solar = new DhwEnergySources("6", "Solar", "Solaire", false);
        public static readonly DhwEnergySources NotApplicable = new DhwEnergySources("7", "Not applicable", "Sans objet", false);

        private DhwEnergySources()
        {
        }

        private DhwEnergySources(string code, string englishText, string frenchText, bool isUserSpecified = false) : base(code, englishText, frenchText, isUserSpecified)
        {
        }

        public static List<DhwEnergySources> All
        {
            get
            {
                List<DhwEnergySources> list1 = new List<DhwEnergySources>();
                list1.Add(Electricity);
                list1.Add(NaturalGas);
                list1.Add(Oil);
                list1.Add(Propane);
                list1.Add(MixedWood);
                list1.Add(Hardwood);
                list1.Add(Softwood);
                list1.Add(WoodPellets);
                list1.Add(Solar);
                list1.Add(NotApplicable);
                return list1;
            }
        }
    }
}

