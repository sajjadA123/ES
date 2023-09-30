namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.ResultsComponents
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class MonthlyResults
    {
        [XmlElement("FractionOfTimeHeatingSystemNotOperating")]
        public MonthlyData FractionOfTimeHeatingSystemNotOperating = new MonthlyData();
        [XmlElement("SolarHotWaterEnergyContribution")]
        public MonthlyData SolarHotWaterEnergyContribution = new MonthlyData();
        [XmlElement("ElectricalConsumption")]
        public ElectricalMonthly ElectricalConsumption = new ElectricalMonthly();
        [XmlElement("Gains")]
        public ca.nrcan.gc.OEE.HouseFileLibrary.Components.ResultsComponents.Gains Gains = new ca.nrcan.gc.OEE.HouseFileLibrary.Components.ResultsComponents.Gains();
        [XmlElement("UtilizedAuxiliaryHeatRequired")]
        public MonthlyData UtilizedAuxiliaryHeatRequired = new MonthlyData();
        [XmlElement("Temperatures")]
        public TemperaturesMonthly Temperatures = new TemperaturesMonthly();
        [XmlElement("Load")]
        public LoadMonthly Load = new LoadMonthly();
        [XmlElement("HeatLoss")]
        public MonthlyHeatLoss HeatLoss = new MonthlyHeatLoss();
        [XmlElement("Factors")]
        public ca.nrcan.gc.OEE.HouseFileLibrary.Components.ResultsComponents.Factors Factors = new ca.nrcan.gc.OEE.HouseFileLibrary.Components.ResultsComponents.Factors();
        [XmlElement("AirChangeRate")]
        public MonthlyAirChangeRate AirChangeRate = new MonthlyAirChangeRate();
    }
}

