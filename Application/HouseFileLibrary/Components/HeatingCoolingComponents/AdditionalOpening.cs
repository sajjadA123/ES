namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class AdditionalOpening : CodeAndText
    {
        [XmlAttribute("rank")]
        public ushort Rank;
        [XmlAttribute("flueDiameter")]
        public decimal FlueDiameter;
        [XmlAttribute("damperClosed")]
        public bool DamperClosed;
        [XmlAttribute("numberOfOpenings")]
        public ushort NumberOfOpenings;
    }
}

