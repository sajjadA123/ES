namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.ResultsComponents
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class SupplementalHeating
    {
        [XmlAttribute("system1")]
        public decimal System1;
        [XmlAttribute("system2")]
        public decimal System2;
        [XmlAttribute("system3")]
        public decimal System3;
        [XmlAttribute("system4")]
        public decimal System4;
        [XmlAttribute("system5")]
        public decimal System5;
    }
}

