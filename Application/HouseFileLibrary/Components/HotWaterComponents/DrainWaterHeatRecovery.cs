namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.HotWaterComponents
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using ca.nrcan.gc.OEE.HouseFileLibrary.Components;
    using ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources;
    using System;
    using System.Linq;
    using System.Xml.Serialization;

    [Serializable]
    public class DrainWaterHeatRecovery
    {
        [XmlAttribute("showerLength")]
        public decimal ShowerLength;
        [XmlAttribute("dailyShowers")]
        public decimal DailyShowers;
        [XmlAttribute("preheatShowerTank")]
        public bool PreheatShowerTank;
        [XmlAttribute("effectivenessAt9.5")]
        public decimal Effectiveness;
        [XmlElement("Efficiency")]
        public CodeAndText Efficiency = new CodeAndText();
        [XmlElement("EquipmentInformation")]
        public ca.nrcan.gc.OEE.HouseFileLibrary.Components.EquipmentInformation EquipmentInformation;
        private ShowerTemperatures ShowerTemperature_ = ShowerTemperatures.Warm41C;
        private ShowerFlowRates ShowerHead_ = ShowerFlowRates.UltraLowFlow;

        [XmlElement("ShowerTemperature")]
        public CodeAndText ShowerTemperatureXml
        {
            get => 
                (CodeAndText) this.ShowerTemperature;
            set
            {
                if (value == null)
                {
                    this.ShowerTemperature = null;
                }
                else
                {
                    this.ShowerTemperature = (from dt in ShowerTemperatures.All
                        where dt.Code.ToString() == value.Code
                        select dt).FirstOrDefault<ShowerTemperatures>();
                }
            }
        }

        [XmlIgnore]
        public ShowerTemperatures ShowerTemperature
        {
            get => 
                this.ShowerTemperature_;
            set => 
                this.ShowerTemperature_ = value;
        }

        [XmlElement("ShowerHead")]
        public CodeAndText ShowerHeadXml
        {
            get => 
                (CodeAndText) this.ShowerHead;
            set
            {
                if (value == null)
                {
                    this.ShowerHead = null;
                }
                else
                {
                    this.ShowerHead = (from dt in ShowerFlowRates.All
                        where dt.Code.ToString() == value.Code
                        select dt).FirstOrDefault<ShowerFlowRates>();
                }
            }
        }

        [XmlIgnore]
        public ShowerFlowRates ShowerHead
        {
            get => 
                this.ShowerHead_;
            set => 
                this.ShowerHead_ = value;
        }
    }
}

