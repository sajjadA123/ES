namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.SupplementaryHeat
{
    using System;
    using System.Xml.Serialization;

    [Serializable, XmlRoot("System")]
    public class SupplementaryHeat
    {
        [XmlAttribute("rank")]
        public ushort Rank;
        [XmlElement("EquipmentInformation")]
        public SupplementaryHeatEquipmentInformation EquipmentInformation = new SupplementaryHeatEquipmentInformation();
        [XmlElement("Equipment")]
        public SupplementaryHeatEquipment Equipment = new SupplementaryHeatEquipment();
        [XmlElement("Specifications")]
        public SupplementaryHeatSpecifications Specifications = new SupplementaryHeatSpecifications();
    }
}

