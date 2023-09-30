namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.HotWaterComponents
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using ca.nrcan.gc.OEE.HouseFileLibrary.Components;
    using ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources;
    using System;
    using System.Linq;
    using System.Xml.Serialization;

    [Serializable]
    public class HotWaterComponent
    {
        [XmlAttribute("hasDrainWaterHeatRecovery")]
        public bool HasDrainWaterHeatRecovery;
        [XmlAttribute("insulatingBlanket")]
        public decimal InsulatingBlanket;
        [XmlAttribute("pilotEnergy")]
        public decimal PilotEnergy;
        [XmlAttribute("heatPumpCoefficient")]
        public decimal HeatPumpCoefficient;
        [XmlAttribute("combinedFlue")]
        public bool CombinedFlue;
        [XmlAttribute("flueDiameter")]
        public decimal FlueDiameter;
        [XmlAttribute("energyStar")]
        public bool EnergyStar;
        [XmlAttribute("ecoEnergy")]
        public bool EcoEnergy;
        [XmlAttribute("userDefinedPilot")]
        public bool UserDefinedPilot;
        [XmlAttribute("fraction")]
        public decimal Fraction;
        [XmlAttribute("connectedUnitsDwhr")]
        public byte ConnectedUnitsDwhr;
        [XmlElement("EquipmentInformation")]
        public ca.nrcan.gc.OEE.HouseFileLibrary.Components.EquipmentInformation EquipmentInformation = new ca.nrcan.gc.OEE.HouseFileLibrary.Components.EquipmentInformation();
        private DhwEnergySources EnergySource_ = DhwEnergySources.NotApplicable;
        [XmlIgnore]
        public IDhwTankType TankType;
        private DhwTankVolumes TankVolume_ = DhwTankVolumes.NotApplicable;
        [XmlElement("EnergyFactor")]
        public ca.nrcan.gc.OEE.HouseFileLibrary.Components.HotWaterComponents.EnergyFactor EnergyFactor = new ca.nrcan.gc.OEE.HouseFileLibrary.Components.HotWaterComponents.EnergyFactor();
        private DhwDrawPatterns DrawPattern_;
        private DhwTankLocations TankLocation_ = DhwTankLocations.MainFloor;
        [XmlElement("Solar")]
        public ca.nrcan.gc.OEE.HouseFileLibrary.Components.HotWaterComponents.Solar Solar;
        [XmlElement("DrainWaterHeatRecovery")]
        public ca.nrcan.gc.OEE.HouseFileLibrary.Components.HotWaterComponents.DrainWaterHeatRecovery DrainWaterHeatRecovery;

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
                    this.EnergySource = (from dt in DhwEnergySources.All
                        where dt.Code.ToString() == value.Code
                        select dt).FirstOrDefault<DhwEnergySources>();
                }
            }
        }

        [XmlIgnore]
        public DhwEnergySources EnergySource
        {
            get => 
                this.EnergySource_;
            set
            {
                if (value == null)
                {
                    this.EnergySource_ = DhwEnergySources.NotApplicable;
                }
                else
                {
                    this.EnergySource_ = value;
                }
            }
        }

        [XmlElement("TankType")]
        public CodeAndText TankTypeXml
        {
            get => 
                this.TankType?.ToCodeAndText();
            set
            {
                if (value == null)
                {
                    this.TankType = null;
                }
                else if ((this.EnergySource == DhwEnergySources.NaturalGas) || (this.EnergySource == DhwEnergySources.Propane))
                {
                    this.TankType = (from t in DhwTankTypeGasPropane.All
                        where t.Code.ToString() == value.Code
                        select t).FirstOrDefault<DhwTankTypeGasPropane>();
                }
                else if (this.EnergySource == DhwEnergySources.Oil)
                {
                    this.TankType = (from t in DhwTankTypeOil.All
                        where t.Code.ToString() == value.Code
                        select t).FirstOrDefault<DhwTankTypeOil>();
                }
                else if ((this.EnergySource == DhwEnergySources.MixedWood) || ((this.EnergySource == DhwEnergySources.Hardwood) || ((this.EnergySource == DhwEnergySources.Softwood) || (this.EnergySource == DhwEnergySources.WoodPellets))))
                {
                    this.TankType = (from t in DhwTankTypeWood.All
                        where t.Code.ToString() == value.Code
                        select t).FirstOrDefault<DhwTankTypeWood>();
                }
                else if (this.EnergySource == DhwEnergySources.Solar)
                {
                    this.TankType = (from t in DhwTankTypeSolar.All
                        where t.Code.ToString() == value.Code
                        select t).FirstOrDefault<DhwTankTypeSolar>();
                }
                else
                {
                    this.TankType = (from t in DhwTankTypeElectric.All
                        where t.Code.ToString() == value.Code
                        select t).FirstOrDefault<DhwTankTypeElectric>();
                }
            }
        }

        [XmlElement("TankVolume")]
        public CodeTextAndValue TankVolumeXml
        {
            get => 
                (CodeTextAndValue) this.TankVolume;
            set
            {
                if (value == null)
                {
                    this.TankVolume = null;
                }
                else
                {
                    this.TankVolume = (from dt in DhwTankVolumes.All
                        where dt.Code.ToString() == value.Code
                        select dt).FirstOrDefault<DhwTankVolumes>();
                    if (this.TankVolume.IsUserSpecified)
                    {
                        this.TankVolume.Value = value.Value;
                    }
                }
            }
        }

        [XmlIgnore]
        public DhwTankVolumes TankVolume
        {
            get => 
                this.TankVolume_;
            set
            {
                if (value == null)
                {
                    this.TankVolume_ = DhwTankVolumes.NotApplicable;
                }
                else if ((value == null) || !value.IsUserSpecified)
                {
                    this.TankVolume_ = value;
                }
                else
                {
                    this.TankVolume_ = (from us in DhwTankVolumes.All
                        where us.Code == value.Code
                        select us).FirstOrDefault<DhwTankVolumes>();
                    this.TankVolume_.Value = value.Value;
                }
            }
        }

        [XmlElement("DrawPattern")]
        public CodeAndText DrawPatternXml
        {
            get => 
                (CodeAndText) this.DrawPattern;
            set
            {
                if ((value != null) && this.EnergyFactor.isUniform)
                {
                    this.DrawPattern = (from dt in DhwDrawPatterns.All
                        where dt.Code.ToString() == value.Code
                        select dt).FirstOrDefault<DhwDrawPatterns>();
                }
                else
                {
                    this.DrawPattern = null;
                }
            }
        }

        [XmlIgnore]
        public DhwDrawPatterns DrawPattern
        {
            get => 
                this.DrawPattern_;
            set
            {
                if ((value == null) && this.EnergyFactor.isUniform)
                {
                    this.DrawPattern_ = DhwDrawPatterns.VerySmall;
                }
                else
                {
                    this.DrawPattern_ = value;
                }
            }
        }

        [XmlElement("TankLocation")]
        public CodeAndText TankLocationXml
        {
            get => 
                (CodeAndText) this.TankLocation;
            set
            {
                if (value == null)
                {
                    this.TankLocation = null;
                }
                else
                {
                    this.TankLocation = (from dt in DhwTankLocations.All
                        where dt.Code.ToString() == value.Code
                        select dt).FirstOrDefault<DhwTankLocations>();
                }
            }
        }

        [XmlIgnore]
        public DhwTankLocations TankLocation
        {
            get => 
                this.TankLocation_;
            set
            {
                if (value == null)
                {
                    this.TankLocation_ = DhwTankLocations.MainFloor;
                }
                else
                {
                    this.TankLocation_ = value;
                }
            }
        }

        public bool HasWoodEnergySource =>
            (this.EnergySource == DhwEnergySources.MixedWood) || ((this.EnergySource == DhwEnergySources.Hardwood) || ((this.EnergySource == DhwEnergySources.Softwood) || (this.EnergySource == DhwEnergySources.WoodPellets)));
    }
}

