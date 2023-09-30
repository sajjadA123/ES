namespace ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    public class MultipleSystemsOil : ResourceList, IMultipleSystemsEquipmentTypes
    {
        public static readonly MultipleSystemsOil ForcedAirDirectVentNonCondensing = new MultipleSystemsOil("1", "Forced air - Direct vent non-condensing", "Air puls\x00e9 - \x00e0 \x00e9vacuation directe sans condensation", false);
        public static readonly MultipleSystemsOil ForcedAirCondensingNoChimney = new MultipleSystemsOil("2", "Forced air - Condensing (no chimney)", "Air puls\x00e9 - \x00e0 condensation (sans chemin\x00e9e)", false);
        public static readonly MultipleSystemsOil ForcedAirMidEffNoDilAir = new MultipleSystemsOil("3", "Forced air - Mid-eff. (no dil. air)", "Air puls\x00e9 – \x00e0 rendement moyen (sans air de dilution)", false);
        public static readonly MultipleSystemsOil ForcedAirFlameRetentionHead = new MultipleSystemsOil("4", "Forced air - flame retention head", "Air puls\x00e9–avec t\x00eate de r\x00e9tention de flamme", false);
        public static readonly MultipleSystemsOil ForcedAirVentDamper = new MultipleSystemsOil("5", "Forced air - vent damper", "Air puls\x00e9 – avec registre de tirage", false);
        public static readonly MultipleSystemsOil ForcedAirBoilerDirectVentNonCondensing = new MultipleSystemsOil("6", "Forced air Boiler - Direct vent non-condensing", "Air puls\x00e9 – \x00e0 \x00e9vacuation directe sans condensation", false);
        public static readonly MultipleSystemsOil BoilerCondensingNoChimney = new MultipleSystemsOil("7", "Boiler - Condensing (no chimney)", "Chaudi\x00e8re – \x00e0 condensation (sans chemin\x00e9e)", false);
        public static readonly MultipleSystemsOil BoilerMidEffNoDilAir = new MultipleSystemsOil("8", "Boiler - Mid-eff. (no dil. air)", "Chaudi\x00e8re – \x00e0 rendement moyen (sans air de dilution)", false);
        public static readonly MultipleSystemsOil BoilerFlameRetentionHead = new MultipleSystemsOil("9", "Boiler - flame retention head", "Chaudi\x00e8re – avec t\x00eate de r\x00e9tention de flamme", false);
        public static readonly MultipleSystemsOil BoilerVentDamper = new MultipleSystemsOil("10", "Boiler - vent damper", "Chaudi\x00e8re – avec registre de tirage", false);
        public static readonly MultipleSystemsOil Boiler = new MultipleSystemsOil("11", "Boiler", "Chaudi\x00e8re", false);
        public static readonly MultipleSystemsOil ComboCondensingNoChimney = new MultipleSystemsOil("12", "Combo - Condensing (no chimney)", "Combinaison - condensation (sans chemin\x00e9e)", false);
        public static readonly MultipleSystemsOil ComboDirectVentNonCondensing = new MultipleSystemsOil("13", "Combo - Direct vent non-condensing", "Combinaison - \x00e0 \x00e9vacuation directe sans condensation", false);
        public static readonly MultipleSystemsOil ComboMidEffNoDilAir = new MultipleSystemsOil("14", "Combo - Mid-eff. (no dil. air)", "Combinaison - \x00e0 rendement moyen (sans air de dilution)", false);
        public static readonly MultipleSystemsOil ComboFlameRetentionHead = new MultipleSystemsOil("15", "Combo - flame retention head", "Combinaison - avec t\x00eate de r\x00e9tention de flamme", false);
        public static readonly MultipleSystemsOil ComboVentDamper = new MultipleSystemsOil("16", "Combo - vent damper", "Combinaison - avec registre de tirage", false);

        private MultipleSystemsOil()
        {
        }

        private MultipleSystemsOil(string code, string englishText, string frenchText, bool isUserSpecified = false) : base(code, englishText, frenchText, isUserSpecified)
        {
        }

        public static List<MultipleSystemsOil> All
        {
            get
            {
                List<MultipleSystemsOil> list1 = new List<MultipleSystemsOil>();
                list1.Add(ForcedAirDirectVentNonCondensing);
                list1.Add(ForcedAirCondensingNoChimney);
                list1.Add(ForcedAirMidEffNoDilAir);
                list1.Add(ForcedAirFlameRetentionHead);
                list1.Add(ForcedAirVentDamper);
                list1.Add(ForcedAirBoilerDirectVentNonCondensing);
                list1.Add(BoilerCondensingNoChimney);
                list1.Add(BoilerMidEffNoDilAir);
                list1.Add(BoilerFlameRetentionHead);
                list1.Add(BoilerVentDamper);
                list1.Add(Boiler);
                list1.Add(ComboCondensingNoChimney);
                list1.Add(ComboDirectVentNonCondensing);
                list1.Add(ComboMidEffNoDilAir);
                list1.Add(ComboFlameRetentionHead);
                list1.Add(ComboVentDamper);
                return list1;
            }
        }
    }
}

