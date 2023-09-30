namespace ca.nrcan.gc.OEE.HouseFileLibrary.CodesComponent
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class SteelFramingLayer : FramingLayer
    {
        [XmlElement("Framing")]
        public SteelFraming Framing = new SteelFraming();
    }
}

