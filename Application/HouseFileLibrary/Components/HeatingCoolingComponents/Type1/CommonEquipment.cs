namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.Type1
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources;
    using System;
    using System.Linq;
    using System.Xml.Serialization;

    [Serializable]
    public class CommonEquipment
    {
        [XmlAttribute("isBiEnergy")]
        public bool IsBiEnergy;
        [XmlAttribute("switchoverTemperature")]
        public decimal SwitchoverTemperature;
        private HeatingEnergySources EnergySource_ = HeatingEnergySources.Electric;

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
                    this.EnergySource = (from dt in HeatingEnergySources.All
                        where dt.Code.ToString() == value.Code
                        select dt).FirstOrDefault<HeatingEnergySources>();
                }
            }
        }

        [XmlIgnore]
        public HeatingEnergySources EnergySource
        {
            get => 
                this.EnergySource_;
            set
            {
                if (value == null)
                {
                    this.EnergySource_ = HeatingEnergySources.Electric;
                }
                else
                {
                    this.EnergySource_ = value;
                }
            }
        }
    }
}

