namespace ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    public class WoodBoilerTypes : ResourceList, IBoilerTypes
    {
        public static readonly WoodBoilerTypes ConventionalBoiler = new WoodBoilerTypes("4", "Conventional boiler", "Chaudi\x00e8re conventionnelle", false);
        public static readonly WoodBoilerTypes OutdoorWoodBoiler = new WoodBoilerTypes("11", "Outdoor wood boiler", "Chaudi\x00e8re \x00e0 bois ext\x00e9rieur", false);

        private WoodBoilerTypes()
        {
        }

        private WoodBoilerTypes(string code, string englishText, string frenchText, bool isUserSpecified = false) : base(code, englishText, frenchText, isUserSpecified)
        {
        }

        public static List<WoodBoilerTypes> All
        {
            get
            {
                List<WoodBoilerTypes> list1 = new List<WoodBoilerTypes>();
                list1.Add(ConventionalBoiler);
                list1.Add(OutdoorWoodBoiler);
                return list1;
            }
        }
    }
}

