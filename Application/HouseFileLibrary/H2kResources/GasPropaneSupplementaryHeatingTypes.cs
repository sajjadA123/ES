namespace ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    public class GasPropaneSupplementaryHeatingTypes : ResourceList, ISupplementaryHeatingTypes
    {
        public static readonly GasPropaneSupplementaryHeatingTypes FurnaceBoilerSparkIgnition = new GasPropaneSupplementaryHeatingTypes("1", "Furnace/Boiler w/ spark ignition", "Fournaise/Chaudi\x00e8re avec allum. par \x00e9tincelle", false);
        public static readonly GasPropaneSupplementaryHeatingTypes FireplaceSparkIgnitionUnsealed = new GasPropaneSupplementaryHeatingTypes("2", "Fireplace with spark ignit. (unsealed)", "Foyer avec allum. par \x00e9tincelle (non scell\x00e9)", false);
        public static readonly GasPropaneSupplementaryHeatingTypes FireplaceSparkIgnitionSealed = new GasPropaneSupplementaryHeatingTypes("3", "Fireplace with spark ignit. (sealed)", "Foyer avec allum. par \x00e9tincelle (scell\x00e9)", false);
        public static readonly GasPropaneSupplementaryHeatingTypes FireplacePilotUnsealed = new GasPropaneSupplementaryHeatingTypes("6", "Fireplace with pilot (unsealed)", "Foyer avec allum. par veilleuse (non scell\x00e9)", false);
        public static readonly GasPropaneSupplementaryHeatingTypes FireplacePilotSealed = new GasPropaneSupplementaryHeatingTypes("7", "Fireplace with pilot (sealed)", "Foyer avec allum. par veilleuse (scell\x00e9)", false);
        public static readonly GasPropaneSupplementaryHeatingTypes PortableHeater = new GasPropaneSupplementaryHeatingTypes("4", "Portable heater", "R\x00e9chauffeur portable", false);
        public static readonly GasPropaneSupplementaryHeatingTypes OtherDescribe = new GasPropaneSupplementaryHeatingTypes("5", "Other (describe)", "Autre (d\x00e9crire)", false);
        public static readonly GasPropaneSupplementaryHeatingTypes SameAsType1 = new GasPropaneSupplementaryHeatingTypes("8", "Same as Type 1 heating system", "Identique au syst\x00e8me de chauffage Type 1", false);

        private GasPropaneSupplementaryHeatingTypes()
        {
        }

        private GasPropaneSupplementaryHeatingTypes(string code, string englishText, string frenchText, bool isUserSpecified = false) : base(code, englishText, frenchText, isUserSpecified)
        {
        }

        public static List<GasPropaneSupplementaryHeatingTypes> All
        {
            get
            {
                List<GasPropaneSupplementaryHeatingTypes> list1 = new List<GasPropaneSupplementaryHeatingTypes>();
                list1.Add(FurnaceBoilerSparkIgnition);
                list1.Add(FireplaceSparkIgnitionUnsealed);
                list1.Add(FireplaceSparkIgnitionSealed);
                list1.Add(FireplacePilotUnsealed);
                list1.Add(FireplacePilotSealed);
                list1.Add(PortableHeater);
                list1.Add(OtherDescribe);
                list1.Add(SameAsType1);
                return list1;
            }
        }
    }
}

