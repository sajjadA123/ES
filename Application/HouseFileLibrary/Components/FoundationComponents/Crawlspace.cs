namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.FoundationComponents
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources;
    using ca.nrcan.gc.OEE.HouseFileLibrary.HouseFileEvents;
    using System;
    using System.Linq;
    using System.Xml.Serialization;

    [Serializable]
    public class Crawlspace : Foundation, ISerializationEvents
    {
        private VentilationTypes VentilationType_ = VentilationTypes.Closed;
        [XmlElement("Floor")]
        public FoundationFloor Floor = new FoundationFloor();
        [XmlElement("Wall")]
        public CrawlspaceWall Wall = new CrawlspaceWall();

        public Crawlspace()
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
        }

        public void SetDefaults()
        {
            base.Label = "Crawlspace";
        }

        [XmlElement("VentilationType")]
        public CodeAndText VentilationTypeXml
        {
            get => 
                (CodeAndText) this.VentilationType;
            set
            {
                if (value == null)
                {
                    this.VentilationType = null;
                }
                else
                {
                    this.VentilationType = (from dt in VentilationTypes.All
                        where dt.Code.ToString() == value.Code
                        select dt).FirstOrDefault<VentilationTypes>();
                }
            }
        }

        [XmlIgnore]
        public VentilationTypes VentilationType
        {
            get => 
                this.VentilationType_;
            set
            {
                if (value == null)
                {
                    this.VentilationType_ = VentilationTypes.Closed;
                }
                else
                {
                    this.VentilationType_ = value;
                }
            }
        }
    }
}

