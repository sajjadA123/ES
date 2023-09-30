namespace ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    public class DepressurizationLimits : ResourceValueList
    {
        public static readonly DepressurizationLimits FivePa = new DepressurizationLimits("1", "5 Pa", "5 Pa", 5M, false);
        public static readonly DepressurizationLimits TenPa = new DepressurizationLimits("2", "10 Pa", "10 Pa", 10M, false);
        public static readonly DepressurizationLimits NoLimit = new DepressurizationLimits("3", " No limit", " Aucune limite", 0M, false);

        private DepressurizationLimits()
        {
        }

        private DepressurizationLimits(string code, string englishText, string frenchText, decimal value = 0M, bool isUserSpecified = false) : base(code, englishText, frenchText, value, isUserSpecified)
        {
        }

        public static DepressurizationLimits UserSpecified =>
            new DepressurizationLimits("4", " User specified", " Sp\x00e9cifi\x00e9 par l'util.", 0M, true);

        public static List<DepressurizationLimits> All
        {
            get
            {
                List<DepressurizationLimits> list1 = new List<DepressurizationLimits>();
                list1.Add(FivePa);
                list1.Add(TenPa);
                list1.Add(NoLimit);
                list1.Add(UserSpecified);
                return list1;
            }
        }
    }
}

