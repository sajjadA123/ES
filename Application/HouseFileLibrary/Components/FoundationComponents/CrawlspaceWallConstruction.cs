namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.FoundationComponents
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using ca.nrcan.gc.OEE.HouseFileLibrary.HouseFileEvents;
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class CrawlspaceWallConstruction : ISerializationEvents
    {
        [XmlAttribute("corners")]
        public ushort Corners;
        [XmlElement("Type")]
        public CodeDescriptionAndComposite Type = new CodeDescriptionAndComposite();
        [XmlElement("Lintels")]
        public CodeReference Lintels;

        public void OnDeserialization()
        {
            this.Type.OnDeserialization();
        }

        public void OnPostSerialization()
        {
        }

        public void OnPreSerialization()
        {
        }
    }
}

