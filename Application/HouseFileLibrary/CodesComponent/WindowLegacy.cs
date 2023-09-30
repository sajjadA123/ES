namespace ca.nrcan.gc.OEE.HouseFileLibrary.CodesComponent
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class WindowLegacy : UserDefinedLayer
    {
        [XmlAttribute("frameHeight")]
        public decimal FrameHeight;
        [XmlAttribute("shgc")]
        public decimal Shgc;
        [XmlElement("Type")]
        public CodeAndText Type = new CodeAndText();
        [XmlElement("RsiValues")]
        public ca.nrcan.gc.OEE.HouseFileLibrary.CodesComponent.RsiValues RsiValues = new ca.nrcan.gc.OEE.HouseFileLibrary.CodesComponent.RsiValues();
    }
}

