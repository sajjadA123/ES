namespace ca.nrcan.gc.OEE.HouseFileLibrary.CodesComponent
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class LintelUserDefined : UserDefinedLayer
    {
        [XmlAttribute("totalThickness")]
        public decimal TotalThickness;
        [XmlElement("Studs")]
        public ca.nrcan.gc.OEE.HouseFileLibrary.CodesComponent.Studs Studs = new ca.nrcan.gc.OEE.HouseFileLibrary.CodesComponent.Studs();
        [XmlElement("Insulation")]
        public UserDefinedBaseComponent Insulation = new UserDefinedBaseComponent();
    }
}

