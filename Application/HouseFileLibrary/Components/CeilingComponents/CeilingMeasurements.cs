namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.CeilingComponents
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources;
    using System;
    using System.Linq;
    using System.Xml.Serialization;

    [Serializable]
    public class CeilingMeasurements
    {
        [XmlAttribute("area")]
        public decimal Area;
        [XmlAttribute("length")]
        public decimal Length;
        [XmlAttribute("heelHeight")]
        public decimal HeelHeight;
        private CeilingSlopes Slope_;

        public CeilingMeasurements()
        {
            this.Slope_ = CeilingSlopes.Slope4Twelfth;
        }

        public CeilingMeasurements(CeilingMeasurements toCopy)
        {
            this.Slope_ = CeilingSlopes.Slope4Twelfth;
            this.Area = toCopy.Area;
            this.Length = toCopy.Length;
            this.HeelHeight = toCopy.HeelHeight;
            this.Slope = toCopy.Slope;
        }

        [XmlElement("Slope")]
        public CodeTextAndValue SlopeXml
        {
            get => 
                (CodeTextAndValue) this.Slope;
            set
            {
                if (value == null)
                {
                    this.Slope = null;
                }
                else
                {
                    this.Slope = (from dt in CeilingSlopes.All
                        where dt.Code.ToString() == value.Code
                        select dt).FirstOrDefault<CeilingSlopes>();
                    if (this.Slope.IsUserSpecified)
                    {
                        this.Slope.Value = value.Value;
                    }
                }
            }
        }

        [XmlIgnore]
        public CeilingSlopes Slope
        {
            get => 
                this.Slope_;
            set
            {
                if (value == null)
                {
                    this.Slope_ = CeilingSlopes.Slope4Twelfth;
                }
                else if ((value == null) || !value.IsUserSpecified)
                {
                    this.Slope_ = value;
                }
                else
                {
                    this.Slope_ = (from us in CeilingSlopes.All
                        where us.Code == value.Code
                        select us).FirstOrDefault<CeilingSlopes>();
                    this.Slope_.Value = value.Value;
                }
            }
        }
    }
}

