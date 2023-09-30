namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.Type1
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class FansAndPumpPowerHeating
    {
        [XmlAttribute("isCalculated")]
        public bool IsCalculated;
        [XmlAttribute("low")]
        public decimal Low;
        [XmlAttribute("high")]
        public decimal High;
    }
}

