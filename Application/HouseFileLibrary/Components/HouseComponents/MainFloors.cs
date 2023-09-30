namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.HouseComponents
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources;
    using System;
    using System.Linq;
    using System.Xml.Serialization;

    [Serializable]
    public class MainFloors
    {
        [XmlAttribute("coolingSetPoint")]
        public decimal CoolingSetPoint;
        [XmlAttribute("daytimeHeatingSetPoint")]
        public decimal DaytimeHeatingSetPoint;
        [XmlAttribute("nighttimeHeatingSetPoint")]
        public decimal NighttimeHeatingSetPoint;
        [XmlAttribute("nighttimeSetbackDuration")]
        public decimal NighttimeSetbackDuration;
        private ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources.AllowableRise AllowableRise_ = ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources.AllowableRise.High;

        [XmlElement("AllowableRise")]
        public CodeAndText AllowableRiseXml
        {
            get => 
                (CodeAndText) this.AllowableRise;
            set
            {
                if (value == null)
                {
                    this.AllowableRise = null;
                }
                else
                {
                    this.AllowableRise = (from dt in ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources.AllowableRise.All
                        where dt.Code.ToString() == value.Code
                        select dt).FirstOrDefault<ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources.AllowableRise>();
                }
            }
        }

        [XmlIgnore]
        public ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources.AllowableRise AllowableRise
        {
            get => 
                this.AllowableRise_;
            set
            {
                if (value == null)
                {
                    this.AllowableRise_ = ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources.AllowableRise.High;
                }
                else
                {
                    this.AllowableRise_ = value;
                }
            }
        }
    }
}

