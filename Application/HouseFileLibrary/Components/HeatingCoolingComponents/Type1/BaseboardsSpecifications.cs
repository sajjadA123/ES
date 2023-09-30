namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.Type1
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class BaseboardsSpecifications
    {
        [XmlAttribute("sizingFactor")]
        public decimal SizingFactor;
        [XmlAttribute("efficiency")]
        public decimal Efficiency;
        [XmlElement("OutputCapacity")]
        public ca.nrcan.gc.OEE.HouseFileLibrary.OutputCapacity OutputCapacity = new ca.nrcan.gc.OEE.HouseFileLibrary.OutputCapacity();
    }
}

