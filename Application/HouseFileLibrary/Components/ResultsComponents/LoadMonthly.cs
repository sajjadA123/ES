namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.ResultsComponents
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class LoadMonthly
    {
        [XmlElement("PhotoVoltaicUtilized")]
        public MonthlyData PhotoVoltaicUtilized = new MonthlyData();
        [XmlElement("PhotoVoltaicAvailable")]
        public MonthlyData PhotoVoltaicAvailable = new MonthlyData();
        [XmlElement("WindUtilized")]
        public MonthlyData WindUtilized = new MonthlyData();
        [XmlElement("WindAvailable")]
        public MonthlyData WindAvailable = new MonthlyData();
        [XmlElement("GrossThermal")]
        public MonthlyData GrossThermal = new MonthlyData();
        [XmlElement("Basement")]
        public BasementLoadMonthly Basement = new BasementLoadMonthly();
    }
}

