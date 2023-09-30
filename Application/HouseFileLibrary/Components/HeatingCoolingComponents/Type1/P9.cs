namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.Type1
{
    using ca.nrcan.gc.OEE.HouseFileLibrary.Components;
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class P9
    {
        [XmlAttribute("numberOfSystems")]
        public ushort NumberOfSystems;
        [XmlAttribute("thermalPerformanceFactor")]
        public decimal ThermalPerformanceFactor;
        [XmlAttribute("annualElectricity")]
        public decimal AnnualElectricity;
        [XmlAttribute("spaceHeatingCapacity")]
        public decimal SpaceHeatingCapacity;
        [XmlAttribute("spaceHeatingEfficiency")]
        public decimal SpaceHeatingEfficiency;
        [XmlAttribute("waterHeatingPerformanceFactor")]
        public decimal WaterHeatingPerformanceFactor;
        [XmlAttribute("burnerInput")]
        public decimal BurnerInput;
        [XmlAttribute("recoveryEfficiency")]
        public decimal RecoveryEfficiency;
        [XmlAttribute("isUserSpecified")]
        public bool IsUserSpecified;
        [XmlElement("EquipmentInformation")]
        public ca.nrcan.gc.OEE.HouseFileLibrary.Components.EquipmentInformation EquipmentInformation = new ca.nrcan.gc.OEE.HouseFileLibrary.Components.EquipmentInformation();
        [XmlElement("TestData")]
        public ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.Type1.TestData TestData = new ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.Type1.TestData();
    }
}

