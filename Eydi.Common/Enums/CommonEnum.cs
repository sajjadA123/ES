using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ES.Common.Enums
{

    public enum LockType
    {
        [Description("باز")]
        Open,
        [Description("بسته")]
        Close
    }
    public enum CodeTypes
    {
        [Description("Wall")]
        Wall,
        [Description("Ceiling")]
        Ceiling,
        [Description("Window")]
        Window,
        [Description("Floor")]
        Floor,
        [Description("Lintel")]
        Lintel,
        [Description("CeilingFlat")]
        CeilingFlat,
        [Description("FloorsAbove")]
        FloorsAbove,
        [Description("FloorsAdded")]
        FloorsAdded,
        [Description("BasementWall")]
        BasementWall,
        [Description("CrawlspaceWall")]
        CrawlspaceWall,
        [Description("FloorHeader")]
        FloorHeader
    }
    public enum MonthType
    {
        [Description("فروردین")]
        Farvardin = 1,
        [Description("اردیبهشت")]
        Ordibehesht,
        [Description("خرداد")]
        Khordad,
        [Description("تیر")]
        Tir,
        [Description("مرداد")]
        Mordad,
        [Description("شهریور")]
        Shahrivar,
        [Description("مهر")]
        Mehr,
        [Description("آبان")]
        Aban,
        [Description("آذر")]
        Azar,
        [Description("دی")]
        Dey,
        [Description("بهمن")]
        Bahman,
        [Description("اسفند")]
        Esfand,
        [Description("Test")]
        test,
    }

    public enum UnitDivisionType
    {
        [Description("حوزه کل")]
        Total,
        [Description("واحد")]
        Partial
    }

    public enum RoleType
    {
        [Description("admin")]
        Admin,
    }


    public enum IndicatorType
    {
        [Description("عمومی")]
        Public,
        [Description("عملکردی")]
        Functionality
    }
    public enum ComponentsType
    {
        [Description("Wall")]
        Wall,
        [Description("Ceiling")]
        Ceiling,
        [Description("Window")]
        Window,
        [Description("Door")]
        Door,
        [Description("Pony Wall")]
        PonyWall,
        [Description("Floor")]
        Floor,
        [Description("Foundation Basement")]
        FoundationBasement,
        [Description("Floor Header")]
        FloorHeader,
        [Description("Exposed Floor")]
        ExposedFloor,
        [Description("Ventilation")]
        Ventilation,
        [Description("DomesticHotWaterPrimary")]
        DomesticHotWaterPrimary,
        [Description("NaturalAirInfiltration")]
        NaturalAirInfiltration,
        [Description("HeatingCooling")]
        HeatingCooling

    }
    public enum DisplayUnitType
    {
        [Description("Metric")]
        Metric = 1,
        [Description("Imperial")]
        Imperial=2,
        [Description("US")]
        US=3,
    }
    public enum RoomShapeType
    {
        [Description("Rectangle")]
        Rectangle = 1,
        [Description("NoRectangle")]
        NoRectangle = 2,
    }
    public enum LintelMaterial
    {
        [Description("Wood")]
        Wood = 1,
        [Description("Steel")]
        Steel = 2,
    }
    public enum UValues
    {
        [Description("> 1.22")]
        GreaterThan = 1,
        [Description("> 1.05 And <=1.22")]
        between = 2,
        [Description("<= 1.05")]
        LessThan = 3,
    }
    public enum EnergyFactorType
    {
        [Description("Energy Factor")]
        EnergyFactor = 1,
        [Description("Uniform Energy Factor")]
        UniformEnergyFactor = 2,
    }
    public enum StandyHeatLossUnit
    {
        [Description("BTU/hr")]
        BTU = 1,
        [Description("%hr")]
        Hr = 2,
    }
    public enum DHWType
    {
        [Description("Primary")]
        Primary = 1,
        [Description("Secondary")]
        Secondary = 2,
    }
    public enum CSAType
    {
        [Description("CSA F379")]
        CSAF379 = 1,
    }
    public enum FloorDimension
    {
        [Description("Rectangular")]
        Rectangular = 1,
        [Description("Non-Rectangular")]
        NonRectangular = 2,
    }
    public enum InsulationType
    {
        [Description("Insulation")]
        Insulation = 1,
        [Description("Skirt")]
        Skirt = 2,
        [Description("Coverage")]
        Coverage = 3,
    }

    public enum BasementType
    {
        [Description("Crwl Space")]
        CrwlSpace = 1,
        [Description("Basement")]
        Basement = 2,
        [Description("slab")]
        Slab = 3,
        [Description("WalkOut")]
        WalkOut = 4,
    }
    //public enum AirDistrubtionORCirculation
    //{
    //    [Description("Forced air heating ductwork")]
    //    ForcedAir = 1,
    //    [Description("Deducted low volume ductwork")]
    //    DeductedLow = 2,
    //    [Description("Deducted ductwork with transfer fans")]
    //    DeductedDuctwork = 3,
    //}
    public enum UserOrDefult
    {
        [Description("User Specification")]
        UserSpec = 1,
        [Description("Default")]
        Default = 2,
    }
    public enum VentilationComponentType
    {
        [Description("WholeHouse")]
        WholeHouse = 1,
        [Description("Supplemental")]
        Supplemental = 2,
    }

    public enum ColdAirType
    {
        [Description("Flexible")]
        Flexible = 1,
        [Description("Sheet Metal w/liner")]
        SheetMEtal = 2,
        [Description("Exterior Insulated Sheet Metal")]
        ExteriorInsulated = 3,
    }
    public enum SealingCharact
    {
        [Description("Very tight")]
        Verytight = 1,
        [Description("Sealed")]
        Sealed = 2,
        [Description("UnSealed")]
        UnSealed = 3,
    }

    public enum VentilatorFanType
    {
        [Description("HRV")]
        HRV = 1,
        [Description("N/A")]
        NA = 2,
        [Description("Range Hood")]
        EangeHood = 4,
        [Description("Bathroom")]
        Bathroom = 5,
        [Description("Utility")]
        Utility = 6,
    }
    public enum DryerExhaustDestination
    {
        [Description("Vented Outdoors")]
        Outdoors = 1,
        [Description("Vented Indoors")]
        Indoors = 2,
    }
    public enum SpaceCondHeadPumpType
    {
        [Description("Transfer All Heat Load To Type 1")]
        All = 1,
        [Description("Set To Standard Performance Level")]
        Standart = 2,
    }

    public enum AllowableRize
    {
        [Description("Low (0 deg)")]
        Low = 1,
        [Description("Mediume (2.8 C=5 F)")]
        Mediume = 2,
        [Description("High (5.5 C=9.9 F)")]
        High = 3,
    }
    public enum LightingType
    {
        [Description("< 25% CFL or LED")]
        Low = 1,
        [Description("25%-75% CFL or LED")]
        Mediume = 2,
        [Description("> 75% CFL or LED")]
        High = 3,
    }
    public enum IndicatePresenceVermiculite
    {
        [Description("None")]
        None = 1,
        [Description("Unknown")]
        Unknown = 2,
        [Description("Vermiculite")]
        Vermiculite = 3,
        [Description("No Vermiculite")]
        NoVermiculite = 4,
    }
    public enum DepressTestType
    {
        [Description("No Applicable")]
        NoApplicable = 1,
        [Description("Not Possible to Perform Test")]
        NotPossible = 2,
        [Description("Test Result")]
        TestResult = 3,
    }
    public enum BlowerTestType
    {
        [Description("As Operated")]
        Operated = 1,
        [Description("OGSB")]
        OGSB = 2,
    }
    public enum UserSpecOrCalcType
    {
        [Description("User Specification")]
        UserSpec = 1,
        [Description("Calculated")]
        Calculated = 2,
    }
    public enum DefaultOrUserSpecType
    {
        [Description("User Defaults")]
        Defaults = 1,
        [Description("User Specification")]
        Specification = 2,
    }
    public enum EquvalLeakageAreaAt
    {
        [Description("4 Pa")]
        _4pa = 1,
        [Description("10 Pa")]
        _10pa = 2,
    }
    public enum LocalShadeFlueType
    {
        [Description("None")]
        None = 1,
        [Description("Light")]
        Light = 2,
        [Description("Heavy")]
        Heavy = 3,
        [Description("Very Heavy")]
        VeryHeavy = 4,
        [Description("Compelete(by large buildings)")]
        Compelete = 5,
    }
    public enum TestFlowRange
    {
        [Description("Open")]
        Open = 1,
        [Description("Ring 1")]
        Ring1 = 2,
        [Description("Ring 2")]
        Ring2 = 3,
        [Description("Ring 3")]
        Ring3 = 4,
    }
    public enum EquipmentType
    {
        [Description("Not Applicable")]
        NotApplicable = 1,
        [Description("Fireplace With Doors")]
        FireplaceDoor = 2,
        [Description("Open Fireplace")]
        OpenFireplace = 3,
        [Description("Wood Stove")]
        WoodStove = 4,
        [Description("Wood/Coal furnace")]
        WoodCoal = 5,
    }
    public enum GeoMonthType
    {
        [Description("January")]
        January = 1,
        [Description("February")]
        February,
        [Description("March")]
        March,
        [Description("April")]
        April,
        [Description("May")]
        May,
        [Description("June")]
        June,
        [Description("July")]
        July,
        [Description("August")]
        August,
        [Description("September")]
        September,
        [Description("October")]
        October,
        [Description("November")]
        November,
        [Description("December")]
        December,
    }
    public enum FansPumpModel
    {
        [Description("N/A")]
        NA = 1,
        [Description("Auto")]
        Auto = 2,
        [Description("Continuous")]
        Continuous = 4,
        [Description("Two Speed")]
        TwoSpeed = 5,
    }
    public enum FansPumpPower
    {
        [Description("Calculated")]
        Calculated = 1,
        [Description("Auto")]
        Auto = 2,
    }
    public enum CSADataType
    {
        [Description("Library")]
        Library = 1,
        [Description("User Specified")]
        UserSpecified = 2,
    }
    public enum DWHRConfig
    {
        [Description("Preheated cold water delivered to hot water heater only")]
        HeaterOnly = 1,
        [Description("Preheated cold water delivered to hot water heater and shower")]
        HeaterShower = 2,
    }
    public enum EnergySourceType
    {
        [Description("")]
        None = 1,
        [Description("Natural Gas")]
        NaturalGas = 2,
        [Description("Oil")]
        Oil = 3,
        [Description("Propane")]
        Propane = 4,
    }
    public enum EnergyFactorSourceType
    {
        [Description("Electricity")]
        None = 1,
        [Description("Natural Gas")]
        NaturalGas = 2,
        [Description("Oil")]
        Oil = 3,
        [Description("Propane")]
        Propane = 4,

        [Description("Mixed Wood")]
        MixedWood = 5,
        [Description("Hard Wood")]
        HardWood = 6,
        [Description("Soft Wood")]
        SoftWood = 7,
        [Description("Wood Pellets")]
        WoodPellets = 8,
        [Description("Solar")]
        Solar = 9,
        [Description("Not Applicable")]
        NotApplicable = 10,
    }
    public enum GasStoveType
    {
        [Description("")]
        None = 1,
        [Description("Natural Gas")]
        NaturalGas = 2,
        [Description("Propane")]
        Propane = 3,
    }


    public enum CapacityUnit
    {
        [Description("kW")]
        KW = 1,
        [Description("btu/hr")]
        BtuHr = 2,
    }
    public enum EfficiencyType
    {
        [Description("Steady State")]
        SteadyState = 1,
        [Description("AFUE")]
        AFUE = 2,
    }
    public enum HeatCoolEfficiencyType
    {
        [Description("COP")]
        COP = 1,
        [Description("HSPF")]
        HSPF = 2,
    }
    public enum UnitFuncType
    {
        [Description("Heating")]
        Heating = 1,
        [Description("Heating/Cooling")]
        HeatingCooling = 2,
    }
    public enum CentralEquipmentTpe
    {
        [Description("Central Split System")]
        CentralSplit = 1,
        [Description("Central Single Package System")]
        CentralSinglePackage = 2,
        [Description("Mini-split Doctless")]
        MinisplitDoctless = 2,
    }
    public enum Type1Type
    {
        [Description("Baseboards/Hydronic/Plenum heaters")]
        Baseboards = 1,
        [Description("Furnace")]
        Furnace = 2,
        [Description("Boiler")]
        Boiler = 3,
        [Description("Combo Heating/DHW")]
        ComboHeating = 4,
        [Description("CSA p.9-11 tested Combo Heating/DHW")]
        CSA = 5,
    }
    public enum Type2Type
    {
        [Description("N/A")]
        NA = 1,
        [Description("Air Source Heat Pump")]
        AirSource = 2,
        [Description("Water Source Heat Pump")]
        WaterSource = 3,
        [Description("Ground Source Heat Pump")]
        GroundSource = 4,
        [Description("Air Conditioning")]
        AirConditioning = 5,
    }
    public enum OutputCapacityType
    {
        [Description("User Specification")]
        UserSpec = 1,
        [Description("Calculated")]
        Calculated = 2,
        [Description("1.25 x cooling load ")]
        CoolingLoad = 3,
    }
    public enum TempCutoffType
    {
        [Description("Balance Point")]
        BalancePoint = 1,
        [Description("Restricted")]
        Restricted = 2,
        [Description("UnRestricted")]
        UnRestricted = 3,
    }
    public enum WindowTiltType
    {
        [Description("Vertical")]
        Vertical = 1,
        [Description("Horizontal")]
        Horizontal = 2,
        [Description("Same as roof")]
        SameAsRoof = 3,
        [Description("User specified")]
        UserSpecified = 4,
    }
    public enum TempRatingType
    {
        [Description("8.3 C(47 F)")]
        _47F = 1,
        [Description("0.0 C(32 F)")]
        _32F = 2,
        [Description("User Specified")]
        UserSpecified = 3,
    }
    public enum Orientation
    {
        [Description("South")]
        South = 1,
        [Description("Sotheast")]
        Sotheast = 2,
        [Description("East")]
        East = 3,
        [Description("Northeast")]
        Northeast = 4,
        [Description("North")]
        North = 5,
        [Description("Northwest")]
        Northwest = 6,
        [Description("West")]
        West = 7,
        [Description("Sothwest")]
        Sothwest = 8,
        [Description("N/A")]
        NA = 9,
    }
    public enum RoomType
    {
        [Description("Kitchen")]
        Kitchen = 1,
        [Description("Living Room")]
        LivingRoom = 2,
        [Description("Dinning Room")]
        DinningRoom = 3,
        [Description("Bedroom")]
        Bedroom = 4,
        [Description("Bathroom")]
        Bathroom = 5,
        [Description("Utility Room")]
        UtilityRoom = 6,
        [Description("Other")]
        Other = 7,
    }
    public enum RoofSlopeType
    {
        [Description("User Specified")]
        UserSpecified = 1,
        [Description("Flat Roof")]
        FlatRoof = 2,
        [Description("2/12")]
        _2_12 = 3,
        [Description("3/12")]
        _3_12 = 4,
        [Description("4/12")]
        _4_12 = 5,
        [Description("5/12")]
        _5_12 = 6,
        [Description("6/12")]
        _6_12 = 7,
        [Description("7/12")]
        _7_12 = 7,
    }
    public enum FloorType
    {
        [Description("Ground Floor")]
        GroundFloor = 1,
        [Description("Second Floor")]
        SecondFloor = 2,
        [Description("Third Floor")]
        ThirdFloor = 3,
    }
    public enum CeilingConstType
    {
        [Description("Attic/Gable")]
        AtticGable = 1,
        [Description("Attic/Hip")]
        AtticHip = 2,
        [Description("Cathedral")]
        Cathedral = 3,
        [Description("Flat")]
        Flat = 4,
        [Description("Scissor")]
        Scissor = 5,
    }
    public enum CrawlSpaceType
    {
        [Description("Vented")]
        Vented = 1,
        [Description("Closed")]
        Closed = 2,
        [Description("Open")]
        Open = 3,

    }

}
