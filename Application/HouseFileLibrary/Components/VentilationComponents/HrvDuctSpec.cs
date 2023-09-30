namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.VentilationComponents
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources;
    using System;
    using System.Linq;
    using System.Xml.Serialization;

    [Serializable]
    public class HrvDuctSpec
    {
        private DuctLocations Location_ = DuctLocations.MainFloor;
        private DuctTypes Type_ = DuctTypes.Flexible;
        private DuctSealingCharacteristics Sealing_ = DuctSealingCharacteristics.Sealed;
        [XmlAttribute("length")]
        public decimal Length;
        [XmlAttribute("diameter")]
        public decimal Diameter;
        [XmlAttribute("insulation")]
        public decimal Insulation;

        [XmlElement("Location")]
        public CodeAndText LocationXml
        {
            get => 
                (CodeAndText) this.Location;
            set
            {
                if (value == null)
                {
                    this.Location = null;
                }
                else
                {
                    this.Location = (from dt in DuctLocations.All
                        where dt.Code.ToString() == value.Code
                        select dt).FirstOrDefault<DuctLocations>();
                }
            }
        }

        [XmlIgnore]
        public DuctLocations Location
        {
            get => 
                this.Location_;
            set
            {
                if (value == null)
                {
                    this.Location_ = DuctLocations.MainFloor;
                }
                else
                {
                    this.Location_ = value;
                }
            }
        }

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
                    this.Type = (from dt in DuctTypes.All
                        where dt.Code.ToString() == value.Code
                        select dt).FirstOrDefault<DuctTypes>();
                }
            }
        }

        [XmlIgnore]
        public DuctTypes Type
        {
            get => 
                this.Type_;
            set
            {
                if (value == null)
                {
                    this.Type_ = DuctTypes.Flexible;
                }
                else
                {
                    this.Type_ = value;
                }
            }
        }

        [XmlElement("Sealing")]
        public CodeAndText SealingXml
        {
            get => 
                (CodeAndText) this.Sealing;
            set
            {
                if (value == null)
                {
                    this.Sealing = null;
                }
                else
                {
                    this.Sealing = (from dt in DuctSealingCharacteristics.All
                        where dt.Code.ToString() == value.Code
                        select dt).FirstOrDefault<DuctSealingCharacteristics>();
                }
            }
        }

        [XmlIgnore]
        public DuctSealingCharacteristics Sealing
        {
            get => 
                this.Sealing_;
            set
            {
                if (value == null)
                {
                    this.Sealing_ = DuctSealingCharacteristics.Sealed;
                }
                else
                {
                    this.Sealing_ = value;
                }
            }
        }
    }
}

