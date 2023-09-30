namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.ResultsComponents
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class MonthlyHeatLoss
    {
        [XmlElement("Ceiling")]
        public MonthlyData Ceiling = new MonthlyData();
        [XmlElement("MainWalls")]
        public MonthlyData MainWalls = new MonthlyData();
        [XmlElement("Doors")]
        public MonthlyData Doors = new MonthlyData();
        [XmlElement("ExposedFloors")]
        public MonthlyData ExposedFloors = new MonthlyData();
        [XmlElement("Crawlspace")]
        public MonthlyData Crawlspace = new MonthlyData();
        [XmlElement("Slab")]
        public MonthlyData Slab = new MonthlyData();
        [XmlElement("Basement")]
        public BasementHeatLoss Basement = new BasementHeatLoss();
    }
}

