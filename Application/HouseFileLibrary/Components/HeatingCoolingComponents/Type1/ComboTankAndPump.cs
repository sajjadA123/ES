namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.Type1
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources;
    using System;
    using System.Linq;
    using System.Xml.Serialization;

    [Serializable]
    public class ComboTankAndPump
    {
        [XmlAttribute("waterTemperature")]
        public decimal WaterTemperature;
        private DhwTankVolumes TankCapacity_ = DhwTankVolumes.NotApplicable;
        [XmlElement("EnergyFactor")]
        public ComboEnergyFactor EnergyFactor = new ComboEnergyFactor();
        [XmlElement("TankLocation")]
        public CodeAndText TankLocation = new CodeAndText();
        [XmlElement("CirculationPump")]
        public ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.Type1.CirculationPump CirculationPump = new ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.Type1.CirculationPump();

        [XmlElement("TankCapacity")]
        public CodeTextAndValue TankCapacityXml
        {
            get => 
                (CodeTextAndValue) this.TankCapacity;
            set
            {
                if (value == null)
                {
                    this.TankCapacity = null;
                }
                else
                {
                    this.TankCapacity = (from dt in DhwTankVolumes.All
                        where dt.Code.ToString() == value.Code
                        select dt).FirstOrDefault<DhwTankVolumes>();
                    if (this.TankCapacity.IsUserSpecified)
                    {
                        this.TankCapacity.Value = value.Value;
                    }
                }
            }
        }

        [XmlIgnore]
        public DhwTankVolumes TankCapacity
        {
            get => 
                this.TankCapacity_;
            set
            {
                if (value == null)
                {
                    this.TankCapacity_ = DhwTankVolumes.NotApplicable;
                }
                else if ((value == null) || !value.IsUserSpecified)
                {
                    this.TankCapacity_ = value;
                }
                else
                {
                    this.TankCapacity_ = (from us in DhwTankVolumes.All
                        where us.Code == value.Code
                        select us).FirstOrDefault<DhwTankVolumes>();
                    this.TankCapacity_.Value = value.Value;
                }
            }
        }
    }
}

