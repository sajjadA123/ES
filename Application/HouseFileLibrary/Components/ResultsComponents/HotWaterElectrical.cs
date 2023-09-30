namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.ResultsComponents
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class HotWaterElectrical
    {
        [XmlAttribute("dhw")]
        public decimal Dhw;
        [XmlAttribute("primary")]
        public decimal Primary;
        [XmlAttribute("secondary")]
        public decimal Secondary;
    }
}

