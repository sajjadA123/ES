namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.NaturalAirInfiltrationComponents.AirLeakageReportComponents
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class PressureData
    {
        [XmlAttribute("initial")]
        public decimal Initial;
        [XmlAttribute("final")]
        public decimal Final;
    }
}

