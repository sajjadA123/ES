namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.HouseComponents
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class Name
    {
        [XmlElement("First")]
        public string First;
        [XmlElement("Last")]
        public string Last;
    }
}

