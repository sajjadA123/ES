namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.Type2
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class FansAndPumpPowerCooling
    {
        [XmlAttribute("isCalculated")]
        public bool IsCalculated = true;
        [XmlAttribute("value")]
        public decimal Value;
    }
}

