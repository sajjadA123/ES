namespace ca.nrcan.gc.OEE.HouseFileLibrary.FuelCostsComponents
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class FuelCostRateBlock
    {
        [XmlAttribute("units")]
        public int units;
        [XmlAttribute("costPerUnit")]
        public decimal costPerUnit;
    }
}

