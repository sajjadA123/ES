namespace ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    public class HouseTypes : ResourceList, IHouseTypes
    {
        public static readonly HouseTypes SingleDetached = new HouseTypes("1", "Single Detached", "D\x00e9tach\x00e9", false);
        public static readonly HouseTypes DoubleSemiDetached = new HouseTypes("2", "Double/Semi-detached", "Double/semi-d\x00e9tach\x00e9", false);
        public static readonly HouseTypes DuplexNonMurb = new HouseTypes("3", "Duplex (non-MURB)", " Duplex (non IRLM)", false);
        public static readonly HouseTypes TriplexNonMurb = new HouseTypes("4", "Triplex (non-MURB)", "Triplex (non IRLM)", false);
        public static readonly HouseTypes RowHouseEndUnit = new HouseTypes("6", "Row house, end unit", "Rang\x00e9e, unit\x00e9 d'extr\x00e9mit\x00e9", false);
        public static readonly HouseTypes RowHouseMiddleUnit = new HouseTypes("8", "Row house, middle unit", "Rang\x00e9e, unit\x00e9 du milieu", false);
        public static readonly HouseTypes MobileHome = new HouseTypes("7", "Mobile Home", "Maison mobile", false);
        public static readonly HouseTypes ApartmentNonMurb = new HouseTypes("5", "Apartment (non-MURB)", "Appartement (non IRLM)", false);

        private HouseTypes()
        {
        }

        private HouseTypes(string code, string englishText, string frenchText, bool isUserSpecified = false) : base(code, englishText, frenchText, isUserSpecified)
        {
        }

        public static List<HouseTypes> All
        {
            get
            {
                List<HouseTypes> list1 = new List<HouseTypes>();
                list1.Add(SingleDetached);
                list1.Add(DoubleSemiDetached);
                list1.Add(DuplexNonMurb);
                list1.Add(TriplexNonMurb);
                list1.Add(RowHouseEndUnit);
                list1.Add(RowHouseMiddleUnit);
                list1.Add(MobileHome);
                list1.Add(ApartmentNonMurb);
                return list1;
            }
        }
    }
}

