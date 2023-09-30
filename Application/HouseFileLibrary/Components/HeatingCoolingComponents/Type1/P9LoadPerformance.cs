namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.Type1
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class P9LoadPerformance
    {
        [XmlAttribute("loadPerformance15")]
        public decimal LoadPerformance15;
        [XmlAttribute("loadPerformance40")]
        public decimal LoadPerformance40;
        [XmlAttribute("loadPerformance100")]
        public decimal LoadPerformance100;
    }
}

