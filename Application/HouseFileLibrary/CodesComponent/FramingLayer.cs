namespace ca.nrcan.gc.OEE.HouseFileLibrary.CodesComponent
{
    using System;
    using System.Xml.Serialization;

    [Serializable, XmlInclude(typeof(SteelFramingLayer)), XmlInclude(typeof(WoodFramingLayer))]
    public class FramingLayer : UserDefinedLayer
    {
        [XmlAttribute("isPrimary")]
        public bool IsPrimary;
        [XmlAttribute("studsPerCorner")]
        public short StudsPerCorner;
        [XmlAttribute("studsPerInteriorWall")]
        public short StudsPerInteriorWall;
        [XmlAttribute("topAndBottomPlates")]
        public short TopAndBottomPlates;
        [XmlAttribute("doubleStudsOnWindows")]
        public bool DoubleStudsOnWindows;
        [XmlAttribute("ridgeBoardWidth")]
        public decimal RidgeBoardWidth;
        [XmlAttribute("blockingWidth")]
        public decimal BlockingWidth;
        [XmlElement("CavityInsulation")]
        public UserDefinedComponent CavityInsulation = new UserDefinedComponent();
    }
}

