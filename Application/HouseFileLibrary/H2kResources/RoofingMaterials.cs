namespace ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    public class RoofingMaterials : ResourceValueList
    {
        public static readonly RoofingMaterials AsphaltShingles = new RoofingMaterials("2", "Asphalt shingles", "Bardeau d'asphalte", 0.078M, false);
        public static readonly RoofingMaterials MetalRoofing = new RoofingMaterials("3", "Metal roofing", "Toiture de m\x00e9tal", 0.110M, false);
        public static readonly RoofingMaterials BuiltUpMembrane = new RoofingMaterials("4", "Built-up membrane", "Membrane multicouche", 0.058M, false);
        public static readonly RoofingMaterials AsphaltRollRoofing = new RoofingMaterials("5", "Asphalt roll roofing", "Toit lamin\x00e9 d'asphalte", 0.026M, false);
        public static readonly RoofingMaterials WoodShingles = new RoofingMaterials("6", "Wood shingles", "Bardeau de bois", 0.165M, false);
        public static readonly RoofingMaterials CrushedStoneNotDried = new RoofingMaterials("7", "Crushed stone (not dried)", "Pierre concass\x00e9e (pas s\x00e8che)", 0.150M, false);
        public static readonly RoofingMaterials Slate = new RoofingMaterials("8", "Slate", "Ardoise", 0.009M, false);
        public static readonly RoofingMaterials ClayTile = new RoofingMaterials("9", "Clay tile", "Tuile d'argile", 0.200M, false);

        private RoofingMaterials()
        {
        }

        private RoofingMaterials(string code, string englishText, string frenchText, decimal value = 0M, bool isUserSpecified = false) : base(code, englishText, frenchText, value, isUserSpecified)
        {
        }

        public static RoofingMaterials UserSpecified =>
            new RoofingMaterials("1", "User specified", "Indiqu\x00e9 par l'util.", 0M, true);

        public static List<RoofingMaterials> All
        {
            get
            {
                List<RoofingMaterials> list1 = new List<RoofingMaterials>();
                list1.Add(UserSpecified);
                list1.Add(AsphaltShingles);
                list1.Add(MetalRoofing);
                list1.Add(BuiltUpMembrane);
                list1.Add(AsphaltRollRoofing);
                list1.Add(WoodShingles);
                list1.Add(CrushedStoneNotDried);
                list1.Add(Slate);
                list1.Add(ClayTile);
                return list1;
            }
        }
    }
}

