namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.WindowComponents
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources;
    using System;
    using System.Linq;
    using System.Xml.Serialization;

    [Serializable]
    public class WindowMeasurements
    {
        [XmlAttribute("height")]
        public decimal Height = 500M;
        [XmlAttribute("width")]
        public decimal Width = 500M;
        [XmlAttribute("headerHeight")]
        public decimal HeaderHeight;
        [XmlAttribute("overhangWidth")]
        public decimal OverhangWidth;
        private WindowTilts Tilt_ = WindowTilts.Vertical;

        [XmlElement("Tilt")]
        public CodeTextAndValue TiltXml
        {
            get => 
                (CodeTextAndValue) this.Tilt;
            set
            {
                if (value == null)
                {
                    this.Tilt = null;
                }
                else
                {
                    this.Tilt = (from dt in WindowTilts.All
                        where dt.Code.ToString() == value.Code
                        select dt).FirstOrDefault<WindowTilts>();
                    if (this.Tilt.IsUserSpecified)
                    {
                        this.Tilt.Value = value.Value;
                    }
                }
            }
        }

        [XmlIgnore]
        public WindowTilts Tilt
        {
            get => 
                this.Tilt_;
            set
            {
                if (value == null)
                {
                    this.Tilt_ = WindowTilts.Vertical;
                }
                else if ((value == null) || !value.IsUserSpecified)
                {
                    this.Tilt_ = value;
                }
                else
                {
                    this.Tilt_ = (from us in WindowTilts.All
                        where us.Code == value.Code
                        select us).FirstOrDefault<WindowTilts>();
                    this.Tilt_.Value = value.Value;
                }
            }
        }

        [XmlIgnore]
        public decimal Area
        {
            get => 
                this.Width * this.Height;
            set
            {
            }
        }
    }
}

