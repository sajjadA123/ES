namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.Type1
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class ComboHeatDhw : Common
    {
        [XmlElement("Equipment")]
        public ComboHeatDhwEquipment Equipment = new ComboHeatDhwEquipment();
    }
}

