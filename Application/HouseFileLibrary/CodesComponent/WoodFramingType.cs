namespace ca.nrcan.gc.OEE.HouseFileLibrary.CodesComponent
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class WoodFramingType
    {
        [XmlElement("Structure")]
        public CodeAndText Structure = new CodeAndText();
        [XmlElement("Truss")]
        public CodeAndText Truss;
    }
}

