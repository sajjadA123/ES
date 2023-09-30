namespace ca.nrcan.gc.OEE.HouseFileLibrary
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class Cardinal
    {
        [XmlAttribute("south")]
        public decimal South;
        [XmlAttribute("southEast")]
        public decimal SouthEast;
        [XmlAttribute("east")]
        public decimal East;
        [XmlAttribute("northEast")]
        public decimal NorthEast;
        [XmlAttribute("north")]
        public decimal North;
        [XmlAttribute("northWest")]
        public decimal NorthWest;
        [XmlAttribute("west")]
        public decimal West;
        [XmlAttribute("southWest")]
        public decimal SouthWest;

        [XmlIgnore]
        public decimal Total =>
            ((((((this.South + this.SouthEast) + this.East) + this.NorthEast) + this.North) + this.NorthWest) + this.West) + this.SouthWest;
    }
}

