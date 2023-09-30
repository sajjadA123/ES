namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.HouseComponents
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class Equipment
    {
        [XmlAttribute("heatingSetPoint")]
        public decimal HeatingSetPoint;
        [XmlAttribute("coolingSetPoint")]
        public decimal CoolingSetPoint;
    }
}

