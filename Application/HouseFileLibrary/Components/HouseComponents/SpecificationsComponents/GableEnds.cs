namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.HouseComponents.SpecificationsComponents
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources;
    using System;
    using System.Linq;
    using System.Xml.Serialization;

    [Serializable]
    public class GableEnds
    {
        [XmlAttribute("area")]
        public decimal area;
        private SheathingMaterials SheatingMaterial_;
        private ExteriorMaterials ExteriorMaterial_;

        public GableEnds()
        {
            this.SheatingMaterial_ = SheathingMaterials.PlywoodPartBd9_5Mm;
            this.ExteriorMaterial_ = ExteriorMaterials.HollowMetalVinylCladding;
        }

        public GableEnds(GableEnds toCopy)
        {
            this.SheatingMaterial_ = SheathingMaterials.PlywoodPartBd9_5Mm;
            this.ExteriorMaterial_ = ExteriorMaterials.HollowMetalVinylCladding;
            this.area = toCopy.area;
            this.SheatingMaterial = toCopy.SheatingMaterial;
            this.ExteriorMaterial = toCopy.ExteriorMaterial;
        }

        [XmlElement("SheatingMaterial")]
        public CodeTextAndValue SheatingMaterialXml
        {
            get => 
                (CodeTextAndValue) this.SheatingMaterial;
            set
            {
                if (value == null)
                {
                    this.SheatingMaterial = null;
                }
                else
                {
                    this.SheatingMaterial = (from dt in SheathingMaterials.All
                        where dt.Code.ToString() == value.Code
                        select dt).FirstOrDefault<SheathingMaterials>();
                    if (this.SheatingMaterial.IsUserSpecified)
                    {
                        this.SheatingMaterial.Value = value.Value;
                    }
                }
            }
        }

        [XmlIgnore]
        public SheathingMaterials SheatingMaterial
        {
            get => 
                this.SheatingMaterial_;
            set
            {
                if (value == null)
                {
                    this.SheatingMaterial_ = SheathingMaterials.PlywoodPartBd9_5Mm;
                }
                else if ((value == null) || !value.IsUserSpecified)
                {
                    this.SheatingMaterial_ = value;
                }
                else
                {
                    this.SheatingMaterial_ = (from us in SheathingMaterials.All
                        where us.Code == value.Code
                        select us).FirstOrDefault<SheathingMaterials>();
                    this.SheatingMaterial_.Value = value.Value;
                }
            }
        }

        [XmlElement("ExteriorMaterial")]
        public CodeTextAndValue ExteriorMaterialXml
        {
            get => 
                (CodeTextAndValue) this.ExteriorMaterial;
            set
            {
                if (value == null)
                {
                    this.ExteriorMaterial = null;
                }
                else
                {
                    this.ExteriorMaterial = (from dt in ExteriorMaterials.All
                        where dt.Code.ToString() == value.Code
                        select dt).FirstOrDefault<ExteriorMaterials>();
                    if (this.ExteriorMaterial.IsUserSpecified)
                    {
                        this.ExteriorMaterial.Value = value.Value;
                    }
                }
            }
        }

        [XmlIgnore]
        public ExteriorMaterials ExteriorMaterial
        {
            get => 
                this.ExteriorMaterial_;
            set
            {
                if (value == null)
                {
                    this.ExteriorMaterial_ = ExteriorMaterials.HollowMetalVinylCladding;
                }
                else if ((value == null) || !value.IsUserSpecified)
                {
                    this.ExteriorMaterial_ = value;
                }
                else
                {
                    this.ExteriorMaterial_ = (from us in ExteriorMaterials.All
                        where us.Code == value.Code
                        select us).FirstOrDefault<ExteriorMaterials>();
                    this.ExteriorMaterial_.Value = value.Value;
                }
            }
        }
    }
}

