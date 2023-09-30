namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.ResultsComponents
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class DoorAndWindows
    {
        [XmlAttribute("door")]
        public decimal Door;
        [XmlElement("Windows")]
        public Cardinal Windows = new Cardinal();
    }
}

