namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.ResultsComponents
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class BasementLoadMonthly
    {
        [XmlElement("Heating")]
        public MonthlyData Heating = new MonthlyData();
        [XmlElement("Cooling")]
        public MonthlyData Cooling = new MonthlyData();
    }
}

