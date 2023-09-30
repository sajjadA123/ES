namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.ResultsComponents
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class MainFloorsFactors
    {
        [XmlElement("SolarUtilization")]
        public MonthlyData SolarUtilization = new MonthlyData();
        [XmlElement("GainLoadRatio")]
        public MonthlyData GainLoadRatio = new MonthlyData();
        [XmlElement("MassGainRatio")]
        public MonthlyData MassGainRatio = new MonthlyData();
        [XmlElement("InternalGainsUtilization")]
        public MonthlyData InternalGainsUtilization = new MonthlyData();
    }
}

