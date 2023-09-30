namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.ResultsComponents
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class FanConsumption
    {
        [XmlAttribute("heatingHours")]
        public decimal HeatingHours;
        [XmlAttribute("neitherHours")]
        public decimal NeitherHours;
        [XmlAttribute("coolingHours")]
        public decimal CoolingHours;
        [XmlAttribute("total")]
        public decimal Total;
    }
}

