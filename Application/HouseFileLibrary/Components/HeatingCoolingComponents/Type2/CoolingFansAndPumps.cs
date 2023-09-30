namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.Type2
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources;
    using System;
    using System.Linq;
    using System.Xml.Serialization;

    [Serializable]
    public class CoolingFansAndPumps
    {
        [XmlAttribute("flowRate")]
        public decimal FlowRate;
        [XmlAttribute("hasEnergyEfficientMotor")]
        public bool HasEnergyEfficientMotor;
        private CoolingFanModes Mode_ = CoolingFanModes.Auto;
        [XmlElement("Power")]
        public FansAndPumpPowerCooling Power = new FansAndPumpPowerCooling();

        [XmlElement("Mode")]
        public CodeAndText ModeXml
        {
            get => 
                (CodeAndText) this.Mode;
            set
            {
                if (value == null)
                {
                    this.Mode = null;
                }
                else
                {
                    this.Mode = (from dt in CoolingFanModes.All
                        where dt.Code.ToString() == value.Code
                        select dt).FirstOrDefault<CoolingFanModes>();
                }
            }
        }

        [XmlIgnore]
        public CoolingFanModes Mode
        {
            get => 
                this.Mode_;
            set
            {
                if (value == null)
                {
                    this.Mode_ = CoolingFanModes.Auto;
                }
                else
                {
                    this.Mode_ = value;
                }
            }
        }
    }
}

