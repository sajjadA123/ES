namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.BaseLoadsComponents
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources;
    using System;
    using System.Linq;
    using System.Xml.Serialization;

    [Serializable]
    public class ElectricalUsage
    {
        [XmlAttribute("otherLoad")]
        public decimal OtherLoad;
        [XmlAttribute("averageExteriorUse")]
        public decimal AverageExteriorUse;
        [XmlElement("ClothesDryer")]
        public ca.nrcan.gc.OEE.HouseFileLibrary.Components.BaseLoadsComponents.ClothesDryer ClothesDryer;
        [XmlElement("Stove")]
        public ca.nrcan.gc.OEE.HouseFileLibrary.Components.BaseLoadsComponents.Stove Stove;
        private RefrigeratorRatedConsumptions Refrigerator_;
        private InteriorLightingTypes InteriorLighting_;

        public ElectricalUsage()
        {
            this.Stove = new ca.nrcan.gc.OEE.HouseFileLibrary.Components.BaseLoadsComponents.Stove();
            this.Refrigerator_ = RefrigeratorRatedConsumptions.Default;
            this.InteriorLighting_ = InteriorLightingTypes.LessThan25Percent;
            this.SetDefaults();
        }

        public ElectricalUsage(ElectricalUsage toCopy)
        {
            this.Stove = new ca.nrcan.gc.OEE.HouseFileLibrary.Components.BaseLoadsComponents.Stove();
            this.Refrigerator_ = RefrigeratorRatedConsumptions.Default;
            this.InteriorLighting_ = InteriorLightingTypes.LessThan25Percent;
            this.OtherLoad = toCopy.OtherLoad;
            this.AverageExteriorUse = toCopy.AverageExteriorUse;
            this.ClothesDryer = (toCopy.ClothesDryer == null) ? null : new ca.nrcan.gc.OEE.HouseFileLibrary.Components.BaseLoadsComponents.ClothesDryer(toCopy.ClothesDryer);
            this.Stove = new ca.nrcan.gc.OEE.HouseFileLibrary.Components.BaseLoadsComponents.Stove(toCopy.Stove);
            this.Refrigerator = toCopy.Refrigerator;
            this.InteriorLighting = toCopy.InteriorLighting;
        }

        public void SetDefaults()
        {
            this.OtherLoad = 9.7M;
            this.AverageExteriorUse = 0.9M;
            this.ClothesDryer = new ca.nrcan.gc.OEE.HouseFileLibrary.Components.BaseLoadsComponents.ClothesDryer();
            this.Stove.SetDefaults();
            this.Refrigerator = RefrigeratorRatedConsumptions.Default;
            this.InteriorLighting = InteriorLightingTypes.LessThan25Percent;
        }

        [XmlElement("Refrigerator")]
        public CodeTextAndValue RefrigeratorXml
        {
            get => 
                (CodeTextAndValue) this.Refrigerator;
            set
            {
                if (value == null)
                {
                    this.Refrigerator = null;
                }
                else
                {
                    this.Refrigerator = (from dt in RefrigeratorRatedConsumptions.All
                        where dt.Code.ToString() == value.Code
                        select dt).FirstOrDefault<RefrigeratorRatedConsumptions>();
                    if (this.Refrigerator.IsUserSpecified)
                    {
                        this.Refrigerator.Value = value.Value;
                    }
                }
            }
        }

        [XmlIgnore]
        public RefrigeratorRatedConsumptions Refrigerator
        {
            get => 
                this.Refrigerator_;
            set
            {
                if (value == null)
                {
                    this.Refrigerator_ = RefrigeratorRatedConsumptions.Default;
                }
                else if ((value == null) || !value.IsUserSpecified)
                {
                    this.Refrigerator_ = value;
                }
                else
                {
                    this.Refrigerator_ = (from us in RefrigeratorRatedConsumptions.All
                        where us.Code == value.Code
                        select us).FirstOrDefault<RefrigeratorRatedConsumptions>();
                    this.Refrigerator_.Value = value.Value;
                }
            }
        }

        [XmlElement("InteriorLighting")]
        public CodeTextAndValue InteriorLightingXml
        {
            get => 
                (CodeTextAndValue) this.InteriorLighting;
            set
            {
                if (value == null)
                {
                    this.InteriorLighting = null;
                }
                else
                {
                    this.InteriorLighting = (from dt in InteriorLightingTypes.All
                        where dt.Code.ToString() == value.Code
                        select dt).FirstOrDefault<InteriorLightingTypes>();
                    if (this.InteriorLighting.IsUserSpecified)
                    {
                        this.InteriorLighting.Value = value.Value;
                    }
                }
            }
        }

        [XmlIgnore]
        public InteriorLightingTypes InteriorLighting
        {
            get => 
                this.InteriorLighting_;
            set
            {
                if (value == null)
                {
                    this.InteriorLighting_ = InteriorLightingTypes.LessThan25Percent;
                }
                else if ((value == null) || !value.IsUserSpecified)
                {
                    this.InteriorLighting_ = value;
                }
                else
                {
                    this.InteriorLighting_ = (from us in InteriorLightingTypes.All
                        where us.Code == value.Code
                        select us).FirstOrDefault<InteriorLightingTypes>();
                    this.InteriorLighting_.Value = value.Value;
                }
            }
        }
    }
}

