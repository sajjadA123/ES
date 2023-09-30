namespace ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    public class CentralEquipmentTypes : ResourceList
    {
        public static readonly CentralEquipmentTypes CentralSplitSystem = new CentralEquipmentTypes("1", "Central split system", "Syst\x00e8me central bibloc", false);
        public static readonly CentralEquipmentTypes CentralSinglePackageSystem = new CentralEquipmentTypes("2", "Central single package system", "Syst\x00e8me central monobloc", false);
        public static readonly CentralEquipmentTypes MiniSplitDuctless = new CentralEquipmentTypes("3", "Mini-split ductless", "Petit syst\x00e8me bibloc sans conduits", false);

        private CentralEquipmentTypes()
        {
        }

        private CentralEquipmentTypes(string code, string englishText, string frenchText, bool isUserSpecified = false) : base(code, englishText, frenchText, isUserSpecified)
        {
        }

        public static List<CentralEquipmentTypes> All
        {
            get
            {
                List<CentralEquipmentTypes> list1 = new List<CentralEquipmentTypes>();
                list1.Add(CentralSplitSystem);
                list1.Add(CentralSinglePackageSystem);
                list1.Add(MiniSplitDuctless);
                return list1;
            }
        }
    }
}

