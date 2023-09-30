namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.ResultsComponents
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class MonthlyAirChangeRate
    {
        [XmlElement("Natural")]
        public MonthlyData Natural = new MonthlyData();
        [XmlElement("Total")]
        public MonthlyData Total = new MonthlyData();
    }
}

