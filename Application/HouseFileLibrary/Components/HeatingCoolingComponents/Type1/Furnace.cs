namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.Type1
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class Furnace : Common
    {
        [XmlElement("Equipment")]
        public FurnaceEquipment Equipment = new FurnaceEquipment();
    }
}

