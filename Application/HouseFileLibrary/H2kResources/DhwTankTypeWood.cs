namespace ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    public class DhwTankTypeWood : ResourceList, IDhwTankType
    {
        public static readonly DhwTankTypeWood NotApplicable = new DhwTankTypeWood("1", "Not applicable", "Sans objet", false);
        public static readonly DhwTankTypeWood Fireplace = new DhwTankTypeWood("2", "Fireplace", "Foyer \x00e0 feu ouvert", false);
        public static readonly DhwTankTypeWood WoodStoveWaterCoil = new DhwTankTypeWood("3", "Wood stove water coil", "Po\x00eale \x00e0 bois + serpentin \x00e0 eau", false);
        public static readonly DhwTankTypeWood IndoorWoodBoiler = new DhwTankTypeWood("4", "Indoor wood boiler", "Chaudi\x00e8re \x00e0 bois int\x00e9rieure", false);
        public static readonly DhwTankTypeWood OutdoorWoodBoiler = new DhwTankTypeWood("5", "Outdoor wood boiler", "Chaudi\x00e8re \x00e0 bois ext\x00e9rieure", false);
        public static readonly DhwTankTypeWood WoodHotWaterTank = new DhwTankTypeWood("6", "Wood hot water tank", "R\x00e9servoir \x00e0 eau chaude au bois", false);

        private DhwTankTypeWood()
        {
        }

        private DhwTankTypeWood(string code, string englishText, string frenchText, bool isUserSpecified = false) : base(code, englishText, frenchText, isUserSpecified)
        {
        }

        public static List<DhwTankTypeWood> All
        {
            get
            {
                List<DhwTankTypeWood> list1 = new List<DhwTankTypeWood>();
                list1.Add(NotApplicable);
                list1.Add(Fireplace);
                list1.Add(WoodStoveWaterCoil);
                list1.Add(IndoorWoodBoiler);
                list1.Add(OutdoorWoodBoiler);
                list1.Add(WoodHotWaterTank);
                return list1;
            }
        }
    }
}

