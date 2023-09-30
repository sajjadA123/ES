namespace ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    public class OilFurnaceTypes : ResourceList, IFurnaceTypes
    {
        public static readonly OilFurnaceTypes Furnace = new OilFurnaceTypes("1", "Furnace", "Fournaise", false);
        public static readonly OilFurnaceTypes FurnaceVentDamper = new OilFurnaceTypes("2", "Furnace w/vent damper", "Fournaise avec registre de tirage", false);
        public static readonly OilFurnaceTypes FurnaceFlameRetHead = new OilFurnaceTypes("3", "Furnace w/ flame ret. head", "Fourn. avec t\x00eate de r\x00e9tention de flamme", false);
        public static readonly OilFurnaceTypes MidEffFurnaceNoDilAir = new OilFurnaceTypes("4", "Mid-eff. furnace (no dil. air)", "Fourn. \x00e0 rend. moy. (sans air de dilution)", false);
        public static readonly OilFurnaceTypes CondensingFurnaceNoChimney = new OilFurnaceTypes("5", "Condensing furnace (no chimney)", "Fourn. \x00e0 condensation (sans chemin\x00e9e)", false);
        public static readonly OilFurnaceTypes DirectVentNonCondensing = new OilFurnaceTypes("6", "Direct vent, non-condensing", "Fourn. \x00e0 \x00e9vacuation directe - sans condensation", false);

        private OilFurnaceTypes()
        {
        }

        private OilFurnaceTypes(string code, string englishText, string frenchText, bool isUserSpecified = false) : base(code, englishText, frenchText, isUserSpecified)
        {
        }

        public static List<OilFurnaceTypes> All
        {
            get
            {
                List<OilFurnaceTypes> list1 = new List<OilFurnaceTypes>();
                list1.Add(Furnace);
                list1.Add(FurnaceVentDamper);
                list1.Add(FurnaceFlameRetHead);
                list1.Add(MidEffFurnaceNoDilAir);
                list1.Add(CondensingFurnaceNoChimney);
                list1.Add(DirectVentNonCondensing);
                return list1;
            }
        }
    }
}

