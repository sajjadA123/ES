namespace ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    public class Terrains : ResourceList
    {
        public static readonly Terrains OpenSeaFetch5Km = new Terrains("1", "Open sea, fetch > 5 km", "Pr\x00e8s de la mer > 5 km", false);
        public static readonly Terrains MudFlatsNoVegetation = new Terrains("2", "Mud flats, no vegetation", "Aucune v\x00e9g\x00e9tation, slikke", false);
        public static readonly Terrains OpenFlatTerrainGrass = new Terrains("3", "Open flat terrain, grass", "Prairie \x00e0 l'herbe", false);
        public static readonly Terrains LowCrops = new Terrains("4", "Low crops", "Cultures basses", false);
        public static readonly Terrains HighCropsScatteredObstacles = new Terrains("5", "High crops, scattered obstacles", "Culture haute, obstacles", false);
        public static readonly Terrains ParklandBushes = new Terrains("6", "Parkland, bushes", "Parc, bois\x00e9s", false);
        public static readonly Terrains SuburbanForest = new Terrains("7", "Suburban, forest", "Banlieue, for\x00eat", false);
        public static readonly Terrains CityCentre = new Terrains("8", "City centre", "Centre-ville", false);

        private Terrains()
        {
        }

        private Terrains(string code, string englishText, string frenchText, bool isUserSpecified = false) : base(code, englishText, frenchText, isUserSpecified)
        {
        }

        public static List<Terrains> All
        {
            get
            {
                List<Terrains> list1 = new List<Terrains>();
                list1.Add(OpenSeaFetch5Km);
                list1.Add(MudFlatsNoVegetation);
                list1.Add(OpenFlatTerrainGrass);
                list1.Add(LowCrops);
                list1.Add(HighCropsScatteredObstacles);
                list1.Add(ParklandBushes);
                list1.Add(SuburbanForest);
                list1.Add(CityCentre);
                return list1;
            }
        }
    }
}

