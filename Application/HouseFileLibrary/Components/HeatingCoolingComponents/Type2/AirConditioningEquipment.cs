namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.Type2
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources;
    using System;
    using System.Linq;
    using System.Xml.Serialization;

    [Serializable]
    public class AirConditioningEquipment : Type2Equipment
    {
        private CentralEquipmentTypes CentralType_ = CentralEquipmentTypes.CentralSplitSystem;
        [XmlElement("WindowUnits")]
        public ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.Type2.WindowUnits WindowUnits;

        [XmlElement("CentralType")]
        public CodeAndText CentralTypeXml
        {
            get => 
                (CodeAndText) this.CentralType;
            set
            {
                if (value == null)
                {
                    this.CentralType = null;
                }
                else
                {
                    this.CentralType = (from dt in CentralEquipmentTypes.All
                        where dt.Code.ToString() == value.Code
                        select dt).FirstOrDefault<CentralEquipmentTypes>();
                }
            }
        }

        [XmlIgnore]
        public CentralEquipmentTypes CentralType
        {
            get => 
                this.CentralType_;
            set => 
                this.CentralType_ = value;
        }
    }
}

