namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.ResultsComponents
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class BasementHeatLoss
    {
        [XmlElement("AboveGrade")]
        public MonthlyData AboveGrade = new MonthlyData();
        [XmlElement("BelowGrade")]
        public MonthlyData BelowGrade = new MonthlyData();
        [XmlElement("AboveGradeWall")]
        public MonthlyData AboveGradeWall = new MonthlyData();
        [XmlElement("FloorHeaders")]
        public MonthlyData FloorHeaders = new MonthlyData();
        [XmlElement("PonyWall")]
        public MonthlyData PonyWall = new MonthlyData();
        [XmlElement("FloorsAbove")]
        public MonthlyData FloorsAbove = new MonthlyData();
        [XmlElement("AirLeakageAndMechanicalVentilation")]
        public MonthlyData AirLeakageAndMechanicalVentilation = new MonthlyData();
    }
}

