namespace ca.nrcan.gc.OEE.HouseFileLibrary.CodesComponent
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class WoodFramingLayer : FramingLayer
    {
        [XmlElement("Type")]
        public WoodFramingType Type = new WoodFramingType();
        [XmlElement("Framing")]
        public FramingComponent Framing = new FramingComponent();
    }
}

