namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.Type2
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class HeatPump
    {
        [XmlElement("EquipmentInformation")]
        public HeatPumpEquipmentInformation EquipmentInformation = new HeatPumpEquipmentInformation();
        [XmlElement("Equipment")]
        public HeatPumpEquipment Equipment = new HeatPumpEquipment();
        [XmlElement("Specifications")]
        public HeatPumpSpecifications Specifications = new HeatPumpSpecifications();
        [XmlElement("Temperature")]
        public HeatPumpTemperature Temperature = new HeatPumpTemperature();
        [XmlElement("SourceTemperature")]
        public ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.Type2.SourceTemperature SourceTemperature = new ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.Type2.SourceTemperature();
        [XmlElement("CoolingParameters")]
        public HeatPumpCoolingType CoolingParameters;
        [XmlElement("ColdClimateHeatPump")]
        public ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.Type2.ColdClimateHeatPump ColdClimateHeatPump;
    }
}

