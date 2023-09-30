namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.ResultsComponents
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class GrossAreaMainFloors : GrossAreaFloor
    {
        [XmlAttribute("mainWalls")]
        public decimal MainWalls;
    }
}

