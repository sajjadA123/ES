namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.Type1
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class Boiler : Common
    {
        [XmlElement("Equipment")]
        public BoilerEquipment Equipment = new BoilerEquipment();
    }
}

