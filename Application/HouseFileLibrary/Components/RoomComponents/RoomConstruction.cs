namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.RoomComponents
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources;
    using System;
    using System.Linq;
    using System.Xml.Serialization;

    [Serializable]
    public class RoomConstruction
    {
        private RoomTypes Type_ = RoomTypes.Kitchen;
        private RoomFloors Floor_ = RoomFloors.GroundFloor;
        [XmlElement("FoundationBelow")]
        public CodeAndText FoundationBelow;

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
                    this.Type = (from dt in RoomTypes.All
                        where dt.Code.ToString() == value.Code
                        select dt).FirstOrDefault<RoomTypes>();
                }
            }
        }

        [XmlIgnore]
        public RoomTypes Type
        {
            get => 
                this.Type_;
            set
            {
                if (value == null)
                {
                    this.Type_ = RoomTypes.Kitchen;
                }
                else
                {
                    this.Type_ = value;
                }
            }
        }

        [XmlElement("Floor")]
        public CodeAndText FloorXml
        {
            get => 
                (CodeAndText) this.Floor;
            set
            {
                if (value == null)
                {
                    this.Floor = null;
                }
                else
                {
                    this.Floor = (from dt in RoomFloors.All
                        where dt.Code.ToString() == value.Code
                        select dt).FirstOrDefault<RoomFloors>();
                }
            }
        }

        [XmlIgnore]
        public RoomFloors Floor
        {
            get => 
                this.Floor_;
            set
            {
                if (value == null)
                {
                    this.Floor_ = RoomFloors.GroundFloor;
                }
                else
                {
                    this.Floor_ = value;
                }
            }
        }
    }
}

