namespace ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    public class OilComboHeatDhwTypes : ResourceList, IComboHeatDhwTypes
    {
        public static readonly OilComboHeatDhwTypes HeaterVentDamper = new OilComboHeatDhwTypes("1", "Heater w/vent damper", "R\x00e9chauffeur avec limiteur de ventillation", false);
        public static readonly OilComboHeatDhwTypes HeaterFlameRetHead = new OilComboHeatDhwTypes("2", "Heater w/ flame ret. head", "R\x00e9chauffeur avec t\x00eate de r\x00e9tention", false);
        public static readonly OilComboHeatDhwTypes MidEffHeaterNoDilAir = new OilComboHeatDhwTypes("3", "Mid-eff. heater (no dil. air)", "R\x00e9chauffeur \x00e0 efficacit\x00e9 moy. (pas d'air dil.)", false);
        public static readonly OilComboHeatDhwTypes DirectVentNonCondensingHeater = new OilComboHeatDhwTypes("4", "Direct vent, non-condensing heater", "R\x00e9chauffeur \x00e0 vent. directe, sans condensation", false);
        public static readonly OilComboHeatDhwTypes CondensingHeaterNoChimney = new OilComboHeatDhwTypes("5", "Condensing heater (no chimney)", "R\x00e9chauffeur \x00e0 condensation (sans chemin\x00e9e)", false);

        private OilComboHeatDhwTypes()
        {
        }

        private OilComboHeatDhwTypes(string code, string englishText, string frenchText, bool isUserSpecified = false) : base(code, englishText, frenchText, isUserSpecified)
        {
        }

        public static List<OilComboHeatDhwTypes> All
        {
            get
            {
                List<OilComboHeatDhwTypes> list1 = new List<OilComboHeatDhwTypes>();
                list1.Add(HeaterVentDamper);
                list1.Add(HeaterFlameRetHead);
                list1.Add(MidEffHeaterNoDilAir);
                list1.Add(DirectVentNonCondensingHeater);
                list1.Add(CondensingHeaterNoChimney);
                return list1;
            }
        }
    }
}

