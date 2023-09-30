namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.GenerationComponents
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class Array
    {
        [XmlAttribute("area")]
        public decimal Area;
        [XmlAttribute("slope")]
        public decimal Slope;
        [XmlAttribute("azimuth")]
        public decimal Azimuth;
    }
}

