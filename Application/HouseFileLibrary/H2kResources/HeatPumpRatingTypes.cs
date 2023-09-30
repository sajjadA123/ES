namespace ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    public class HeatPumpRatingTypes : ResourceValueList
    {
        public static readonly HeatPumpRatingTypes EightDegreesCelcius = new HeatPumpRatingTypes("1", "8.3 C (47 F)", "8.3 C (47 F)", 8.3M, false);
        public static readonly HeatPumpRatingTypes ZeroDegreesCelcius = new HeatPumpRatingTypes("2", "0.0 C (32 F)", "0.0 C (32 F)", 0.0M, false);

        private HeatPumpRatingTypes()
        {
        }

        private HeatPumpRatingTypes(string code, string englishText, string frenchText, decimal value = 0M, bool isUserSpecified = false) : base(code, englishText, frenchText, value, isUserSpecified)
        {
        }

        public static HeatPumpRatingTypes UserSpecified =>
            new HeatPumpRatingTypes("3", "User specified", "Sp\x00e9cifi\x00e9 par l'util.", 0M, true);

        public static List<HeatPumpRatingTypes> All
        {
            get
            {
                List<HeatPumpRatingTypes> list1 = new List<HeatPumpRatingTypes>();
                list1.Add(EightDegreesCelcius);
                list1.Add(ZeroDegreesCelcius);
                list1.Add(UserSpecified);
                return list1;
            }
        }
    }
}

