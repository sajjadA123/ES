namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components
{
    using ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.Type1;
    using ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.Type2;
    using System;
    using System.Xml.Serialization;

    [Serializable, XmlInclude(typeof(Type1EquipmentInformation)), XmlInclude(typeof(HeatPumpEquipmentInformation))]
    public class EnergyStarEquipmentInformation : EquipmentInformation
    {
        [XmlAttribute("energystar")]
        public bool EnergyStar;
        [XmlAttribute("AHRI")]
        public int AHRI;
    }
}

