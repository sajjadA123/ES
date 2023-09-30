namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.HotWaterComponents
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class NumberOfDwhrSystems
    {
        [XmlAttribute("lowEfficiency")]
        public byte LowEfficiency;
        [XmlAttribute("highEfficiency")]
        public byte HighEfficiency;
    }
}

