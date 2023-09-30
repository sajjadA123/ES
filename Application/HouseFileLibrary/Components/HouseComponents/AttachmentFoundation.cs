namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.HouseComponents
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class AttachmentFoundation
    {
        [XmlAttribute("id")]
        public uint Id;
        [XmlAttribute("aboveGradeArea")]
        public decimal AboveGradeArea;
        [XmlAttribute("belowGradeArea")]
        public decimal BelowGradeArea;
        [XmlAttribute("slabLength")]
        public decimal SlabLength;
        [XmlText]
        public string Text;
    }
}

