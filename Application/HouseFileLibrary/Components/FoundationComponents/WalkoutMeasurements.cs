namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.FoundationComponents
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class WalkoutMeasurements
    {
        [XmlAttribute("withSlab")]
        public bool WithSlab;
        [XmlAttribute("height")]
        public decimal Height;
        [XmlAttribute("d1")]
        public decimal D1;
        [XmlAttribute("d2")]
        public decimal D2;
        [XmlAttribute("d3")]
        public decimal D3;
        [XmlAttribute("d4")]
        public decimal D4;
        [XmlAttribute("d5")]
        public decimal D5;
        [XmlAttribute("l1")]
        public decimal L1;
        [XmlAttribute("l2")]
        public decimal L2;
        [XmlAttribute("l3")]
        public decimal L3;
        [XmlAttribute("l4")]
        public decimal L4;
    }
}

