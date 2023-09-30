namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.Type1
{
    using System;
    using System.Xml.Serialization;

    [Serializable, XmlInclude(typeof(Boiler)), XmlInclude(typeof(Furnace)), XmlInclude(typeof(ComboHeatDhw))]
    public class Common
    {
        [XmlElement("EquipmentInformation")]
        public Type1EquipmentInformation EquipmentInformation = new Type1EquipmentInformation();
        [XmlElement("Specifications")]
        public CommonSpecifications Specifications = new CommonSpecifications();
        [XmlElement("ComboTankAndPump")]
        public ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.Type1.ComboTankAndPump ComboTankAndPump;
    }
}

