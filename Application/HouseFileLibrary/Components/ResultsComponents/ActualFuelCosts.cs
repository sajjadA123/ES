namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.ResultsComponents
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class ActualFuelCosts
    {
        [XmlAttribute("electrical")]
        public decimal Electrical;
        [XmlAttribute("naturalGas")]
        public decimal NaturalGas;
        [XmlAttribute("oil")]
        public decimal Oil;
        [XmlAttribute("propane")]
        public decimal Propane;
        [XmlAttribute("wood")]
        public decimal Wood;
    }
}

