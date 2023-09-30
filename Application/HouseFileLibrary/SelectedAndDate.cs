namespace ca.nrcan.gc.OEE.HouseFileLibrary
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class SelectedAndDate
    {
        [XmlAttribute("selected")]
        public bool Selected;
        [XmlText]
        public string Date;
    }
}

