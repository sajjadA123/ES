namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents
{
    using System;
    using System.Collections.Generic;
    using System.Xml.Serialization;

    [Serializable]
    public class MultipleSystems
    {
        [XmlArray("EquipmentInformation"), XmlArrayItem("Equipment", typeof(MultipleSystemsEquipment))]
        public List<MultipleSystemsEquipment> EquipmentInformation = new List<MultipleSystemsEquipment>();
        [XmlElement("Summary")]
        public MultipleSystemsSummary Summary = new MultipleSystemsSummary();
    }
}

