namespace ca.nrcan.gc.OEE.HouseFileLibrary.FuelCostsComponents
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class FuelCostRateBlocks
    {
        [XmlElement("Block1")]
        public FuelCostRateBlock Block1 = new FuelCostRateBlock();
        [XmlElement("Block2")]
        public FuelCostRateBlock Block2 = new FuelCostRateBlock();
        [XmlElement("Block3")]
        public FuelCostRateBlock Block3 = new FuelCostRateBlock();
        [XmlElement("Block4")]
        public FuelCostRateBlock Block4 = new FuelCostRateBlock();
    }
}

