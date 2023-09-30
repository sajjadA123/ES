namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.Type1
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources;
    using System;
    using System.Linq;
    using System.Xml.Serialization;

    [Serializable]
    public class ComboHeatDhwEquipment : CommonEquipment
    {
        [XmlIgnore]
        public IComboHeatDhwTypes EquipmentType;

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
                else if ((base.EnergySource == HeatingEnergySources.NaturalGas) || (base.EnergySource == HeatingEnergySources.Propane))
                {
                    this.EquipmentType = (from t in GasPropaneComboHeatDhwTypes.All
                        where t.Code.ToString() == value.Code
                        select t).FirstOrDefault<GasPropaneComboHeatDhwTypes>();
                }
                else if (base.EnergySource == HeatingEnergySources.Oil)
                {
                    this.EquipmentType = (from t in OilComboHeatDhwTypes.All
                        where t.Code.ToString() == value.Code
                        select t).FirstOrDefault<OilComboHeatDhwTypes>();
                }
                else
                {
                    this.EquipmentType = null;
                }
            }
        }
    }
}

