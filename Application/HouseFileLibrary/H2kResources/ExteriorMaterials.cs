namespace ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    public class ExteriorMaterials : ResourceValueList
    {
        public static readonly ExteriorMaterials WoodLapped = new ExteriorMaterials("2", "Wood (lapped)", "Bois", 0.180M, false);
        public static readonly ExteriorMaterials HollowMetalVinylCladding = new ExteriorMaterials("3", "Hollow metal/vinyl cladding", "M\x00e9tal creux/rev\x00eatement vinyle", 0.110M, false);
        public static readonly ExteriorMaterials InsulMetalVinylCladding = new ExteriorMaterials("4", "Insul. metal/vinyl cladding", "M\x00e9tal isol\x00e9/rev\x00eatement vinyle", 0.320M, false);
        public static readonly ExteriorMaterials Brick = new ExteriorMaterials("5", "Brick", "Brique", 0.320M, false);
        public static readonly ExteriorMaterials Mortar = new ExteriorMaterials("6", "Mortar", "Mortier", 0.009M, false);
        public static readonly ExteriorMaterials Stucco = new ExteriorMaterials("7", "Stucco", "Stucco", 0.009M, false);

        private ExteriorMaterials()
        {
        }

        private ExteriorMaterials(string code, string englishText, string frenchText, decimal value = 0M, bool isUserSpecified = false) : base(code, englishText, frenchText, value, isUserSpecified)
        {
        }

        public static ExteriorMaterials UserSpecified =>
            new ExteriorMaterials("1", "User specified", "Indiqu\x00e9 par l'util.", 0M, true);

        public static List<ExteriorMaterials> All
        {
            get
            {
                List<ExteriorMaterials> list1 = new List<ExteriorMaterials>();
                list1.Add(UserSpecified);
                list1.Add(WoodLapped);
                list1.Add(HollowMetalVinylCladding);
                list1.Add(InsulMetalVinylCladding);
                list1.Add(Brick);
                list1.Add(Mortar);
                list1.Add(Stucco);
                return list1;
            }
        }
    }
}

