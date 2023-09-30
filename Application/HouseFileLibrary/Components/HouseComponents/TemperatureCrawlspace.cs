namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.HouseComponents
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class TemperatureCrawlspace
    {
        [XmlAttribute("heated")]
        public bool Heated;
        [XmlAttribute("heatingSetPoint")]
        public decimal HeatingSetPoint;
    }
}

