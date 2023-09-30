namespace ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    public class InteriorLightingTypes : ResourceValueList
    {
        public static readonly InteriorLightingTypes LessThan25Percent = new InteriorLightingTypes("1", "< 25% CFL or LED", "< 25% LFC ou DEL ", 2.6M, false);
        public static readonly InteriorLightingTypes Between25And75Percent = new InteriorLightingTypes("2", "25%-75% CFL or LED", "25 % \x00e0 75 % LFC ou DEL", 1.6M, false);
        public static readonly InteriorLightingTypes GreaterThan75Percent = new InteriorLightingTypes("3", " >75% CFL or LED", "> 75 % LFC ou DEL", 0.6M, false);

        private InteriorLightingTypes()
        {
        }

        private InteriorLightingTypes(string code, string englishText, string frenchText, decimal value = 0M, bool isUserSpecified = false) : base(code, englishText, frenchText, value, isUserSpecified)
        {
        }

        public static InteriorLightingTypes UserSpecified =>
            new InteriorLightingTypes("0", "User Specified", "Prescrit par l'utilisateur", 0M, true);

        public static List<InteriorLightingTypes> All
        {
            get
            {
                List<InteriorLightingTypes> list1 = new List<InteriorLightingTypes>();
                list1.Add(LessThan25Percent);
                list1.Add(Between25And75Percent);
                list1.Add(GreaterThan75Percent);
                list1.Add(UserSpecified);
                return list1;
            }
        }
    }
}

