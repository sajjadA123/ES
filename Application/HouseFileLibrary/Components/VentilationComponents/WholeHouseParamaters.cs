namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.VentilationComponents
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources;
    using System;
    using System.Linq;
    using System.Xml.Serialization;

    [Serializable]
    public class WholeHouseParamaters
    {
        [XmlAttribute("temperatureControlLower")]
        public decimal TemperatureControlLower;
        [XmlAttribute("temperatureControlUpper")]
        public decimal TemperatureControlUpper;
        [XmlAttribute("hviHrvErvInMurb")]
        public ushort HviHrvErvInMurb;
        private AirDistributionTypes AirDistributionType_ = AirDistributionTypes.ForcedAirHeatingDuctwork;
        private AirDistributionFanPowerLevels AirDistributionFanPower_ = AirDistributionFanPowerLevels.Default;
        private OperationSchedules OperationSchedule_ = OperationSchedules.FourHundredEightyMinsPerDay;

        [XmlElement("AirDistributionType")]
        public CodeAndText AirDistributionTypeXml
        {
            get => 
                (CodeAndText) this.AirDistributionType;
            set
            {
                if (value == null)
                {
                    this.AirDistributionType = null;
                }
                else
                {
                    this.AirDistributionType = (from dt in AirDistributionTypes.All
                        where dt.Code.ToString() == value.Code
                        select dt).FirstOrDefault<AirDistributionTypes>();
                }
            }
        }

        [XmlIgnore]
        public AirDistributionTypes AirDistributionType
        {
            get => 
                this.AirDistributionType_;
            set
            {
                if (value == null)
                {
                    this.AirDistributionType_ = AirDistributionTypes.ForcedAirHeatingDuctwork;
                }
                else
                {
                    this.AirDistributionType_ = value;
                }
            }
        }

        [XmlElement("AirDistributionFanPower")]
        public CodeTextAndValue AirDistributionFanPowerXml
        {
            get => 
                (CodeTextAndValue) this.AirDistributionFanPower;
            set
            {
                if (value == null)
                {
                    this.AirDistributionFanPower = null;
                }
                else
                {
                    this.AirDistributionFanPower = (from dt in AirDistributionFanPowerLevels.All
                        where dt.Code.ToString() == value.Code
                        select dt).FirstOrDefault<AirDistributionFanPowerLevels>();
                    if (this.AirDistributionFanPower.IsUserSpecified)
                    {
                        this.AirDistributionFanPower.Value = value.Value;
                    }
                }
            }
        }

        [XmlIgnore]
        public AirDistributionFanPowerLevels AirDistributionFanPower
        {
            get => 
                this.AirDistributionFanPower_;
            set
            {
                if (value == null)
                {
                    this.AirDistributionFanPower_ = AirDistributionFanPowerLevels.Default;
                }
                else if ((value == null) || !value.IsUserSpecified)
                {
                    this.AirDistributionFanPower_ = value;
                }
                else
                {
                    this.AirDistributionFanPower_ = (from us in AirDistributionFanPowerLevels.All
                        where us.Code == value.Code
                        select us).FirstOrDefault<AirDistributionFanPowerLevels>();
                    this.AirDistributionFanPower_.Value = value.Value;
                }
            }
        }

        [XmlElement("OperationSchedule")]
        public CodeTextAndValue OperationScheduleXml
        {
            get => 
                (CodeTextAndValue) this.OperationSchedule;
            set
            {
                if (value == null)
                {
                    this.OperationSchedule = null;
                }
                else
                {
                    this.OperationSchedule = (from dt in OperationSchedules.All
                        where dt.Code.ToString() == value.Code
                        select dt).FirstOrDefault<OperationSchedules>();
                    if (this.OperationSchedule.IsUserSpecified)
                    {
                        this.OperationSchedule.Value = value.Value;
                    }
                }
            }
        }

        [XmlIgnore]
        public OperationSchedules OperationSchedule
        {
            get => 
                this.OperationSchedule_;
            set
            {
                if (value == null)
                {
                    this.OperationSchedule_ = OperationSchedules.FourHundredEightyMinsPerDay;
                }
                else if ((value == null) || !value.IsUserSpecified)
                {
                    this.OperationSchedule_ = value;
                }
                else
                {
                    this.OperationSchedule_ = (from us in OperationSchedules.All
                        where us.Code == value.Code
                        select us).FirstOrDefault<OperationSchedules>();
                    this.OperationSchedule_.Value = value.Value;
                }
            }
        }
    }
}

