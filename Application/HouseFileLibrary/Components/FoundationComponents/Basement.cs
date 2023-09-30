namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.FoundationComponents
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources;
    using ca.nrcan.gc.OEE.HouseFileLibrary.HouseFileEvents;
    using System;
    using System.Linq;
    using System.Xml.Serialization;

    [Serializable]
    public class Basement : Foundation, ISerializationEvents
    {
        private OpeningsUpstairs OpeningUpstairs_ = OpeningsUpstairs.StandardDoorOpen;
        private RoomTypes RoomType_ = RoomTypes.UtilityRoom;
        [XmlElement("Floor")]
        public FoundationFloor Floor = new FoundationFloor();
        [XmlElement("Wall")]
        public FoundationWall Wall = new FoundationWall();

        public Basement()
        {
            this.SetDefaults();
        }

        public void OnDeserialization()
        {
            this.Wall.OnDeserialization();
        }

        public void OnPostSerialization()
        {
        }

        public void OnPreSerialization()
        {
            this.Wall.OnPreSerialization();
        }

        public void SetDefaults()
        {
            base.Label = "Basement";
            this.Wall.Measurements = new FoundationWallMeasurements();
        }

        [XmlElement("OpeningUpstairs")]
        public CodeTextAndValue OpeningUpstairsXml
        {
            get => 
                (CodeTextAndValue) this.OpeningUpstairs;
            set
            {
                if (value == null)
                {
                    this.OpeningUpstairs = null;
                }
                else
                {
                    this.OpeningUpstairs = (from dt in OpeningsUpstairs.All
                        where dt.Code.ToString() == value.Code
                        select dt).FirstOrDefault<OpeningsUpstairs>();
                    if (this.OpeningUpstairs.IsUserSpecified)
                    {
                        this.OpeningUpstairs.Value = value.Value;
                    }
                }
            }
        }

        [XmlIgnore]
        public OpeningsUpstairs OpeningUpstairs
        {
            get => 
                this.OpeningUpstairs_;
            set
            {
                if (value == null)
                {
                    this.OpeningUpstairs_ = OpeningsUpstairs.StandardDoorOpen;
                }
                else if ((value == null) || !value.IsUserSpecified)
                {
                    this.OpeningUpstairs_ = value;
                }
                else
                {
                    this.OpeningUpstairs_ = (from us in OpeningsUpstairs.All
                        where us.Code == value.Code
                        select us).FirstOrDefault<OpeningsUpstairs>();
                    this.OpeningUpstairs_.Value = value.Value;
                }
            }
        }

        [XmlElement("RoomType")]
        public CodeAndText RoomTypeXml
        {
            get => 
                (CodeAndText) this.RoomType;
            set
            {
                if (value == null)
                {
                    this.RoomType = null;
                }
                else
                {
                    this.RoomType = (from dt in RoomTypes.All
                        where dt.Code.ToString() == value.Code
                        select dt).FirstOrDefault<RoomTypes>();
                }
            }
        }

        [XmlIgnore]
        public RoomTypes RoomType
        {
            get => 
                this.RoomType_;
            set
            {
                if (value == null)
                {
                    this.RoomType_ = RoomTypes.UtilityRoom;
                }
                else
                {
                    this.RoomType_ = value;
                }
            }
        }
    }
}

