namespace ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    public class SoilConditions : ResourceList
    {
        public static readonly SoilConditions NormalConductivityDrySandLoamClay = new SoilConditions("1", "Normal conductivity (dry sand, loam, clay)", "conductivit\x00e9 normale (sable sec, argile)", false);
        public static readonly SoilConditions HighConductivityMoistSoil = new SoilConditions("2", "High conductivity (moist soil)", "conductivit\x00e9 \x00e9lev\x00e9e (sol humide)", false);
        public static readonly SoilConditions PermaFrostSoil = new SoilConditions("3", "Perma-frost soil", "Perg\x00e9lisol", false);

        private SoilConditions()
        {
        }

        private SoilConditions(string code, string englishText, string frenchText, bool isUserSpecified = false) : base(code, englishText, frenchText, isUserSpecified)
        {
        }

        public static List<SoilConditions> All
        {
            get
            {
                List<SoilConditions> list1 = new List<SoilConditions>();
                list1.Add(NormalConductivityDrySandLoamClay);
                list1.Add(HighConductivityMoistSoil);
                list1.Add(PermaFrostSoil);
                return list1;
            }
        }
    }
}

