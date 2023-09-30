namespace ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    public class YearBuilt : ResourceValueList
    {
        public static readonly YearBuilt Before1920 = new YearBuilt("2", "Before 1920", "Avant 1920", 0M, false);
        public static readonly YearBuilt Years1920To29 = new YearBuilt("3", "1920-29", "1920-29", 0M, false);
        public static readonly YearBuilt Years1930To39 = new YearBuilt("4", "1930-39", "1930-39", 0M, false);
        public static readonly YearBuilt Years1940To49 = new YearBuilt("5", "1940-49", "1940-49", 0M, false);
        public static readonly YearBuilt Years1950To59 = new YearBuilt("6", "1950-59", "1950-59", 0M, false);
        public static readonly YearBuilt Years1960To69 = new YearBuilt("7", "1960-69", "1960-69", 0M, false);
        public static readonly YearBuilt Years1970To79 = new YearBuilt("8", "1970-79", "1970-79", 0M, false);
        public static readonly YearBuilt Years1980To89 = new YearBuilt("9", "1980-89", "1980-89", 0M, false);
        public static readonly YearBuilt Years1990To99 = new YearBuilt("10", "1990-99", "1990-99", 0M, false);
        public static readonly YearBuilt After2000 = new YearBuilt("11", "2000-", "2000-", 0M, false);

        private YearBuilt()
        {
        }

        private YearBuilt(string code, string englishText, string frenchText, decimal value = 0M, bool isUserSpecified = false) : base(code, englishText, frenchText, value, isUserSpecified)
        {
        }

        public static YearBuilt UserSpecified =>
            new YearBuilt("1", "User specified", "Sp\x00e9cifi\x00e9 par l'util.", 0M, true);

        public static List<YearBuilt> All
        {
            get
            {
                List<YearBuilt> list1 = new List<YearBuilt>();
                list1.Add(UserSpecified);
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

