namespace ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    public class DhwTankLocations : ResourceList
    {
        public static readonly DhwTankLocations MainFloor = new DhwTankLocations("1", "Main floor", "Rez-de-chauss\x00e9e", false);
        public static readonly DhwTankLocations Basement = new DhwTankLocations("2", "Basement", "Sous-sol", false);
        public static readonly DhwTankLocations Attic = new DhwTankLocations("3", "Attic", "Combles", false);
        public static readonly DhwTankLocations CrawlSpace = new DhwTankLocations("4", "Crawl space", "Vide sanitaire", false);
        public static readonly DhwTankLocations Garage = new DhwTankLocations("5", "Garage", "Garage", false);
        public static readonly DhwTankLocations Porch = new DhwTankLocations("6", "Porch", "V\x00e9randa", false);
        public static readonly DhwTankLocations Outside = new DhwTankLocations("7", "Outside", "Ext\x00e9rieur", false);

        private DhwTankLocations()
        {
        }

        private DhwTankLocations(string code, string englishText, string frenchText, bool isUserSpecified = false) : base(code, englishText, frenchText, isUserSpecified)
        {
        }

        public static List<DhwTankLocations> All
        {
            get
            {
                List<DhwTankLocations> list1 = new List<DhwTankLocations>();
                list1.Add(MainFloor);
                list1.Add(Basement);
                list1.Add(Attic);
                list1.Add(CrawlSpace);
                list1.Add(Garage);
                list1.Add(Porch);
                list1.Add(Outside);
                return list1;
            }
        }
    }
}

