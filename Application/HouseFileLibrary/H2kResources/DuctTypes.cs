namespace ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    public class DuctTypes : ResourceList
    {
        public static readonly DuctTypes Flexible = new DuctTypes("1", "Flexible", "Flexible", false);
        public static readonly DuctTypes SheetMetalWLiner = new DuctTypes("2", "Sheet metal w/ liner", "T\x00f4le doubl\x00e9e", false);
        public static readonly DuctTypes ExteriorInsulatedSheetMetal = new DuctTypes("3", "Exterior insulated sheet metal", "T\x00f4le isol\x00e9e ext\x00e9rieure", false);

        private DuctTypes()
        {
        }

        private DuctTypes(string code, string englishText, string frenchText, bool isUserSpecified = false) : base(code, englishText, frenchText, isUserSpecified)
        {
        }

        public static List<DuctTypes> All
        {
            get
            {
                List<DuctTypes> list1 = new List<DuctTypes>();
                list1.Add(Flexible);
                list1.Add(SheetMetalWLiner);
                list1.Add(ExteriorInsulatedSheetMetal);
                return list1;
            }
        }
    }
}

