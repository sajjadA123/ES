namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.FoundationComponents
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class Location
    {
        [XmlAttribute("x1")]
        public decimal X1;
        [XmlAttribute("x2")]
        public decimal X2;
    }
}

