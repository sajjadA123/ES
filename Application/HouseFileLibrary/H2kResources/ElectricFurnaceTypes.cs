namespace ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    public class ElectricFurnaceTypes : ResourceList, IFurnaceTypes
    {
        public static readonly ElectricFurnaceTypes ElectricFurnace = new ElectricFurnaceTypes("2", "Electric furnace", "Fournaise \x00e9lectrique", false);

        private ElectricFurnaceTypes()
        {
        }

        private ElectricFurnaceTypes(string code, string englishText, string frenchText, bool isUserSpecified = false) : base(code, englishText, frenchText, isUserSpecified)
        {
        }

        public static List<ElectricFurnaceTypes> All
        {
            get
            {
                List<ElectricFurnaceTypes> list1 = new List<ElectricFurnaceTypes>();
                list1.Add(ElectricFurnace);
                return list1;
            }
        }
    }
}

