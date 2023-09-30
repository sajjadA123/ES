namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.NaturalAirInfiltrationComponents.AirLeakageReportComponents
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class DataPoint
    {
        [XmlAttribute("rank")]
        public ushort Rank;
        [XmlAttribute("housePressure")]
        public decimal HousePressure;
        [XmlAttribute("fanPressure")]
        public decimal FanPressure;
        [XmlAttribute("measuredFlow")]
        public decimal MeasuredFlow;
        [XmlAttribute("zone1Pressure")]
        public decimal Zone1Pressure;
        [XmlAttribute("zone2Pressure")]
        public decimal Zone2Pressure;
        [XmlElement("FlowRanges")]
        public CodeAndText FlowRanges = new CodeAndText();
    }
}

