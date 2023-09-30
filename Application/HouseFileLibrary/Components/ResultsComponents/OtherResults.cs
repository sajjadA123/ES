namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.ResultsComponents
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class OtherResults
    {
        [XmlAttribute("designHeatLossRate")]
        public decimal DesignHeatLossRate;
        [XmlAttribute("designCoolLossRate")]
        public decimal DesignCoolLossRate;
        [XmlAttribute("seasonalHeatEfficiency")]
        public decimal SeasonalHeatEfficiency;
        [XmlElement("Ventilation")]
        public VentilationResults Ventilation = new VentilationResults();
        [XmlElement("FanEnergyConsumption")]
        public ca.nrcan.gc.OEE.HouseFileLibrary.Components.ResultsComponents.FanEnergyConsumption FanEnergyConsumption = new ca.nrcan.gc.OEE.HouseFileLibrary.Components.ResultsComponents.FanEnergyConsumption();
        [XmlElement("GrossArea")]
        public ca.nrcan.gc.OEE.HouseFileLibrary.Components.ResultsComponents.GrossArea GrossArea = new ca.nrcan.gc.OEE.HouseFileLibrary.Components.ResultsComponents.GrossArea();
    }
}

