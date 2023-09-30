namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.VentilationComponents
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources;
    using System;
    using System.Linq;
    using System.Xml.Serialization;

    [Serializable]
    public class Rooms
    {
        [XmlAttribute("living")]
        public uint Living;
        [XmlAttribute("bedrooms")]
        public uint Bedrooms;
        [XmlAttribute("bathrooms")]
        public uint Bathrooms;
        [XmlAttribute("utility")]
        public uint Utility;
        [XmlAttribute("otherHabitable")]
        public uint OtherHabitable;
        private ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources.VentilationRate VentilationRate_ = ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources.VentilationRate.TenLitersPerSecond;
        private DepressurizationLimits DepressurizationLimit_ = DepressurizationLimits.FivePa;

        [XmlElement("VentilationRate")]
        public CodeTextAndValue VentilationRateXml
        {
            get => 
                (CodeTextAndValue) this.VentilationRate;
            set
            {
                if (value == null)
                {
                    this.VentilationRate = null;
                }
                else
                {
                    this.VentilationRate = (from dt in ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources.VentilationRate.All
                        where dt.Code.ToString() == value.Code
                        select dt).FirstOrDefault<ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources.VentilationRate>();
                    if (this.VentilationRate.IsUserSpecified)
                    {
                        this.VentilationRate.Value = value.Value;
                    }
                }
            }
        }

        [XmlIgnore]
        public ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources.VentilationRate VentilationRate
        {
            get => 
                this.VentilationRate_;
            set
            {
                if (value == null)
                {
                    this.VentilationRate_ = ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources.VentilationRate.TenLitersPerSecond;
                }
                else
                {
                    this.VentilationRate_ = value;
                }
            }
        }

        [XmlElement("DepressurizationLimit")]
        public CodeTextAndValue DepressurizationLimitXml
        {
            get => 
                (CodeTextAndValue) this.DepressurizationLimit;
            set
            {
                if (value == null)
                {
                    this.DepressurizationLimit = null;
                }
                else
                {
                    this.DepressurizationLimit = (from dt in DepressurizationLimits.All
                        where dt.Code.ToString() == value.Code
                        select dt).FirstOrDefault<DepressurizationLimits>();
                    if (this.DepressurizationLimit.IsUserSpecified)
                    {
                        this.DepressurizationLimit.Value = value.Value;
                    }
                }
            }
        }

        [XmlIgnore]
        public DepressurizationLimits DepressurizationLimit
        {
            get => 
                this.DepressurizationLimit_;
            set
            {
                if (value == null)
                {
                    this.DepressurizationLimit_ = DepressurizationLimits.FivePa;
                }
                else if ((value == null) || !value.IsUserSpecified)
                {
                    this.DepressurizationLimit_ = value;
                }
                else
                {
                    this.DepressurizationLimit_ = (from us in DepressurizationLimits.All
                        where us.Code == value.Code
                        select us).FirstOrDefault<DepressurizationLimits>();
                    this.DepressurizationLimit_.Value = value.Value;
                }
            }
        }

        [XmlIgnore]
        public decimal MinimumVentilationRate
        {
            get
            {
                decimal num = ((this.Living + this.Bathrooms) + this.Utility) + this.OtherHabitable;
                if (this.Bedrooms > 0)
                {
                    num += this.Bedrooms;
                }
                num *= 5M;
                if (this.Bedrooms > 0)
                {
                    num += 10M;
                }
                return (num + this.VentilationRate.Value);
            }
        }
    }
}

