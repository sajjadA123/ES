namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.FloorHeaderComponents
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using ca.nrcan.gc.OEE.HouseFileLibrary.Components;
    using ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources;
    using System;
    using System.Linq;
    using System.Xml.Serialization;

    [Serializable]
    public class FloorHeader : Component
    {
        [XmlAttribute("adjacentEnclosedSpace")]
        public bool AdjacentEnclosedSpace;
        [XmlElement("Construction")]
        public FloorHeaderConstruction Construction;
        [XmlElement("Measurements")]
        public FloorHeaderMeasurements Measurements;
        private FloorHeaderDirections FacingDirection_;

        public FloorHeader()
        {
            this.Construction = new FloorHeaderConstruction();
            this.Measurements = new FloorHeaderMeasurements();
            this.FacingDirection_ = FloorHeaderDirections.NotApplicable;
            this.SetDefaults();
        }

        public FloorHeader(FloorHeader toCopy)
        {
            this.Construction = new FloorHeaderConstruction();
            this.Measurements = new FloorHeaderMeasurements();
            this.FacingDirection_ = FloorHeaderDirections.NotApplicable;
            base.Label = toCopy.Label;
            this.AdjacentEnclosedSpace = toCopy.AdjacentEnclosedSpace;
            this.FacingDirection = toCopy.FacingDirection;
            this.Construction.Type = new CodeReference(toCopy.Construction.Type);
            this.Measurements.Height = toCopy.Measurements.Height;
            this.Measurements.Perimeter = toCopy.Measurements.Perimeter;
        }

        public void SetDefaults()
        {
            base.Label = "Floor Header";
            this.AdjacentEnclosedSpace = false;
            this.FacingDirection = FloorHeaderDirections.NotApplicable;
            this.Construction.Type = new CodeReference("1", "User specified", 0.1M, 0M);
            this.Measurements.Height = 0.25M;
            this.Measurements.Perimeter = 10M;
        }

        [XmlElement("FacingDirection")]
        public CodeAndText FacingDirectionXml
        {
            get => 
                (CodeAndText) this.FacingDirection;
            set
            {
                if (value == null)
                {
                    this.FacingDirection = null;
                }
                else
                {
                    this.FacingDirection = (from dt in FloorHeaderDirections.All
                        where dt.Code.ToString() == value.Code
                        select dt).FirstOrDefault<FloorHeaderDirections>();
                }
            }
        }

        [XmlIgnore]
        public FloorHeaderDirections FacingDirection
        {
            get => 
                this.FacingDirection_;
            set
            {
                if (value == null)
                {
                    this.FacingDirection_ = FloorHeaderDirections.NotApplicable;
                }
                else
                {
                    this.FacingDirection_ = value;
                }
            }
        }
    }
}

