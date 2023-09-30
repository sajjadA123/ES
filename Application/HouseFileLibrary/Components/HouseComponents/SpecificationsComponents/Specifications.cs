namespace ca.nrcan.gc.OEE.HouseFileLibrary.Components.HouseComponents.SpecificationsComponents
{
    using ca.nrcan.gc.OEE.HouseFileLibrary;
    using ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources;
    using System;
    using System.Linq;
    using System.Xml.Serialization;

    [Serializable, XmlType("HouseSpecifications")]
    public class Specifications
    {
        [XmlAttribute("effectiveMassFraction")]
        public decimal EffectiveMassFraction;
        [XmlAttribute("defaultRoofCavity")]
        public bool DefaultRoofCavity;
        [XmlAttribute("eligibleForNBC")]
        public bool EligibleForNBC;
        [XmlIgnore]
        public building_types BuildingType;
        [XmlIgnore]
        public IHouseTypes HouseType;
        private HousePlanShapes PlanShape_;
        private HouseStoreys Storeys_;
        private HouseDirections FacingDirection_;
        private ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources.ThermalMass ThermalMass_;
        private ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources.YearBuilt YearBuilt_;
        private Colours WallColour_;
        private SoilConditions SoilCondition_;
        private Colours RoofColour_;
        private WaterTableLevels WaterLevel_;
        [XmlElement("RoofCavity")]
        public ca.nrcan.gc.OEE.HouseFileLibrary.Components.HouseComponents.SpecificationsComponents.RoofCavity RoofCavity;
        [XmlElement("NumberOf")]
        public ca.nrcan.gc.OEE.HouseFileLibrary.Components.HouseComponents.SpecificationsComponents.NumberOf NumberOf;
        [XmlElement("HeatedFloorArea")]
        public ca.nrcan.gc.OEE.HouseFileLibrary.Components.HouseComponents.SpecificationsComponents.HeatedFloorArea HeatedFloorArea;

        public Specifications()
        {
            this.PlanShape_ = HousePlanShapes.Rectangular;
            this.Storeys_ = HouseStoreys.OneStorey;
            this.FacingDirection_ = HouseDirections.North;
            this.ThermalMass_ = ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources.ThermalMass.LightWoodFrame;
            this.YearBuilt_ = ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources.YearBuilt.Years1990To99;
            this.WallColour_ = Colours.Default;
            this.SoilCondition_ = SoilConditions.NormalConductivityDrySandLoamClay;
            this.RoofColour_ = Colours.MediumBrown;
            this.WaterLevel_ = WaterTableLevels.Normal;
            this.HeatedFloorArea = new ca.nrcan.gc.OEE.HouseFileLibrary.Components.HouseComponents.SpecificationsComponents.HeatedFloorArea();
        }

        public Specifications(Specifications toCopy)
        {
            this.PlanShape_ = HousePlanShapes.Rectangular;
            this.Storeys_ = HouseStoreys.OneStorey;
            this.FacingDirection_ = HouseDirections.North;
            this.ThermalMass_ = ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources.ThermalMass.LightWoodFrame;
            this.YearBuilt_ = ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources.YearBuilt.Years1990To99;
            this.WallColour_ = Colours.Default;
            this.SoilCondition_ = SoilConditions.NormalConductivityDrySandLoamClay;
            this.RoofColour_ = Colours.MediumBrown;
            this.WaterLevel_ = WaterTableLevels.Normal;
            this.HeatedFloorArea = new ca.nrcan.gc.OEE.HouseFileLibrary.Components.HouseComponents.SpecificationsComponents.HeatedFloorArea();
            this.EffectiveMassFraction = toCopy.EffectiveMassFraction;
            this.DefaultRoofCavity = toCopy.DefaultRoofCavity;
            this.EligibleForNBC = toCopy.EligibleForNBC;
            this.BuildingType = toCopy.BuildingType;
            this.HouseType = toCopy.HouseType;
            this.PlanShape = toCopy.PlanShape;
            this.Storeys = toCopy.Storeys;
            this.FacingDirection = toCopy.FacingDirection;
            this.ThermalMass = toCopy.ThermalMass;
            this.YearBuilt = toCopy.YearBuilt;
            this.WallColour = toCopy.WallColour;
            this.SoilCondition = toCopy.SoilCondition;
            this.RoofColour = toCopy.RoofColour;
            this.WaterLevel = toCopy.WaterLevel;
            this.RoofCavity = (toCopy.RoofCavity == null) ? null : new ca.nrcan.gc.OEE.HouseFileLibrary.Components.HouseComponents.SpecificationsComponents.RoofCavity(toCopy.RoofCavity);
            this.NumberOf = (toCopy.NumberOf == null) ? null : new ca.nrcan.gc.OEE.HouseFileLibrary.Components.HouseComponents.SpecificationsComponents.NumberOf(toCopy.NumberOf);
            this.HeatedFloorArea = new ca.nrcan.gc.OEE.HouseFileLibrary.Components.HouseComponents.SpecificationsComponents.HeatedFloorArea(toCopy.HeatedFloorArea);
        }

        [XmlAttribute("buildingType")]
        public string BuildingTypeXml
        {
            get
            {
                switch (this.BuildingType)
                {
                    case building_types.MURB_ONE_UNIT:
                        return "Multi-unit: one unit";

                    case building_types.MURB_WHOLE_BUILDING:
                        return "Multi-unit: whole building";
                }
                return "House";
            }
            set
            {
                if (value.Equals("Multi-unit: whole building", StringComparison.CurrentCultureIgnoreCase))
                {
                    this.BuildingType = building_types.MURB_WHOLE_BUILDING;
                }
                else if (value.Equals("Multi-unit: one unit", StringComparison.CurrentCultureIgnoreCase))
                {
                    this.BuildingType = building_types.MURB_ONE_UNIT;
                }
                else
                {
                    this.BuildingType = building_types.HOUSE;
                }
            }
        }

        [XmlElement("HouseType")]
        public CodeAndText HouseTypeXml
        {
            get => 
                this.HouseType.ToCodeAndText();
            set
            {
                if (this.BuildingType == building_types.HOUSE)
                {
                    if (value == null)
                    {
                        this.HouseType = HouseTypes.SingleDetached;
                    }
                    else
                    {
                        this.HouseType = (from t in HouseTypes.All
                            where t.Code.ToString() == value.Code
                            select t).FirstOrDefault<HouseTypes>();
                    }
                }
                else if (value == null)
                {
                    this.HouseType = HouseTypesMurb.DetachedDuplex;
                }
                else
                {
                    this.HouseType = (from t in HouseTypesMurb.All
                        where t.Code.ToString() == value.Code
                        select t).FirstOrDefault<HouseTypesMurb>();
                }
            }
        }

        [XmlElement("PlanShape")]
        public CodeAndText PlanShapeXml
        {
            get => 
                (CodeAndText) this.PlanShape;
            set
            {
                if (value == null)
                {
                    this.PlanShape = null;
                }
                else
                {
                    this.PlanShape = (from dt in HousePlanShapes.All
                        where dt.Code.ToString() == value.Code
                        select dt).FirstOrDefault<HousePlanShapes>();
                }
            }
        }

        [XmlIgnore]
        public HousePlanShapes PlanShape
        {
            get => 
                this.PlanShape_;
            set
            {
                if (value == null)
                {
                    this.PlanShape_ = HousePlanShapes.Rectangular;
                }
                else
                {
                    this.PlanShape_ = value;
                }
            }
        }

        [XmlElement("Storeys")]
        public CodeAndText StoreysXml
        {
            get => 
                (CodeAndText) this.Storeys;
            set
            {
                if (value == null)
                {
                    this.Storeys = null;
                }
                else
                {
                    this.Storeys = (from dt in HouseStoreys.All
                        where dt.Code.ToString() == value.Code
                        select dt).FirstOrDefault<HouseStoreys>();
                }
            }
        }

        [XmlIgnore]
        public HouseStoreys Storeys
        {
            get => 
                this.Storeys_;
            set
            {
                if (value == null)
                {
                    this.Storeys_ = HouseStoreys.OneStorey;
                }
                else
                {
                    this.Storeys_ = value;
                }
            }
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
                    this.FacingDirection = (from dt in HouseDirections.All
                        where dt.Code.ToString() == value.Code
                        select dt).FirstOrDefault<HouseDirections>();
                }
            }
        }

        [XmlIgnore]
        public HouseDirections FacingDirection
        {
            get => 
                this.FacingDirection_;
            set
            {
                if (value == null)
                {
                    this.FacingDirection_ = HouseDirections.North;
                }
                else
                {
                    this.FacingDirection_ = value;
                }
            }
        }

        [XmlElement("ThermalMass")]
        public CodeAndText ThermalMassXml
        {
            get => 
                (CodeAndText) this.ThermalMass;
            set
            {
                if (value == null)
                {
                    this.ThermalMass = null;
                }
                else
                {
                    this.ThermalMass = (from dt in ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources.ThermalMass.All
                        where dt.Code.ToString() == value.Code
                        select dt).FirstOrDefault<ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources.ThermalMass>();
                }
            }
        }

        [XmlIgnore]
        public ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources.ThermalMass ThermalMass
        {
            get => 
                this.ThermalMass_;
            set
            {
                if (value == null)
                {
                    this.ThermalMass_ = ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources.ThermalMass.LightWoodFrame;
                }
                else
                {
                    this.ThermalMass_ = value;
                }
            }
        }

        [XmlElement("YearBuilt")]
        public CodeTextAndValue YearBuiltXml
        {
            get => 
                (CodeTextAndValue) this.YearBuilt;
            set
            {
                if (value == null)
                {
                    this.YearBuilt = null;
                }
                else
                {
                    this.YearBuilt = (from dt in ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources.YearBuilt.All
                        where dt.Code.ToString() == value.Code
                        select dt).FirstOrDefault<ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources.YearBuilt>();
                    if (this.YearBuilt.IsUserSpecified)
                    {
                        this.YearBuilt.Value = value.Value;
                    }
                }
            }
        }

        [XmlIgnore]
        public ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources.YearBuilt YearBuilt
        {
            get => 
                this.YearBuilt_;
            set
            {
                if (value == null)
                {
                    this.YearBuilt_ = ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources.YearBuilt.Years1990To99;
                }
                else if ((value == null) || !value.IsUserSpecified)
                {
                    this.YearBuilt_ = value;
                }
                else
                {
                    this.YearBuilt_ = (from us in ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources.YearBuilt.All
                        where us.Code == value.Code
                        select us).FirstOrDefault<ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources.YearBuilt>();
                    this.YearBuilt_.Value = value.Value;
                }
            }
        }

        [XmlElement("WallColour")]
        public CodeTextAndValue WallColourXml
        {
            get => 
                (CodeTextAndValue) this.WallColour;
            set
            {
                if (value == null)
                {
                    this.WallColour = null;
                }
                else
                {
                    this.WallColour = (from dt in Colours.All
                        where dt.Code.ToString() == value.Code
                        select dt).FirstOrDefault<Colours>();
                    if (this.WallColour.IsUserSpecified)
                    {
                        this.WallColour.Value = value.Value;
                    }
                }
            }
        }

        [XmlIgnore]
        public Colours WallColour
        {
            get => 
                this.WallColour_;
            set
            {
                if (value == null)
                {
                    this.WallColour_ = Colours.Default;
                }
                else if ((value == null) || !value.IsUserSpecified)
                {
                    this.WallColour_ = value;
                }
                else
                {
                    this.WallColour_ = (from us in Colours.All
                        where us.Code == value.Code
                        select us).FirstOrDefault<Colours>();
                    this.WallColour_.Value = value.Value;
                }
            }
        }

        [XmlElement("SoilCondition")]
        public CodeAndText SoilConditionXml
        {
            get => 
                (CodeAndText) this.SoilCondition;
            set
            {
                if (value == null)
                {
                    this.SoilCondition = null;
                }
                else
                {
                    this.SoilCondition = (from dt in SoilConditions.All
                        where dt.Code.ToString() == value.Code
                        select dt).FirstOrDefault<SoilConditions>();
                }
            }
        }

        [XmlIgnore]
        public SoilConditions SoilCondition
        {
            get => 
                this.SoilCondition_;
            set
            {
                if (value == null)
                {
                    this.SoilCondition_ = SoilConditions.NormalConductivityDrySandLoamClay;
                }
                else
                {
                    this.SoilCondition_ = value;
                }
            }
        }

        [XmlElement("RoofColour")]
        public CodeTextAndValue RoofColourXml
        {
            get => 
                (CodeTextAndValue) this.RoofColour;
            set
            {
                if (value == null)
                {
                    this.RoofColour = null;
                }
                else
                {
                    this.RoofColour = (from dt in Colours.All
                        where dt.Code.ToString() == value.Code
                        select dt).FirstOrDefault<Colours>();
                    if (this.RoofColour.IsUserSpecified)
                    {
                        this.RoofColour.Value = value.Value;
                    }
                }
            }
        }

        [XmlIgnore]
        public Colours RoofColour
        {
            get => 
                this.RoofColour_;
            set
            {
                if (value == null)
                {
                    this.RoofColour_ = Colours.MediumBrown;
                }
                else if ((value == null) || !value.IsUserSpecified)
                {
                    this.RoofColour_ = value;
                }
                else
                {
                    this.RoofColour_ = (from us in Colours.All
                        where us.Code == value.Code
                        select us).FirstOrDefault<Colours>();
                    this.RoofColour_.Value = value.Value;
                }
            }
        }

        [XmlElement("WaterLevel")]
        public CodeAndText WaterLevelXml
        {
            get => 
                (CodeAndText) this.WaterLevel;
            set
            {
                if (value == null)
                {
                    this.WaterLevel = null;
                }
                else
                {
                    this.WaterLevel = (from dt in WaterTableLevels.All
                        where dt.Code.ToString() == value.Code
                        select dt).FirstOrDefault<WaterTableLevels>();
                }
            }
        }

        [XmlIgnore]
        public WaterTableLevels WaterLevel
        {
            get => 
                this.WaterLevel_;
            set
            {
                if (value == null)
                {
                    this.WaterLevel_ = WaterTableLevels.Normal;
                }
                else
                {
                    this.WaterLevel_ = value;
                }
            }
        }
    }
}

