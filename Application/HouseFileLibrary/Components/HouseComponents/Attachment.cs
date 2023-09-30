namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.HouseComponents
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class Attachment
    {
        [XmlElement("Foundation1")]
        public AttachmentFoundation Foundation1 = new AttachmentFoundation();
        [XmlElement("Foundation2")]
        public AttachmentFoundation Foundation2;
    }
}

