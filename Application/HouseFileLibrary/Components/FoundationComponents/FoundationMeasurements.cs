namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.FoundationComponents
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class FoundationMeasurements
    {
        [XmlAttribute("isRectangular")]
        public bool IsRectangular;
        [XmlAttribute("area")]
        public decimal Area;
        [XmlAttribute("width")]
        public decimal Width;
        [XmlAttribute("length")]
        public decimal Length;
        [XmlAttribute("perimeter")]
        public decimal Perimeter;

        [XmlIgnore]
        public decimal FloorArea =>
            this.IsRectangular ? (this.Width * this.Length) : this.Area;
    }
}

