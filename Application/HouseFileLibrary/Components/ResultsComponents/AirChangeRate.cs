namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.ResultsComponents
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class AirChangeRate
    {
        [XmlAttribute("natural")]
        public decimal Natural;
        [XmlAttribute("total")]
        public decimal Total;
    }
}

