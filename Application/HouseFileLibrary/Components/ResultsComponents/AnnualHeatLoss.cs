namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.ResultsComponents
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class AnnualHeatLoss
    {
        [XmlAttribute("total")]
        public decimal Total;
        [XmlAttribute("ceiling")]
        public decimal Ceiling;
        [XmlAttribute("mainWalls")]
        public decimal MainWalls;
        [XmlAttribute("windows")]
        public decimal Windows;
        [XmlAttribute("doors")]
        public decimal Doors;
        [XmlAttribute("exposedFloors")]
        public decimal ExposedFloors;
        [XmlAttribute("crawlspace")]
        public decimal Crawlspace;
        [XmlAttribute("slab")]
        public decimal Slab;
        [XmlAttribute("basementBelowGradeWall")]
        public decimal BasementBelowGradeWall;
        [XmlAttribute("basementAboveGradeWall")]
        public decimal BasementAboveGradeWall;
        [XmlAttribute("basementFloorHeaders")]
        public decimal BasementFloorHeaders;
        [XmlAttribute("ponyWall")]
        public decimal PonyWall;
        [XmlAttribute("floorsAboveBasement")]
        public decimal FloorsAboveBasement;
        [XmlAttribute("airLeakageAndNaturalVentilation")]
        public decimal AirLeakageAndNaturalVentilation;
        [XmlElement("MainFloor")]
        public DoorAndWindows MainFloorDoorsAndWindows = new DoorAndWindows();
        [XmlElement("Basement")]
        public DoorAndWindows BasementDoorsAndWindows = new DoorAndWindows();
        [XmlElement("Crawlspace")]
        public DoorAndWindows CrawlspaceDoorsAndWindows = new DoorAndWindows();
    }
}

