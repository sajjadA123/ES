namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.ResultsComponents
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class Gains
    {
        [XmlElement("UtilizedInternal")]
        public MonthlyData UtilizedInternal = new MonthlyData();
        [XmlElement("UtilizedSolar")]
        public MonthlyData UtilizedSolar = new MonthlyData();
        [XmlElement("CrawlspaceSolar")]
        public MonthlyData CrawlspaceSolar = new MonthlyData();
    }
}

