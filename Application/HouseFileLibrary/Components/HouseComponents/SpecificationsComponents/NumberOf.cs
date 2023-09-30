namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.HouseComponents.SpecificationsComponents
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class NumberOf
    {
        [XmlAttribute("storeysInBuilding")]
        public uint StoreysInBuilding;
        [XmlAttribute("dwellingUnits")]
        public uint DwellingUnits;
        [XmlAttribute("nonResUnits")]
        public uint NonResUnits;
        [XmlAttribute("unitsVisited")]
        public uint UnitsVisited;

        public NumberOf()
        {
            this.SetDefaults();
        }

        public NumberOf(NumberOf toCopy)
        {
            this.StoreysInBuilding = toCopy.StoreysInBuilding;
            this.DwellingUnits = toCopy.DwellingUnits;
            this.NonResUnits = toCopy.NonResUnits;
            this.UnitsVisited = toCopy.UnitsVisited;
        }

        public void SetDefaults()
        {
            this.StoreysInBuilding = 0;
            this.DwellingUnits = 1;
            this.NonResUnits = 0;
            this.UnitsVisited = 0;
        }
    }
}

