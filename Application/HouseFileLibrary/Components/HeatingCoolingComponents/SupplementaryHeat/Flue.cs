namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.SupplementaryHeat
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources;
    using System;
    using System.Linq;
    using System.Xml.Serialization;

    [Serializable]
    public class Flue
    {
        [XmlAttribute("isInterior")]
        public bool IsInterior;
        [XmlAttribute("diameter")]
        public decimal Diameter;
        [XmlAttribute("area")]
        public decimal Area;
        private FlueTypes Type_ = FlueTypes.Brick;

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
                    this.Type = (from dt in FlueTypes.All
                        where dt.Code.ToString() == value.Code
                        select dt).FirstOrDefault<FlueTypes>();
                }
            }
        }

        [XmlIgnore]
        public FlueTypes Type
        {
            get => 
                this.Type_;
            set
            {
                if (value == null)
                {
                    this.Type_ = FlueTypes.Brick;
                }
                else
                {
                    this.Type_ = value;
                }
            }
        }
    }
}

