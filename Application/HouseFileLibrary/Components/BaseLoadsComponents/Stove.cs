namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.BaseLoadsComponents
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources;
    using System;
    using System.Linq;
    using System.Xml.Serialization;

    [Serializable]
    public class Stove
    {
        private ApplianceEnergySources EnergySource_;
        private StoveRatedConsumptions RatedValue_;

        public Stove()
        {
            this.EnergySource_ = ApplianceEnergySources.Electric;
            this.RatedValue_ = StoveRatedConsumptions.Default;
            this.SetDefaults();
        }

        public Stove(Stove toCopy)
        {
            this.EnergySource_ = ApplianceEnergySources.Electric;
            this.RatedValue_ = StoveRatedConsumptions.Default;
            this.EnergySource = toCopy.EnergySource;
            this.RatedValue = toCopy.RatedValue;
        }

        public void SetDefaults()
        {
            this.EnergySource = ApplianceEnergySources.Electric;
            this.RatedValue = StoveRatedConsumptions.Default;
        }

        [XmlElement("EnergySource")]
        public CodeAndText EnergySourceXml
        {
            get => 
                (CodeAndText) this.EnergySource;
            set
            {
                if (value == null)
                {
                    this.EnergySource = null;
                }
                else
                {
                    this.EnergySource = (from dt in ApplianceEnergySources.All
                        where dt.Code.ToString() == value.Code
                        select dt).FirstOrDefault<ApplianceEnergySources>();
                }
            }
        }

        [XmlIgnore]
        public ApplianceEnergySources EnergySource
        {
            get => 
                this.EnergySource_;
            set
            {
                if (value == null)
                {
                    this.EnergySource_ = ApplianceEnergySources.Electric;
                }
                else
                {
                    this.EnergySource_ = value;
                }
            }
        }

        [XmlElement("RatedValue")]
        public CodeTextAndValue RatedValueXml
        {
            get => 
                (CodeTextAndValue) this.RatedValue;
            set
            {
                if (value == null)
                {
                    this.RatedValue = null;
                }
                else
                {
                    this.RatedValue = (from dt in StoveRatedConsumptions.All
                        where dt.Code.ToString() == value.Code
                        select dt).FirstOrDefault<StoveRatedConsumptions>();
                    if (this.RatedValue.IsUserSpecified)
                    {
                        this.RatedValue.Value = value.Value;
                    }
                }
            }
        }

        [XmlIgnore]
        public StoveRatedConsumptions RatedValue
        {
            get => 
                this.RatedValue_;
            set
            {
                if (value == null)
                {
                    this.RatedValue_ = StoveRatedConsumptions.Default;
                }
                else if ((value == null) || !value.IsUserSpecified)
                {
                    this.RatedValue_ = value;
                }
                else
                {
                    this.RatedValue_ = (from us in StoveRatedConsumptions.All
                        where us.Code == value.Code
                        select us).FirstOrDefault<StoveRatedConsumptions>();
                    this.RatedValue_.Value = value.Value;
                }
            }
        }
    }
}

