namespace ca.nrcan.gc.OEE.HouseFileLibrary.CodesComponent
{
    using System;
    using System.Xml.Serialization;

    [Serializable, XmlInclude(typeof(FramingComponent)), XmlInclude(typeof(Studs)), XmlInclude(typeof(UserDefinedComponent))]
    public class UserDefinedBaseComponent : UserDefinedLayer
    {
        [XmlAttribute("resistivity")]
        public decimal Resistivity;
        [XmlElement("Material")]
        public ca.nrcan.gc.OEE.HouseFileLibrary.CodesComponent.Material Material = new ca.nrcan.gc.OEE.HouseFileLibrary.CodesComponent.Material();
    }
}

