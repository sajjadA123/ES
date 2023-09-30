namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.HouseComponents
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using System;
    using System.Xml.Serialization;

    [Serializable, XmlInclude(typeof(MailingAddress))]
    public class Address
    {
        [XmlElement("Street")]
        public string Street;
        [XmlElement("UnitNumber")]
        public string UnitNumber;
        [XmlElement("City")]
        public CodeAndText City = new CodeAndText();
        [XmlElement("Province")]
        public string ProvinceOrTerritory;
        [XmlElement("PostalCode")]
        public string PostalCode;
    }
}

