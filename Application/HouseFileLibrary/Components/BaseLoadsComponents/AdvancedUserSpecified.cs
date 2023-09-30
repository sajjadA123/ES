namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.BaseLoadsComponents
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources;
    using System;
    using System.Linq;
    using System.Xml.Serialization;

    [Serializable]
    public class AdvancedUserSpecified
    {
        [XmlAttribute("hotWaterTemperature")]
        public decimal HotWaterTemperature;
        private ApplianceEnergySourceSpecified GasStove_;
        private ApplianceEnergySourceSpecified GasDryer_;
        [XmlElement("DryerLocation")]
        public CodeAndText DryerLocation;

        public AdvancedUserSpecified()
        {
            this.DryerLocation = new CodeAndText("1", "Main Floor", "Plancher Principal");
            this.SetDefaults();
        }

        public AdvancedUserSpecified(AdvancedUserSpecified toCopy)
        {
            this.DryerLocation = new CodeAndText("1", "Main Floor", "Plancher Principal");
            this.HotWaterTemperature = toCopy.HotWaterTemperature;
            this.GasStove = toCopy.GasStove;
            this.GasDryer = toCopy.GasDryer;
            this.DryerLocation = new CodeAndText(toCopy.DryerLocation);
        }

        public void SetDefaults()
        {
            this.HotWaterTemperature = 55M;
            this.GasStove = null;
            this.GasDryer = null;
            this.DryerLocation = new CodeAndText("1", "Main Floor", "Plancher Principal");
        }

        [XmlElement("GasStove")]
        public CodeTextAndValue GasStoveXml
        {
            get => 
                (CodeTextAndValue) this.GasStove;
            set
            {
                if (value == null)
                {
                    this.GasStove = null;
                }
                else
                {
                    this.GasStove = (from dt in ApplianceEnergySourceSpecified.All
                        where dt.Code.ToString() == value.Code
                        select dt).FirstOrDefault<ApplianceEnergySourceSpecified>();
                    if ((this.GasStove != null) && this.GasStove.IsUserSpecified)
                    {
                        this.GasStove.Value = value.Value;
                    }
                }
            }
        }

        [XmlIgnore]
        public ApplianceEnergySourceSpecified GasStove
        {
            get => 
                this.GasStove_;
            set
            {
                this.GasStove_ = value;
                if ((value != null) && value.IsUserSpecified)
                {
                    this.GasStove_ = (from us in ApplianceEnergySourceSpecified.All
                        where us.Code == value.Code
                        select us).FirstOrDefault<ApplianceEnergySourceSpecified>();
                    this.GasStove_.Value = value.Value;
                }
            }
        }

        [XmlElement("GasDryer")]
        public CodeTextAndValue GasDryerXml
        {
            get => 
                (CodeTextAndValue) this.GasDryer;
            set
            {
                if (value == null)
                {
                    this.GasDryer = null;
                }
                else
                {
                    this.GasDryer = (from dt in ApplianceEnergySourceSpecified.All
                        where dt.Code.ToString() == value.Code
                        select dt).FirstOrDefault<ApplianceEnergySourceSpecified>();
                    if ((this.GasDryer != null) && this.GasDryer.IsUserSpecified)
                    {
                        this.GasDryer.Value = value.Value;
                    }
                }
            }
        }

        [XmlIgnore]
        public ApplianceEnergySourceSpecified GasDryer
        {
            get => 
                this.GasDryer_;
            set
            {
                this.GasDryer_ = value;
                if ((value != null) && value.IsUserSpecified)
                {
                    this.GasDryer_ = (from us in ApplianceEnergySourceSpecified.All
                        where us.Code == value.Code
                        select us).FirstOrDefault<ApplianceEnergySourceSpecified>();
                    this.GasDryer_.Value = value.Value;
                }
            }
        }
    }
}

