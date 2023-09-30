namespace ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    public class GasPropaneFurnaceTypes : ResourceList, IFurnaceTypes
    {
        public static readonly GasPropaneFurnaceTypes FurnaceContinuousPilot = new GasPropaneFurnaceTypes("1", "Furnace w/ continuous pilot", "Fournaise avec veilleuse permanente", false);
        public static readonly GasPropaneFurnaceTypes FurnaceSparkIgnition = new GasPropaneFurnaceTypes("2", "Furnace w/ spark ignition", "Fournaise \x00e0 allumage par \x00e9tincelle", false);
        public static readonly GasPropaneFurnaceTypes FurnaceSparkIgnitionVentDamper = new GasPropaneFurnaceTypes("3", "Furn. w/ spark ignition & vent damper", "Fourn. \x00e0 allum. par \x00e9tin., avec registre", false);
        public static readonly GasPropaneFurnaceTypes InducedDraftFanFurnace = new GasPropaneFurnaceTypes("4", "Induced draft fan furnace", "Fournaise \x00e0 tirage induit", false);
        public static readonly GasPropaneFurnaceTypes Condensing = new GasPropaneFurnaceTypes("5", "Condensing", "Fournaise \x00e0 condensation", false);
        public static readonly GasPropaneFurnaceTypes GasFiredFurnaceWHeatPump = new GasPropaneFurnaceTypes("6", "Gas-fired furnace w/ heat pump", "Fournaise \x00e0 gaz/thermopompe combin\x00e9es", false);

        private GasPropaneFurnaceTypes()
        {
        }

        private GasPropaneFurnaceTypes(string code, string englishText, string frenchText, bool isUserSpecified = false) : base(code, englishText, frenchText, isUserSpecified)
        {
        }

        public static List<GasPropaneFurnaceTypes> All
        {
            get
            {
                List<GasPropaneFurnaceTypes> list1 = new List<GasPropaneFurnaceTypes>();
                list1.Add(FurnaceContinuousPilot);
                list1.Add(FurnaceSparkIgnition);
                list1.Add(FurnaceSparkIgnitionVentDamper);
                list1.Add(InducedDraftFanFurnace);
                list1.Add(Condensing);
                list1.Add(GasFiredFurnaceWHeatPump);
                return list1;
            }
        }
    }
}

