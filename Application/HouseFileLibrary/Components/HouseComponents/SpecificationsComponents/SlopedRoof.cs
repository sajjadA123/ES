namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.HouseComponents.SpecificationsComponents
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources;
    using System;
    using System.Linq;
    using System.Xml.Serialization;

    [Serializable]
    public class SlopedRoof
    {
        [XmlAttribute("area")]
        public decimal area;
        private SheathingMaterials SheatingMaterial_;
        private RoofingMaterials RoofingMaterial_;

        public SlopedRoof()
        {
            this.SheatingMaterial_ = SheathingMaterials.PlywoodPartBd12_7Mm;
            this.RoofingMaterial_ = RoofingMaterials.AsphaltShingles;
        }

        public SlopedRoof(SlopedRoof toCopy)
        {
            this.SheatingMaterial_ = SheathingMaterials.PlywoodPartBd12_7Mm;
            this.RoofingMaterial_ = RoofingMaterials.AsphaltShingles;
            this.area = toCopy.area;
            this.SheatingMaterial = toCopy.SheatingMaterial;
            this.RoofingMaterial = toCopy.RoofingMaterial;
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
                    this.SheatingMaterial_ = SheathingMaterials.PlywoodPartBd12_7Mm;
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

        [XmlElement("RoofingMaterial")]
        public CodeTextAndValue RoofingMaterialXml
        {
            get => 
                (CodeTextAndValue) this.RoofingMaterial;
            set
            {
                if (value == null)
                {
                    this.RoofingMaterial = null;
                }
                else
                {
                    this.RoofingMaterial = (from dt in RoofingMaterials.All
                        where dt.Code.ToString() == value.Code
                        select dt).FirstOrDefault<RoofingMaterials>();
                    if (this.RoofingMaterial.IsUserSpecified)
                    {
                        this.RoofingMaterial.Value = value.Value;
                    }
                }
            }
        }

        [XmlIgnore]
        public RoofingMaterials RoofingMaterial
        {
            get => 
                this.RoofingMaterial_;
            set
            {
                if (value == null)
                {
                    this.RoofingMaterial_ = RoofingMaterials.AsphaltShingles;
                }
                else if ((value == null) || !value.IsUserSpecified)
                {
                    this.RoofingMaterial_ = value;
                }
                else
                {
                    this.RoofingMaterial_ = (from us in RoofingMaterials.All
                        where us.Code == value.Code
                        select us).FirstOrDefault<RoofingMaterials>();
                    this.RoofingMaterial_.Value = value.Value;
                }
            }
        }
    }
}

