namespace ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    public class ElectricSupplementaryHeatingTypes : ResourceList, ISupplementaryHeatingTypes
    {
        public static readonly ElectricSupplementaryHeatingTypes BaseboardHydronicPlenum = new ElectricSupplementaryHeatingTypes("1", "Baseboard/Hydronic/Plenum(duct) htrs", "Chauffage Plinthe/Hydronique/Soufflant", false);
        public static readonly ElectricSupplementaryHeatingTypes ForcedAirFurnace = new ElectricSupplementaryHeatingTypes("2", "Forced air furnace", "Fournaise \x00e0 air forc\x00e9", false);
        public static readonly ElectricSupplementaryHeatingTypes RadiantFloorPanels = new ElectricSupplementaryHeatingTypes("3", "Radiant floor panels", "Paneaux Radiants au plancher", false);
        public static readonly ElectricSupplementaryHeatingTypes RadiantCeilingPanels = new ElectricSupplementaryHeatingTypes("4", "Radiant ceiling panels", "Paneaux Radiants au plafond", false);
        public static readonly ElectricSupplementaryHeatingTypes FanHeaterUnits = new ElectricSupplementaryHeatingTypes("5", "Fan heater units", "Radiateurs soufflants", false);
        public static readonly ElectricSupplementaryHeatingTypes ToeSpaceHeaters = new ElectricSupplementaryHeatingTypes("6", "Toe-space heaters", "Toe-space heaters", false);
        public static readonly ElectricSupplementaryHeatingTypes OtherDescribe = new ElectricSupplementaryHeatingTypes("7", "Other (describe)", "Autre (d\x00e9crire)", false);
        public static readonly ElectricSupplementaryHeatingTypes SameAsType1 = new ElectricSupplementaryHeatingTypes("8", "Same as Type 1 heating system", "Identique au syst\x00e8me de chauffage Type 1", false);

        private ElectricSupplementaryHeatingTypes()
        {
        }

        private ElectricSupplementaryHeatingTypes(string code, string englishText, string frenchText, bool isUserSpecified = false) : base(code, englishText, frenchText, isUserSpecified)
        {
        }

        public static List<ElectricSupplementaryHeatingTypes> All
        {
            get
            {
                List<ElectricSupplementaryHeatingTypes> list1 = new List<ElectricSupplementaryHeatingTypes>();
                list1.Add(BaseboardHydronicPlenum);
                list1.Add(ForcedAirFurnace);
                list1.Add(RadiantFloorPanels);
                list1.Add(RadiantCeilingPanels);
                list1.Add(FanHeaterUnits);
                list1.Add(ToeSpaceHeaters);
                list1.Add(OtherDescribe);
                list1.Add(SameAsType1);
                return list1;
            }
        }
    }
}

