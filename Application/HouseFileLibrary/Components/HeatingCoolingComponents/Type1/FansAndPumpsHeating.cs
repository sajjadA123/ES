namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.Type1
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources;
    using System;
    using System.Linq;
    using System.Xml.Serialization;

    [Serializable]
    public class FansAndPumpsHeating
    {
        [XmlAttribute("hasEnergyEfficientMotor")]
        public bool HasEnergyEfficientMotor;
        private HeatingFanModes Mode_ = HeatingFanModes.Auto;
        [XmlElement("Power")]
        public FansAndPumpPowerHeating Power = new FansAndPumpPowerHeating();

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
                    this.Mode = (from dt in HeatingFanModes.All
                        where dt.Code.ToString() == value.Code
                        select dt).FirstOrDefault<HeatingFanModes>();
                }
            }
        }

        [XmlIgnore]
        public HeatingFanModes Mode
        {
            get => 
                this.Mode_;
            set
            {
                if (value == null)
                {
                    this.Mode_ = HeatingFanModes.Auto;
                }
                else
                {
                    this.Mode_ = value;
                }
            }
        }
    }
}

