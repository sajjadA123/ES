namespace ca.nrcan.gc.OEE.HouseFileLibrary.EnergyUpgradesComponents
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class Setting
    {
        [XmlAttribute("cost")]
        public decimal Cost;
        [XmlAttribute("priority")]
        public uint priority;
        [XmlElement("Cost")]
        public Cardinal WindowCost;
    }
}

