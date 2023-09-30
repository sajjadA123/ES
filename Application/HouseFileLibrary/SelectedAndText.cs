namespace ca.nrcan.gc.OEE.HouseFileLibrary
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class SelectedAndText
    {
        [XmlAttribute("selected")]
        public bool Selected;
        [XmlText]
        public string Text;
    }
}

