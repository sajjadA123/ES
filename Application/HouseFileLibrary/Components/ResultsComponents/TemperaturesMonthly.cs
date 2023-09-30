namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.ResultsComponents
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class TemperaturesMonthly
    {
        [XmlElement("CrawlSpace")]
        public MonthlyData CrawlSpace = new MonthlyData();
        [XmlElement("Attic")]
        public MonthlyData Attic = new MonthlyData();
    }
}

