namespace ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    public class HouseDirections : ResourceList
    {
        public static readonly HouseDirections South = new HouseDirections("1", "South", "Sud", false);
        public static readonly HouseDirections Southeast = new HouseDirections("2", "Southeast", "Sud-est", false);
        public static readonly HouseDirections East = new HouseDirections("3", "East", "Est", false);
        public static readonly HouseDirections Northeast = new HouseDirections("4", "Northeast", "Nord-est", false);
        public static readonly HouseDirections North = new HouseDirections("5", "North", "Nord", false);
        public static readonly HouseDirections Northwest = new HouseDirections("6", "Northwest", "Nord-ouest", false);
        public static readonly HouseDirections West = new HouseDirections("7", "West", "Ouest", false);
        public static readonly HouseDirections Southwest = new HouseDirections("8", "Southwest", "Sud-ouest", false);

        private HouseDirections()
        {
        }

        private HouseDirections(string code, string englishText, string frenchText, bool isUserSpecified = false) : base(code, englishText, frenchText, isUserSpecified)
        {
        }

        public static List<HouseDirections> All
        {
            get
            {
                List<HouseDirections> list1 = new List<HouseDirections>();
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

