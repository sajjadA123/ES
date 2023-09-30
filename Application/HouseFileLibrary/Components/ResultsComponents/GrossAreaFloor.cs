namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.ResultsComponents
{
    using System;
    using System.Xml.Serialization;

    [Serializable, XmlInclude(typeof(GrossAreaMainFloors)), XmlInclude(typeof(GrossAreaBasement)), XmlInclude(typeof(GrossAreaCrawlspace))]
    public class GrossAreaFloor
    {
        [XmlElement("Windows")]
        public GrossAreaWindows Windows = new GrossAreaWindows();
        [XmlElement("Door")]
        public GrossAreaComponent Door = new GrossAreaComponent();
    }
}

