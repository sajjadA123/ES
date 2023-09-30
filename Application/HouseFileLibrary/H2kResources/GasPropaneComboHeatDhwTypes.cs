namespace ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    public class GasPropaneComboHeatDhwTypes : ResourceList, IComboHeatDhwTypes
    {
        public static readonly GasPropaneComboHeatDhwTypes HeaterContinuousPilot = new GasPropaneComboHeatDhwTypes("1", "Heater w/ continuous pilot", "R\x00e9chauffeur avec veilleuse continue", false);
        public static readonly GasPropaneComboHeatDhwTypes HeaterSparkIgnition = new GasPropaneComboHeatDhwTypes("2", "Heater w/ spark ignition", "R\x00e9chauffeur avec allumage par \x00e9tincelle", false);
        public static readonly GasPropaneComboHeatDhwTypes HeaterSparkIgnitionVentDamper = new GasPropaneComboHeatDhwTypes("3", "Heater w/ spark ignition & vent damper", "R\x00e9chauffeur avec allumage par \x00e9tincelle et limiteur de vent.", false);
        public static readonly GasPropaneComboHeatDhwTypes HeaterInducedDraftFan = new GasPropaneComboHeatDhwTypes("4", "Heater w/ Induced draft fan", "R\x00e9chauffeur avec ventillateur", false);
        public static readonly GasPropaneComboHeatDhwTypes CondensingHeater = new GasPropaneComboHeatDhwTypes("5", "Condensing heater", "R\x00e9chauffeur \x00e0 condensation", false);

        private GasPropaneComboHeatDhwTypes()
        {
        }

        private GasPropaneComboHeatDhwTypes(string code, string englishText, string frenchText, bool isUserSpecified = false) : base(code, englishText, frenchText, isUserSpecified)
        {
        }

        public static List<GasPropaneComboHeatDhwTypes> All
        {
            get
            {
                List<GasPropaneComboHeatDhwTypes> list1 = new List<GasPropaneComboHeatDhwTypes>();
                list1.Add(HeaterContinuousPilot);
                list1.Add(HeaterSparkIgnition);
                list1.Add(HeaterSparkIgnitionVentDamper);
                list1.Add(HeaterInducedDraftFan);
                list1.Add(CondensingHeater);
                return list1;
            }
        }
    }
}

