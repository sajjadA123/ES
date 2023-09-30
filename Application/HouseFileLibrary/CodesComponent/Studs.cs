namespace ca.nrcan.gc.OEE.HouseFileLibrary.CodesComponent
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class Studs : UserDefinedBaseComponent
    {
        [XmlAttribute("isWood")]
        public bool IsWood;
        [XmlElement("Quantity")]
        public CodeAndText Quantity = new CodeAndText();
    }
}

