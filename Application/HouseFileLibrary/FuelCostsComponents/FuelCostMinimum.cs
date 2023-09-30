namespace ca.nrcan.gc.OEE.HouseFileLibrary.FuelCostsComponents
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class FuelCostMinimum
    {
        [XmlAttribute("units")]
        public int units;
        [XmlAttribute("charge")]
        public decimal charge;
    }
}

