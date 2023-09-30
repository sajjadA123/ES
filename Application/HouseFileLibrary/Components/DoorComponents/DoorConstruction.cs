namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.DoorComponents
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources;
    using System;
    using System.Linq;
    using System.Xml.Serialization;

    [Serializable]
    public class DoorConstruction
    {
        [XmlAttribute("energyStar")]
        public bool EnergyStar;
        private DoorTypes Type_;

        public DoorConstruction()
        {
            this.Type_ = DoorTypes.WoodHollowCore;
        }

        public DoorConstruction(DoorConstruction toCopy)
        {
            this.Type_ = DoorTypes.WoodHollowCore;
            this.EnergyStar = toCopy.EnergyStar;
            this.Type = toCopy.Type;
        }

        [XmlElement("Type")]
        public CodeTextAndValue TypeXml
        {
            get => 
                (CodeTextAndValue) this.Type;
            set
            {
                if (value == null)
                {
                    this.Type = null;
                }
                else
                {
                    this.Type = (from dt in DoorTypes.All
                        where dt.Code.ToString() == value.Code
                        select dt).FirstOrDefault<DoorTypes>();
                    if (this.Type.IsUserSpecified)
                    {
                        this.Type.Value = value.Value;
                    }
                }
            }
        }

        [XmlIgnore]
        public DoorTypes Type
        {
            get => 
                this.Type_;
            set
            {
                if (value == null)
                {
                    this.Type_ = DoorTypes.WoodHollowCore;
                }
                else
                {
                    this.Type_ = value;
                }
            }
        }
    }
}

