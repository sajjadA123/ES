namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.WindowComponents
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using ca.nrcan.gc.OEE.HouseFileLibrary.Components;
    using ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources;
    using System;
    using System.Linq;
    using System.Xml.Serialization;

    [Serializable]
    public class Window : Component
    {
        [XmlAttribute("number")]
        public decimal Number = 1M;
        [XmlAttribute("er")]
        public decimal Er;
        [XmlAttribute("shgc")]
        public decimal Shgc;
        [XmlAttribute("frameHeight")]
        public decimal FrameHeight;
        [XmlAttribute("frameAreaFraction")]
        public decimal FrameAreaFraction;
        [XmlAttribute("edgeOfGlassFraction")]
        public decimal EdgeOfGlassFraction;
        [XmlAttribute("centreOfGlassFraction")]
        public decimal CentreOfGlassFraction;
        [XmlAttribute("adjacentEnclosedSpace")]
        public bool AdjacentEnclosedSpace;
        [XmlElement("Construction")]
        public WindowConstruction Construction = new WindowConstruction();
        [XmlElement("Measurements")]
        public WindowMeasurements Measurements = new WindowMeasurements();
        [XmlElement("Shading")]
        public WindowShading Shading = new WindowShading();
        private WindowDirections FacingDirection_ = WindowDirections.South;
        [XmlElement("EnergyStar")]
        public ca.nrcan.gc.OEE.HouseFileLibrary.Components.WindowComponents.EnergyStar EnergyStar;

        public Window()
        {
            base.Label = "Window";
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
                    this.FacingDirection = (from dt in WindowDirections.All
                        where dt.Code.ToString() == value.Code
                        select dt).FirstOrDefault<WindowDirections>();
                }
            }
        }

        [XmlIgnore]
        public WindowDirections FacingDirection
        {
            get => 
                this.FacingDirection_;
            set
            {
                if (value == null)
                {
                    this.FacingDirection_ = WindowDirections.South;
                }
                else
                {
                    this.FacingDirection_ = value;
                }
            }
        }
    }
}

