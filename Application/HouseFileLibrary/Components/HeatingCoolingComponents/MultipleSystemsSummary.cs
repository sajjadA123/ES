namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class MultipleSystemsSummary
    {
        [XmlAttribute("energySaverHeatingSystems")]
        public ushort EnergySaverHeatingSystems;
        [XmlAttribute("energySaverAirSourceHeatPump")]
        public ushort EnergySaverAirSourceHeatPump;
        [XmlAttribute("woodAppliances")]
        public ushort WoodAppliances;
        [XmlAttribute("epaCsaHeatingSystems")]
        public ushort EpaCsaHeatingSystems;
    }
}

