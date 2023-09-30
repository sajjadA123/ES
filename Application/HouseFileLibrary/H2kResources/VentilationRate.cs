namespace ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    public class VentilationRate : ResourceValueList
    {
        public static readonly VentilationRate NotApplicable = new VentilationRate("1", "Not applicable", "Sans objet", 0.0M, false);
        public static readonly VentilationRate FiveLitersPerSecond = new VentilationRate("2", "5 L/s (11 cfm)", "5 L/s (11 pi\x00b3/min)", 5.0M, false);
        public static readonly VentilationRate TenLitersPerSecond = new VentilationRate("3", "10 L/s (21 cfm)", "10 L/s (21 pi\x00b3/min)", 10.0M, false);

        private VentilationRate()
        {
        }

        private VentilationRate(string code, string englishText, string frenchText, decimal value = 0M, bool isUserSpecified = false) : base(code, englishText, frenchText, value, isUserSpecified)
        {
        }

        public static List<VentilationRate> All
        {
            get
            {
                List<VentilationRate> list1 = new List<VentilationRate>();
                list1.Add(NotApplicable);
                list1.Add(FiveLitersPerSecond);
                list1.Add(TenLitersPerSecond);
                return list1;
            }
        }
    }
}

