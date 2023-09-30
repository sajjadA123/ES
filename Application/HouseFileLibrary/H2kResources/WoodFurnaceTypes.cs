namespace ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    public class WoodFurnaceTypes : ResourceList, IFurnaceTypes
    {
        public static readonly WoodFurnaceTypes AdvancedAirtightWoodStove = new WoodFurnaceTypes("1", "Advanced airtight wood stove", "Po\x00eale herm\x00e9tique performant", false);
        public static readonly WoodFurnaceTypes FirstOptionWithCatalyticConverter = new WoodFurnaceTypes("2", "1st option with catalytic converter", "1er option + convert. catalitique.", false);
        public static readonly WoodFurnaceTypes ConventionalFurnace = new WoodFurnaceTypes("3", "Conventional furnace", "Fournaise conventionnelle", false);
        public static readonly WoodFurnaceTypes ConventionalBoiler = new WoodFurnaceTypes("4", "Conventional boiler", "Chaudi\x00e8re conventionnelle", false);
        public static readonly WoodFurnaceTypes ConventionalStove = new WoodFurnaceTypes("5", "Conventional stove", "Po\x00eale conventionnel", false);
        public static readonly WoodFurnaceTypes PelletStove = new WoodFurnaceTypes("6", "Pellet stove", "Po\x00eale \x00e0 granules", false);
        public static readonly WoodFurnaceTypes MasonryHeater = new WoodFurnaceTypes("7", "Masonry heater", "Foyer de masse", false);
        public static readonly WoodFurnaceTypes ConventionalFireplace = new WoodFurnaceTypes("8", "Conventional fireplace", "Foyer conventionnel", false);
        public static readonly WoodFurnaceTypes FireplaceInsert = new WoodFurnaceTypes("10", "Fireplace insert", "Foyer encastrable", false);

        private WoodFurnaceTypes()
        {
        }

        private WoodFurnaceTypes(string code, string englishText, string frenchText, bool isUserSpecified = false) : base(code, englishText, frenchText, isUserSpecified)
        {
        }

        public static List<WoodFurnaceTypes> All
        {
            get
            {
                List<WoodFurnaceTypes> list1 = new List<WoodFurnaceTypes>();
                list1.Add(AdvancedAirtightWoodStove);
                list1.Add(FirstOptionWithCatalyticConverter);
                list1.Add(ConventionalFurnace);
                list1.Add(ConventionalBoiler);
                list1.Add(ConventionalStove);
                list1.Add(PelletStove);
                list1.Add(MasonryHeater);
                list1.Add(ConventionalFireplace);
                list1.Add(FireplaceInsert);
                return list1;
            }
        }
    }
}

