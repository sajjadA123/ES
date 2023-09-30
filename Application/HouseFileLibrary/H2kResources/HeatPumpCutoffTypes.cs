namespace ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    public class HeatPumpCutoffTypes : ResourceValueList
    {
        public static readonly HeatPumpCutoffTypes BalancePoint = new HeatPumpCutoffTypes("1", "Balance point", "Point d'\x00e9quilibre", 0M, false);
        public static readonly HeatPumpCutoffTypes Unrestricted = new HeatPumpCutoffTypes("3", "Unrestricted", "Non restreint", 0M, false);

        private HeatPumpCutoffTypes()
        {
        }

        private HeatPumpCutoffTypes(string code, string englishText, string frenchText, decimal value = 0M, bool isUserSpecified = false) : base(code, englishText, frenchText, value, isUserSpecified)
        {
        }

        public static HeatPumpCutoffTypes Restricted =>
            new HeatPumpCutoffTypes("2", "Restricted", "Restreint", 0M, true);

        public static List<HeatPumpCutoffTypes> All
        {
            get
            {
                List<HeatPumpCutoffTypes> list1 = new List<HeatPumpCutoffTypes>();
                list1.Add(BalancePoint);
                list1.Add(Restricted);
                list1.Add(Unrestricted);
                return list1;
            }
        }
    }
}

