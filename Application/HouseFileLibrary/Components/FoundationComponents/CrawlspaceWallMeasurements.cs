namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.FoundationComponents
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class CrawlspaceWallMeasurements
    {
        [XmlAttribute("height")]
        public decimal Height;
        [XmlAttribute("depth")]
        public decimal Depth;
    }
}

