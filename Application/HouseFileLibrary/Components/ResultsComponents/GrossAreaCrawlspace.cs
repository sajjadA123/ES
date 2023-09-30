namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.ResultsComponents
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class GrossAreaCrawlspace : GrossAreaFloor
    {
        [XmlAttribute("wall")]
        public decimal Wall;
        [XmlAttribute("floor")]
        public decimal Floor;
        [XmlAttribute("floorHeader")]
        public decimal FloorHeader;
    }
}

