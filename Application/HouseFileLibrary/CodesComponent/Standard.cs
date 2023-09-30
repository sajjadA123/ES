namespace ca.nrcan.gc.OEE.HouseFileLibrary.CodesComponent
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class Standard : Code
    {
        [XmlAttribute("value")]
        public string Value;
        [XmlElement("Layers")]
        public StandardLayer Layers;
    }
}

