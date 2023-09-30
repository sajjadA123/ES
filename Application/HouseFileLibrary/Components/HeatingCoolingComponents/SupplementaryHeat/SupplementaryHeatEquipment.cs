namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.SupplementaryHeat
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources;
    using System;
    using System.Linq;
    using System.Xml.Serialization;

    [Serializable]
    public class SupplementaryHeatEquipment
    {
        private SupplementaryEnergySources EnergySource_ = SupplementaryEnergySources.NaturalGas;
        [XmlIgnore]
        public ISupplementaryHeatingTypes Type;

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
                    this.EnergySource = (from dt in SupplementaryEnergySources.All
                        where dt.Code.ToString() == value.Code
                        select dt).FirstOrDefault<SupplementaryEnergySources>();
                }
            }
        }

        [XmlIgnore]
        public SupplementaryEnergySources EnergySource
        {
            get => 
                this.EnergySource_;
            set
            {
                if (value == null)
                {
                    this.EnergySource_ = SupplementaryEnergySources.NaturalGas;
                }
                else
                {
                    this.EnergySource_ = value;
                }
            }
        }

        [XmlElement("Type")]
        public CodeAndText TypeXml
        {
            get => 
                this.Type?.ToCodeAndText();
            set
            {
                if (value == null)
                {
                    this.Type = null;
                }
                else if (this.EnergySource == SupplementaryEnergySources.Electric)
                {
                    this.Type = (from t in ElectricSupplementaryHeatingTypes.All
                        where t.Code.ToString() == value.Code
                        select t).FirstOrDefault<ElectricSupplementaryHeatingTypes>();
                }
                else if ((this.EnergySource == SupplementaryEnergySources.NaturalGas) || (this.EnergySource == SupplementaryEnergySources.Propane))
                {
                    this.Type = (from t in GasPropaneSupplementaryHeatingTypes.All
                        where t.Code.ToString() == value.Code
                        select t).FirstOrDefault<GasPropaneSupplementaryHeatingTypes>();
                }
                else if (this.EnergySource == SupplementaryEnergySources.Oil)
                {
                    this.Type = (from t in OilSupplementaryHeatingTypes.All
                        where t.Code.ToString() == value.Code
                        select t).FirstOrDefault<OilSupplementaryHeatingTypes>();
                }
                else
                {
                    this.Type = (from t in WoodSupplementaryHeatingTypes.All
                        where t.Code.ToString() == value.Code
                        select t).FirstOrDefault<WoodSupplementaryHeatingTypes>();
                }
            }
        }
    }
}

