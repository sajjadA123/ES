namespace ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    public class RoomTypes : ResourceList
    {
        public static readonly RoomTypes Kitchen = new RoomTypes("1", "Kitchen", "Cuisine", false);
        public static readonly RoomTypes LivingRoom = new RoomTypes("2", "Living Room", "Salon", false);
        public static readonly RoomTypes DiningRoom = new RoomTypes("3", "Dining Room", "Salle \x00e0 Manger", false);
        public static readonly RoomTypes Bedroom = new RoomTypes("4", "Bedroom", "Chambre", false);
        public static readonly RoomTypes Bathroom = new RoomTypes("5", "Bathroom", "Salle de Bain", false);
        public static readonly RoomTypes UtilityRoom = new RoomTypes("6", "Utility Room", "Pi\x00e8ce Utilitaire", false);
        public static readonly RoomTypes Other = new RoomTypes("7", "Other", "Autre", false);

        private RoomTypes()
        {
        }

        private RoomTypes(string code, string englishText, string frenchText, bool isUserSpecified = false) : base(code, englishText, frenchText, isUserSpecified)
        {
        }

        public static List<RoomTypes> All
        {
            get
            {
                List<RoomTypes> list1 = new List<RoomTypes>();
                list1.Add(Kitchen);
                list1.Add(LivingRoom);
                list1.Add(DiningRoom);
                list1.Add(Bedroom);
                list1.Add(Bathroom);
                list1.Add(UtilityRoom);
                list1.Add(Other);
                return list1;
            }
        }
    }
}

