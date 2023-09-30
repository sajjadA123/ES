namespace ca.nrcan.gc.OEE.HouseFileLibrary.FuelCostsComponents
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class FuelCostMonthlyData
    {
        [XmlAttribute("january")]
        public string January;
        [XmlAttribute("february")]
        public string February;
        [XmlAttribute("march")]
        public string March;
        [XmlAttribute("april")]
        public string April;
        [XmlAttribute("may")]
        public string May;
        [XmlAttribute("june")]
        public string June;
        [XmlAttribute("july")]
        public string July;
        [XmlAttribute("august")]
        public string August;
        [XmlAttribute("september")]
        public string September;
        [XmlAttribute("october")]
        public string October;
        [XmlAttribute("november")]
        public string November;
        [XmlAttribute("december")]
        public string December;
    }
}

