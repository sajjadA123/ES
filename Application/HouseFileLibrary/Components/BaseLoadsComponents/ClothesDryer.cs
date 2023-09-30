namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.BaseLoadsComponents
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources;
    using System;
    using System.Linq;
    using System.Xml.Serialization;

    [Serializable]
    public class ClothesDryer
    {
        [XmlAttribute("installed")]
        public bool Installed;
        [XmlAttribute("percentageOfWasherLoads")]
        public decimal PercentageOfWasherLoads;
        private ApplianceEnergySources EnergySource_;
        private DryerRatedConsumptions RatedValue_;
        [XmlElement("Location")]
        public CodeAndText Location;

        public ClothesDryer()
        {
            this.EnergySource_ = ApplianceEnergySources.Electric;
            this.RatedValue_ = DryerRatedConsumptions.Default;
            this.Location = new CodeAndText();
            this.SetDefaults();
        }

        public ClothesDryer(ClothesDryer toCopy)
        {
            this.EnergySource_ = ApplianceEnergySources.Electric;
            this.RatedValue_ = DryerRatedConsumptions.Default;
            this.Location = new CodeAndText();
            this.Installed = toCopy.Installed;
            this.PercentageOfWasherLoads = toCopy.PercentageOfWasherLoads;
            this.EnergySource = toCopy.EnergySource;
            this.RatedValue = toCopy.RatedValue;
            this.Location = new CodeAndText(toCopy.Location);
        }

        public void SetDefaults()
        {
            this.Installed = true;
            this.PercentageOfWasherLoads = 71M;
            this.EnergySource = ApplianceEnergySources.Electric;
            this.RatedValue = DryerRatedConsumptions.Default;
            this.Location = new CodeAndText("1", "Electric", "\x00c9lectricit\x00e9");
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
                    this.RatedValue = (from dt in DryerRatedConsumptions.All
                        where dt.Code.ToString() == value.Code
                        select dt).FirstOrDefault<DryerRatedConsumptions>();
                    if (this.RatedValue.IsUserSpecified)
                    {
                        this.RatedValue.Value = value.Value;
                    }
                }
            }
        }

        [XmlIgnore]
        public DryerRatedConsumptions RatedValue
        {
            get => 
                this.RatedValue_;
            set
            {
                if (value == null)
                {
                    this.RatedValue_ = DryerRatedConsumptions.Default;
                }
                else if ((value == null) || !value.IsUserSpecified)
                {
                    this.RatedValue_ = value;
                }
                else
                {
                    this.RatedValue_ = (from us in DryerRatedConsumptions.All
                        where us.Code == value.Code
                        select us).FirstOrDefault<DryerRatedConsumptions>();
                    this.RatedValue_.Value = value.Value;
                }
            }
        }
    }
}

