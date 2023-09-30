namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class RadiantHeatingComponent
    {
        [XmlAttribute("effectiveTemperature")]
        public decimal EffectiveTemperature;
        [XmlAttribute("fractionOfArea")]
        public decimal FractionOfArea;
    }
}

