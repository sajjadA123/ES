namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.BaseLoadsComponents
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public class DishWasher
    {
        [XmlAttribute("numberPerOccupantPerWeek")]
        public decimal NumberPerOccupantPerWeek;
        [XmlElement("RatedValues")]
        public RatedValue RatedValues;

        public DishWasher()
        {
            this.RatedValues = new RatedValue();
            this.SetDefaults();
        }

        public DishWasher(DishWasher toCopy)
        {
            this.RatedValues = new RatedValue();
            this.RatedValues = new RatedValue(toCopy.RatedValues);
            this.NumberPerOccupantPerWeek = toCopy.NumberPerOccupantPerWeek;
        }

        public void SetDefaults()
        {
            this.RatedValues.SetDefaults();
            this.NumberPerOccupantPerWeek = 1.37M;
        }
    }
}

