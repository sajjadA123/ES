namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.Type1
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources;
    using System;
    using System.Linq;
    using System.Xml.Serialization;

    [Serializable]
    public class FurnaceEquipment : CommonEquipment
    {
        [XmlIgnore]
        public IFurnaceTypes EquipmentType;

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
                    this.EquipmentType = (from t in ElectricFurnaceTypes.All
                        where t.Code.ToString() == value.Code
                        select t).FirstOrDefault<ElectricFurnaceTypes>();
                }
                else if ((base.EnergySource == HeatingEnergySources.NaturalGas) || (base.EnergySource == HeatingEnergySources.Propane))
                {
                    this.EquipmentType = (from t in GasPropaneFurnaceTypes.All
                        where t.Code.ToString() == value.Code
                        select t).FirstOrDefault<GasPropaneFurnaceTypes>();
                }
                else if (base.EnergySource == HeatingEnergySources.Oil)
                {
                    this.EquipmentType = (from t in OilFurnaceTypes.All
                        where t.Code.ToString() == value.Code
                        select t).FirstOrDefault<OilFurnaceTypes>();
                }
                else
                {
                    this.EquipmentType = (from t in WoodFurnaceTypes.All
                        where t.Code.ToString() == value.Code
                        select t).FirstOrDefault<WoodFurnaceTypes>();
                }
            }
        }
    }
}

