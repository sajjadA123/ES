namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.FoundationComponents
{
    using ca.nrcan.gc.OEE.HouseFileLibrary.HouseFileEvents;
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class CrawlspaceWall : ISerializationEvents
    {
        [XmlElement("Construction")]
        public CrawlspaceWallConstruction Construction = new CrawlspaceWallConstruction();
        [XmlElement("Measurements")]
        public CrawlspaceWallMeasurements Measurements = new CrawlspaceWallMeasurements();
        [XmlElement("RValues")]
        public WallRValues RValues = new WallRValues();

        public void OnDeserialization()
        {
            this.Construction.OnDeserialization();
        }

        public void OnPostSerialization()
        {
        }

        public void OnPreSerialization()
        {
        }
    }
}

