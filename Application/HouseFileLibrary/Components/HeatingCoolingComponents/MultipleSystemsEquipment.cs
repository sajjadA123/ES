namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources;
    using System;
    using System.Linq;
    using System.Xml.Serialization;

    [Serializable]
    public class MultipleSystemsEquipment
    {
        [XmlAttribute("rank")]
        public ushort Rank;
        [XmlAttribute("efficiency")]
        public decimal Efficiency;
        [XmlAttribute("flueDiameter")]
        public decimal FlueDiameter;
        [XmlAttribute("heatingCapacitykW")]
        public decimal HeatingCapacitykW;
        [XmlAttribute("heatingCapacityUiUnits")]
        public string HeatingCapacityUiUnits = "kW";
        [XmlAttribute("pilotLight")]
        public bool PilotLight;
        [XmlAttribute("energyStar")]
        public bool EnergyStar;
        [XmlAttribute("energyEfficientMotor")]
        public bool EnergyEfficientMotor;
        [XmlAttribute("identicalSystems")]
        public ushort IdenticalSystems;
        private MultipleSystemsEnergySources EnergySource_ = MultipleSystemsEnergySources.Electric;
        [XmlIgnore]
        public IMultipleSystemsEquipmentTypes EquipmentType;
        [XmlElement("Manufacturer")]
        public string Manufacturer;
        [XmlElement("Model")]
        public string Model;
        private MultipleSystemsEfficiencyTypes EfficiencyType_ = MultipleSystemsEfficiencyTypes.Percent;

        [XmlIgnore]
        public decimal HeatingCapacityInUiUnits
        {
            get => 
                (this.HeatingCapacityUiUnits.ToLowerInvariant() != "btu/hr") ? this.HeatingCapacitykW : Conversions.ConvertUnits(eConversionType.UNIT_KW_2_BTUHR, eUnitType.M_2_I, this.HeatingCapacitykW);
            set
            {
                if (this.HeatingCapacityUiUnits.ToLowerInvariant() == "btu/hr")
                {
                    this.HeatingCapacitykW = Conversions.ConvertUnits(eConversionType.UNIT_KW_2_BTUHR, eUnitType.I_2_M, value);
                }
                else
                {
                    this.HeatingCapacitykW = value;
                }
            }
        }

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
                    this.EnergySource = (from dt in MultipleSystemsEnergySources.All
                        where dt.Code.ToString() == value.Code
                        select dt).FirstOrDefault<MultipleSystemsEnergySources>();
                }
            }
        }

        [XmlIgnore]
        public MultipleSystemsEnergySources EnergySource
        {
            get => 
                this.EnergySource_;
            set
            {
                if (value == null)
                {
                    this.EnergySource_ = MultipleSystemsEnergySources.Electric;
                }
                else
                {
                    this.EnergySource_ = value;
                }
            }
        }

        [XmlElement("EquipmentType")]
        public CodeAndText EquipmentTypeXml
        {
            get => 
                this.EquipmentType?.ToCodeAndText();
            set
            {
                if (value == null)
                {
                    this.EquipmentType = null;
                }
                else if ((this.EnergySource == null) || (this.EnergySource == MultipleSystemsEnergySources.Electric))
                {
                    this.EquipmentType = (from t in MultipleSystemsElectricity.All
                        where t.Code.ToString() == value.Code
                        select t).FirstOrDefault<MultipleSystemsElectricity>();
                }
                else if ((this.EnergySource == MultipleSystemsEnergySources.NaturalGas) || (this.EnergySource == MultipleSystemsEnergySources.Propane))
                {
                    this.EquipmentType = (from t in MultipleSystemsGasPropane.All
                        where t.Code.ToString() == value.Code
                        select t).FirstOrDefault<MultipleSystemsGasPropane>();
                }
                else if (this.EnergySource == MultipleSystemsEnergySources.Oil)
                {
                    this.EquipmentType = (from t in MultipleSystemsOil.All
                        where t.Code.ToString() == value.Code
                        select t).FirstOrDefault<MultipleSystemsOil>();
                }
                else
                {
                    this.EquipmentType = (from t in MultipleSystemsWood.All
                        where t.Code.ToString() == value.Code
                        select t).FirstOrDefault<MultipleSystemsWood>();
                }
            }
        }

        [XmlElement("EfficiencyType")]
        public CodeAndText EfficiencyTypeXml
        {
            get => 
                (CodeAndText) this.EfficiencyType;
            set
            {
                if (value == null)
                {
                    this.EfficiencyType = null;
                }
                else
                {
                    this.EfficiencyType = (from dt in MultipleSystemsEfficiencyTypes.All
                        where dt.Code.ToString() == value.Code
                        select dt).FirstOrDefault<MultipleSystemsEfficiencyTypes>();
                }
            }
        }

        [XmlIgnore]
        public MultipleSystemsEfficiencyTypes EfficiencyType
        {
            get => 
                this.EfficiencyType_;
            set
            {
                if (value == null)
                {
                    this.EfficiencyType_ = MultipleSystemsEfficiencyTypes.Percent;
                }
                else
                {
                    this.EfficiencyType_ = value;
                }
            }
        }
    }
}

