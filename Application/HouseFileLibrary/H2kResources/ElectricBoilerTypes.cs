namespace ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    public class ElectricBoilerTypes : ResourceList, IBoilerTypes
    {
        public static readonly ElectricBoilerTypes ElectricBoiler = new ElectricBoilerTypes("2", "Electric boiler", "Chaudi\x00e8re \x00e9lectrique", false);

        private ElectricBoilerTypes()
        {
        }

        private ElectricBoilerTypes(string code, string englishText, string frenchText, bool isUserSpecified = false) : base(code, englishText, frenchText, isUserSpecified)
        {
        }

        public static List<ElectricBoilerTypes> All
        {
            get
            {
                List<ElectricBoilerTypes> list1 = new List<ElectricBoilerTypes>();
                list1.Add(ElectricBoiler);
                return list1;
            }
        }
    }
}

