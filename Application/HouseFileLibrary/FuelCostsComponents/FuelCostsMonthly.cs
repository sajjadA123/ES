namespace ca.nrcan.gc.OEE.HouseFileLibrary.FuelCostsComponents
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class FuelCostsMonthly
    {
        [XmlElement("Electricity")]
        public FuelCostMonthlyData Electricity = new FuelCostMonthlyData();
        [XmlElement("NaturalGas")]
        public FuelCostMonthlyData NaturalGas = new FuelCostMonthlyData();
        [XmlElement("Oil")]
        public FuelCostMonthlyData Oil = new FuelCostMonthlyData();
        [XmlElement("Propane")]
        public FuelCostMonthlyData Propane = new FuelCostMonthlyData();
        [XmlElement("Wood")]
        public FuelCostMonthlyData Wood = new FuelCostMonthlyData();
    }
}

