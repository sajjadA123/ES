namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.Type2
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class WindowUnits
    {
        [XmlAttribute("totalCount")]
        public ushort TotalCount;
        [XmlAttribute("numberOfEnergyStarUnits")]
        public ushort NumberOfEnergyStarUnits;
    }
}

