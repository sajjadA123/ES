namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.HouseComponents
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class Client
    {
        [XmlElement("Name")]
        public ca.nrcan.gc.OEE.HouseFileLibrary.Components.HouseComponents.Name Name = new ca.nrcan.gc.OEE.HouseFileLibrary.Components.HouseComponents.Name();
        [XmlElement("Telephone")]
        public string Telephone;
        [XmlElement("StreetAddress")]
        public Address StreetAddress = new Address();
        [XmlElement("MailingAddress")]
        public ca.nrcan.gc.OEE.HouseFileLibrary.Components.HouseComponents.MailingAddress MailingAddress = new ca.nrcan.gc.OEE.HouseFileLibrary.Components.HouseComponents.MailingAddress();
    }
}

