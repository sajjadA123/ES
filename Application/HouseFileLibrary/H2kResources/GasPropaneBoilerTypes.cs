namespace ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    public class GasPropaneBoilerTypes : ResourceList, IBoilerTypes
    {
        public static readonly GasPropaneBoilerTypes BoilerContinuousPilot = new GasPropaneBoilerTypes("1", "Boiler w/ continuous pilot", "Chaudi\x00e8re avec veilleuse permanente", false);
        public static readonly GasPropaneBoilerTypes BoilerSparkIgnition = new GasPropaneBoilerTypes("2", "Boiler w/ spark ignition", "Chaudi\x00e8re \x00e0 allumage par \x00e9tincelle", false);
        public static readonly GasPropaneBoilerTypes BoilerSparkIgnitionVentDamper = new GasPropaneBoilerTypes("3", "Boiler w/ spark ignition & vent damper", "Chaud. \x00e0 allum. par \x00e9tin., avec registre", false);
        public static readonly GasPropaneBoilerTypes InducedDraftFanBoiler = new GasPropaneBoilerTypes("4", "Induced draft fan boiler", "Chaudi\x00e8re \x00e0 tirage induit", false);
        public static readonly GasPropaneBoilerTypes Condensing = new GasPropaneBoilerTypes("5", "Condensing", "Chaudi\x00e8re \x00e0 condensation", false);
        public static readonly GasPropaneBoilerTypes GasFiredBoilerWHeatPump = new GasPropaneBoilerTypes("6", "Gas-fired boiler w/ heat pump", "Chaudi\x00e8re \x00e0 gaz/thermopompe combin\x00e9es", false);

        private GasPropaneBoilerTypes()
        {
        }

        private GasPropaneBoilerTypes(string code, string englishText, string frenchText, bool isUserSpecified = false) : base(code, englishText, frenchText, isUserSpecified)
        {
        }

        public static List<GasPropaneBoilerTypes> All
        {
            get
            {
                List<GasPropaneBoilerTypes> list1 = new List<GasPropaneBoilerTypes>();
                list1.Add(BoilerContinuousPilot);
                list1.Add(BoilerSparkIgnition);
                list1.Add(BoilerSparkIgnitionVentDamper);
                list1.Add(InducedDraftFanBoiler);
                list1.Add(Condensing);
                list1.Add(GasFiredBoilerWHeatPump);
                return list1;
            }
        }
    }
}

