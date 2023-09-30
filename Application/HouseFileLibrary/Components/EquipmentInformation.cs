namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components
{
    using ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.Type1;
    using System;
    using System.Xml.Serialization;

    [Serializable, XmlInclude(typeof(BaseboardsEquipmentInformation)), XmlInclude(typeof(EnergyStarEquipmentInformation))]
    public class EquipmentInformation
    {
        [XmlElement("Manufacturer")]
        public string Manufacturer;
        [XmlElement("Model")]
        public string Model;
        [XmlElement("Description")]
        public string Description;

        public EquipmentInformation()
        {
        }

        public EquipmentInformation(EquipmentInformation toCopy)
        {
            this.Manufacturer = toCopy.Manufacturer;
            this.Model = toCopy.Model;
            this.Description = toCopy.Description;
        }
    }
}

