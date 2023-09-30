namespace ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    public class ShowerTemperatures : ResourceList
    {
        public static readonly ShowerTemperatures Cool37C = new ShowerTemperatures("1", "Cool 37\x00b0C (99\x00b0F)", "Fra\x00eeche 37\x00b0C (99\x00b0F)", false);
        public static readonly ShowerTemperatures Warm41C = new ShowerTemperatures("2", "Warm 41\x00b0C (106\x00b0F)", "Temp\x00e9r\x00e9e 41\x00b0C (106\x00b0F)", false);
        public static readonly ShowerTemperatures Hot45C = new ShowerTemperatures("3", "Hot 45\x00b0C (113\x00b0F)", "Chaude 45\x00b0C (113\x00b0F)", false);

        private ShowerTemperatures()
        {
        }

        private ShowerTemperatures(string code, string englishText, string frenchText, bool isUserSpecified = false) : base(code, englishText, frenchText, isUserSpecified)
        {
        }

        public static List<ShowerTemperatures> All
        {
            get
            {
                List<ShowerTemperatures> list1 = new List<ShowerTemperatures>();
                list1.Add(Cool37C);
                list1.Add(Warm41C);
                list1.Add(Hot45C);
                return list1;
            }
        }
    }
}

