namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.NaturalAirInfiltrationComponents
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources;
    using System;
    using System.Linq;
    using System.Xml.Serialization;

    [Serializable]
    public class LocalShielding
    {
        private LocalShieldings Walls_ = LocalShieldings.Heavy;
        private LocalShieldings Flue_ = LocalShieldings.Light;

        [XmlElement("Walls")]
        public CodeAndText WallsXml
        {
            get => 
                (CodeAndText) this.Walls;
            set
            {
                if (value == null)
                {
                    this.Walls = null;
                }
                else
                {
                    this.Walls = (from dt in LocalShieldings.All
                        where dt.Code.ToString() == value.Code
                        select dt).FirstOrDefault<LocalShieldings>();
                }
            }
        }

        [XmlIgnore]
        public LocalShieldings Walls
        {
            get => 
                this.Walls_;
            set
            {
                if (value == null)
                {
                    this.Walls_ = LocalShieldings.Heavy;
                }
                else
                {
                    this.Walls_ = value;
                }
            }
        }

        [XmlElement("Flue")]
        public CodeAndText FlueXml
        {
            get => 
                (CodeAndText) this.Flue;
            set
            {
                if (value == null)
                {
                    this.Flue = null;
                }
                else
                {
                    this.Flue = (from dt in LocalShieldings.All
                        where dt.Code.ToString() == value.Code
                        select dt).FirstOrDefault<LocalShieldings>();
                }
            }
        }

        [XmlIgnore]
        public LocalShieldings Flue
        {
            get => 
                this.Flue_;
            set
            {
                if (value == null)
                {
                    this.Flue_ = LocalShieldings.Light;
                }
                else
                {
                    this.Flue_ = value;
                }
            }
        }
    }
}

