namespace ca.nrcan.gc.OEE.HouseFileLibrary.CodesComponent
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class StrappingLayer : UserDefinedLayer
    {
        [XmlElement("Strapping")]
        public FramingComponent Strapping = new FramingComponent();
        [XmlElement("CavityInsulation")]
        public UserDefinedComponent CavityInsulation = new UserDefinedComponent();
    }
}

