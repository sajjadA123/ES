namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.WallComponents
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using ca.nrcan.gc.OEE.HouseFileLibrary.Components;
    using ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources;
    using System;
    using System.Linq;
    using System.Xml.Serialization;

    [Serializable]
    public class Wall : Component
    {
        [XmlAttribute("adjacentEnclosedSpace")]
        public bool AdjacentEnclosedSpace;
        [XmlElement("Construction")]
        public WallConstruction Construction;
        [XmlElement("Measurements")]
        public WallMeasurements Measurements;
        private WallDirections FacingDirection_;

        public Wall()
        {
            this.Construction = new WallConstruction();
            this.Measurements = new WallMeasurements();
            this.FacingDirection_ = WallDirections.NotApplicable;
            this.SetDefaults();
        }

        public Wall(Wall toCopy)
        {
            this.Construction = new WallConstruction();
            this.Measurements = new WallMeasurements();
            this.FacingDirection_ = WallDirections.NotApplicable;
            base.Id = toCopy.Id;
            base.Label = toCopy.Label;
            this.AdjacentEnclosedSpace = toCopy.AdjacentEnclosedSpace;
            this.Construction = new WallConstruction(toCopy.Construction);
            this.Measurements = new WallMeasurements(toCopy.Measurements);
            this.FacingDirection = toCopy.FacingDirection;
        }

        public void SetDefaults()
        {
            base.Label = "Wall";
            this.Construction.Type.Code = "1200000000";
            this.Construction.Type.Text = this.Construction.Type.Code;
            this.Construction.Type.RValue = 0.35M;
            this.Measurements.Height = 2.46M;
            this.Measurements.Perimeter = 10M;
            this.FacingDirection = WallDirections.NotApplicable;
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
                    this.FacingDirection = (from dt in WallDirections.All
                        where dt.Code.ToString() == value.Code
                        select dt).FirstOrDefault<WallDirections>();
                }
            }
        }

        [XmlIgnore]
        public WallDirections FacingDirection
        {
            get => 
                this.FacingDirection_;
            set
            {
                if (value == null)
                {
                    this.FacingDirection_ = WallDirections.NotApplicable;
                }
                else
                {
                    this.FacingDirection_ = value;
                }
            }
        }
    }
}

