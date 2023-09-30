namespace ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    public class WindowTilts : ResourceValueList
    {
        public static readonly WindowTilts Vertical = new WindowTilts("1", "Vertical", "Verticale", 90M, false);
        public static readonly WindowTilts Horizontal = new WindowTilts("2", "Horizontal", "Horizontale", 0M, false);

        private WindowTilts()
        {
        }

        private WindowTilts(string code, string englishText, string frenchText, decimal value = 0M, bool isUserSpecified = false) : base(code, englishText, frenchText, value, isUserSpecified)
        {
        }

        public static WindowTilts SameAsRoof =>
            new WindowTilts("3", "Same as roof", "Identique au toit", 0M, true);

        public static WindowTilts UserSpecified =>
            new WindowTilts("4", "User specified", "Sp\x00e9cifi\x00e9 par l'utilisateur", 0M, true);

        public static List<WindowTilts> All
        {
            get
            {
                List<WindowTilts> list1 = new List<WindowTilts>();
                list1.Add(Vertical);
                list1.Add(Horizontal);
                list1.Add(SameAsRoof);
                list1.Add(UserSpecified);
                return list1;
            }
        }
    }
}

