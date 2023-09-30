namespace ca.nrcan.gc.OEE.HouseFileLibrary.CodesComponent
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class FramingComponent : UserDefinedComponent
    {
        [XmlAttribute("width")]
        public decimal Width;
        [XmlAttribute("spacing")]
        public decimal Spacing;
    }
}

