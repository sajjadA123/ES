namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.ResultsComponents
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class GrossAreaWindows
    {
        [XmlElement("South")]
        public GrossAreaComponent South = new GrossAreaComponent();
        [XmlElement("SouthEast")]
        public GrossAreaComponent SouthEast = new GrossAreaComponent();
        [XmlElement("East")]
        public GrossAreaComponent East = new GrossAreaComponent();
        [XmlElement("NorthEast")]
        public GrossAreaComponent NorthEast = new GrossAreaComponent();
        [XmlElement("North")]
        public GrossAreaComponent North = new GrossAreaComponent();
        [XmlElement("NorthWest")]
        public GrossAreaComponent NorthWest = new GrossAreaComponent();
        [XmlElement("West")]
        public GrossAreaComponent West = new GrossAreaComponent();
        [XmlElement("SouthWest")]
        public GrossAreaComponent SouthWest = new GrossAreaComponent();
    }
}

