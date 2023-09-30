namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.SupplementaryHeat
{
    using ca.nrcan.gc.OEE.HouseFileLibrary.Components;
    using System;
    using System.Xml.Serialization;

    public class SupplementaryHeatEquipmentInformation : EquipmentInformation
    {
        [XmlAttribute("csaEpa")]
        public bool CsaEpa;
    }
}

