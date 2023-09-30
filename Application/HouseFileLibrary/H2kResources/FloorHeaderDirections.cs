namespace ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    public class FloorHeaderDirections : ResourceList
    {
        public static readonly FloorHeaderDirections NotApplicable = new FloorHeaderDirections("1", "N/A", "S/O", false);
        public static readonly FloorHeaderDirections South = new FloorHeaderDirections("2", "South", "Sud", false);
        public static readonly FloorHeaderDirections Southeast = new FloorHeaderDirections("3", "Southeast", "Sud-est", false);
        public static readonly FloorHeaderDirections East = new FloorHeaderDirections("4", "East", "Est", false);
        public static readonly FloorHeaderDirections Northeast = new FloorHeaderDirections("5", "Northeast", "Nord-est", false);
        public static readonly FloorHeaderDirections North = new FloorHeaderDirections("6", "North", "Nord", false);
        public static readonly FloorHeaderDirections Northwest = new FloorHeaderDirections("7", "Northwest", "Nord-ouest", false);
        public static readonly FloorHeaderDirections West = new FloorHeaderDirections("8", "West", "Ouest", false);
        public static readonly FloorHeaderDirections Southwest = new FloorHeaderDirections("9", "Southwest", "Sud-ouest", false);

        private FloorHeaderDirections()
        {
        }

        private FloorHeaderDirections(string code, string englishText, string frenchText, bool isUserSpecified = false) : base(code, englishText, frenchText, isUserSpecified)
        {
        }

        public static List<FloorHeaderDirections> All
        {
            get
            {
                List<FloorHeaderDirections> list1 = new List<FloorHeaderDirections>();
                list1.Add(NotApplicable);
                list1.Add(South);
                list1.Add(Southeast);
                list1.Add(East);
                list1.Add(Northeast);
                list1.Add(North);
                list1.Add(Northwest);
                list1.Add(West);
                list1.Add(Southwest);
                return list1;
            }
        }
    }
}

