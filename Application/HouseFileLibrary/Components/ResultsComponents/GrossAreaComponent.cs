namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.ResultsComponents
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class GrossAreaComponent
    {
        [XmlAttribute("grossArea")]
        public decimal GrossArea;
        [XmlAttribute("rsiValue")]
        public decimal RsiValue;
    }
}

