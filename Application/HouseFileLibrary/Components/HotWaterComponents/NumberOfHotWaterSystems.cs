namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.HotWaterComponents
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class NumberOfHotWaterSystems
    {
        [XmlAttribute("energyStarInstantaneousCondensing")]
        public byte EnergyStarInstantaneousCondensing;
        [XmlAttribute("energyStarInstantaneous")]
        public byte EnergyStarInstantaneous;
        [XmlAttribute("condensing")]
        public byte Condensing;
        [XmlAttribute("instantaneous")]
        public byte Instantaneous;
        [XmlAttribute("heatPumpWaterHeater")]
        public byte HeatPumpWaterHeater;
    }
}

