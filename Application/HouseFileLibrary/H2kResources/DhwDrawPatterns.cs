namespace ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    public class DhwDrawPatterns : ResourceList
    {
        public static readonly DhwDrawPatterns VerySmall = new DhwDrawPatterns("1", "Very-small-usage 38 L (10 US gal)", "Tr\x00e8s faible utilisation 38 L (10 gal US)", false);
        public static readonly DhwDrawPatterns Low = new DhwDrawPatterns("2", "Low-usage 144 L (38 US gal)", "Faible utilisation 144 L (38 gal US)", false);
        public static readonly DhwDrawPatterns Medium = new DhwDrawPatterns("3", "Medium-usage 208 L (55 US gal)", "Moyenne utilisation 208 L (55 gal US)", false);
        public static readonly DhwDrawPatterns High = new DhwDrawPatterns("4", "High-usage 318 L (84 US gal)", "Grande utilisation 318 L (84 gal US)", false);

        private DhwDrawPatterns()
        {
        }

        private DhwDrawPatterns(string code, string englishText, string frenchText, bool isUserSpecified = false) : base(code, englishText, frenchText, isUserSpecified)
        {
        }

        public static List<DhwDrawPatterns> All
        {
            get
            {
                List<DhwDrawPatterns> list1 = new List<DhwDrawPatterns>();
                list1.Add(VerySmall);
                list1.Add(Low);
                list1.Add(Medium);
                list1.Add(High);
                return list1;
            }
        }
    }
}

