namespace ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    public class HouseTypesMurb : ResourceList, IHouseTypes
    {
        public static readonly HouseTypesMurb DetachedDuplex = new HouseTypesMurb("9", "Detached Duplex", "Duplex D\x00e9tach\x00e9", false);
        public static readonly HouseTypesMurb DetachedTriplex = new HouseTypesMurb("10", "Detached Triplex", "Triplex D\x00e9tach\x00e9", false);
        public static readonly HouseTypesMurb AttachedDuplex = new HouseTypesMurb("11", "Attached Duplex", "Duplex Attach\x00e9", false);
        public static readonly HouseTypesMurb AttachedTriplex = new HouseTypesMurb("12", "Attached Triplex", "Triplex Attach\x00e9", false);
        public static readonly HouseTypesMurb Apartment = new HouseTypesMurb("13", "Apartment", "Appartement", false);
        public static readonly HouseTypesMurb ApartmentRow = new HouseTypesMurb("14", "Apartment Row", "Rang\x00e9e d'appartements", false);

        private HouseTypesMurb()
        {
        }

        private HouseTypesMurb(string code, string englishText, string frenchText, bool isUserSpecified = false) : base(code, englishText, frenchText, isUserSpecified)
        {
        }

        public static List<HouseTypesMurb> All
        {
            get
            {
                List<HouseTypesMurb> list1 = new List<HouseTypesMurb>();
                list1.Add(DetachedDuplex);
                list1.Add(DetachedTriplex);
                list1.Add(AttachedDuplex);
                list1.Add(AttachedTriplex);
                list1.Add(Apartment);
                list1.Add(ApartmentRow);
                return list1;
            }
        }
    }
}

