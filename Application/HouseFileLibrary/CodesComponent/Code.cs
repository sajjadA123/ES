namespace ca.nrcan.gc.OEE.HouseFileLibrary.CodesComponent
{
    using System;
    using System.Xml.Serialization;

    [Serializable, XmlInclude(typeof(Standard)), XmlInclude(typeof(UserDefined))]
    public class Code
    {
        [XmlAttribute("id")]
        public string Id;
        [XmlAttribute("nominalRValue")]
        public decimal NominalRValue;
        [XmlElement("Label")]
        public string Label = string.Empty;
        [XmlElement("Description")]
        public string Description = string.Empty;
    }
}

