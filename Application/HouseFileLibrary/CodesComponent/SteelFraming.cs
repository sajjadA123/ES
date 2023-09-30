namespace ca.nrcan.gc.OEE.HouseFileLibrary.CodesComponent
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class SteelFraming
    {
        [XmlAttribute("thickness")]
        public decimal Thickness;
        [XmlAttribute("width")]
        public decimal Width;
        [XmlAttribute("spacing")]
        public decimal Spacing;
        [XmlElement("SteelGauge")]
        public CodeTextAndValue SteelGauge = new CodeTextAndValue();
    }
}

