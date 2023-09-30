namespace ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    public class WindowDirections : ResourceList
    {
        public static readonly WindowDirections South = new WindowDirections("1", "South", "Sud", false);
        public static readonly WindowDirections Southeast = new WindowDirections("2", "Southeast", "Sud-est", false);
        public static readonly WindowDirections East = new WindowDirections("3", "East", "Est", false);
        public static readonly WindowDirections Northeast = new WindowDirections("4", "Northeast", "Nord-est", false);
        public static readonly WindowDirections North = new WindowDirections("5", "North", "Nord", false);
        public static readonly WindowDirections Northwest = new WindowDirections("6", "Northwest", "Nord-ouest", false);
        public static readonly WindowDirections West = new WindowDirections("7", "West", "Ouest", false);
        public static readonly WindowDirections Southwest = new WindowDirections("8", "Southwest", "Sud-ouest", false);

        private WindowDirections()
        {
        }

        private WindowDirections(string code, string englishText, string frenchText, bool isUserSpecified = false) : base(code, englishText, frenchText, isUserSpecified)
        {
        }

        public static List<WindowDirections> All
        {
            get
            {
                List<WindowDirections> list1 = new List<WindowDirections>();
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

