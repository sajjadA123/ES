namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.ResultsComponents
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class GrossArea
    {
        [XmlAttribute("ceiling")]
        public decimal Ceiling;
        [XmlAttribute("doors")]
        public decimal Doors;
        [XmlAttribute("exposedFloors")]
        public decimal ExposedFloors;
        [XmlAttribute("slab")]
        public decimal Slab;
        [XmlAttribute("ponyWall")]
        public decimal PonyWall;
        [XmlAttribute("buildingSurfaceArea")]
        public decimal BuildingSurfaceArea;
        [XmlAttribute("houseVolumeWithoutCrawlspace")]
        public decimal HouseVolumeWithoutCrawlspace;
        [XmlElement("MainFloors")]
        public GrossAreaMainFloors MainFloors = new GrossAreaMainFloors();
        [XmlElement("Basement")]
        public GrossAreaBasement Basement = new GrossAreaBasement();
        [XmlElement("Crawlspace")]
        public GrossAreaCrawlspace Crawlspace = new GrossAreaCrawlspace();
    }
}

