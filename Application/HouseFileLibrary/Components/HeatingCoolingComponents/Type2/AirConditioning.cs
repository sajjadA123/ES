namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.Type2
{
    using ca.nrcan.gc.OEE.HouseFileLibrary.Components;
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class AirConditioning
    {
        [XmlElement("EquipmentInformation")]
        public EnergyStarEquipmentInformation EquipmentInformation = new EnergyStarEquipmentInformation();
        [XmlElement("Equipment")]
        public AirConditioningEquipment Equipment = new AirConditioningEquipment();
        [XmlElement("Specifications")]
        public AirConditioningSpecifications Specifications = new AirConditioningSpecifications();
        [XmlElement("CoolingParameters")]
        public HeatPumpCoolingType CoolingParameters = new HeatPumpCoolingType();
    }
}

