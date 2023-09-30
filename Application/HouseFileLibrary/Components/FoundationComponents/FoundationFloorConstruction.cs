namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.FoundationComponents
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class FoundationFloorConstruction
    {
        [XmlAttribute("isBelowFrostline")]
        public bool IsBelowFrostline;
        [XmlAttribute("hasIntegralFooting")]
        public bool HasIntegralFooting;
        [XmlAttribute("heatedFloor")]
        public bool HeatedFloor;
        [XmlElement("AddedToSlab")]
        public CodeReference AddedToSlab;
        [XmlElement("FloorsAbove")]
        public CodeReference FloorsAbove = new CodeReference();
    }
}

