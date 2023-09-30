namespace ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    public class SheathingMaterials : ResourceValueList
    {
        public static readonly SheathingMaterials WaferboardOsm9_5Mm = new SheathingMaterials("2", "Waferboard/OSM 9.5 mm (3/8 in)", "Pan. cop./OSB 9.5 mm (3/8 po)", 0.105M, false);
        public static readonly SheathingMaterials WaferboardOsm11_1Mm = new SheathingMaterials("3", "Waferboard/OSM 11.1 mm (7/16 in)", "Pan. cop./OSB 11.1 mm (7/16 po)", 0.122M, false);
        public static readonly SheathingMaterials WaferboardOsm15_9Mm = new SheathingMaterials("4", "Waferboard/OSM 15.9 mm (5/8 in)", "Pan. cop./OSB 1.9 mm (5/8 po)", 0.175M, false);
        public static readonly SheathingMaterials PlywoodPartBd9_5Mm = new SheathingMaterials("5", "Plywood/Part. bd 9.5 mm (3/8 in)", "Cont./pan. part. 9.5 mm (3/8 po)", 0.083M, false);
        public static readonly SheathingMaterials PlywoodPartBd12_7Mm = new SheathingMaterials("6", "Plywood/Part. bd 12.7 mm (1/2 in)", "Cont./pan. part. 12.7 mm (1/2 po)", 0.111M, false);
        public static readonly SheathingMaterials PlywoodPartBd15_5Mm = new SheathingMaterials("7", "Plywood/Part. bd 15.5 mm (5/8 in)", "Cont./pan. part. 15.5 mm (5/8 po)", 0.135M, false);
        public static readonly SheathingMaterials PlywoodPartBd18_5Mm = new SheathingMaterials("8", "Plywood/Part. bd 18.5 mm (3/4 in)", "Cont./pan. part. 18.5 mm (3/4 po)", 0.161M, false);
        public static readonly SheathingMaterials Fibreboard9_5Mm = new SheathingMaterials("9", "Fibreboard 9.5 mm (3/8 in)", "Pan. fibres 9.5 mm (3/8 po)", 0.157M, false);
        public static readonly SheathingMaterials Fibreboard11_1Mm = new SheathingMaterials("10", "Fibreboard 11.1 mm (7/16 in)", "Pan. fibres 11.1 mm (7/16 po)", 0.183M, false);
        public static readonly SheathingMaterials GypsumSheating9_5Mm = new SheathingMaterials("11", "Gypsum sheating 9.5 mm (3/8 in)", "Plaque pl\x00e2tre 9.5 mm (3/8 po)", 0.059M, false);
        public static readonly SheathingMaterials GypsumSheating12_7Mm = new SheathingMaterials("12", "Gypsum sheating 12.7 mm (1/2 in)", "Plaque pl\x00e2tre 12.7 mm (1/2 po)", 0.079M, false);

        private SheathingMaterials()
        {
        }

        private SheathingMaterials(string code, string englishText, string frenchText, decimal value = 0M, bool isUserSpecified = false) : base(code, englishText, frenchText, value, isUserSpecified)
        {
        }

        public static SheathingMaterials UserSpecified =>
            new SheathingMaterials("1", "User specified", "Sp\x00e9cifi\x00e9 par l'utilisateur", 0M, true);

        public static List<SheathingMaterials> All
        {
            get
            {
                List<SheathingMaterials> list1 = new List<SheathingMaterials>();
                list1.Add(UserSpecified);
                list1.Add(WaferboardOsm9_5Mm);
                list1.Add(WaferboardOsm11_1Mm);
                list1.Add(WaferboardOsm15_9Mm);
                list1.Add(PlywoodPartBd9_5Mm);
                list1.Add(PlywoodPartBd12_7Mm);
                list1.Add(PlywoodPartBd15_5Mm);
                list1.Add(PlywoodPartBd18_5Mm);
                list1.Add(Fibreboard9_5Mm);
                list1.Add(Fibreboard11_1Mm);
                list1.Add(GypsumSheating9_5Mm);
                list1.Add(GypsumSheating12_7Mm);
                return list1;
            }
        }
    }
}

