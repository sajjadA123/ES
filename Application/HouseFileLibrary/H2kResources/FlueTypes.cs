namespace ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    public class FlueTypes : ResourceList
    {
        public static readonly FlueTypes Brick = new FlueTypes("1", "Brick", "Brique", false);
        public static readonly FlueTypes BrickTileLined = new FlueTypes("2", "Brick/Tile lined", "Brique/Tuile contrecoll\x00e9", false);
        public static readonly FlueTypes PlasticSingleWall = new FlueTypes("3", "Plastic single wall", "Mur plastique \x00e0 paroi simple", false);
        public static readonly FlueTypes Metal = new FlueTypes("4", "Metal", "M\x00e9tal", false);
        public static readonly FlueTypes MetalInsulated = new FlueTypes("5", "Metal insulated", "M\x00e9tal isol\x00e9", false);

        private FlueTypes()
        {
        }

        private FlueTypes(string code, string englishText, string frenchText, bool isUserSpecified = false) : base(code, englishText, frenchText, isUserSpecified)
        {
        }

        public static List<FlueTypes> All
        {
            get
            {
                List<FlueTypes> list1 = new List<FlueTypes>();
                list1.Add(Brick);
                list1.Add(BrickTileLined);
                list1.Add(PlasticSingleWall);
                list1.Add(Metal);
                list1.Add(MetalInsulated);
                return list1;
            }
        }
    }
}

