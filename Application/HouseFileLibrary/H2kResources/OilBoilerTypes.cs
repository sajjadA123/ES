namespace ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    public class OilBoilerTypes : ResourceList, IBoilerTypes
    {
        public static readonly OilBoilerTypes Boiler = new OilBoilerTypes("1", "Boiler", "Chaudi\x00e8re", false);
        public static readonly OilBoilerTypes BoilerVentDamper = new OilBoilerTypes("2", "Boiler w/vent damper", "Chaudi\x00e8re avec registre de tirage", false);
        public static readonly OilBoilerTypes BoilerFlameRetHead = new OilBoilerTypes("3", "Boiler w/ flame ret. head", "Chaud. avec t\x00eate de r\x00e9tention de flamme", false);
        public static readonly OilBoilerTypes MidEffBoilerNoDilAir = new OilBoilerTypes("4", "Mid-eff. boiler (no dil. air)", "Chaud. \x00e0 rend. moy. (sans air de dilution)", false);
        public static readonly OilBoilerTypes CondensingBoilerNoChimney = new OilBoilerTypes("5", "Condensing boiler (no chimney)", "Chaud. \x00e0 condensation (sans chemin\x00e9e)", false);
        public static readonly OilBoilerTypes DirectVentNonCondensing = new OilBoilerTypes("6", "Direct vent, non-condensing", "Chaud. \x00e0 \x00e9vacuation directe - sans condensation", false);

        private OilBoilerTypes()
        {
        }

        private OilBoilerTypes(string code, string englishText, string frenchText, bool isUserSpecified = false) : base(code, englishText, frenchText, isUserSpecified)
        {
        }

        public static List<OilBoilerTypes> All
        {
            get
            {
                List<OilBoilerTypes> list1 = new List<OilBoilerTypes>();
                list1.Add(Boiler);
                list1.Add(BoilerVentDamper);
                list1.Add(BoilerFlameRetHead);
                list1.Add(MidEffBoilerNoDilAir);
                list1.Add(CondensingBoilerNoChimney);
                list1.Add(DirectVentNonCondensing);
                return list1;
            }
        }
    }
}

