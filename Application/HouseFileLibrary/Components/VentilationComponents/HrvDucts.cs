namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.VentilationComponents
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class HrvDucts
    {
        [XmlElement("Supply")]
        public HrvDuctSpec Supply = new HrvDuctSpec();
        [XmlElement("Exhaust")]
        public HrvDuctSpec Exhaust = new HrvDuctSpec();
    }
}

