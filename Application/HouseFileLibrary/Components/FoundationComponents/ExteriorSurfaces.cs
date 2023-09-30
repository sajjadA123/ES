namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.FoundationComponents
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class ExteriorSurfaces
    {
        [XmlAttribute("aboveGradeArea")]
        public decimal AboveGradeArea;
        [XmlAttribute("belowGradeArea")]
        public decimal BelowGradeArea;
        [XmlAttribute("ponyWallArea")]
        public decimal PonyWallArea;
        [XmlAttribute("slabPerimeter")]
        public decimal SlabPerimeter;
    }
}

