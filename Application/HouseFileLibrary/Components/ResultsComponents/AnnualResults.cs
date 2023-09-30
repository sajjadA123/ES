namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.ResultsComponents
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class AnnualResults
    {
        [XmlElement("Consumption")]
        public AnnualConsumption Consumption = new AnnualConsumption();
        [XmlElement("HotWaterDemand")]
        public ca.nrcan.gc.OEE.HouseFileLibrary.Components.ResultsComponents.HotWaterDemand HotWaterDemand = new ca.nrcan.gc.OEE.HouseFileLibrary.Components.ResultsComponents.HotWaterDemand();
        [XmlElement("Load")]
        public LoadAnnual Load = new LoadAnnual();
        [XmlElement("HeatLoss")]
        public AnnualHeatLoss HeatLoss = new AnnualHeatLoss();
        [XmlElement("AirChangeRate")]
        public ca.nrcan.gc.OEE.HouseFileLibrary.Components.ResultsComponents.AirChangeRate AirChangeRate = new ca.nrcan.gc.OEE.HouseFileLibrary.Components.ResultsComponents.AirChangeRate();
        [XmlElement("UtilizedSolarGains")]
        public ValueOnly UtilizedSolarGains = new ValueOnly();
        [XmlElement("ActualFuelCosts")]
        public ca.nrcan.gc.OEE.HouseFileLibrary.Components.ResultsComponents.ActualFuelCosts ActualFuelCosts = new ca.nrcan.gc.OEE.HouseFileLibrary.Components.ResultsComponents.ActualFuelCosts();
    }
}

