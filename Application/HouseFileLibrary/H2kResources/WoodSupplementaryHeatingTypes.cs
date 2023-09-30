namespace ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    public class WoodSupplementaryHeatingTypes : ResourceList, ISupplementaryHeatingTypes
    {
        public static readonly WoodSupplementaryHeatingTypes AdvancedAirtightWoodStove = new WoodSupplementaryHeatingTypes("1", "Advanced airtight wood stove", "Po\x00eale \x00e0 bois \x00e9tanche avanc\x00e9", false);
        public static readonly WoodSupplementaryHeatingTypes AdvancedAirtightWoodStoveCatConv = new WoodSupplementaryHeatingTypes("2", "Adv. airtight wood stove + cat. conv.", "Po\x00eale \x00e0 bois \x00e9tan. av. + conv. cat.", false);
        public static readonly WoodSupplementaryHeatingTypes WoodFurnace = new WoodSupplementaryHeatingTypes("3", "Wood furnace", "Fournaise \x00e0 bois", false);
        public static readonly WoodSupplementaryHeatingTypes WoodFireplace = new WoodSupplementaryHeatingTypes("4", "Wood fireplace", "Foyer \x00e0 bois", false);
        public static readonly WoodSupplementaryHeatingTypes WoodFireplaceInsert = new WoodSupplementaryHeatingTypes("5", "Wood fireplace insert", "Foyer \x00e0 bois encastr\x00e9", false);
        public static readonly WoodSupplementaryHeatingTypes PelletStove = new WoodSupplementaryHeatingTypes("7", "Pellet Stove", "Po\x00eale \x00e0 granules", false);
        public static readonly WoodSupplementaryHeatingTypes OtherDescri = new WoodSupplementaryHeatingTypes("6", "Other (describe)", "Autre (d\x00e9crire)", false);
        public static readonly WoodSupplementaryHeatingTypes SameAsType1HeatingSystem = new WoodSupplementaryHeatingTypes("8", "Same as Type 1 heating system", "Identique au syst\x00e8me de chauffage Type 1", false);

        private WoodSupplementaryHeatingTypes()
        {
        }

        private WoodSupplementaryHeatingTypes(string code, string englishText, string frenchText, bool isUserSpecified = false) : base(code, englishText, frenchText, isUserSpecified)
        {
        }

        public static List<WoodSupplementaryHeatingTypes> All
        {
            get
            {
                List<WoodSupplementaryHeatingTypes> list1 = new List<WoodSupplementaryHeatingTypes>();
                list1.Add(AdvancedAirtightWoodStove);
                list1.Add(AdvancedAirtightWoodStoveCatConv);
                list1.Add(WoodFurnace);
                list1.Add(WoodFireplace);
                list1.Add(WoodFireplaceInsert);
                list1.Add(PelletStove);
                list1.Add(OtherDescri);
                list1.Add(SameAsType1HeatingSystem);
                return list1;
            }
        }
    }
}

