namespace ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    public class YearMade : ResourceList
    {
        public static readonly YearMade Before1920 = new YearMade("1", "Before 1920", "Avant 1920", false);
        public static readonly YearMade Years1920To29 = new YearMade("2", "1920-29", "1920-29", false);
        public static readonly YearMade Years1930To39 = new YearMade("3", "1930-39", "1930-39", false);
        public static readonly YearMade Years1940To49 = new YearMade("4", "1940-49", "1940-49", false);
        public static readonly YearMade Years1950To59 = new YearMade("5", "1950-59", "1950-59", false);
        public static readonly YearMade Years1960To69 = new YearMade("6", "1960-69", "1960-69", false);
        public static readonly YearMade Years1970To79 = new YearMade("7", "1970-79", "1970-79", false);
        public static readonly YearMade Years1980To89 = new YearMade("8", "1980-89", "1980-89", false);
        public static readonly YearMade Years1990To99 = new YearMade("9", "1990-99", "1990-99", false);
        public static readonly YearMade After2000 = new YearMade("10", "2000-", "2000-", false);

        private YearMade()
        {
        }

        private YearMade(string code, string englishText, string frenchText, bool isUserSpecified = false) : base(code, englishText, frenchText, isUserSpecified)
        {
        }

        public static List<YearMade> All
        {
            get
            {
                List<YearMade> list1 = new List<YearMade>();
                list1.Add(Before1920);
                list1.Add(Years1920To29);
                list1.Add(Years1930To39);
                list1.Add(Years1940To49);
                list1.Add(Years1950To59);
                list1.Add(Years1960To69);
                list1.Add(Years1970To79);
                list1.Add(Years1980To89);
                list1.Add(Years1990To99);
                list1.Add(After2000);
                return list1;
            }
        }
    }
}

