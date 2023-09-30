namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.NaturalAirInfiltrationComponents.AirLeakageReportComponents
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using System;
    using System.Collections.Generic;
    using System.Xml.Serialization;

    [Serializable]
    public class Test
    {
        [XmlAttribute("rank")]
        public ushort Rank;
        [XmlAttribute("equipment")]
        public ushort Equipment;
        [XmlAttribute("insideTemperature")]
        public decimal InsideTemperature;
        [XmlAttribute("zoneHeatedVolume")]
        public decimal ZoneHeatedVolume;
        [XmlElement("Manometer")]
        public string Manometer;
        [XmlElement("Pressure")]
        public ca.nrcan.gc.OEE.HouseFileLibrary.Components.NaturalAirInfiltrationComponents.AirLeakageReportComponents.Pressure Pressure = new ca.nrcan.gc.OEE.HouseFileLibrary.Components.NaturalAirInfiltrationComponents.AirLeakageReportComponents.Pressure();
        [XmlElement("FanType")]
        public CodeAndText FanType = new CodeAndText();
        [XmlArray("Data"), XmlArrayItem("DataPoint", typeof(DataPoint))]
        public List<DataPoint> Data;
    }
}

