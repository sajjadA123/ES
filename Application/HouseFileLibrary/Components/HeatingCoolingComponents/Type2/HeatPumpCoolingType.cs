namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.Type2
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class HeatPumpCoolingType
    {
        [XmlAttribute("sensibleHeatRatio")]
        public decimal sensibleHeatRatio = 0.76M;
        [XmlAttribute("openableWindowArea")]
        public decimal openableWindowArea;
        [XmlElement("FansAndPump")]
        public CoolingFansAndPumps FansAndPump = new CoolingFansAndPumps();
    }
}

