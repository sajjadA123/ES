namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.ResultsComponents
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class HotWaterDemand
    {
        [XmlAttribute("base")]
        public decimal Base;
        [XmlAttribute("primary")]
        public decimal Primary;
        [XmlAttribute("secondary")]
        public decimal Secondary;
    }
}

