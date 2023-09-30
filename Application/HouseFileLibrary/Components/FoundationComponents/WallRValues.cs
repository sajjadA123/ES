namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.FoundationComponents
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class WallRValues
    {
        [XmlAttribute("skirt")]
        public decimal Skirt;
        [XmlAttribute("thermalBreak")]
        public decimal ThermalBreak;
    }
}

