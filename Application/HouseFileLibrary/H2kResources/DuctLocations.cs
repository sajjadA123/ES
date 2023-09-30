namespace ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    public class DuctLocations : ResourceList
    {
        public static readonly DuctLocations Basement = new DuctLocations("1", "Basement", "Sous-sol", false);
        public static readonly DuctLocations CrawlSpace = new DuctLocations("2", "Crawl space", "Vide sanitaire", false);
        public static readonly DuctLocations Attic = new DuctLocations("3", "Attic", "Grenier", false);
        public static readonly DuctLocations MainFloor = new DuctLocations("4", "Main floor", "Rez-de-chauss\x00e9e", false);

        private DuctLocations()
        {
        }

        private DuctLocations(string code, string englishText, string frenchText, bool isUserSpecified = false) : base(code, englishText, frenchText, isUserSpecified)
        {
        }

        public static List<DuctLocations> All
        {
            get
            {
                List<DuctLocations> list1 = new List<DuctLocations>();
                list1.Add(Basement);
                list1.Add(CrawlSpace);
                list1.Add(Attic);
                list1.Add(MainFloor);
                return list1;
            }
        }
    }
}

