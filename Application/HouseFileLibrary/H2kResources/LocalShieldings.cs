namespace ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    public class LocalShieldings : ResourceList
    {
        public static readonly LocalShieldings None = new LocalShieldings("1", "None", "Aucun abri", false);
        public static readonly LocalShieldings Light = new LocalShieldings("2", "Light", "Un peu d'abri", false);
        public static readonly LocalShieldings Heavy = new LocalShieldings("3", "Heavy", "Assez d'abri", false);
        public static readonly LocalShieldings VeryHeavy = new LocalShieldings("4", "Very heavy", "Beaucoup d'abri", false);
        public static readonly LocalShieldings CompleteByLargeBuildings = new LocalShieldings("5", "Complete (by large buildings)", "Abri complet (gros b\x00e2timents)", false);

        private LocalShieldings()
        {
        }

        private LocalShieldings(string code, string englishText, string frenchText, bool isUserSpecified = false) : base(code, englishText, frenchText, isUserSpecified)
        {
        }

        public static List<LocalShieldings> All
        {
            get
            {
                List<LocalShieldings> list1 = new List<LocalShieldings>();
                list1.Add(None);
                list1.Add(Light);
                list1.Add(Heavy);
                list1.Add(VeryHeavy);
                list1.Add(CompleteByLargeBuildings);
                return list1;
            }
        }
    }
}

