namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.Type2
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class HeatPumpSpecifications
    {
        [XmlElement("OutputCapacity")]
        public ca.nrcan.gc.OEE.HouseFileLibrary.OutputCapacity OutputCapacity = new ca.nrcan.gc.OEE.HouseFileLibrary.OutputCapacity();
        [XmlElement("HeatingEfficiency")]
        public CopSeerValue HeatingEfficiency = new CopSeerValue();
        [XmlElement("CoolingEfficiency")]
        public CopSeerValue CoolingEfficiency;
    }
}

