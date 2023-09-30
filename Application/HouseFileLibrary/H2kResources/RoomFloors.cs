namespace ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    public class RoomFloors : ResourceList
    {
        public static readonly RoomFloors GroundFloor = new RoomFloors("1", "Ground Floor", "Rez-de-Chauss\x00e9e", false);
        public static readonly RoomFloors SecondFloor = new RoomFloors("2", "Second Floor", "Deuxi\x00e8me \x00c9tage", false);
        public static readonly RoomFloors ThirdFloor = new RoomFloors("3", "Third Floor", "Troisi\x00e8me \x00c9tage", false);

        private RoomFloors()
        {
        }

        private RoomFloors(string code, string englishText, string frenchText, bool isUserSpecified = false) : base(code, englishText, frenchText, isUserSpecified)
        {
        }

        public static List<RoomFloors> All
        {
            get
            {
                List<RoomFloors> list1 = new List<RoomFloors>();
                list1.Add(GroundFloor);
                list1.Add(SecondFloor);
                list1.Add(ThirdFloor);
                return list1;
            }
        }
    }
}

