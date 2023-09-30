namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.Type1
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class ComboEnergyFactor
    {
        [XmlAttribute("useDefaults")]
        public bool UseDefaults;
        [XmlAttribute("value")]
        public decimal Value;
    }
}

