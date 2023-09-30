namespace ca.nrcan.gc.OEE.HouseFileLibrary.CodesComponent
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class Material
    {
        [XmlElement("Category")]
        public CodeAndText Category = new CodeAndText();
        [XmlElement("Type")]
        public CodeAndText Type;
    }
}

