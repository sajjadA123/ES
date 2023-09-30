namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.VentilationComponents
{
    using System;
    using System.Xml.Serialization;

    public class Hrv : VentilatorObjects
    {
        [XmlAttribute("temperatureCondition1")]
        public decimal TemperatureCondition1;
        [XmlAttribute("temperatureCondition2")]
        public decimal TemperatureCondition2;
        [XmlAttribute("fanPower2")]
        public decimal FanPower2;
        [XmlAttribute("efficiency1")]
        public decimal Efficiency1;
        [XmlAttribute("efficiency2")]
        public decimal Efficiency2;
        [XmlAttribute("preheaterCapacity")]
        public decimal PreheaterCapacity;
        [XmlAttribute("lowTempVentReduction")]
        public decimal LowTempVentReduction;
        [XmlAttribute("coolingEfficiency")]
        public decimal CoolingEfficiency;
        [XmlElement("ColdAirDucts")]
        public ca.nrcan.gc.OEE.HouseFileLibrary.Components.VentilationComponents.HrvDucts HrvDucts = new ca.nrcan.gc.OEE.HouseFileLibrary.Components.VentilationComponents.HrvDucts();
    }
}

