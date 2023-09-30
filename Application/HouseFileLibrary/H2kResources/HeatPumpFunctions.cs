namespace ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    public class HeatPumpFunctions : ResourceList
    {
        public static readonly HeatPumpFunctions Heating = new HeatPumpFunctions("1", "Heating", "Chauffage", false);
        public static readonly HeatPumpFunctions HeatingCooling = new HeatPumpFunctions("2", "Heating/Cooling", "Chauffage/climatisation", false);

        private HeatPumpFunctions()
        {
        }

        private HeatPumpFunctions(string code, string englishText, string frenchText, bool isUserSpecified = false) : base(code, englishText, frenchText, isUserSpecified)
        {
        }

        public static List<HeatPumpFunctions> All
        {
            get
            {
                List<HeatPumpFunctions> list1 = new List<HeatPumpFunctions>();
                list1.Add(Heating);
                list1.Add(HeatingCooling);
                return list1;
            }
        }
    }
}

