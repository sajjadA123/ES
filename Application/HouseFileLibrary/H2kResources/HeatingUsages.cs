namespace ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    public class HeatingUsages : ResourceList
    {
        public static readonly HeatingUsages Never = new HeatingUsages("1", "Never", "Jamais", false);
        public static readonly HeatingUsages TenPercent = new HeatingUsages("2", "10% of the time", "10% du temps", false);
        public static readonly HeatingUsages TwentyFivePercent = new HeatingUsages("3", "25% of the time", "25%  du temps", false);
        public static readonly HeatingUsages FiftyPercent = new HeatingUsages("4", "50% of the time", "50%  du temps", false);
        public static readonly HeatingUsages SeventyFivePercent = new HeatingUsages("5", "75% of the time", "75%  du temps", false);
        public static readonly HeatingUsages Always = new HeatingUsages("6", "Always", "Toujours", false);
        public static readonly HeatingUsages SpecifiedMonthlyPercent = new HeatingUsages("7", "Specified monthly (%)", "Sp\x00e9cifi\x00e9 mensuellement (%)", false);
        public static readonly HeatingUsages SpecifiedMonthlyHrDay = new HeatingUsages("8", "Specified monthly (hr/day)", "Sp\x00e9cifi\x00e9 mensuellement (hr/jour)", false);

        private HeatingUsages()
        {
        }

        private HeatingUsages(string code, string englishText, string frenchText, bool isUserSpecified = false) : base(code, englishText, frenchText, isUserSpecified)
        {
        }

        public static List<HeatingUsages> All
        {
            get
            {
                List<HeatingUsages> list1 = new List<HeatingUsages>();
                list1.Add(Never);
                list1.Add(TenPercent);
                list1.Add(TwentyFivePercent);
                list1.Add(FiftyPercent);
                list1.Add(SeventyFivePercent);
                list1.Add(Always);
                list1.Add(SpecifiedMonthlyPercent);
                list1.Add(SpecifiedMonthlyHrDay);
                return list1;
            }
        }
    }
}

