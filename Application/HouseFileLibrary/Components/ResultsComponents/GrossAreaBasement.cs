namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.ResultsComponents
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class GrossAreaBasement : GrossAreaFloor
    {
        [XmlAttribute("aboveGrade")]
        public decimal AboveGrade;
        [XmlAttribute("belowGrade")]
        public decimal BelowGrade;
        [XmlAttribute("floorSlab")]
        public decimal FloorSlab;
        [XmlAttribute("floorHeader")]
        public decimal FloorHeader;
        [XmlAttribute("floorsAbove")]
        public decimal FloorsAbove;
    }
}

