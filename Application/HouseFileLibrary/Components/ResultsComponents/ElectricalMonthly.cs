namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.ResultsComponents
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class ElectricalMonthly
    {
        [XmlElement("ImsOrP9HeatingHours")]
        public MonthlyData ImsOrP9HeatingHours = new MonthlyData();
        [XmlElement("Gross")]
        public MonthlyData Gross = new MonthlyData();
    }
}

