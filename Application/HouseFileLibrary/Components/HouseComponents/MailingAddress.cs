namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.HouseComponents
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class MailingAddress : Address
    {
        [XmlElement("Name")]
        public string Name;
    }
}

