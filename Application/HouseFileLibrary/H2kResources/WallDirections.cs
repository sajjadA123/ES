namespace ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    public class WallDirections : ResourceList
    {
        public static readonly WallDirections NotApplicable = new WallDirections("1", "N/A", "S/O", false);
        public static readonly WallDirections South = new WallDirections("2", "South", "Sud", false);
        public static readonly WallDirections Southeast = new WallDirections("3", "Southeast", "Sud-est", false);
        public static readonly WallDirections East = new WallDirections("4", "East", "Est", false);
        public static readonly WallDirections Northeast = new WallDirections("5", "Northeast", "Nord-est", false);
        public static readonly WallDirections North = new WallDirections("6", "North", "Nord", false);
        public static readonly WallDirections Northwest = new WallDirections("7", "Northwest", "Nord-ouest", false);
        public static readonly WallDirections West = new WallDirections("8", "West", "Ouest", false);
        public static readonly WallDirections Southwest = new WallDirections("9", "Southwest", "Sud-ouest", false);

        private WallDirections()
        {
        }

        private WallDirections(string code, string englishText, string frenchText, bool isUserSpecified = false) : base(code, englishText, frenchText, isUserSpecified)
        {
        }

        public static List<WallDirections> All
        {
            get
            {
                List<WallDirections> list1 = new List<WallDirections>();
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

