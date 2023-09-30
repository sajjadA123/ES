namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.BaseLoadsComponents
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources;
    using System;
    using System.Linq;
    using System.Xml.Serialization;

    [Serializable]
    public class Shower
    {
        [XmlAttribute("averageDuration")]
        public decimal AverageDuration;
        [XmlAttribute("numberPerOccupantPerWeek")]
        public decimal NumberPerOccupantPerWeek;
        [XmlAttribute("totalDurationPerDay")]
        public decimal TotalDurationPerDay;
        private BaseShowerTemperatures Temperature_;
        private BaseShowerFlowRates FlowRate_;

        public Shower()
        {
            this.Temperature_ = BaseShowerTemperatures.Warm41C;
            this.FlowRate_ = BaseShowerFlowRates.Standard;
            this.SetDefaults();
        }

        public Shower(Shower toCopy)
        {
            this.Temperature_ = BaseShowerTemperatures.Warm41C;
            this.FlowRate_ = BaseShowerFlowRates.Standard;
            this.AverageDuration = toCopy.AverageDuration;
            this.NumberPerOccupantPerWeek = toCopy.NumberPerOccupantPerWeek;
            this.TotalDurationPerDay = toCopy.TotalDurationPerDay;
            this.Temperature = toCopy.Temperature;
            this.FlowRate = toCopy.FlowRate;
        }

        public void SetDefaults()
        {
            this.AverageDuration = 6.5M;
            this.NumberPerOccupantPerWeek = 5.2M;
            this.TotalDurationPerDay = 14.4857M;
            this.Temperature = BaseShowerTemperatures.Warm41C;
            this.FlowRate = BaseShowerFlowRates.Standard;
        }

        [XmlElement("Temperature")]
        public CodeTextAndValue TemperatureXml
        {
            get => 
                (CodeTextAndValue) this.Temperature;
            set
            {
                if (value == null)
                {
                    this.Temperature = null;
                }
                else
                {
                    this.Temperature = (from dt in BaseShowerTemperatures.All
                        where dt.Code.ToString() == value.Code
                        select dt).FirstOrDefault<BaseShowerTemperatures>();
                    if (this.Temperature.IsUserSpecified)
                    {
                        this.Temperature.Value = value.Value;
                    }
                }
            }
        }

        [XmlIgnore]
        public BaseShowerTemperatures Temperature
        {
            get => 
                this.Temperature_;
            set
            {
                if (value == null)
                {
                    this.Temperature_ = BaseShowerTemperatures.Warm41C;
                }
                else
                {
                    this.Temperature_ = value;
                }
            }
        }

        [XmlElement("FlowRate")]
        public CodeTextAndValue FlowRateXml
        {
            get => 
                (CodeTextAndValue) this.FlowRate;
            set
            {
                if (value == null)
                {
                    this.FlowRate = null;
                }
                else
                {
                    this.FlowRate = (from dt in BaseShowerFlowRates.All
                        where dt.Code.ToString() == value.Code
                        select dt).FirstOrDefault<BaseShowerFlowRates>();
                    if (this.FlowRate.IsUserSpecified)
                    {
                        this.FlowRate.Value = value.Value;
                    }
                }
            }
        }

        [XmlIgnore]
        public BaseShowerFlowRates FlowRate
        {
            get => 
                this.FlowRate_;
            set
            {
                if (value == null)
                {
                    this.FlowRate_ = BaseShowerFlowRates.Standard;
                }
                else
                {
                    this.FlowRate_ = value;
                }
            }
        }
    }
}

