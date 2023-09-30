namespace ca.nrcan.gc.OEE.HouseFileLibrary.CodesComponent
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class StandardLayer
    {
        [XmlElement("InsulationInFramingLayer")]
        public CodeAndText InsulationInFramingLayer;
        [XmlElement("ExtraInsulationLayer")]
        public CodeAndText ExtraInsulationLayer;
        [XmlElement("Framing")]
        public CodeAndText Framing;
        [XmlElement("StructureType")]
        public CodeAndText StructureType;
        [XmlElement("ComponentTypeSize")]
        public CodeAndText ComponentTypeSize;
        [XmlElement("Spacing")]
        public CodeAndText Spacing;
        [XmlElement("Insulation")]
        public CodeAndText Insulation;
        [XmlElement("InsulationLayer1")]
        public CodeAndText InsulationLayer1;
        [XmlElement("InsulationLayer2")]
        public CodeAndText InsulationLayer2;
        [XmlElement("Interior")]
        public CodeAndText Interior;
        [XmlElement("InteriorFinish")]
        public CodeAndText InteriorFinish;
        [XmlElement("Sheathing")]
        public CodeAndText Sheathing;
        [XmlElement("Exterior")]
        public CodeAndText Exterior;
        [XmlElement("Type")]
        public CodeAndText Type;
        [XmlElement("DropFraming")]
        public CodeAndText DropFraming;
        [XmlElement("Material")]
        public CodeAndText Material;
        [XmlElement("StudsCornerIntersection")]
        public CodeAndText StudsCornerIntersection;
        [XmlElement("GlazingTypes")]
        public CodeAndText GlazingTypes;
        [XmlElement("CoatingsTints")]
        public CodeAndText CoatingsTints;
        [XmlElement("FillType")]
        public CodeAndText FillType;
        [XmlElement("SpacerType")]
        public CodeAndText SpacerType;
        [XmlElement("FrameMaterial")]
        public CodeAndText FrameMaterial;
    }
}

