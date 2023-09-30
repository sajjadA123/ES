namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.FoundationComponents
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class Locations
    {
        [XmlElement("L1_1")]
        public Location L1_1;
        [XmlElement("L1_2")]
        public Location L1_2;
        [XmlElement("L2_1")]
        public Location L2_1;
        [XmlElement("L2_2")]
        public Location L2_2;
    }
}

