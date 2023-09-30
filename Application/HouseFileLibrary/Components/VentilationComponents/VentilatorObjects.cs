namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.VentilationComponents
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using ca.nrcan.gc.OEE.HouseFileLibrary.Components;
    using ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources;
    using System;
    using System.Linq;
    using System.Xml.Serialization;

    [XmlInclude(typeof(Hrv)), XmlInclude(typeof(Dryer))]
    public class VentilatorObjects
    {
        [XmlAttribute("supplyFlowrate")]
        public decimal SupplyFlowrate;
        [XmlAttribute("exhaustFlowrate")]
        public decimal ExhaustFlowrate;
        [XmlAttribute("fanPower1")]
        public decimal FanPower1;
        [XmlAttribute("isDefaultFanpower")]
        public bool IsDefaultFanpower;
        [XmlAttribute("isEnergyStar")]
        public bool IsEnergyStar;
        [XmlAttribute("isHomeVentilatingInstituteCertified")]
        public bool IsHomeVentilatingInstituteCertified;
        [XmlAttribute("isSupplemental")]
        public bool IsSupplemental;
        private VentilatorTypes VentilatorType_ = VentilatorTypes.NotApplicable;
        [XmlElement("EquipmentInformation")]
        public ca.nrcan.gc.OEE.HouseFileLibrary.Components.EquipmentInformation EquipmentInformation = new ca.nrcan.gc.OEE.HouseFileLibrary.Components.EquipmentInformation();
        private OperationSchedules OperationSchedule_ = OperationSchedules.FortyFiveMinsPerDay;

        [XmlElement("VentilatorType")]
        public CodeAndText VentilatorTypeXml
        {
            get => 
                (CodeAndText) this.VentilatorType;
            set
            {
                if (value == null)
                {
                    this.VentilatorType = null;
                }
                else
                {
                    this.VentilatorType = (from dt in VentilatorTypes.All
                        where dt.Code.ToString() == value.Code
                        select dt).FirstOrDefault<VentilatorTypes>();
                }
            }
        }

        [XmlIgnore]
        public VentilatorTypes VentilatorType
        {
            get => 
                this.VentilatorType_;
            set
            {
                if (value == null)
                {
                    this.VentilatorType_ = VentilatorTypes.NotApplicable;
                }
                else
                {
                    this.VentilatorType_ = value;
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
                    this.OperationSchedule_ = OperationSchedules.FortyFiveMinsPerDay;
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

