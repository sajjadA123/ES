namespace ca.nrcan.gc.OEE.HouseFileLibrary.CodesComponent
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class RsiValues
    {
        [XmlAttribute("centreOfGlass")]
        public decimal CentreOfGlass;
        [XmlAttribute("edgeOfGlass")]
        public decimal EdgeOfGlass;
        [XmlAttribute("frame")]
        public decimal Frame;
    }
}

