namespace ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    public class OilSupplementaryHeatingTypes : ResourceList, ISupplementaryHeatingTypes
    {
        public static readonly OilSupplementaryHeatingTypes SpaceHeater = new OilSupplementaryHeatingTypes("1", "Space heater", "Chauferette", false);
        public static readonly OilSupplementaryHeatingTypes OtherDescribe = new OilSupplementaryHeatingTypes("2", "Other (describe)", "Autre (d\x00e9crire)", false);
        public static readonly OilSupplementaryHeatingTypes SameAsType1 = new OilSupplementaryHeatingTypes("8", "Same as Type 1 heating system", "Identique au syst\x00e8me de chauffage Type 1", false);

        private OilSupplementaryHeatingTypes()
        {
        }

        private OilSupplementaryHeatingTypes(string code, string englishText, string frenchText, bool isUserSpecified = false) : base(code, englishText, frenchText, isUserSpecified)
        {
        }

        public static List<OilSupplementaryHeatingTypes> All
        {
            get
            {
                List<OilSupplementaryHeatingTypes> list1 = new List<OilSupplementaryHeatingTypes>();
                list1.Add(SpaceHeater);
                list1.Add(OtherDescribe);
                list1.Add(SameAsType1);
                return list1;
            }
        }
    }
}

