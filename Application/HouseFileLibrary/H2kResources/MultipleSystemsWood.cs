namespace ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    public class MultipleSystemsWood : ResourceList, IMultipleSystemsEquipmentTypes
    {
        public static readonly MultipleSystemsWood AdvancedAirTightStove = new MultipleSystemsWood("1", "Advanced air tight stove", "Po\x00eale herm\x00e9tique performant", false);
        public static readonly MultipleSystemsWood AdvancedStoveWithCatalyticConverter = new MultipleSystemsWood("2", "Advanced stove with catalytic converter", "Po\x00eale performant avec convertisseur catalytique", false);
        public static readonly MultipleSystemsWood ForcedAirConventional = new MultipleSystemsWood("3", "Forced air - conventional", "Air puls\x00e9 – conventionnel", false);
        public static readonly MultipleSystemsWood ConventionalStove = new MultipleSystemsWood("4", "Conventional stove", "Po\x00eale conventionnel", false);
        public static readonly MultipleSystemsWood PelletStove = new MultipleSystemsWood("5", "Pellet stove", "Po\x00eale \x00e0 granules", false);
        public static readonly MultipleSystemsWood MasonryHeater = new MultipleSystemsWood("6", "Masonry heater", "Foyer de masse", false);
        public static readonly MultipleSystemsWood ConventionalFireplace = new MultipleSystemsWood("7", "Conventional fireplace", "Foyer conventionnel", false);
        public static readonly MultipleSystemsWood FireplaceInsert = new MultipleSystemsWood("8", "Fireplace insert", "Foyer encastrable", false);
        public static readonly MultipleSystemsWood ConventionalBoiler = new MultipleSystemsWood("9", "Conventional boiler", "Chaudi\x00e8re conventionnelle", false);
        public static readonly MultipleSystemsWood OutdoorWoodBoiler = new MultipleSystemsWood("10", "Outdoor wood boiler", "Chaudi\x00e8re \x00e0 bois ext\x00e9rieure", false);

        private MultipleSystemsWood()
        {
        }

        private MultipleSystemsWood(string code, string englishText, string frenchText, bool isUserSpecified = false) : base(code, englishText, frenchText, isUserSpecified)
        {
        }

        public static List<MultipleSystemsWood> All
        {
            get
            {
                List<MultipleSystemsWood> list1 = new List<MultipleSystemsWood>();
                list1.Add(AdvancedAirTightStove);
                list1.Add(AdvancedStoveWithCatalyticConverter);
                list1.Add(ForcedAirConventional);
                list1.Add(ConventionalStove);
                list1.Add(PelletStove);
                list1.Add(MasonryHeater);
                list1.Add(ConventionalFireplace);
                list1.Add(FireplaceInsert);
                list1.Add(ConventionalBoiler);
                list1.Add(OutdoorWoodBoiler);
                return list1;
            }
        }
    }
}

