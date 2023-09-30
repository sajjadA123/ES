namespace ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    public class Months : ResourceList
    {
        public static readonly Months January = new Months("1", "January", "Janvier", false);
        public static readonly Months February = new Months("2", "February", "F\x00e9vrier", false);
        public static readonly Months March = new Months("3", "March", "Mars", false);
        public static readonly Months April = new Months("4", "April", "Avril", false);
        public static readonly Months May = new Months("5", "May", "Mai", false);
        public static readonly Months June = new Months("6", "June", "Juin", false);
        public static readonly Months July = new Months("7", "July", "Juillet", false);
        public static readonly Months August = new Months("8", "August", "Ao\x00fbt", false);
        public static readonly Months September = new Months("9", "September", "Septembre", false);
        public static readonly Months October = new Months("10", "October", "Octobre", false);
        public static readonly Months November = new Months("11", "November", "Novembre", false);
        public static readonly Months December = new Months("12", "December", "D\x00e9cembre", false);

        private Months()
        {
        }

        private Months(string code, string englishText, string frenchText, bool isUserSpecified = false) : base(code, englishText, frenchText, isUserSpecified)
        {
        }

        public static List<Months> All
        {
            get
            {
                List<Months> list1 = new List<Months>();
                list1.Add(January);
                list1.Add(February);
                list1.Add(March);
                list1.Add(April);
                list1.Add(May);
                list1.Add(June);
                list1.Add(July);
                list1.Add(August);
                list1.Add(September);
                list1.Add(October);
                list1.Add(November);
                list1.Add(December);
                return list1;
            }
        }
    }
}

