namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.Type2
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources;
    using System;
    using System.Linq;
    using System.Xml.Serialization;

    [Serializable, XmlInclude(typeof(HeatPumpEquipment)), XmlInclude(typeof(AirConditioningEquipment))]
    public abstract class Type2Equipment
    {
        [XmlAttribute("crankcaseHeater")]
        public decimal CrankcaseHeater = 60M;
        [XmlAttribute("numberOfHeads")]
        public int NumberOfHeads;
        private CentralEquipmentTypes Type_ = CentralEquipmentTypes.CentralSplitSystem;

        protected Type2Equipment()
        {
        }

        [XmlElement("Type")]
        public CodeAndText TypeXml
        {
            get => 
                (CodeAndText) this.Type;
            set
            {
                if (value == null)
                {
                    this.Type = null;
                }
                else
                {
                    this.Type = (from dt in CentralEquipmentTypes.All
                        where dt.Code.ToString() == value.Code
                        select dt).FirstOrDefault<CentralEquipmentTypes>();
                }
            }
        }

        [XmlIgnore]
        public CentralEquipmentTypes Type
        {
            get => 
                this.Type_;
            set => 
                this.Type_ = value;
        }
    }
}

