namespace ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    public class BaseShowerTemperatures : ResourceValueList
    {
        public static readonly BaseShowerTemperatures Cool37C = new BaseShowerTemperatures("0", "Cool 37\x00b0C (99\x00b0F)", "Fra\x00eeche 37\x00b0C (99\x00b0F)", 37M, false);
        public static readonly BaseShowerTemperatures Warm41C = new BaseShowerTemperatures("1", "Warm 41\x00b0C (106\x00b0F)", "Temp\x00e9r\x00e9e 41\x00b0C (106\x00b0F)", 41M, false);
        public static readonly BaseShowerTemperatures Hot45C = new BaseShowerTemperatures("2", "Hot 45\x00b0C (113\x00b0F)", "Chaude 45\x00b0C (113\x00b0F)", 45M, false);

        private BaseShowerTemperatures()
        {
        }

        private BaseShowerTemperatures(string code, string englishText, string frenchText, decimal value = 0M, bool isUserSpecified = false) : base(code, englishText, frenchText, value, isUserSpecified)
        {
        }

        public static List<BaseShowerTemperatures> All
        {
            get
            {
                List<BaseShowerTemperatures> list1 = new List<BaseShowerTemperatures>();
                list1.Add(Cool37C);
                list1.Add(Warm41C);
                list1.Add(Hot45C);
                return list1;
            }
        }
    }
}

