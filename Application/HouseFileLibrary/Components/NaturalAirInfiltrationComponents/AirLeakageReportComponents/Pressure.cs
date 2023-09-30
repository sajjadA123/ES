namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.NaturalAirInfiltrationComponents.AirLeakageReportComponents
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class Pressure
    {
        [XmlElement("Static")]
        public PressureData Static = new PressureData();
        [XmlElement("Zone1")]
        public PressureData Zone1;
        [XmlElement("Zone2")]
        public PressureData Zone2;
    }
}

