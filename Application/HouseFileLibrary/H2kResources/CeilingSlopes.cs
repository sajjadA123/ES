namespace ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    public class CeilingSlopes : ResourceValueList
    {
        public static readonly CeilingSlopes FlatRoof = new CeilingSlopes("1", "Flat roof", "Toit plat", 0.0M, false);
        public static readonly CeilingSlopes Slope2Twelfth = new CeilingSlopes("2", "2 / 12", "2 / 12", 0.167M, false);
        public static readonly CeilingSlopes Slope3Twelfth = new CeilingSlopes("3", "3 / 12", "3 / 12", 0.25M, false);
        public static readonly CeilingSlopes Slope4Twelfth = new CeilingSlopes("4", "4 / 12", "4 / 12", 0.333M, false);
        public static readonly CeilingSlopes Slope5Twelfth = new CeilingSlopes("5", "5 / 12", "5 / 12", 0.417M, false);
        public static readonly CeilingSlopes Slope6Twelfth = new CeilingSlopes("6", "6 / 12", "6 / 12", 0.5M, false);
        public static readonly CeilingSlopes Slope7Twelfth = new CeilingSlopes("7", "7 / 12", "7 / 12", 0.583M, false);

        private CeilingSlopes()
        {
        }

        private CeilingSlopes(string code, string englishText, string frenchText, decimal value = 0M, bool isUserSpecified = false) : base(code, englishText, frenchText, value, isUserSpecified)
        {
        }

        public static CeilingSlopes UserSpecified =>
            new CeilingSlopes("0", "User specified", "Sp\x00e9cifi\x00e9 par l'utilisateur", 0M, true);

        public static List<CeilingSlopes> All
        {
            get
            {
                List<CeilingSlopes> list1 = new List<CeilingSlopes>();
                list1.Add(UserSpecified);
                list1.Add(FlatRoof);
                list1.Add(Slope2Twelfth);
                list1.Add(Slope3Twelfth);
                list1.Add(Slope4Twelfth);
                list1.Add(Slope5Twelfth);
                list1.Add(Slope6Twelfth);
                list1.Add(Slope7Twelfth);
                return list1;
            }
        }
    }
}

