namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.Type2
{
    using ca.nrcan.gc.OEE.HouseFileLibrary.Components;
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class HeatPumpEquipmentInformation : EnergyStarEquipmentInformation
    {
        [XmlAttribute("canCsaC448")]
        public bool CanCsaC448;
    }
}

