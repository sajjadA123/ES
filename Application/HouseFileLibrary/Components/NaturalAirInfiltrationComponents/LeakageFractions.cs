namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.NaturalAirInfiltrationComponents
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class LeakageFractions
    {
        [XmlAttribute("useDefaults")]
        public bool UseDefaults;
        [XmlAttribute("ceilings")]
        public decimal Ceilings;
        [XmlAttribute("walls")]
        public decimal Walls;
        [XmlAttribute("floors")]
        public decimal Floors;
    }
}

