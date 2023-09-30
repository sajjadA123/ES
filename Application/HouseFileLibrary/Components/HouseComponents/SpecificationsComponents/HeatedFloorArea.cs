namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.HouseComponents.SpecificationsComponents
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class HeatedFloorArea
    {
        [XmlAttribute("aboveGrade")]
        public decimal AboveGrade;
        [XmlAttribute("belowGrade")]
        public decimal BelowGrade;
        [XmlAttribute("nonResUnits")]
        public decimal NonResUnits;
        [XmlAttribute("commonSpace")]
        public decimal CommonSpace;

        public HeatedFloorArea()
        {
            this.SetDefaults();
        }

        public HeatedFloorArea(HeatedFloorArea toCopy)
        {
            this.AboveGrade = toCopy.AboveGrade;
            this.BelowGrade = toCopy.BelowGrade;
            this.NonResUnits = toCopy.NonResUnits;
            this.CommonSpace = toCopy.CommonSpace;
        }

        public void SetDefaults()
        {
            this.AboveGrade = 0.1M;
            this.BelowGrade = 0.1M;
            this.NonResUnits = 0M;
            this.CommonSpace = 0M;
        }
    }
}

