namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.Type1
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources;
    using System;
    using System.Linq;
    using System.Xml.Serialization;

    [Serializable]
    public class BoilerEquipment : CommonEquipment
    {
        [XmlIgnore]
        public IBoilerTypes EquipmentType;

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
                else if (base.EnergySource == HeatingEnergySources.Electric)
                {
                    this.EquipmentType = (from t in ElectricBoilerTypes.All
                        where t.Code.ToString() == value.Code
                        select t).FirstOrDefault<ElectricBoilerTypes>();
                }
                else if ((base.EnergySource == HeatingEnergySources.NaturalGas) || (base.EnergySource == HeatingEnergySources.Propane))
                {
                    this.EquipmentType = (from t in GasPropaneBoilerTypes.All
                        where t.Code.ToString() == value.Code
                        select t).FirstOrDefault<GasPropaneBoilerTypes>();
                }
                else if (base.EnergySource == HeatingEnergySources.Oil)
                {
                    this.EquipmentType = (from t in OilBoilerTypes.All
                        where t.Code.ToString() == value.Code
                        select t).FirstOrDefault<OilBoilerTypes>();
                }
                else
                {
                    this.EquipmentType = (from t in WoodBoilerTypes.All
                        where t.Code.ToString() == value.Code
                        select t).FirstOrDefault<WoodBoilerTypes>();
                }
            }
        }
    }
}

