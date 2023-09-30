namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.RoomComponents
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class RoomMeasurements
    {
        [XmlAttribute("isRectangular")]
        public bool IsRectangular;
        [XmlAttribute("height")]
        public decimal Height;
        [XmlAttribute("width")]
        public decimal Width;
        [XmlAttribute("depth")]
        public decimal Depth;
        [XmlAttribute("perimeter")]
        public decimal Perimeter;
        [XmlAttribute("area")]
        public decimal Area;
    }
}

