namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.Type1
{
    using ca.nrcan.gc.OEE.HouseFileLibrary.Components;
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class Type1EquipmentInformation : EnergyStarEquipmentInformation
    {
        [XmlAttribute("epaCsa")]
        public bool EpaCsa;
    }
}

