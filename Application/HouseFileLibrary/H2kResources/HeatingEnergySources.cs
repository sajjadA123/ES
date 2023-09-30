namespace ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    public class HeatingEnergySources : ResourceList
    {
        public static readonly HeatingEnergySources Electric = new HeatingEnergySources("1", "Electric", "\x00c9lectricit\x00e9", false);
        public static readonly HeatingEnergySources NaturalGas = new HeatingEnergySources("2", "Natural gas", "Gaz naturel", false);
        public static readonly HeatingEnergySources Oil = new HeatingEnergySources("3", "Oil", "Mazout", false);
        public static readonly HeatingEnergySources Propane = new HeatingEnergySources("4", "Propane", "Propane", false);
        public static readonly HeatingEnergySources MixedWood = new HeatingEnergySources("5", "Mixed Wood", "Bois m\x00e9lang\x00e9", false);
        public static readonly HeatingEnergySources Hardwood = new HeatingEnergySources("6", "Hardwood", "Bois dur", false);
        public static readonly HeatingEnergySources Softwood = new HeatingEnergySources("7", "Softwood", "Bois mou", false);
        public static readonly HeatingEnergySources WoodPellets = new HeatingEnergySources("8", "Wood Pellets", "Granules de bois", false);
        public static readonly HeatingEnergySources DistrictEnergySystem = new HeatingEnergySources("9", "District Energy System", "Syst\x00e8me \x00e9nerg\x00e9tique de quartier", false);

        private HeatingEnergySources()
        {
        }

        private HeatingEnergySources(string code, string englishText, string frenchText, bool isUserSpecified = false) : base(code, englishText, frenchText, isUserSpecified)
        {
        }

        public static List<HeatingEnergySources> All
        {
            get
            {
                List<HeatingEnergySources> list1 = new List<HeatingEnergySources>();
                list1.Add(Electric);
                list1.Add(NaturalGas);
                list1.Add(Oil);
                list1.Add(Propane);
                list1.Add(MixedWood);
                list1.Add(Hardwood);
                list1.Add(Softwood);
                list1.Add(WoodPellets);
                list1.Add(DistrictEnergySystem);
                return list1;
            }
        }
    }
}

