namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.HotWaterComponents
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class Solar
    {
        [XmlAttribute("rating")]
        public decimal Rating;
        [XmlAttribute("slope")]
        public decimal Slope;
        [XmlAttribute("azimuth")]
        public decimal Azimuth;
    }
}

