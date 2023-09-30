namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.VentilationComponents
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources;
    using System;
    using System.Linq;
    using System.Xml.Serialization;

    [Serializable]
    public class Requirements
    {
        [XmlAttribute("ach")]
        public decimal Ach;
        [XmlAttribute("supply")]
        public decimal Supply;
        [XmlAttribute("exhaust")]
        public decimal Exhaust;
        private VentilationUses Use_ = VentilationUses.NotApplicable;

        [XmlElement("Use")]
        public CodeAndText UseXml
        {
            get => 
                (CodeAndText) this.Use;
            set
            {
                if (value == null)
                {
                    this.Use = null;
                }
                else
                {
                    this.Use = (from dt in VentilationUses.All
                        where dt.Code.ToString() == value.Code
                        select dt).FirstOrDefault<VentilationUses>();
                }
            }
        }

        [XmlIgnore]
        public VentilationUses Use
        {
            get => 
                this.Use_;
            set
            {
                if (value == null)
                {
                    this.Use_ = VentilationUses.NotApplicable;
                }
                else
                {
                    this.Use_ = value;
                }
            }
        }
    }
}

