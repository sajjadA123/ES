namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.Type1
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class Baseboards
    {
        [XmlElement("EquipmentInformation")]
        public BaseboardsEquipmentInformation EquipmentInformation = new BaseboardsEquipmentInformation();
        [XmlElement("Specifications")]
        public BaseboardsSpecifications Specifications = new BaseboardsSpecifications();
    }
}

