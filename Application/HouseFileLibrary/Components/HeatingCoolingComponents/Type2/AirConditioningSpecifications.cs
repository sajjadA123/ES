namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.Type2
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class AirConditioningSpecifications
    {
        [XmlAttribute("sizingFactor")]
        public decimal SizingFactor = 1M;
        [XmlElement("RatedCapacity")]
        public OutputCapacity RatedCapacity = new OutputCapacity("2", "Calculated", "Calcul\x00e9", 0M, "kW");
        [XmlElement("Efficiency")]
        public CopSeerValue Efficiency = new CopSeerValue(true, 3M);
    }
}

