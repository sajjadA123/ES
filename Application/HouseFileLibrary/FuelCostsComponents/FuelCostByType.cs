namespace ca.nrcan.gc.OEE.HouseFileLibrary.FuelCostsComponents
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class FuelCostByType
    {
        [XmlAttribute("id")]
        public uint Id;
        [XmlElement("Label")]
        public string Label;
        [XmlElement("Comment")]
        public string Comment;
        [XmlElement("Units")]
        public CodeAndText Units = new CodeAndText();
        [XmlElement("Minimum")]
        public FuelCostMinimum Minimum = new FuelCostMinimum();
        [XmlElement("RateBlocks")]
        public FuelCostRateBlocks RateBlocks = new FuelCostRateBlocks();
    }
}

