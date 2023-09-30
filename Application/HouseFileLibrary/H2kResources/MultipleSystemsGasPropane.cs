namespace ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    public class MultipleSystemsGasPropane : ResourceList, IMultipleSystemsEquipmentTypes
    {
        public static readonly MultipleSystemsGasPropane ForcedAirCondensing = new MultipleSystemsGasPropane("1", "Forced air - condensing", "Air puls\x00e9 - \x00e0 condensation", false);
        public static readonly MultipleSystemsGasPropane ForcedAirInducedDraft = new MultipleSystemsGasPropane("2", "Forced air - Induced draft", "Air puls\x00e9 - \x00e0 tirage induit", false);
        public static readonly MultipleSystemsGasPropane ForcedAirSparkIgnitionVentDamper = new MultipleSystemsGasPropane("3", "Forced air - spark ignition vent damper", "Air puls\x00e9- \x00e0 allumage par \x00e9tincelle avec registre", false);
        public static readonly MultipleSystemsGasPropane ForcedAirSparkIgnition = new MultipleSystemsGasPropane("4", "Forced air - spark ignition", "Air puls\x00e9 - \x00e0 allumage par \x00e9tincelle", false);
        public static readonly MultipleSystemsGasPropane ForcedAirContinuousPilot = new MultipleSystemsGasPropane("5", "Forced air - continuous pilot", "Air puls\x00e9 - avec veilleuse permanente", false);
        public static readonly MultipleSystemsGasPropane BoilerCondensing = new MultipleSystemsGasPropane("6", "Boiler - condensing", "Chaudi\x00e8re \x00e0 condensation", false);
        public static readonly MultipleSystemsGasPropane BoilerInducedDraft = new MultipleSystemsGasPropane("7", "Boiler - Induced draft", "Chaudi\x00e8re \x00e0 tirage induit", false);
        public static readonly MultipleSystemsGasPropane BoilerSparkIgnitionVentDamper = new MultipleSystemsGasPropane("8", "Boiler - spark ignition vent damper", "Chaudi\x00e8re \x00e0 allumage par \x00e9tincelle avec registre", false);
        public static readonly MultipleSystemsGasPropane BoilerSparkIgnition = new MultipleSystemsGasPropane("9", "Boiler - spark ignition", "Chaudi\x00e8re \x00e0 allumage par \x00e9tincelle", false);
        public static readonly MultipleSystemsGasPropane BoilerContinuousPilot = new MultipleSystemsGasPropane("10", "Boiler - continuous pilot", "Chaudi\x00e8re avec veilleuse permanente", false);
        public static readonly MultipleSystemsGasPropane ComboCondensing = new MultipleSystemsGasPropane("11", "Combo - condensing", "Chaudi\x00e8re avec veilleuse permanente", false);
        public static readonly MultipleSystemsGasPropane ComboInducedDraft = new MultipleSystemsGasPropane("12", "Combo - Induced draft", "Combinaison - \x00e0 tirage induit", false);
        public static readonly MultipleSystemsGasPropane ComboSparkIgnitionVentDamper = new MultipleSystemsGasPropane("13", "Combo -  spark ignition vent damper", "Combinaison - \x00e0 allumage par \x00e9tincelle avec registre", false);
        public static readonly MultipleSystemsGasPropane ComboSparkIgnition = new MultipleSystemsGasPropane("14", "Combo - spark ignition", "Combinaison - \x00e0 allumage par \x00e9tincelle", false);
        public static readonly MultipleSystemsGasPropane ComboContinuousPilot = new MultipleSystemsGasPropane("15", "Combo - continuous pilot", "Combinaison - avec veilleuse permanente", false);
        public static readonly MultipleSystemsGasPropane P9 = new MultipleSystemsGasPropane("16", "P9", "P9", false);

        private MultipleSystemsGasPropane()
        {
        }

        private MultipleSystemsGasPropane(string code, string englishText, string frenchText, bool isUserSpecified = false) : base(code, englishText, frenchText, isUserSpecified)
        {
        }

        public static List<MultipleSystemsGasPropane> All
        {
            get
            {
                List<MultipleSystemsGasPropane> list1 = new List<MultipleSystemsGasPropane>();
                list1.Add(ForcedAirCondensing);
                list1.Add(ForcedAirInducedDraft);
                list1.Add(ForcedAirSparkIgnitionVentDamper);
                list1.Add(ForcedAirSparkIgnition);
                list1.Add(ForcedAirContinuousPilot);
                list1.Add(BoilerCondensing);
                list1.Add(BoilerInducedDraft);
                list1.Add(BoilerSparkIgnitionVentDamper);
                list1.Add(BoilerSparkIgnition);
                list1.Add(BoilerContinuousPilot);
                list1.Add(ComboCondensing);
                list1.Add(ComboInducedDraft);
                list1.Add(ComboSparkIgnitionVentDamper);
                list1.Add(ComboSparkIgnition);
                list1.Add(ComboContinuousPilot);
                list1.Add(P9);
                return list1;
            }
        }
    }
}

