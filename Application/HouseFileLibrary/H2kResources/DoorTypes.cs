namespace ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    public class DoorTypes : ResourceValueList
    {
        public static readonly DoorTypes WoodHollowCore = new DoorTypes("1", "Wood hollow core", "Bois / \x00e2me creuse", 0.37M, false);
        public static readonly DoorTypes SolidWood = new DoorTypes("2", "Solid wood", "Bois massif", 0.39M, false);
        public static readonly DoorTypes SteelFibreglassCore = new DoorTypes("3", "Steel fibreglass core", "Acier / \x00e2me en fibre de verre", 0.29M, false);
        public static readonly DoorTypes SteelPolystyreneCore = new DoorTypes("4", "Steel polystyrene core", "Acier / \x00e2me en polystyr\x00e8ne", 0.98M, false);
        public static readonly DoorTypes SteelMediumDensitySprayFoamCore = new DoorTypes("5", "Steel Medium density spray foam core", "Acier / \x00e2me en mousse \x00e0 vaporiser de densit\x00e9 moyenne", 1.14M, false);
        public static readonly DoorTypes FibreglassPolystyreneCore = new DoorTypes("6", "Fibreglass polystyrene core", "Fibre de verre / \x00e2me en polystyr\x00e8ne", 0.85M, false);
        public static readonly DoorTypes FibreglassMediumDensitySprayFoamCore = new DoorTypes("7", "Fibreglass Medium density spray foam core", "Fibre de verre / \x00e2me en mousse \x00e0 vaporiser de densit\x00e9 moyenne", 0.98M, false);

        private DoorTypes()
        {
        }

        private DoorTypes(string code, string englishText, string frenchText, decimal value = 0M, bool isUserSpecified = false) : base(code, englishText, frenchText, value, isUserSpecified)
        {
        }

        public static DoorTypes UserSpecified =>
            new DoorTypes("8", "User specified", "Sp\x00e9cifi\x00e9 par l'utilisateur", 0M, true);

        public static List<DoorTypes> All
        {
            get
            {
                List<DoorTypes> list1 = new List<DoorTypes>();
                list1.Add(WoodHollowCore);
                list1.Add(SolidWood);
                list1.Add(SteelFibreglassCore);
                list1.Add(SteelPolystyreneCore);
                list1.Add(SteelMediumDensitySprayFoamCore);
                list1.Add(FibreglassPolystyreneCore);
                list1.Add(FibreglassMediumDensitySprayFoamCore);
                list1.Add(UserSpecified);
                return list1;
            }
        }
    }
}

