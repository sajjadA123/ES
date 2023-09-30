namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.Type2
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources;
    using System;
    using System.Linq;
    using System.Xml.Serialization;

    [Serializable]
    public class SourceTemperature
    {
        [XmlAttribute("depth")]
        public decimal Depth;
        private HeatingCoolingUses Use_ = HeatingCoolingUses.Calculated;
        [XmlElement("Temperatures")]
        public MonthlyData Temperatures;

        [XmlElement("Use")]
        public CodeAndText UseXml
        {
            get => 
                (CodeAndText) this.Use;
            set
            {
                if (value == null)
                {
                    this.Use = null;
                }
                else
                {
                    this.Use = (from dt in HeatingCoolingUses.All
                        where dt.Code.ToString() == value.Code
                        select dt).FirstOrDefault<HeatingCoolingUses>();
                }
            }
        }

        [XmlIgnore]
        public HeatingCoolingUses Use
        {
            get => 
                this.Use_;
            set
            {
                if (value == null)
                {
                    this.Use_ = HeatingCoolingUses.Calculated;
                }
                else
                {
                    this.Use_ = value;
                }
            }
        }
    }
}

