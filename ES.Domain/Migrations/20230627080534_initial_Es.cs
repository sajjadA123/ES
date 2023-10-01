using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ES.Domain.Migrations
{
    public partial class initial_Es : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AdditionalOpenings",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EquipmentType1 = table.Column<int>(type: "int", nullable: false),
                    FlueDiameter1 = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    DamperClosed1 = table.Column<bool>(type: "bit", nullable: true),
                    EquipmentType2 = table.Column<int>(type: "int", nullable: false),
                    FlueDiameter2 = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    DamperClosed2 = table.Column<bool>(type: "bit", nullable: true),
                    EquipmentType3 = table.Column<int>(type: "int", nullable: false),
                    FlueDiameter3 = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    DamperClosed3 = table.Column<bool>(type: "bit", nullable: true),
                    CREATORID = table.Column<int>(type: "int", nullable: false),
                    DATEINSERTED = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DATEMODIFIED = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LocationType = table.Column<long>(type: "bigint", nullable: true),
                    LocationId = table.Column<long>(type: "bigint", nullable: true),
                    UPDATERID = table.Column<int>(type: "int", nullable: true),
                    ISDELETE = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ES_PK_ADDITIONALOPENING", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ATypicalEnergyLoads",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeIcingCable = table.Column<bool>(type: "bit", nullable: true),
                    ElecVehicleShargSt = table.Column<bool>(type: "bit", nullable: true),
                    ExExtLight = table.Column<bool>(type: "bit", nullable: true),
                    HeatedGarag = table.Column<bool>(type: "bit", nullable: true),
                    HotTub = table.Column<bool>(type: "bit", nullable: true),
                    MixedUse = table.Column<bool>(type: "bit", nullable: true),
                    OutGas = table.Column<bool>(type: "bit", nullable: true),
                    SwimmPool = table.Column<bool>(type: "bit", nullable: true),
                    UnitCount = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    EnStarCout = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    CREATORID = table.Column<int>(type: "int", nullable: false),
                    DATEINSERTED = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DATEMODIFIED = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LocationType = table.Column<long>(type: "bigint", nullable: true),
                    LocationId = table.Column<long>(type: "bigint", nullable: true),
                    UPDATERID = table.Column<int>(type: "int", nullable: true),
                    ISDELETE = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ES_PK_ATYPICALENERGYLOAD", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "BasementAttaches",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CREATORID = table.Column<int>(type: "int", nullable: false),
                    DATEINSERTED = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DATEMODIFIED = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LocationType = table.Column<long>(type: "bigint", nullable: true),
                    LocationId = table.Column<long>(type: "bigint", nullable: true),
                    UPDATERID = table.Column<int>(type: "int", nullable: true),
                    ISDELETE = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ES_PK_BASEMENTATTACH", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CodeSummaries",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Type = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Liberary = table.Column<bool>(type: "bit", nullable: true),
                    CREATORID = table.Column<int>(type: "int", nullable: false),
                    DATEINSERTED = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DATEMODIFIED = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LocationType = table.Column<long>(type: "bigint", nullable: true),
                    LocationId = table.Column<long>(type: "bigint", nullable: true),
                    UPDATERID = table.Column<int>(type: "int", nullable: true),
                    ISDELETE = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ES_PK_CODESUMMARY", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Components",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ComponentType = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Insertable = table.Column<bool>(type: "bit", nullable: false),
                    CREATORID = table.Column<int>(type: "int", nullable: false),
                    DATEINSERTED = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DATEMODIFIED = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LocationType = table.Column<long>(type: "bigint", nullable: true),
                    LocationId = table.Column<long>(type: "bigint", nullable: true),
                    UPDATERID = table.Column<int>(type: "int", nullable: true),
                    ISDELETE = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ES_PK_COMPONENTS", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Composites",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sec1Area = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    Sec1Rsi = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    Sec2Area = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    Sec2Rsi = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    RemArea = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    RemRsi = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    EffRsi = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    CREATORID = table.Column<int>(type: "int", nullable: false),
                    DATEINSERTED = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DATEMODIFIED = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LocationType = table.Column<long>(type: "bigint", nullable: true),
                    LocationId = table.Column<long>(type: "bigint", nullable: true),
                    UPDATERID = table.Column<int>(type: "int", nullable: true),
                    ISDELETE = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ES_PK_COMPOSITE", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "cSAP9TestDatas",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnergyType = table.Column<int>(type: "int", nullable: false),
                    NetEff15 = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    NetEff40 = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    NetEff100 = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    AvgElecUse15 = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    AvgElecUse40 = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    AvgElecUse100 = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    CirclBmePower15 = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    CirclBmePower40 = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    CirclBmePower100 = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    Pcont = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    Pcirc = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    DailyElWaterHeat = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    ThemalStandbyOn = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    ThemalStandbyOff = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    HDeliverRateDhw = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    HDeliverRateSh = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    CREATORID = table.Column<int>(type: "int", nullable: false),
                    DATEINSERTED = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DATEMODIFIED = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LocationType = table.Column<long>(type: "bigint", nullable: true),
                    LocationId = table.Column<long>(type: "bigint", nullable: true),
                    UPDATERID = table.Column<int>(type: "int", nullable: true),
                    ISDELETE = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ES_PK_CSAP9TESTDATA", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "FansAndPumps",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HeatSysFanModel = table.Column<int>(type: "int", nullable: false),
                    HeatSysFanPower = table.Column<int>(type: "int", nullable: false),
                    HeatEnergyEfMotor = table.Column<bool>(type: "bit", nullable: true),
                    HeatSysFanPowerHspeed = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    HeatSysFanPowerLspeed = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    CoolFanInModel = table.Column<int>(type: "int", nullable: false),
                    CoolFanPower = table.Column<int>(type: "int", nullable: false),
                    CoolFanInFlowRate = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    Power = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    CoolEnergyEfMotor = table.Column<bool>(type: "bit", nullable: true),
                    CREATORID = table.Column<int>(type: "int", nullable: false),
                    DATEINSERTED = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DATEMODIFIED = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LocationType = table.Column<long>(type: "bigint", nullable: true),
                    LocationId = table.Column<long>(type: "bigint", nullable: true),
                    UPDATERID = table.Column<int>(type: "int", nullable: true),
                    ISDELETE = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ES_PK_FANSANDPUMPS", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Generations",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhotovoliSysCount = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    CapPhotovoliSys = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    BatteryStorage = table.Column<bool>(type: "bit", nullable: true),
                    WindEnergy = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    SolarReady = table.Column<bool>(type: "bit", nullable: true),
                    CREATORID = table.Column<int>(type: "int", nullable: false),
                    DATEINSERTED = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DATEMODIFIED = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LocationType = table.Column<long>(type: "bigint", nullable: true),
                    LocationId = table.Column<long>(type: "bigint", nullable: true),
                    UPDATERID = table.Column<int>(type: "int", nullable: true),
                    ISDELETE = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ES_PK_GENERATION", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HeatPumpSourceTempMonthlies",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    January = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    February = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    March = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    April = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    May = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    June = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    July = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    August = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    September = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    October = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    November = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    December = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    CREATORID = table.Column<int>(type: "int", nullable: false),
                    DATEINSERTED = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DATEMODIFIED = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LocationType = table.Column<long>(type: "bigint", nullable: true),
                    LocationId = table.Column<long>(type: "bigint", nullable: true),
                    UPDATERID = table.Column<int>(type: "int", nullable: true),
                    ISDELETE = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ES_PK_HEATPUMPSOURCETEMPMONTHLY", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HouseHoldOCs",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccupantsNum = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    ThemostatHSeasonDay = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    ThemostatHSeasonNight = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    ThemostatColling = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    CoolingSeasonMonthNum = table.Column<bool>(type: "bit", nullable: true),
                    ClothWasher = table.Column<bool>(type: "bit", nullable: true),
                    MorThn50CflLed = table.Column<bool>(type: "bit", nullable: true),
                    LessThn5Year = table.Column<bool>(type: "bit", nullable: true),
                    CREATORID = table.Column<int>(type: "int", nullable: false),
                    DATEINSERTED = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DATEMODIFIED = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LocationType = table.Column<long>(type: "bigint", nullable: true),
                    LocationId = table.Column<long>(type: "bigint", nullable: true),
                    UPDATERID = table.Column<int>(type: "int", nullable: true),
                    ISDELETE = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ES_PK_HOUSEHOLDOC", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "InsulationConfigs",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    IsType = table.Column<int>(type: "int", nullable: false),
                    CREATORID = table.Column<int>(type: "int", nullable: false),
                    DATEINSERTED = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DATEMODIFIED = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LocationType = table.Column<long>(type: "bigint", nullable: true),
                    LocationId = table.Column<long>(type: "bigint", nullable: true),
                    UPDATERID = table.Column<int>(type: "int", nullable: true),
                    ISDELETE = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ES_PK_INSULATIONCONFIG", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "KeyValues",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KEY = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    VALUE = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CREATORID = table.Column<int>(type: "int", nullable: false),
                    DATEINSERTED = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DATEMODIFIED = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LocationType = table.Column<long>(type: "bigint", nullable: true),
                    LocationId = table.Column<long>(type: "bigint", nullable: true),
                    UPDATERID = table.Column<int>(type: "int", nullable: true),
                    ISDELETE = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ES_PK_KEYVALUE", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CREATORID = table.Column<int>(type: "int", nullable: false),
                    DATEINSERTED = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DATEMODIFIED = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LocationType = table.Column<long>(type: "bigint", nullable: true),
                    LocationId = table.Column<long>(type: "bigint", nullable: true),
                    UPDATERID = table.Column<int>(type: "int", nullable: true),
                    ISDELETE = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ES_PK_LOCATION", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Radiants",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AticCeilingEffTemp = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    AticCeilingTotArea = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    FlatRoofEffTemp = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    FlatRoofTotArea = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    FloorAbCrawlSpcEffTemp = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    FloorAbCrawlSpcTotArea = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    SlabOnGradeEffTemp = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    SlabOnGradeTotArea = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    FloorAbBasementEffTemp = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    FloorAbBasementTotArea = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    BasementEffTemp = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    BasementTotArea = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    CREATORID = table.Column<int>(type: "int", nullable: false),
                    DATEINSERTED = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DATEMODIFIED = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LocationType = table.Column<long>(type: "bigint", nullable: true),
                    LocationId = table.Column<long>(type: "bigint", nullable: true),
                    UPDATERID = table.Column<int>(type: "int", nullable: true),
                    ISDELETE = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ES_PK_RADIANT", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "RedusedOcs",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnStarNewHome = table.Column<bool>(type: "bit", nullable: true),
                    LightingType = table.Column<int>(type: "int", nullable: false),
                    ClothesDryerVal = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    ClothesDryerEn = table.Column<bool>(type: "bit", nullable: true),
                    ClothesWasherVal = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    ClothesWasherEn = table.Column<bool>(type: "bit", nullable: true),
                    DishwasherVal = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    DishwasherEn = table.Column<bool>(type: "bit", nullable: true),
                    RefrigeratorVal = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    RefrigeratorEn = table.Column<bool>(type: "bit", nullable: true),
                    Range = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    HotwaterBathroomRate = table.Column<bool>(type: "bit", nullable: true),
                    HotwaterShowerRate = table.Column<bool>(type: "bit", nullable: true),
                    CREATORID = table.Column<int>(type: "int", nullable: false),
                    DATEINSERTED = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DATEMODIFIED = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LocationType = table.Column<long>(type: "bigint", nullable: true),
                    LocationId = table.Column<long>(type: "bigint", nullable: true),
                    UPDATERID = table.Column<int>(type: "int", nullable: true),
                    ISDELETE = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ES_PK_REDUSEDOC", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "RefrenceHouses",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ElectGeneration = table.Column<bool>(type: "bit", nullable: true),
                    SpaceCondHeadPumpType = table.Column<int>(type: "int", nullable: false),
                    WinDoorSkyligthNeut = table.Column<bool>(type: "bit", nullable: true),
                    PartyWallAreaAbG = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    PartyWallAreaBlG = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    UserHdd = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    CREATORID = table.Column<int>(type: "int", nullable: false),
                    DATEINSERTED = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DATEMODIFIED = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LocationType = table.Column<long>(type: "bigint", nullable: true),
                    LocationId = table.Column<long>(type: "bigint", nullable: true),
                    UPDATERID = table.Column<int>(type: "int", nullable: true),
                    ISDELETE = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ES_PK_REFRENCEHOUSE", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Regions",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegionName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CREATORID = table.Column<int>(type: "int", nullable: false),
                    DATEINSERTED = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DATEMODIFIED = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LocationType = table.Column<long>(type: "bigint", nullable: true),
                    LocationId = table.Column<long>(type: "bigint", nullable: true),
                    UPDATERID = table.Column<int>(type: "int", nullable: true),
                    ISDELETE = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ES_PK_REGIONS", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TbHeads",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HeadCode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    HeadDesc = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    StatusDate = table.Column<TimeSpan>(type: "time", nullable: false),
                    CREATORID = table.Column<int>(type: "int", nullable: false),
                    DATEINSERTED = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DATEMODIFIED = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LocationType = table.Column<long>(type: "bigint", nullable: true),
                    LocationId = table.Column<long>(type: "bigint", nullable: true),
                    UPDATERID = table.Column<int>(type: "int", nullable: true),
                    ISDELETE = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ES_PK_TBHEAD", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "WaterConservations",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Observed = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    Recommnded = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    CREATORID = table.Column<int>(type: "int", nullable: false),
                    DATEINSERTED = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DATEMODIFIED = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LocationType = table.Column<long>(type: "bigint", nullable: true),
                    LocationId = table.Column<long>(type: "bigint", nullable: true),
                    UPDATERID = table.Column<int>(type: "int", nullable: true),
                    ISDELETE = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ES_PK_WATERCONSERVATION", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Type2s",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UnitFuncType = table.Column<int>(type: "int", nullable: false),
                    CentralEquipmentTpe = table.Column<int>(type: "int", nullable: false),
                    OutCapacityType = table.Column<int>(type: "int", nullable: false),
                    OutCapacityVal = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    OutCapacityUnit = table.Column<int>(type: "int", nullable: false),
                    HeatEfficiencyVal = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    HeatEfficiencyType = table.Column<int>(type: "int", nullable: false),
                    CoolEfficiencyVal = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    CoolEfficiencyType = table.Column<int>(type: "int", nullable: false),
                    TempCutoffType = table.Column<int>(type: "int", nullable: false),
                    CutoffTemp = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    TempRatingType = table.Column<int>(type: "int", nullable: false),
                    RatingTemp = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    EquipmentManufact = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    EquipmentModel = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    EquipmentAHRI = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    EnergyStar = table.Column<bool>(type: "bit", nullable: true),
                    CrankcaseHeat = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    SensibleHeatRate = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    OpenableWinArea = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    ColdClimateHeatPumo = table.Column<bool>(type: "bit", nullable: true),
                    CLHHeatEff = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    CLHCoolEff = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    CLHCapVal = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    CLHCapUnit = table.Column<int>(type: "int", nullable: false),
                    CLHCopAt = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    ClhCapMaintnc = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    WaterOrGroundTempUseType = table.Column<int>(type: "int", nullable: false),
                    WaterTempMonId = table.Column<long>(type: "bigint", nullable: true),
                    AvgDepth = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    CAN_CSA = table.Column<bool>(type: "bit", nullable: true),
                    CREATORID = table.Column<int>(type: "int", nullable: false),
                    DATEINSERTED = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DATEMODIFIED = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LocationType = table.Column<long>(type: "bigint", nullable: true),
                    LocationId = table.Column<long>(type: "bigint", nullable: true),
                    UPDATERID = table.Column<int>(type: "int", nullable: true),
                    ISDELETE = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ES_PK_TYPE2", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Type2s_HeatPumpSourceTempMonthlies_WaterTempMonId",
                        column: x => x.WaterTempMonId,
                        principalTable: "HeatPumpSourceTempMonthlies",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "BasementConfigs",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConfingLable = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ConfigImage = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    ConfigDecriprion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsulationId = table.Column<long>(type: "bigint", nullable: true),
                    CREATORID = table.Column<int>(type: "int", nullable: false),
                    DATEINSERTED = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DATEMODIFIED = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LocationType = table.Column<long>(type: "bigint", nullable: true),
                    LocationId = table.Column<long>(type: "bigint", nullable: true),
                    UPDATERID = table.Column<int>(type: "int", nullable: true),
                    ISDELETE = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ES_PK_BASEMENTCONFIG", x => x.ID);
                    table.ForeignKey(
                        name: "FK_BasementConfigs_InsulationConfigs_IsulationId",
                        column: x => x.IsulationId,
                        principalTable: "InsulationConfigs",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Telephone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    StreetAddress = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    UnitNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    City = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    RegionId = table.Column<int>(type: "int", nullable: true),
                    RegionsID = table.Column<long>(type: "bigint", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    MailAddressName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    MailAddress = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    UnitNumber2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    City2 = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    RegionId2 = table.Column<int>(type: "int", nullable: true),
                    Regions2ID = table.Column<long>(type: "bigint", nullable: true),
                    PostalCode2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CREATORID = table.Column<int>(type: "int", nullable: false),
                    DATEINSERTED = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DATEMODIFIED = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LocationType = table.Column<long>(type: "bigint", nullable: true),
                    LocationId = table.Column<long>(type: "bigint", nullable: true),
                    UPDATERID = table.Column<int>(type: "int", nullable: true),
                    ISDELETE = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ES_PK_CLIENT", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Clients_Regions_Regions2ID",
                        column: x => x.Regions2ID,
                        principalTable: "Regions",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Clients_Regions_RegionsID",
                        column: x => x.RegionsID,
                        principalTable: "Regions",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "TbDetails",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HEAD_ID = table.Column<long>(type: "bigint", nullable: true),
                    HeadID = table.Column<long>(type: "bigint", nullable: true),
                    DETAIL_CODE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DETAIL_DESC = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DETAIL_DESC2 = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    STATUS = table.Column<bool>(type: "bit", nullable: true),
                    STATUS_DATE = table.Column<TimeSpan>(type: "time", nullable: false),
                    CREATORID = table.Column<int>(type: "int", nullable: false),
                    DATEINSERTED = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DATEMODIFIED = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LocationType = table.Column<long>(type: "bigint", nullable: true),
                    LocationId = table.Column<long>(type: "bigint", nullable: true),
                    UPDATERID = table.Column<int>(type: "int", nullable: true),
                    ISDELETE = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ES_PK_TBDETAIL", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TbDetails_TbHeads_HeadID",
                        column: x => x.HeadID,
                        principalTable: "TbHeads",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "CodeSelectors",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FloorLable = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    StructureTypeId = table.Column<long>(type: "bigint", nullable: true),
                    ComponentTypeSizeId = table.Column<long>(type: "bigint", nullable: true),
                    SpacingId = table.Column<long>(type: "bigint", nullable: true),
                    InsulLay1Id = table.Column<long>(type: "bigint", nullable: true),
                    InsulLay2Id = table.Column<long>(type: "bigint", nullable: true),
                    InternalCodeId = table.Column<long>(type: "bigint", nullable: true),
                    InternalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InteriorId = table.Column<long>(type: "bigint", nullable: true),
                    SheathingId = table.Column<long>(type: "bigint", nullable: true),
                    ExteriorId = table.Column<long>(type: "bigint", nullable: true),
                    StudCornrIntersectId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ES_PK_CODESELECTOR", x => x.ID);
                    table.ForeignKey(
                        name: "ES_FK_CS_COM_TB_DETAIL",
                        column: x => x.ComponentTypeSizeId,
                        principalTable: "TbDetails",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "ES_FK_CS_EXTERIOR_TB_DETAIL",
                        column: x => x.ExteriorId,
                        principalTable: "TbDetails",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "ES_FK_CS_InsL1_TB_DETAIL",
                        column: x => x.InsulLay1Id,
                        principalTable: "TbDetails",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "ES_FK_CS_InsL2_TB_DETAIL",
                        column: x => x.InsulLay2Id,
                        principalTable: "TbDetails",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "ES_FK_CS_Iter_TB_DETAIL",
                        column: x => x.InteriorId,
                        principalTable: "TbDetails",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "ES_FK_CS_Sheathing_TB_DETAIL",
                        column: x => x.SheathingId,
                        principalTable: "TbDetails",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "ES_FK_CS_SPC_TB_DETAIL",
                        column: x => x.SpacingId,
                        principalTable: "TbDetails",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "ES_FK_CS_STRUCTURE_TB_DETAIL",
                        column: x => x.StructureTypeId,
                        principalTable: "TbDetails",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "ES_FK_CS_STUD_TB_DETAIL",
                        column: x => x.StudCornrIntersectId,
                        principalTable: "TbDetails",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "ComboTankAndPumps",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TankVolumeTypeId = table.Column<long>(type: "bigint", nullable: true),
                    TankVolumeVal = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    EnergyFactorType = table.Column<int>(type: "int", nullable: false),
                    EnergyFactorVal = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    TankLocation = table.Column<int>(type: "int", nullable: false),
                    CirculationPompType = table.Column<int>(type: "int", nullable: false),
                    CirculationPompVal = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    EnergyEffMotor = table.Column<bool>(type: "bit", nullable: true),
                    CREATORID = table.Column<int>(type: "int", nullable: false),
                    DATEINSERTED = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DATEMODIFIED = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LocationType = table.Column<long>(type: "bigint", nullable: true),
                    LocationId = table.Column<long>(type: "bigint", nullable: true),
                    UPDATERID = table.Column<int>(type: "int", nullable: true),
                    ISDELETE = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ES_PK_COMBOTANKANDPUMP", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ComboTankAndPumps_TbDetails_TankVolumeTypeId",
                        column: x => x.TankVolumeTypeId,
                        principalTable: "TbDetails",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Doors",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DoorLable = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DoorTypeId = table.Column<long>(type: "bigint", nullable: true),
                    EnergyStar = table.Column<bool>(type: "bit", nullable: true),
                    AdjustEnclose = table.Column<bool>(type: "bit", nullable: true),
                    Width = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    Heigth = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    GArea = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    RValue = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    CREATORID = table.Column<int>(type: "int", nullable: false),
                    DATEINSERTED = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DATEMODIFIED = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LocationType = table.Column<long>(type: "bigint", nullable: true),
                    LocationId = table.Column<long>(type: "bigint", nullable: true),
                    UPDATERID = table.Column<int>(type: "int", nullable: true),
                    ISDELETE = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ES_PK_DOOR", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Doors_TbDetails_DoorTypeId",
                        column: x => x.DoorTypeId,
                        principalTable: "TbDetails",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "DWHRs",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShowerTemperatureId = table.Column<long>(type: "bigint", nullable: true),
                    ShowerLength = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    ShowerPerDayNum = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    ShowerHeadRateId = table.Column<long>(type: "bigint", nullable: true),
                    Configuration = table.Column<int>(type: "int", nullable: false),
                    ManufactureId = table.Column<long>(type: "bigint", nullable: true),
                    ModelId = table.Column<long>(type: "bigint", nullable: true),
                    Efficiency = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    CREATORID = table.Column<int>(type: "int", nullable: false),
                    DATEINSERTED = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DATEMODIFIED = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LocationType = table.Column<long>(type: "bigint", nullable: true),
                    LocationId = table.Column<long>(type: "bigint", nullable: true),
                    UPDATERID = table.Column<int>(type: "int", nullable: true),
                    ISDELETE = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ES_PK_DWHR", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DWHRs_TbDetails_ManufactureId",
                        column: x => x.ManufactureId,
                        principalTable: "TbDetails",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_DWHRs_TbDetails_ModelId",
                        column: x => x.ModelId,
                        principalTable: "TbDetails",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_DWHRs_TbDetails_ShowerHeadRateId",
                        column: x => x.ShowerHeadRateId,
                        principalTable: "TbDetails",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_DWHRs_TbDetails_ShowerTemperatureId",
                        column: x => x.ShowerTemperatureId,
                        principalTable: "TbDetails",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "ElectricalUsages",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClothsDryerInstalled = table.Column<bool>(type: "bit", nullable: true),
                    ClothsEnergySourceTypeID = table.Column<long>(type: "bigint", nullable: true),
                    ClothWashLoadDryPer = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    ClthRateValTypeID = table.Column<long>(type: "bigint", nullable: true),
                    CLTH_ANNUAL_ENERGY_CONS_RATE = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    DryerLocationId = table.Column<long>(type: "bigint", nullable: true),
                    DryerLocType = table.Column<long>(type: "bigint", nullable: true),
                    StoveEnergySourceTypeID = table.Column<long>(type: "bigint", nullable: true),
                    StoveRateValTypeID = table.Column<long>(type: "bigint", nullable: true),
                    StoveAnnualEnConsRateYear = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    RefrigRateValTypeID = table.Column<long>(type: "bigint", nullable: true),
                    RegrigAnnualEnConsRateYear = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    LigthDailyElecEnConsTypeID = table.Column<long>(type: "bigint", nullable: true),
                    LigthDailyElecEnConsVal = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    OtherElecLoad = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    AvgExtUse = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    CREATORID = table.Column<int>(type: "int", nullable: false),
                    DATEINSERTED = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DATEMODIFIED = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LocationType = table.Column<long>(type: "bigint", nullable: true),
                    LocationId = table.Column<long>(type: "bigint", nullable: true),
                    UPDATERID = table.Column<int>(type: "int", nullable: true),
                    ISDELETE = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ES_PK_ELECTRICALUSAGE", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ElectricalUsages_TbDetails_ClothsEnergySourceTypeID",
                        column: x => x.ClothsEnergySourceTypeID,
                        principalTable: "TbDetails",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ElectricalUsages_TbDetails_ClthRateValTypeID",
                        column: x => x.ClthRateValTypeID,
                        principalTable: "TbDetails",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ElectricalUsages_TbDetails_LigthDailyElecEnConsTypeID",
                        column: x => x.LigthDailyElecEnConsTypeID,
                        principalTable: "TbDetails",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ElectricalUsages_TbDetails_RefrigRateValTypeID",
                        column: x => x.RefrigRateValTypeID,
                        principalTable: "TbDetails",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ElectricalUsages_TbDetails_StoveEnergySourceTypeID",
                        column: x => x.StoveEnergySourceTypeID,
                        principalTable: "TbDetails",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ElectricalUsages_TbDetails_StoveRateValTypeID",
                        column: x => x.StoveRateValTypeID,
                        principalTable: "TbDetails",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "FuelCosts",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ElectricityTypeId = table.Column<long>(type: "bigint", nullable: true),
                    NaturalGasTypeId = table.Column<long>(type: "bigint", nullable: true),
                    OilTypeId = table.Column<long>(type: "bigint", nullable: true),
                    PropaneTypeId = table.Column<long>(type: "bigint", nullable: true),
                    WoodTypeId = table.Column<long>(type: "bigint", nullable: true),
                    CREATORID = table.Column<int>(type: "int", nullable: false),
                    DATEINSERTED = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DATEMODIFIED = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LocationType = table.Column<long>(type: "bigint", nullable: true),
                    LocationId = table.Column<long>(type: "bigint", nullable: true),
                    UPDATERID = table.Column<int>(type: "int", nullable: true),
                    ISDELETE = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ES_PK_FUELCOST", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FuelCosts_TbDetails_ElectricityTypeId",
                        column: x => x.ElectricityTypeId,
                        principalTable: "TbDetails",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_FuelCosts_TbDetails_NaturalGasTypeId",
                        column: x => x.NaturalGasTypeId,
                        principalTable: "TbDetails",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_FuelCosts_TbDetails_OilTypeId",
                        column: x => x.OilTypeId,
                        principalTable: "TbDetails",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_FuelCosts_TbDetails_PropaneTypeId",
                        column: x => x.PropaneTypeId,
                        principalTable: "TbDetails",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_FuelCosts_TbDetails_WoodTypeId",
                        column: x => x.WoodTypeId,
                        principalTable: "TbDetails",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "greenerHomes",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BaseSlabIns = table.Column<bool>(type: "bit", nullable: true),
                    MoisProofCrwSpc = table.Column<bool>(type: "bit", nullable: true),
                    WaterProof = table.Column<bool>(type: "bit", nullable: true),
                    AdhesiveWaterproof = table.Column<bool>(type: "bit", nullable: true),
                    MinR10Contin = table.Column<bool>(type: "bit", nullable: true),
                    RemoteCom = table.Column<bool>(type: "bit", nullable: true),
                    RemoteComTypId = table.Column<long>(type: "bigint", nullable: true),
                    BackWaterValv = table.Column<bool>(type: "bit", nullable: true),
                    SumpPump = table.Column<bool>(type: "bit", nullable: true),
                    Programmable = table.Column<bool>(type: "bit", nullable: true),
                    EvalCost = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    CREATORID = table.Column<int>(type: "int", nullable: false),
                    DATEINSERTED = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DATEMODIFIED = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LocationType = table.Column<long>(type: "bigint", nullable: true),
                    LocationId = table.Column<long>(type: "bigint", nullable: true),
                    UPDATERID = table.Column<int>(type: "int", nullable: true),
                    ISDELETE = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ES_PK_GREENERHOME", x => x.ID);
                    table.ForeignKey(
                        name: "FK_greenerHomes_TbDetails_RemoteComTypId",
                        column: x => x.RemoteComTypId,
                        principalTable: "TbDetails",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "HRVDucts",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupplyLocationTypeId = table.Column<long>(type: "bigint", nullable: true),
                    ColdAirSupplyType = table.Column<int>(type: "int", nullable: false),
                    ColdAirSuppDucLength = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    ColdAirSuppDiameter = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    ColdAirSuppInsulation = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    ColdAirSuppSealingCharact = table.Column<int>(type: "int", nullable: false),
                    ExhaustLocationTypeId = table.Column<long>(type: "bigint", nullable: true),
                    ExhaustType = table.Column<int>(type: "int", nullable: false),
                    ExhaustSDLength = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    ExhaustDiameter = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    ExhaustInsulation = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    ExhaustSealingCharat = table.Column<int>(type: "int", nullable: false),
                    CREATORID = table.Column<int>(type: "int", nullable: false),
                    DATEINSERTED = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DATEMODIFIED = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LocationType = table.Column<long>(type: "bigint", nullable: true),
                    LocationId = table.Column<long>(type: "bigint", nullable: true),
                    UPDATERID = table.Column<int>(type: "int", nullable: true),
                    ISDELETE = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ES_PK_HRVDUCTS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_HRVDucts_TbDetails_ExhaustLocationTypeId",
                        column: x => x.ExhaustLocationTypeId,
                        principalTable: "TbDetails",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_HRVDucts_TbDetails_SupplyLocationTypeId",
                        column: x => x.SupplyLocationTypeId,
                        principalTable: "TbDetails",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Justifications",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EfficFromNameplate = table.Column<bool>(type: "bit", nullable: true),
                    EfficFromComTest = table.Column<bool>(type: "bit", nullable: false),
                    HeatSysCorrect = table.Column<bool>(type: "bit", nullable: true),
                    PossesionDate = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    HeatVolumeDec = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    InsCorrectValCeiling = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    InsCorrectValWall = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    InsCorrectValBasement = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    AchCorrect = table.Column<bool>(type: "bit", nullable: true),
                    TwoBlowerDoor = table.Column<bool>(type: "bit", nullable: true),
                    Other = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Up18Mon = table.Column<bool>(type: "bit", nullable: true),
                    EnergyStarTypeId = table.Column<long>(type: "bigint", nullable: true),
                    CREATORID = table.Column<int>(type: "int", nullable: false),
                    DATEINSERTED = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DATEMODIFIED = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LocationType = table.Column<long>(type: "bigint", nullable: true),
                    LocationId = table.Column<long>(type: "bigint", nullable: true),
                    UPDATERID = table.Column<int>(type: "int", nullable: true),
                    ISDELETE = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ES_PK_JUSTIFICATION", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Justifications_TbDetails_EnergyStarTypeId",
                        column: x => x.EnergyStarTypeId,
                        principalTable: "TbDetails",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "LintelCodeSelectors",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LABLE = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    LintelTypeid = table.Column<long>(type: "bigint", nullable: true),
                    Material = table.Column<int>(type: "int", nullable: false),
                    InsulationId = table.Column<long>(type: "bigint", nullable: true),
                    InternalCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ES_PK_LINTELCODESELECTOR", x => x.ID);
                    table.ForeignKey(
                        name: "FK_LintelCodeSelectors_TbDetails_InsulationId",
                        column: x => x.InsulationId,
                        principalTable: "TbDetails",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_LintelCodeSelectors_TbDetails_LintelTypeid",
                        column: x => x.LintelTypeid,
                        principalTable: "TbDetails",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "PhotovoltaicSystems",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenerationId = table.Column<long>(type: "bigint", nullable: true),
                    Manufacture = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Model = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ArayArea = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    SlopDeg = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    AzimuthDeg = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    ModuleTypeId = table.Column<long>(type: "bigint", nullable: true),
                    ModuleEfficiency = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    NormOperationCellTemp = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    TempCoefficientOfEff = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    MissArrayLoss = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    InverterEff = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    OtherPow = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    GridObsorRate = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    CREATORID = table.Column<int>(type: "int", nullable: false),
                    DATEINSERTED = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DATEMODIFIED = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LocationType = table.Column<long>(type: "bigint", nullable: true),
                    LocationId = table.Column<long>(type: "bigint", nullable: true),
                    UPDATERID = table.Column<int>(type: "int", nullable: true),
                    ISDELETE = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ES_PK_PHOTOVOLTAICSYSTEM", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PhotovoltaicSystems_Generations_GenerationId",
                        column: x => x.GenerationId,
                        principalTable: "Generations",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_PhotovoltaicSystems_TbDetails_ModuleTypeId",
                        column: x => x.ModuleTypeId,
                        principalTable: "TbDetails",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "RoofCavityInputs",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GeTotalArea = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    GeSheathingMatTypeId = table.Column<long>(type: "bigint", nullable: true),
                    GeSheathingMatValue = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    GeExteriorMatTypeId = table.Column<long>(type: "bigint", nullable: true),
                    GeExteriorMatValue = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    SrTotalArea = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    SrSheathingMatTypeId = table.Column<long>(type: "bigint", nullable: true),
                    SrSheathingMatValue = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    SrRoofingMatTypeId = table.Column<long>(type: "bigint", nullable: true),
                    SrRoofingMatValue = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    CavityVol = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    VentilationRate = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    CREATORID = table.Column<int>(type: "int", nullable: false),
                    DATEINSERTED = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DATEMODIFIED = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LocationType = table.Column<long>(type: "bigint", nullable: true),
                    LocationId = table.Column<long>(type: "bigint", nullable: true),
                    UPDATERID = table.Column<int>(type: "int", nullable: true),
                    ISDELETE = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ES_PK_ROOFCAVITYINPUT", x => x.ID);
                    table.ForeignKey(
                        name: "FK_RoofCavityInputs_TbDetails_GeExteriorMatTypeId",
                        column: x => x.GeExteriorMatTypeId,
                        principalTable: "TbDetails",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_RoofCavityInputs_TbDetails_GeSheathingMatTypeId",
                        column: x => x.GeSheathingMatTypeId,
                        principalTable: "TbDetails",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_RoofCavityInputs_TbDetails_SrRoofingMatTypeId",
                        column: x => x.SrRoofingMatTypeId,
                        principalTable: "TbDetails",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_RoofCavityInputs_TbDetails_SrSheathingMatTypeId",
                        column: x => x.SrSheathingMatTypeId,
                        principalTable: "TbDetails",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Lable = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DimensionHeigth = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    SahpeType = table.Column<int>(type: "int", nullable: false),
                    FloorPerimeterOrLength = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    FloorAreaOrLength = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    RoomTypeId = table.Column<long>(type: "bigint", nullable: true),
                    FloorTypeId = table.Column<long>(type: "bigint", nullable: true),
                    FounDationBelowTypeId = table.Column<long>(type: "bigint", nullable: true),
                    ExtWallsQty = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    ExtWallsGArea = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    ExtWallsNetArea = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    ExtCeillingQty = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    ExtCeillingGArea = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    ExtCeillingNetArea = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    DoorsQty = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    DoorsGArea = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    DoorsNetArea = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    ExtFloorsQty = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    ExtFloorGArea = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    FloorHdrsQty = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    FloorHdrsGArea = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    RoomArea = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    RoomPerimeter = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    RoomVolume = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    CREATORID = table.Column<int>(type: "int", nullable: false),
                    DATEINSERTED = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DATEMODIFIED = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LocationType = table.Column<long>(type: "bigint", nullable: true),
                    LocationId = table.Column<long>(type: "bigint", nullable: true),
                    UPDATERID = table.Column<int>(type: "int", nullable: true),
                    ISDELETE = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ES_PK_ROOM", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Rooms_TbDetails_FloorTypeId",
                        column: x => x.FloorTypeId,
                        principalTable: "TbDetails",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Rooms_TbDetails_FounDationBelowTypeId",
                        column: x => x.FounDationBelowTypeId,
                        principalTable: "TbDetails",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Rooms_TbDetails_RoomTypeId",
                        column: x => x.RoomTypeId,
                        principalTable: "TbDetails",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "RoomsInputs",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KitchenLivingDiningRoom = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    Bedroom = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    UtilityRoom = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    OtherHabitableRoom = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    VentiRateOtherBaseTypeId = table.Column<long>(type: "bigint", nullable: true),
                    MinVentiRate = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    VentedComAppLimitTypeId = table.Column<long>(type: "bigint", nullable: true),
                    VentedComAppLimitVal = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    CREATORID = table.Column<int>(type: "int", nullable: false),
                    DATEINSERTED = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DATEMODIFIED = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LocationType = table.Column<long>(type: "bigint", nullable: true),
                    LocationId = table.Column<long>(type: "bigint", nullable: true),
                    UPDATERID = table.Column<int>(type: "int", nullable: true),
                    ISDELETE = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ES_PK_ROOMSINPUT", x => x.ID);
                    table.ForeignKey(
                        name: "FK_RoomsInputs_TbDetails_VentedComAppLimitTypeId",
                        column: x => x.VentedComAppLimitTypeId,
                        principalTable: "TbDetails",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_RoomsInputs_TbDetails_VentiRateOtherBaseTypeId",
                        column: x => x.VentiRateOtherBaseTypeId,
                        principalTable: "TbDetails",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "TestEquips",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FanTypeId = table.Column<long>(type: "bigint", nullable: true),
                    Manometer = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PressureInit = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    PerssureFinal = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    InsideTemp = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    ZoneHeatedVol = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    CREATORID = table.Column<int>(type: "int", nullable: false),
                    DATEINSERTED = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DATEMODIFIED = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LocationType = table.Column<long>(type: "bigint", nullable: true),
                    LocationId = table.Column<long>(type: "bigint", nullable: true),
                    UPDATERID = table.Column<int>(type: "int", nullable: true),
                    ISDELETE = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestEquips", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TestEquips_TbDetails_FanTypeId",
                        column: x => x.FanTypeId,
                        principalTable: "TbDetails",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "VentilatorFanTypeDetails",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DetailType = table.Column<int>(type: "int", nullable: false),
                    EquipmentManufact = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    EquipmentModel = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SchaduleOpTypeID = table.Column<long>(type: "bigint", nullable: true),
                    SCHADULE_OP_VAL = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    EnergyStar = table.Column<bool>(type: "bit", nullable: true),
                    HVI = table.Column<bool>(type: "bit", nullable: true),
                    AirflowSupply = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    AirflowExhaust = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    UseDefFanPwr = table.Column<bool>(type: "bit", nullable: true),
                    RatingCondPwr1 = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    RatingCondTemp1 = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    RatingCondEff1 = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    RatingCondPwr2 = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    RatingCondTemp2 = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    RatingCondEff2 = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    PreheaterCap = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    LowTempVentReduct = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    CoolingEff = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    HrvDuctsId = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    DryerExDestType = table.Column<int>(type: "int", nullable: false),
                    CREATORID = table.Column<int>(type: "int", nullable: false),
                    DATEINSERTED = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DATEMODIFIED = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LocationType = table.Column<long>(type: "bigint", nullable: true),
                    LocationId = table.Column<long>(type: "bigint", nullable: true),
                    UPDATERID = table.Column<int>(type: "int", nullable: true),
                    ISDELETE = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ES_PK_VENTILATORFANTYPEDETAIL", x => x.ID);
                    table.ForeignKey(
                        name: "FK_VentilatorFanTypeDetails_TbDetails_SchaduleOpTypeID",
                        column: x => x.SchaduleOpTypeID,
                        principalTable: "TbDetails",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "WaterUsages",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HotWaterTemp = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    BathFaucetFlowRateTypeId = table.Column<long>(type: "bigint", nullable: true),
                    BathFaucetUserPerOcc = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    ShowerTempTypeId = table.Column<long>(type: "bigint", nullable: true),
                    ShwrHeadFlowRateId = table.Column<long>(type: "bigint", nullable: true),
                    AvgShwrDur = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    ShwrNumPerOcc = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    ClothWasherInstalled = table.Column<bool>(type: "bit", nullable: true),
                    ClthWasherRateValTypeID = table.Column<long>(type: "bigint", nullable: true),
                    ClthWasherTempTypeId = table.Column<long>(type: "bigint", nullable: true),
                    ClthWasherRatePerCycle = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    ClthWasherRateAnnPerYear = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    ClthWasherClothNumPerOcc = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    DishwasherInstalled = table.Column<bool>(type: "bit", nullable: true),
                    DshWasherRateValTypeId = table.Column<long>(type: "bigint", nullable: true),
                    DshWasherDishNumPerCycle = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    DshWasherRateWaterPerCycle = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    DshWasherAnnualEnergyPerYear = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    DshWasherCycleNumPerOcc = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    OtherWaterConsPerDay = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    LowFlushNum = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    CREATORID = table.Column<int>(type: "int", nullable: false),
                    DATEINSERTED = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DATEMODIFIED = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LocationType = table.Column<long>(type: "bigint", nullable: true),
                    LocationId = table.Column<long>(type: "bigint", nullable: true),
                    UPDATERID = table.Column<int>(type: "int", nullable: true),
                    ISDELETE = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ES_PK_WATERUSAGE", x => x.ID);
                    table.ForeignKey(
                        name: "FK_WaterUsages_TbDetails_BathFaucetFlowRateTypeId",
                        column: x => x.BathFaucetFlowRateTypeId,
                        principalTable: "TbDetails",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_WaterUsages_TbDetails_ClthWasherRateValTypeID",
                        column: x => x.ClthWasherRateValTypeID,
                        principalTable: "TbDetails",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_WaterUsages_TbDetails_ClthWasherTempTypeId",
                        column: x => x.ClthWasherTempTypeId,
                        principalTable: "TbDetails",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_WaterUsages_TbDetails_DshWasherRateValTypeId",
                        column: x => x.DshWasherRateValTypeId,
                        principalTable: "TbDetails",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_WaterUsages_TbDetails_ShowerTempTypeId",
                        column: x => x.ShowerTempTypeId,
                        principalTable: "TbDetails",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_WaterUsages_TbDetails_ShwrHeadFlowRateId",
                        column: x => x.ShwrHeadFlowRateId,
                        principalTable: "TbDetails",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Windows",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Lable = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ShuterRValue = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    Curtain = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    AdjustEnclose = table.Column<bool>(type: "bit", nullable: true),
                    EnergyStar = table.Column<bool>(type: "bit", nullable: true),
                    UvalueType = table.Column<int>(type: "int", nullable: false),
                    ERValue = table.Column<long>(type: "bigint", nullable: true),
                    OrientationId = table.Column<long>(type: "bigint", nullable: true),
                    WinNumber = table.Column<long>(type: "bigint", nullable: true),
                    Width = table.Column<long>(type: "bigint", nullable: true),
                    Heigth = table.Column<long>(type: "bigint", nullable: true),
                    GrossArea = table.Column<long>(type: "bigint", nullable: true),
                    OvHangWidth = table.Column<long>(type: "bigint", nullable: true),
                    HeaderHeigth = table.Column<long>(type: "bigint", nullable: true),
                    TiltTypeId = table.Column<long>(type: "bigint", nullable: true),
                    TiltValue = table.Column<long>(type: "bigint", nullable: true),
                    Er2009 = table.Column<long>(type: "bigint", nullable: true),
                    RValue = table.Column<long>(type: "bigint", nullable: true),
                    SHGC = table.Column<long>(type: "bigint", nullable: true),
                    CREATORID = table.Column<int>(type: "int", nullable: false),
                    DATEINSERTED = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DATEMODIFIED = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LocationType = table.Column<long>(type: "bigint", nullable: true),
                    LocationId = table.Column<long>(type: "bigint", nullable: true),
                    UPDATERID = table.Column<int>(type: "int", nullable: true),
                    ISDELETE = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ES_PK_WINDOWS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Windows_TbDetails_OrientationId",
                        column: x => x.OrientationId,
                        principalTable: "TbDetails",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Windows_TbDetails_TiltTypeId",
                        column: x => x.TiltTypeId,
                        principalTable: "TbDetails",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Ceilings",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CeilLable = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ConstractTypeID = table.Column<long>(type: "bigint", nullable: true),
                    CeilTypeID = table.Column<long>(type: "bigint", nullable: true),
                    Length = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    Area = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    RoofSlopeTypeId = table.Column<long>(type: "bigint", nullable: true),
                    RoofSlopeValue = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    RValue = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    HeelHeigth = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    CREATORID = table.Column<int>(type: "int", nullable: false),
                    DATEINSERTED = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DATEMODIFIED = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LocationType = table.Column<long>(type: "bigint", nullable: true),
                    LocationId = table.Column<long>(type: "bigint", nullable: true),
                    UPDATERID = table.Column<int>(type: "int", nullable: true),
                    ISDELETE = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ES_PK_CEILING", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Ceilings_CodeSelectors_CeilTypeID",
                        column: x => x.CeilTypeID,
                        principalTable: "CodeSelectors",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Ceilings_TbDetails_ConstractTypeID",
                        column: x => x.ConstractTypeID,
                        principalTable: "TbDetails",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Ceilings_TbDetails_RoofSlopeTypeId",
                        column: x => x.RoofSlopeTypeId,
                        principalTable: "TbDetails",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Floors",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FloorLable = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    AdjuctEnCloseUncondSpc = table.Column<bool>(type: "bit", nullable: true),
                    FloorTypeId = table.Column<long>(type: "bigint", nullable: true),
                    Heigth = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    Area = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    RValue = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    CREATORID = table.Column<int>(type: "int", nullable: false),
                    DATEINSERTED = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DATEMODIFIED = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LocationType = table.Column<long>(type: "bigint", nullable: true),
                    LocationId = table.Column<long>(type: "bigint", nullable: true),
                    UPDATERID = table.Column<int>(type: "int", nullable: true),
                    ISDELETE = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ES_PK_FLOOR", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Floors_CodeSelectors_FloorTypeId",
                        column: x => x.FloorTypeId,
                        principalTable: "CodeSelectors",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "CSATestedComboHeatings",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataType = table.Column<int>(type: "int", nullable: false),
                    Manufacture = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Model = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    P9SysNum = table.Column<long>(type: "bigint", nullable: true),
                    CSAP9Id = table.Column<long>(type: "bigint", nullable: true),
                    ThrmalPerFactor = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    AnnualElec = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    SpcHeatingCap = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    CompositeSHE = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    WaterHeatPerFact = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    NominalBurner = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    RecoveryEff = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    DWHRId = table.Column<long>(type: "bigint", nullable: true),
                    CREATORID = table.Column<int>(type: "int", nullable: false),
                    DATEINSERTED = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DATEMODIFIED = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LocationType = table.Column<long>(type: "bigint", nullable: true),
                    LocationId = table.Column<long>(type: "bigint", nullable: true),
                    UPDATERID = table.Column<int>(type: "int", nullable: true),
                    ISDELETE = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ES_PK_CSATESTEDCOMBOHEATING", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CSATestedComboHeatings_cSAP9TestDatas_CSAP9Id",
                        column: x => x.CSAP9Id,
                        principalTable: "cSAP9TestDatas",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_CSATestedComboHeatings_DWHRs_DWHRId",
                        column: x => x.DWHRId,
                        principalTable: "DWHRs",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "DomesticHotWaters",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnergySrcTypeId = table.Column<long>(type: "bigint", nullable: true),
                    TankTypeId = table.Column<long>(type: "bigint", nullable: true),
                    TankVolumeTypeId = table.Column<long>(type: "bigint", nullable: true),
                    TankVolumeVal = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    EnergyFactorTypeId = table.Column<long>(type: "bigint", nullable: true),
                    EnergyFactorVal = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    UniformEnergyFactorId = table.Column<long>(type: "bigint", nullable: true),
                    TankLocationType = table.Column<long>(type: "bigint", nullable: true),
                    standbyHeatLoss = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    StandyHeatLossUnit = table.Column<int>(type: "int", nullable: false),
                    StandyThermalEfficiency = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    StandyInputCap = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    EqupmentManufac = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    EqupmentModel = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    EqupmentES = table.Column<bool>(type: "bit", nullable: true),
                    EqupmentEco = table.Column<bool>(type: "bit", nullable: true),
                    InsulatingBlanket = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    HPCOP = table.Column<decimal>(type: "decimal(18,4)", nullable: true),
                    FlueCombined = table.Column<bool>(type: "bit", nullable: true),
                    FlueDiameter = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    CsaType = table.Column<long>(type: "bigint", nullable: true),
                    CsaVal = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    Slope = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    Azimuth = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    FractionOfTank = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    PilotEnergy = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    DWHRId = table.Column<long>(type: "bigint", nullable: true),
                    DHW_TYPE = table.Column<int>(type: "int", nullable: false),
                    CREATORID = table.Column<int>(type: "int", nullable: false),
                    DATEINSERTED = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DATEMODIFIED = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LocationType = table.Column<long>(type: "bigint", nullable: true),
                    LocationId = table.Column<long>(type: "bigint", nullable: true),
                    UPDATERID = table.Column<int>(type: "int", nullable: true),
                    ISDELETE = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ES_PK_DomesticHotWater", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DomesticHotWaters_DWHRs_DWHRId",
                        column: x => x.DWHRId,
                        principalTable: "DWHRs",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_DomesticHotWaters_TbDetails_EnergyFactorTypeId",
                        column: x => x.EnergyFactorTypeId,
                        principalTable: "TbDetails",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_DomesticHotWaters_TbDetails_EnergySrcTypeId",
                        column: x => x.EnergySrcTypeId,
                        principalTable: "TbDetails",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_DomesticHotWaters_TbDetails_TankTypeId",
                        column: x => x.TankTypeId,
                        principalTable: "TbDetails",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_DomesticHotWaters_TbDetails_TankVolumeTypeId",
                        column: x => x.TankVolumeTypeId,
                        principalTable: "TbDetails",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_DomesticHotWaters_TbDetails_UniformEnergyFactorId",
                        column: x => x.UniformEnergyFactorId,
                        principalTable: "TbDetails",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Type1s",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnergySrcType = table.Column<int>(type: "int", nullable: false),
                    DualFuelSystem = table.Column<bool>(type: "bit", nullable: true),
                    SwitchoverTemp = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    EquipmentTypeId = table.Column<long>(type: "bigint", nullable: true),
                    OutCapacityType = table.Column<int>(type: "int", nullable: false),
                    OutCapacityVal = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    OutCapacityUnit = table.Column<int>(type: "int", nullable: false),
                    SizingFactor = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    Efficiency = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    EfficiencyType = table.Column<int>(type: "int", nullable: false),
                    PilotLigth = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    FlueDiameter = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    EquipmentManufact = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    EquipmentModel = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ElectThemostatNum = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    EnergyStar = table.Column<bool>(type: "bit", nullable: true),
                    EPA_CSA = table.Column<bool>(type: "bit", nullable: true),
                    Type1Type = table.Column<int>(type: "int", nullable: false),
                    ComboTankPumpId = table.Column<long>(type: "bigint", nullable: true),
                    DWHRId = table.Column<long>(type: "bigint", nullable: true),
                    CREATORID = table.Column<int>(type: "int", nullable: false),
                    DATEINSERTED = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DATEMODIFIED = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LocationType = table.Column<long>(type: "bigint", nullable: true),
                    LocationId = table.Column<long>(type: "bigint", nullable: true),
                    UPDATERID = table.Column<int>(type: "int", nullable: true),
                    ISDELETE = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ES_PK_TYPE1", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Type1s_ComboTankAndPumps_ComboTankPumpId",
                        column: x => x.ComboTankPumpId,
                        principalTable: "ComboTankAndPumps",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Type1s_DWHRs_DWHRId",
                        column: x => x.DWHRId,
                        principalTable: "DWHRs",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Type1s_TbDetails_EquipmentTypeId",
                        column: x => x.EquipmentTypeId,
                        principalTable: "TbDetails",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "FuelMonthlyCostDatas",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JanuaryCostId = table.Column<long>(type: "bigint", nullable: true),
                    JunuaryCostID = table.Column<long>(type: "bigint", nullable: true),
                    FebruaryCostId = table.Column<long>(type: "bigint", nullable: true),
                    MarchCostId = table.Column<long>(type: "bigint", nullable: true),
                    AprilCostId = table.Column<long>(type: "bigint", nullable: true),
                    MayCostId = table.Column<long>(type: "bigint", nullable: true),
                    JuneCostId = table.Column<long>(type: "bigint", nullable: true),
                    JulyCostId = table.Column<long>(type: "bigint", nullable: true),
                    AugustCostId = table.Column<long>(type: "bigint", nullable: true),
                    SeptemberCostId = table.Column<long>(type: "bigint", nullable: true),
                    OctoberCostId = table.Column<long>(type: "bigint", nullable: true),
                    NovemberCostId = table.Column<long>(type: "bigint", nullable: true),
                    DecemberCostId = table.Column<long>(type: "bigint", nullable: true),
                    CREATORID = table.Column<int>(type: "int", nullable: false),
                    DATEINSERTED = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DATEMODIFIED = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LocationType = table.Column<long>(type: "bigint", nullable: true),
                    LocationId = table.Column<long>(type: "bigint", nullable: true),
                    UPDATERID = table.Column<int>(type: "int", nullable: true),
                    ISDELETE = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ES_PK_FUELMONTHLYCOSTDATA", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FuelMonthlyCostDatas_FuelCosts_AprilCostId",
                        column: x => x.AprilCostId,
                        principalTable: "FuelCosts",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_FuelMonthlyCostDatas_FuelCosts_AugustCostId",
                        column: x => x.AugustCostId,
                        principalTable: "FuelCosts",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_FuelMonthlyCostDatas_FuelCosts_DecemberCostId",
                        column: x => x.DecemberCostId,
                        principalTable: "FuelCosts",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_FuelMonthlyCostDatas_FuelCosts_FebruaryCostId",
                        column: x => x.FebruaryCostId,
                        principalTable: "FuelCosts",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_FuelMonthlyCostDatas_FuelCosts_JulyCostId",
                        column: x => x.JulyCostId,
                        principalTable: "FuelCosts",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_FuelMonthlyCostDatas_FuelCosts_JuneCostId",
                        column: x => x.JuneCostId,
                        principalTable: "FuelCosts",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_FuelMonthlyCostDatas_FuelCosts_JunuaryCostID",
                        column: x => x.JunuaryCostID,
                        principalTable: "FuelCosts",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_FuelMonthlyCostDatas_FuelCosts_MarchCostId",
                        column: x => x.MarchCostId,
                        principalTable: "FuelCosts",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_FuelMonthlyCostDatas_FuelCosts_MayCostId",
                        column: x => x.MayCostId,
                        principalTable: "FuelCosts",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_FuelMonthlyCostDatas_FuelCosts_NovemberCostId",
                        column: x => x.NovemberCostId,
                        principalTable: "FuelCosts",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_FuelMonthlyCostDatas_FuelCosts_OctoberCostId",
                        column: x => x.OctoberCostId,
                        principalTable: "FuelCosts",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_FuelMonthlyCostDatas_FuelCosts_SeptemberCostId",
                        column: x => x.SeptemberCostId,
                        principalTable: "FuelCosts",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "OntarioRefrences",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplyHosueholdOCID = table.Column<long>(type: "bigint", nullable: true),
                    AtypicalEnergyLoadID = table.Column<long>(type: "bigint", nullable: true),
                    WaterConservationId = table.Column<long>(type: "bigint", nullable: true),
                    ApplyRediOCAndESID = table.Column<long>(type: "bigint", nullable: true),
                    RefHouseID = table.Column<long>(type: "bigint", nullable: true),
                    GreenerHomeId = table.Column<long>(type: "bigint", nullable: true),
                    IndicatePresenceType = table.Column<int>(type: "int", nullable: false),
                    AirSeal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MainWalls = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ceillings = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CatchedralCeilling = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExposedFloor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Foundation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Windows = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Doors = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VentilationSys = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HotWaterSys = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HeatingSys = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CoolingSys = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Renewable = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WaterConser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdditionalComment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CREATORID = table.Column<int>(type: "int", nullable: false),
                    DATEINSERTED = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DATEMODIFIED = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LocationType = table.Column<long>(type: "bigint", nullable: true),
                    LocationId = table.Column<long>(type: "bigint", nullable: true),
                    UPDATERID = table.Column<int>(type: "int", nullable: true),
                    ISDELETE = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ES_PK_ONTARIOREFRENCE", x => x.ID);
                    table.ForeignKey(
                        name: "FK_OntarioRefrences_ATypicalEnergyLoads_AtypicalEnergyLoadID",
                        column: x => x.AtypicalEnergyLoadID,
                        principalTable: "ATypicalEnergyLoads",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_OntarioRefrences_greenerHomes_GreenerHomeId",
                        column: x => x.GreenerHomeId,
                        principalTable: "greenerHomes",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_OntarioRefrences_HouseHoldOCs_ApplyHosueholdOCID",
                        column: x => x.ApplyHosueholdOCID,
                        principalTable: "HouseHoldOCs",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_OntarioRefrences_RedusedOcs_ApplyRediOCAndESID",
                        column: x => x.ApplyRediOCAndESID,
                        principalTable: "RedusedOcs",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_OntarioRefrences_RefrenceHouses_RefHouseID",
                        column: x => x.RefHouseID,
                        principalTable: "RefrenceHouses",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_OntarioRefrences_WaterConservations_WaterConservationId",
                        column: x => x.WaterConservationId,
                        principalTable: "WaterConservations",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "HouseFile",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileId = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    PrevFileId = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    HouseId = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    HomeOwnerId = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    OwnershipId = table.Column<long>(type: "bigint", nullable: true),
                    TaxRollNum = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BuilderName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EvalDate = table.Column<TimeSpan>(type: "time", nullable: false),
                    EnteredBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Telephone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Extention = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    CompanyExtention = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    CompanyUser = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    CompanyTelephone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    MixedUse = table.Column<bool>(type: "bit", nullable: true),
                    ClientId = table.Column<long>(type: "bigint", nullable: true),
                    JustificationId = table.Column<long>(type: "bigint", nullable: true),
                    CREATORID = table.Column<int>(type: "int", nullable: false),
                    DATEINSERTED = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DATEMODIFIED = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LocationType = table.Column<long>(type: "bigint", nullable: true),
                    LocationId = table.Column<long>(type: "bigint", nullable: true),
                    UPDATERID = table.Column<int>(type: "int", nullable: true),
                    ISDELETE = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HouseFile", x => x.ID);
                    table.ForeignKey(
                        name: "FK_HouseFile_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_HouseFile_Justifications_JustificationId",
                        column: x => x.JustificationId,
                        principalTable: "Justifications",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "WallFloorConstructions",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InsulationConfigId = table.Column<long>(type: "bigint", nullable: true),
                    Overlap = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    PonyWallConsTypeId = table.Column<long>(type: "bigint", nullable: true),
                    PonyWallRValue = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    PonyWallCompositeId = table.Column<long>(type: "bigint", nullable: true),
                    WallConsInAddedInsId = table.Column<long>(type: "bigint", nullable: true),
                    WallConsInAddedInsRVal = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    WallConsCompositId = table.Column<long>(type: "bigint", nullable: true),
                    CoreWallType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CoreWallRVal = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    ExtAddInsTypeId = table.Column<long>(type: "bigint", nullable: true),
                    ExtAddInsRVal = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    ExtAddInsCompositId = table.Column<long>(type: "bigint", nullable: true),
                    Corners = table.Column<long>(type: "bigint", nullable: true),
                    LintelsId = table.Column<long>(type: "bigint", nullable: true),
                    FloorConsInsAddedSlabTypeId = table.Column<long>(type: "bigint", nullable: true),
                    FloorConsInsAddedSlabRVal = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    FloorAbvFoundTypeId = table.Column<long>(type: "bigint", nullable: true),
                    FloorAbvFoundRVal = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    FloorAbowFrostline = table.Column<bool>(type: "bit", nullable: true),
                    HeatedFloor = table.Column<bool>(type: "bit", nullable: true),
                    RValSkirtVal = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    RValThermalBreakVal = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    CREATORID = table.Column<int>(type: "int", nullable: false),
                    DATEINSERTED = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DATEMODIFIED = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LocationType = table.Column<long>(type: "bigint", nullable: true),
                    LocationId = table.Column<long>(type: "bigint", nullable: true),
                    UPDATERID = table.Column<int>(type: "int", nullable: true),
                    ISDELETE = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ES_PK_WALLFLOORCONSTRUCTION", x => x.ID);
                    table.ForeignKey(
                        name: "FK_WallFloorConstructions_CodeSelectors_FloorAbvFoundTypeId",
                        column: x => x.FloorAbvFoundTypeId,
                        principalTable: "CodeSelectors",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_WallFloorConstructions_CodeSelectors_WallConsInAddedInsId",
                        column: x => x.WallConsInAddedInsId,
                        principalTable: "CodeSelectors",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_WallFloorConstructions_Composites_ExtAddInsCompositId",
                        column: x => x.ExtAddInsCompositId,
                        principalTable: "Composites",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_WallFloorConstructions_Composites_PonyWallCompositeId",
                        column: x => x.PonyWallCompositeId,
                        principalTable: "Composites",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_WallFloorConstructions_Composites_WallConsCompositId",
                        column: x => x.WallConsCompositId,
                        principalTable: "Composites",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_WallFloorConstructions_InsulationConfigs_InsulationConfigId",
                        column: x => x.InsulationConfigId,
                        principalTable: "InsulationConfigs",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_WallFloorConstructions_LintelCodeSelectors_LintelsId",
                        column: x => x.LintelsId,
                        principalTable: "LintelCodeSelectors",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_WallFloorConstructions_TbDetails_ExtAddInsTypeId",
                        column: x => x.ExtAddInsTypeId,
                        principalTable: "TbDetails",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_WallFloorConstructions_TbDetails_FloorConsInsAddedSlabTypeId",
                        column: x => x.FloorConsInsAddedSlabTypeId,
                        principalTable: "TbDetails",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_WallFloorConstructions_TbDetails_PonyWallConsTypeId",
                        column: x => x.PonyWallConsTypeId,
                        principalTable: "TbDetails",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Walls",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Lable = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    FaceDirId = table.Column<long>(type: "bigint", nullable: true),
                    WallTypeId = table.Column<long>(type: "bigint", nullable: true),
                    LintelTypeId = table.Column<long>(type: "bigint", nullable: true),
                    Corners = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    Intersection = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    Heigth = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    Primeter = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    Area = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    AdjustEnclosedUncondSPC = table.Column<bool>(type: "bit", nullable: true),
                    RValue = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    CREATORID = table.Column<int>(type: "int", nullable: false),
                    DATEINSERTED = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DATEMODIFIED = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LocationType = table.Column<long>(type: "bigint", nullable: true),
                    LocationId = table.Column<long>(type: "bigint", nullable: true),
                    UPDATERID = table.Column<int>(type: "int", nullable: true),
                    ISDELETE = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ES_PK_WALLS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Walls_CodeSelectors_WallTypeId",
                        column: x => x.WallTypeId,
                        principalTable: "CodeSelectors",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Walls_LintelCodeSelectors_LintelTypeId",
                        column: x => x.LintelTypeId,
                        principalTable: "LintelCodeSelectors",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Walls_TbDetails_FaceDirId",
                        column: x => x.FaceDirId,
                        principalTable: "TbDetails",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Ventilations",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequireUseTypeId = table.Column<long>(type: "bigint", nullable: true),
                    RequireACH = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    RequireSupply = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    RequireExhaust = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    RequireDeviceOver75l = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    AirDistCircType = table.Column<int>(type: "int", nullable: false),
                    AirDistCircFanPwrType = table.Column<int>(type: "int", nullable: false),
                    AirDistCircFanPwrVal = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    OperationScheduleTypeId = table.Column<long>(type: "bigint", nullable: true),
                    OperationScheduleVal = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    TempControlVentiLow = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    TempControlVentiUp = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    RoomInputId = table.Column<long>(type: "bigint", nullable: true),
                    CREATORID = table.Column<int>(type: "int", nullable: false),
                    DATEINSERTED = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DATEMODIFIED = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LocationType = table.Column<long>(type: "bigint", nullable: true),
                    LocationId = table.Column<long>(type: "bigint", nullable: true),
                    UPDATERID = table.Column<int>(type: "int", nullable: true),
                    ISDELETE = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ES_PK_VENTILATION", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Ventilations_RoomsInputs_RoomInputId",
                        column: x => x.RoomInputId,
                        principalTable: "RoomsInputs",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Ventilations_TbDetails_OperationScheduleTypeId",
                        column: x => x.OperationScheduleTypeId,
                        principalTable: "TbDetails",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Ventilations_TbDetails_RequireUseTypeId",
                        column: x => x.RequireUseTypeId,
                        principalTable: "TbDetails",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "AirLeakages",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TEST_CONDITIONS = table.Column<int>(type: "int", nullable: false),
                    OutsideTemp = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    BarometricPressure = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    TestTypeId = table.Column<long>(type: "bigint", nullable: true),
                    FlowCoEff = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    FlowExponent = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    CorrelationCoEff = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    HeatedVolume = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    ACH = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    ELA = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    RelativeError = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    Test1Equip1Id = table.Column<long>(type: "bigint", nullable: true),
                    Test1Equip2Id = table.Column<long>(type: "bigint", nullable: true),
                    CREATORID = table.Column<int>(type: "int", nullable: false),
                    DATEINSERTED = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DATEMODIFIED = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LocationType = table.Column<long>(type: "bigint", nullable: true),
                    LocationId = table.Column<long>(type: "bigint", nullable: true),
                    UPDATERID = table.Column<int>(type: "int", nullable: true),
                    ISDELETE = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AirLeakages", x => x.ID);
                    table.ForeignKey(
                        name: "FK_AirLeakages_TbDetails_TestTypeId",
                        column: x => x.TestTypeId,
                        principalTable: "TbDetails",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_AirLeakages_TestEquips_Test1Equip1Id",
                        column: x => x.Test1Equip1Id,
                        principalTable: "TestEquips",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_AirLeakages_TestEquips_Test1Equip2Id",
                        column: x => x.Test1Equip2Id,
                        principalTable: "TestEquips",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "TestEquipDatas",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestId = table.Column<long>(type: "bigint", nullable: true),
                    HsePressurePa = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    FanPressurePa = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    MeasuredFlowCfm = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    FlowRanged = table.Column<int>(type: "int", nullable: false),
                    MeasuredFlowCfmRes = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    CorrectPressurePa = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    CorrectFlowCfm = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    CREATORID = table.Column<int>(type: "int", nullable: false),
                    DATEINSERTED = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DATEMODIFIED = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LocationType = table.Column<long>(type: "bigint", nullable: true),
                    LocationId = table.Column<long>(type: "bigint", nullable: true),
                    UPDATERID = table.Column<int>(type: "int", nullable: true),
                    ISDELETE = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestEquipDatas", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TestEquipDatas_TestEquips_TestId",
                        column: x => x.TestId,
                        principalTable: "TestEquips",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "HeatingAndCoolings",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type1Id = table.Column<long>(type: "bigint", nullable: true),
                    Type2Id = table.Column<long>(type: "bigint", nullable: true),
                    AccountForShading = table.Column<bool>(type: "bit", nullable: true),
                    RadiantHeatingId = table.Column<long>(type: "bigint", nullable: true),
                    AditionalOpeningId = table.Column<long>(type: "bigint", nullable: true),
                    SupHeatSys = table.Column<long>(type: "bigint", nullable: true),
                    SeasonCoolStartMon = table.Column<int>(type: "int", nullable: false),
                    SeasonCoolEndMon = table.Column<int>(type: "int", nullable: false),
                    SeasonCoolDesignMon = table.Column<int>(type: "int", nullable: false),
                    FanPumpId = table.Column<long>(type: "bigint", nullable: true),
                    CsaComHeatId = table.Column<long>(type: "bigint", nullable: true),
                    CREATORID = table.Column<int>(type: "int", nullable: false),
                    DATEINSERTED = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DATEMODIFIED = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LocationType = table.Column<long>(type: "bigint", nullable: true),
                    LocationId = table.Column<long>(type: "bigint", nullable: true),
                    UPDATERID = table.Column<int>(type: "int", nullable: true),
                    ISDELETE = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ES_PK_HEATINGANDCOOLING", x => x.ID);
                    table.ForeignKey(
                        name: "FK_HeatingAndCoolings_AdditionalOpenings_AditionalOpeningId",
                        column: x => x.AditionalOpeningId,
                        principalTable: "AdditionalOpenings",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_HeatingAndCoolings_CSATestedComboHeatings_CsaComHeatId",
                        column: x => x.CsaComHeatId,
                        principalTable: "CSATestedComboHeatings",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_HeatingAndCoolings_FansAndPumps_FanPumpId",
                        column: x => x.FanPumpId,
                        principalTable: "FansAndPumps",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_HeatingAndCoolings_Radiants_RadiantHeatingId",
                        column: x => x.RadiantHeatingId,
                        principalTable: "Radiants",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_HeatingAndCoolings_Type1s_Type1Id",
                        column: x => x.Type1Id,
                        principalTable: "Type1s",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_HeatingAndCoolings_Type2s_Type2Id",
                        column: x => x.Type2Id,
                        principalTable: "Type2s",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "HouseWeathers",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HouseId = table.Column<long>(type: "bigint", nullable: true),
                    WeatherLib = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    RegionId = table.Column<long>(type: "bigint", nullable: true),
                    LocationsId = table.Column<long>(type: "bigint", nullable: true),
                    DEPTH_FROST = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    HEATINGDEGREEDAYS = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    CREATORID = table.Column<int>(type: "int", nullable: false),
                    DATEINSERTED = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DATEMODIFIED = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LocationType = table.Column<long>(type: "bigint", nullable: true),
                    LocationId = table.Column<long>(type: "bigint", nullable: true),
                    UPDATERID = table.Column<int>(type: "int", nullable: true),
                    ISDELETE = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ES_PK_HOUSEWEATHER", x => x.ID);
                    table.ForeignKey(
                        name: "FK_HouseWeathers_HouseFile_HouseId",
                        column: x => x.HouseId,
                        principalTable: "HouseFile",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_HouseWeathers_Locations_LocationsId",
                        column: x => x.LocationsId,
                        principalTable: "Locations",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_HouseWeathers_Regions_RegionId",
                        column: x => x.RegionId,
                        principalTable: "Regions",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "UnitsModes",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HouseId = table.Column<long>(type: "bigint", nullable: true),
                    DisplayUnitType = table.Column<int>(type: "int", nullable: false),
                    ProgramsTypeId = table.Column<long>(type: "bigint", nullable: true),
                    CREATORID = table.Column<int>(type: "int", nullable: false),
                    DATEINSERTED = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DATEMODIFIED = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LocationType = table.Column<long>(type: "bigint", nullable: true),
                    LocationId = table.Column<long>(type: "bigint", nullable: true),
                    UPDATERID = table.Column<int>(type: "int", nullable: true),
                    ISDELETE = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ES_PK_UNITSMODE", x => x.ID);
                    table.ForeignKey(
                        name: "FK_UnitsModes_HouseFile_HouseId",
                        column: x => x.HouseId,
                        principalTable: "HouseFile",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_UnitsModes_TbDetails_ProgramsTypeId",
                        column: x => x.ProgramsTypeId,
                        principalTable: "TbDetails",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "HouseComponents",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VentilationSysId = table.Column<long>(type: "bigint", nullable: true),
                    VentilatorFanTypeId = table.Column<long>(type: "bigint", nullable: true),
                    VentilatorDetailId = table.Column<long>(type: "bigint", nullable: true),
                    SupplyFlowRate = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    ExhaustFlowRate = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    ComponentType = table.Column<int>(type: "int", nullable: false),
                    VentilationID = table.Column<long>(type: "bigint", nullable: true),
                    CREATORID = table.Column<int>(type: "int", nullable: false),
                    DATEINSERTED = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DATEMODIFIED = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LocationType = table.Column<long>(type: "bigint", nullable: true),
                    LocationId = table.Column<long>(type: "bigint", nullable: true),
                    UPDATERID = table.Column<int>(type: "int", nullable: true),
                    ISDELETE = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ES_PK_HOUSECOMPONENTS", x => x.ID);
                    table.ForeignKey(
                        name: "ES_FK_HC_VENTILATION_VENTILATIONSYS",
                        column: x => x.VentilationSysId,
                        principalTable: "Ventilations",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_HouseComponents_TbDetails_VentilatorFanTypeId",
                        column: x => x.VentilatorFanTypeId,
                        principalTable: "TbDetails",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_HouseComponents_Ventilations_VentilationID",
                        column: x => x.VentilationID,
                        principalTable: "Ventilations",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "NaturalAirInfiltrations",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HouseVolume = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    AirTigthnessTypeId = table.Column<long>(type: "bigint", nullable: true),
                    BuildingSiteTerrainId = table.Column<long>(type: "bigint", nullable: true),
                    AboveGradeHeigth = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    DepressTestType = table.Column<int>(type: "int", nullable: false),
                    DepressTestResult = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    AirLeakageTestId = table.Column<long>(type: "bigint", nullable: true),
                    Guarded = table.Column<bool>(type: "bit", nullable: true),
                    AirChangeRate = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    TestType = table.Column<int>(type: "int", nullable: false),
                    EquvalLeakageAreaType = table.Column<int>(type: "int", nullable: false),
                    EquvalLeakageAreaVal = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    EquvalLeakageAreaAt = table.Column<int>(type: "int", nullable: false),
                    LocalShadeWallTypeId = table.Column<long>(type: "bigint", nullable: true),
                    LocalShadeFlueType = table.Column<int>(type: "int", nullable: false),
                    CommonSurFloor = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    CommonSurWalls = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    CommonSurCeilings = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    CommonSurTot = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    WeatherStTerrainTypeId = table.Column<long>(type: "bigint", nullable: true),
                    WeatherStTerrainAnemHeight = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    LeakageFracType = table.Column<int>(type: "int", nullable: false),
                    LeakageFracCeillings = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    LeakageFracWalls = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    LeakageFracFloors = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    CREATORID = table.Column<int>(type: "int", nullable: false),
                    DATEINSERTED = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DATEMODIFIED = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LocationType = table.Column<long>(type: "bigint", nullable: true),
                    LocationId = table.Column<long>(type: "bigint", nullable: true),
                    UPDATERID = table.Column<int>(type: "int", nullable: true),
                    ISDELETE = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NaturalAirInfiltrations", x => x.ID);
                    table.ForeignKey(
                        name: "FK_NaturalAirInfiltrations_AirLeakages_AirLeakageTestId",
                        column: x => x.AirLeakageTestId,
                        principalTable: "AirLeakages",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_NaturalAirInfiltrations_TbDetails_AirTigthnessTypeId",
                        column: x => x.AirTigthnessTypeId,
                        principalTable: "TbDetails",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_NaturalAirInfiltrations_TbDetails_BuildingSiteTerrainId",
                        column: x => x.BuildingSiteTerrainId,
                        principalTable: "TbDetails",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_NaturalAirInfiltrations_TbDetails_LocalShadeWallTypeId",
                        column: x => x.LocalShadeWallTypeId,
                        principalTable: "TbDetails",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_NaturalAirInfiltrations_TbDetails_WeatherStTerrainTypeId",
                        column: x => x.WeatherStTerrainTypeId,
                        principalTable: "TbDetails",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AirLeakages_Test1Equip1Id",
                table: "AirLeakages",
                column: "Test1Equip1Id");

            migrationBuilder.CreateIndex(
                name: "IX_AirLeakages_Test1Equip2Id",
                table: "AirLeakages",
                column: "Test1Equip2Id");

            migrationBuilder.CreateIndex(
                name: "IX_AirLeakages_TestTypeId",
                table: "AirLeakages",
                column: "TestTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_BasementConfigs_IsulationId",
                table: "BasementConfigs",
                column: "IsulationId");

            migrationBuilder.CreateIndex(
                name: "IX_Ceilings_CeilTypeID",
                table: "Ceilings",
                column: "CeilTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Ceilings_ConstractTypeID",
                table: "Ceilings",
                column: "ConstractTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Ceilings_RoofSlopeTypeId",
                table: "Ceilings",
                column: "RoofSlopeTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_Regions2ID",
                table: "Clients",
                column: "Regions2ID");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_RegionsID",
                table: "Clients",
                column: "RegionsID");

            migrationBuilder.CreateIndex(
                name: "IX_CodeSelectors_ComponentTypeSizeId",
                table: "CodeSelectors",
                column: "ComponentTypeSizeId");

            migrationBuilder.CreateIndex(
                name: "IX_CodeSelectors_ExteriorId",
                table: "CodeSelectors",
                column: "ExteriorId");

            migrationBuilder.CreateIndex(
                name: "IX_CodeSelectors_InsulLay1Id",
                table: "CodeSelectors",
                column: "InsulLay1Id");

            migrationBuilder.CreateIndex(
                name: "IX_CodeSelectors_InsulLay2Id",
                table: "CodeSelectors",
                column: "InsulLay2Id");

            migrationBuilder.CreateIndex(
                name: "IX_CodeSelectors_InteriorId",
                table: "CodeSelectors",
                column: "InteriorId");

            migrationBuilder.CreateIndex(
                name: "IX_CodeSelectors_SheathingId",
                table: "CodeSelectors",
                column: "SheathingId");

            migrationBuilder.CreateIndex(
                name: "IX_CodeSelectors_SpacingId",
                table: "CodeSelectors",
                column: "SpacingId");

            migrationBuilder.CreateIndex(
                name: "IX_CodeSelectors_StructureTypeId",
                table: "CodeSelectors",
                column: "StructureTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_CodeSelectors_StudCornrIntersectId",
                table: "CodeSelectors",
                column: "StudCornrIntersectId");

            migrationBuilder.CreateIndex(
                name: "IX_ComboTankAndPumps_TankVolumeTypeId",
                table: "ComboTankAndPumps",
                column: "TankVolumeTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_CSATestedComboHeatings_CSAP9Id",
                table: "CSATestedComboHeatings",
                column: "CSAP9Id");

            migrationBuilder.CreateIndex(
                name: "IX_CSATestedComboHeatings_DWHRId",
                table: "CSATestedComboHeatings",
                column: "DWHRId");

            migrationBuilder.CreateIndex(
                name: "IX_DomesticHotWaters_DWHRId",
                table: "DomesticHotWaters",
                column: "DWHRId");

            migrationBuilder.CreateIndex(
                name: "IX_DomesticHotWaters_EnergyFactorTypeId",
                table: "DomesticHotWaters",
                column: "EnergyFactorTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_DomesticHotWaters_EnergySrcTypeId",
                table: "DomesticHotWaters",
                column: "EnergySrcTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_DomesticHotWaters_TankTypeId",
                table: "DomesticHotWaters",
                column: "TankTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_DomesticHotWaters_TankVolumeTypeId",
                table: "DomesticHotWaters",
                column: "TankVolumeTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_DomesticHotWaters_UniformEnergyFactorId",
                table: "DomesticHotWaters",
                column: "UniformEnergyFactorId");

            migrationBuilder.CreateIndex(
                name: "IX_Doors_DoorTypeId",
                table: "Doors",
                column: "DoorTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_DWHRs_ManufactureId",
                table: "DWHRs",
                column: "ManufactureId");

            migrationBuilder.CreateIndex(
                name: "IX_DWHRs_ModelId",
                table: "DWHRs",
                column: "ModelId");

            migrationBuilder.CreateIndex(
                name: "IX_DWHRs_ShowerHeadRateId",
                table: "DWHRs",
                column: "ShowerHeadRateId");

            migrationBuilder.CreateIndex(
                name: "IX_DWHRs_ShowerTemperatureId",
                table: "DWHRs",
                column: "ShowerTemperatureId");

            migrationBuilder.CreateIndex(
                name: "IX_ElectricalUsages_ClothsEnergySourceTypeID",
                table: "ElectricalUsages",
                column: "ClothsEnergySourceTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_ElectricalUsages_ClthRateValTypeID",
                table: "ElectricalUsages",
                column: "ClthRateValTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_ElectricalUsages_LigthDailyElecEnConsTypeID",
                table: "ElectricalUsages",
                column: "LigthDailyElecEnConsTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_ElectricalUsages_RefrigRateValTypeID",
                table: "ElectricalUsages",
                column: "RefrigRateValTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_ElectricalUsages_StoveEnergySourceTypeID",
                table: "ElectricalUsages",
                column: "StoveEnergySourceTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_ElectricalUsages_StoveRateValTypeID",
                table: "ElectricalUsages",
                column: "StoveRateValTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Floors_FloorTypeId",
                table: "Floors",
                column: "FloorTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_FuelCosts_ElectricityTypeId",
                table: "FuelCosts",
                column: "ElectricityTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_FuelCosts_NaturalGasTypeId",
                table: "FuelCosts",
                column: "NaturalGasTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_FuelCosts_OilTypeId",
                table: "FuelCosts",
                column: "OilTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_FuelCosts_PropaneTypeId",
                table: "FuelCosts",
                column: "PropaneTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_FuelCosts_WoodTypeId",
                table: "FuelCosts",
                column: "WoodTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_FuelMonthlyCostDatas_AprilCostId",
                table: "FuelMonthlyCostDatas",
                column: "AprilCostId");

            migrationBuilder.CreateIndex(
                name: "IX_FuelMonthlyCostDatas_AugustCostId",
                table: "FuelMonthlyCostDatas",
                column: "AugustCostId");

            migrationBuilder.CreateIndex(
                name: "IX_FuelMonthlyCostDatas_DecemberCostId",
                table: "FuelMonthlyCostDatas",
                column: "DecemberCostId");

            migrationBuilder.CreateIndex(
                name: "IX_FuelMonthlyCostDatas_FebruaryCostId",
                table: "FuelMonthlyCostDatas",
                column: "FebruaryCostId");

            migrationBuilder.CreateIndex(
                name: "IX_FuelMonthlyCostDatas_JulyCostId",
                table: "FuelMonthlyCostDatas",
                column: "JulyCostId");

            migrationBuilder.CreateIndex(
                name: "IX_FuelMonthlyCostDatas_JuneCostId",
                table: "FuelMonthlyCostDatas",
                column: "JuneCostId");

            migrationBuilder.CreateIndex(
                name: "IX_FuelMonthlyCostDatas_JunuaryCostID",
                table: "FuelMonthlyCostDatas",
                column: "JunuaryCostID");

            migrationBuilder.CreateIndex(
                name: "IX_FuelMonthlyCostDatas_MarchCostId",
                table: "FuelMonthlyCostDatas",
                column: "MarchCostId");

            migrationBuilder.CreateIndex(
                name: "IX_FuelMonthlyCostDatas_MayCostId",
                table: "FuelMonthlyCostDatas",
                column: "MayCostId");

            migrationBuilder.CreateIndex(
                name: "IX_FuelMonthlyCostDatas_NovemberCostId",
                table: "FuelMonthlyCostDatas",
                column: "NovemberCostId");

            migrationBuilder.CreateIndex(
                name: "IX_FuelMonthlyCostDatas_OctoberCostId",
                table: "FuelMonthlyCostDatas",
                column: "OctoberCostId");

            migrationBuilder.CreateIndex(
                name: "IX_FuelMonthlyCostDatas_SeptemberCostId",
                table: "FuelMonthlyCostDatas",
                column: "SeptemberCostId");

            migrationBuilder.CreateIndex(
                name: "IX_greenerHomes_RemoteComTypId",
                table: "greenerHomes",
                column: "RemoteComTypId");

            migrationBuilder.CreateIndex(
                name: "IX_HeatingAndCoolings_AditionalOpeningId",
                table: "HeatingAndCoolings",
                column: "AditionalOpeningId");

            migrationBuilder.CreateIndex(
                name: "IX_HeatingAndCoolings_CsaComHeatId",
                table: "HeatingAndCoolings",
                column: "CsaComHeatId");

            migrationBuilder.CreateIndex(
                name: "IX_HeatingAndCoolings_FanPumpId",
                table: "HeatingAndCoolings",
                column: "FanPumpId");

            migrationBuilder.CreateIndex(
                name: "IX_HeatingAndCoolings_RadiantHeatingId",
                table: "HeatingAndCoolings",
                column: "RadiantHeatingId");

            migrationBuilder.CreateIndex(
                name: "IX_HeatingAndCoolings_Type1Id",
                table: "HeatingAndCoolings",
                column: "Type1Id");

            migrationBuilder.CreateIndex(
                name: "IX_HeatingAndCoolings_Type2Id",
                table: "HeatingAndCoolings",
                column: "Type2Id");

            migrationBuilder.CreateIndex(
                name: "IX_HouseComponents_VentilationID",
                table: "HouseComponents",
                column: "VentilationID");

            migrationBuilder.CreateIndex(
                name: "IX_HouseComponents_VentilationSysId",
                table: "HouseComponents",
                column: "VentilationSysId");

            migrationBuilder.CreateIndex(
                name: "IX_HouseComponents_VentilatorFanTypeId",
                table: "HouseComponents",
                column: "VentilatorFanTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_HouseFile_ClientId",
                table: "HouseFile",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_HouseFile_JustificationId",
                table: "HouseFile",
                column: "JustificationId");

            migrationBuilder.CreateIndex(
                name: "IX_HouseWeathers_HouseId",
                table: "HouseWeathers",
                column: "HouseId");

            migrationBuilder.CreateIndex(
                name: "IX_HouseWeathers_LocationsId",
                table: "HouseWeathers",
                column: "LocationsId");

            migrationBuilder.CreateIndex(
                name: "IX_HouseWeathers_RegionId",
                table: "HouseWeathers",
                column: "RegionId");

            migrationBuilder.CreateIndex(
                name: "IX_HRVDucts_ExhaustLocationTypeId",
                table: "HRVDucts",
                column: "ExhaustLocationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_HRVDucts_SupplyLocationTypeId",
                table: "HRVDucts",
                column: "SupplyLocationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Justifications_EnergyStarTypeId",
                table: "Justifications",
                column: "EnergyStarTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_LintelCodeSelectors_InsulationId",
                table: "LintelCodeSelectors",
                column: "InsulationId");

            migrationBuilder.CreateIndex(
                name: "IX_LintelCodeSelectors_LintelTypeid",
                table: "LintelCodeSelectors",
                column: "LintelTypeid");

            migrationBuilder.CreateIndex(
                name: "IX_NaturalAirInfiltrations_AirLeakageTestId",
                table: "NaturalAirInfiltrations",
                column: "AirLeakageTestId");

            migrationBuilder.CreateIndex(
                name: "IX_NaturalAirInfiltrations_AirTigthnessTypeId",
                table: "NaturalAirInfiltrations",
                column: "AirTigthnessTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_NaturalAirInfiltrations_BuildingSiteTerrainId",
                table: "NaturalAirInfiltrations",
                column: "BuildingSiteTerrainId");

            migrationBuilder.CreateIndex(
                name: "IX_NaturalAirInfiltrations_LocalShadeWallTypeId",
                table: "NaturalAirInfiltrations",
                column: "LocalShadeWallTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_NaturalAirInfiltrations_WeatherStTerrainTypeId",
                table: "NaturalAirInfiltrations",
                column: "WeatherStTerrainTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_OntarioRefrences_ApplyHosueholdOCID",
                table: "OntarioRefrences",
                column: "ApplyHosueholdOCID");

            migrationBuilder.CreateIndex(
                name: "IX_OntarioRefrences_ApplyRediOCAndESID",
                table: "OntarioRefrences",
                column: "ApplyRediOCAndESID");

            migrationBuilder.CreateIndex(
                name: "IX_OntarioRefrences_AtypicalEnergyLoadID",
                table: "OntarioRefrences",
                column: "AtypicalEnergyLoadID");

            migrationBuilder.CreateIndex(
                name: "IX_OntarioRefrences_GreenerHomeId",
                table: "OntarioRefrences",
                column: "GreenerHomeId");

            migrationBuilder.CreateIndex(
                name: "IX_OntarioRefrences_RefHouseID",
                table: "OntarioRefrences",
                column: "RefHouseID");

            migrationBuilder.CreateIndex(
                name: "IX_OntarioRefrences_WaterConservationId",
                table: "OntarioRefrences",
                column: "WaterConservationId");

            migrationBuilder.CreateIndex(
                name: "IX_PhotovoltaicSystems_GenerationId",
                table: "PhotovoltaicSystems",
                column: "GenerationId");

            migrationBuilder.CreateIndex(
                name: "IX_PhotovoltaicSystems_ModuleTypeId",
                table: "PhotovoltaicSystems",
                column: "ModuleTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_RoofCavityInputs_GeExteriorMatTypeId",
                table: "RoofCavityInputs",
                column: "GeExteriorMatTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_RoofCavityInputs_GeSheathingMatTypeId",
                table: "RoofCavityInputs",
                column: "GeSheathingMatTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_RoofCavityInputs_SrRoofingMatTypeId",
                table: "RoofCavityInputs",
                column: "SrRoofingMatTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_RoofCavityInputs_SrSheathingMatTypeId",
                table: "RoofCavityInputs",
                column: "SrSheathingMatTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_FloorTypeId",
                table: "Rooms",
                column: "FloorTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_FounDationBelowTypeId",
                table: "Rooms",
                column: "FounDationBelowTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_RoomTypeId",
                table: "Rooms",
                column: "RoomTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomsInputs_VentedComAppLimitTypeId",
                table: "RoomsInputs",
                column: "VentedComAppLimitTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomsInputs_VentiRateOtherBaseTypeId",
                table: "RoomsInputs",
                column: "VentiRateOtherBaseTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TbDetails_HeadID",
                table: "TbDetails",
                column: "HeadID");

            migrationBuilder.CreateIndex(
                name: "IX_TestEquipDatas_TestId",
                table: "TestEquipDatas",
                column: "TestId");

            migrationBuilder.CreateIndex(
                name: "IX_TestEquips_FanTypeId",
                table: "TestEquips",
                column: "FanTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Type1s_ComboTankPumpId",
                table: "Type1s",
                column: "ComboTankPumpId");

            migrationBuilder.CreateIndex(
                name: "IX_Type1s_DWHRId",
                table: "Type1s",
                column: "DWHRId");

            migrationBuilder.CreateIndex(
                name: "IX_Type1s_EquipmentTypeId",
                table: "Type1s",
                column: "EquipmentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Type2s_WaterTempMonId",
                table: "Type2s",
                column: "WaterTempMonId");

            migrationBuilder.CreateIndex(
                name: "IX_UnitsModes_HouseId",
                table: "UnitsModes",
                column: "HouseId");

            migrationBuilder.CreateIndex(
                name: "IX_UnitsModes_ProgramsTypeId",
                table: "UnitsModes",
                column: "ProgramsTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Ventilations_OperationScheduleTypeId",
                table: "Ventilations",
                column: "OperationScheduleTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Ventilations_RequireUseTypeId",
                table: "Ventilations",
                column: "RequireUseTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Ventilations_RoomInputId",
                table: "Ventilations",
                column: "RoomInputId");

            migrationBuilder.CreateIndex(
                name: "IX_VentilatorFanTypeDetails_SchaduleOpTypeID",
                table: "VentilatorFanTypeDetails",
                column: "SchaduleOpTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_WallFloorConstructions_ExtAddInsCompositId",
                table: "WallFloorConstructions",
                column: "ExtAddInsCompositId");

            migrationBuilder.CreateIndex(
                name: "IX_WallFloorConstructions_ExtAddInsTypeId",
                table: "WallFloorConstructions",
                column: "ExtAddInsTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_WallFloorConstructions_FloorAbvFoundTypeId",
                table: "WallFloorConstructions",
                column: "FloorAbvFoundTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_WallFloorConstructions_FloorConsInsAddedSlabTypeId",
                table: "WallFloorConstructions",
                column: "FloorConsInsAddedSlabTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_WallFloorConstructions_InsulationConfigId",
                table: "WallFloorConstructions",
                column: "InsulationConfigId");

            migrationBuilder.CreateIndex(
                name: "IX_WallFloorConstructions_LintelsId",
                table: "WallFloorConstructions",
                column: "LintelsId");

            migrationBuilder.CreateIndex(
                name: "IX_WallFloorConstructions_PonyWallCompositeId",
                table: "WallFloorConstructions",
                column: "PonyWallCompositeId");

            migrationBuilder.CreateIndex(
                name: "IX_WallFloorConstructions_PonyWallConsTypeId",
                table: "WallFloorConstructions",
                column: "PonyWallConsTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_WallFloorConstructions_WallConsCompositId",
                table: "WallFloorConstructions",
                column: "WallConsCompositId");

            migrationBuilder.CreateIndex(
                name: "IX_WallFloorConstructions_WallConsInAddedInsId",
                table: "WallFloorConstructions",
                column: "WallConsInAddedInsId");

            migrationBuilder.CreateIndex(
                name: "IX_Walls_FaceDirId",
                table: "Walls",
                column: "FaceDirId");

            migrationBuilder.CreateIndex(
                name: "IX_Walls_LintelTypeId",
                table: "Walls",
                column: "LintelTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Walls_WallTypeId",
                table: "Walls",
                column: "WallTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_WaterUsages_BathFaucetFlowRateTypeId",
                table: "WaterUsages",
                column: "BathFaucetFlowRateTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_WaterUsages_ClthWasherRateValTypeID",
                table: "WaterUsages",
                column: "ClthWasherRateValTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_WaterUsages_ClthWasherTempTypeId",
                table: "WaterUsages",
                column: "ClthWasherTempTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_WaterUsages_DshWasherRateValTypeId",
                table: "WaterUsages",
                column: "DshWasherRateValTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_WaterUsages_ShowerTempTypeId",
                table: "WaterUsages",
                column: "ShowerTempTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_WaterUsages_ShwrHeadFlowRateId",
                table: "WaterUsages",
                column: "ShwrHeadFlowRateId");

            migrationBuilder.CreateIndex(
                name: "IX_Windows_OrientationId",
                table: "Windows",
                column: "OrientationId");

            migrationBuilder.CreateIndex(
                name: "IX_Windows_TiltTypeId",
                table: "Windows",
                column: "TiltTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BasementAttaches");

            migrationBuilder.DropTable(
                name: "BasementConfigs");

            migrationBuilder.DropTable(
                name: "Ceilings");

            migrationBuilder.DropTable(
                name: "CodeSummaries");

            migrationBuilder.DropTable(
                name: "Components");

            migrationBuilder.DropTable(
                name: "DomesticHotWaters");

            migrationBuilder.DropTable(
                name: "Doors");

            migrationBuilder.DropTable(
                name: "ElectricalUsages");

            migrationBuilder.DropTable(
                name: "Floors");

            migrationBuilder.DropTable(
                name: "FuelMonthlyCostDatas");

            migrationBuilder.DropTable(
                name: "HeatingAndCoolings");

            migrationBuilder.DropTable(
                name: "HouseComponents");

            migrationBuilder.DropTable(
                name: "HouseWeathers");

            migrationBuilder.DropTable(
                name: "HRVDucts");

            migrationBuilder.DropTable(
                name: "KeyValues");

            migrationBuilder.DropTable(
                name: "NaturalAirInfiltrations");

            migrationBuilder.DropTable(
                name: "OntarioRefrences");

            migrationBuilder.DropTable(
                name: "PhotovoltaicSystems");

            migrationBuilder.DropTable(
                name: "RoofCavityInputs");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "TestEquipDatas");

            migrationBuilder.DropTable(
                name: "UnitsModes");

            migrationBuilder.DropTable(
                name: "VentilatorFanTypeDetails");

            migrationBuilder.DropTable(
                name: "WallFloorConstructions");

            migrationBuilder.DropTable(
                name: "Walls");

            migrationBuilder.DropTable(
                name: "WaterUsages");

            migrationBuilder.DropTable(
                name: "Windows");

            migrationBuilder.DropTable(
                name: "FuelCosts");

            migrationBuilder.DropTable(
                name: "AdditionalOpenings");

            migrationBuilder.DropTable(
                name: "CSATestedComboHeatings");

            migrationBuilder.DropTable(
                name: "FansAndPumps");

            migrationBuilder.DropTable(
                name: "Radiants");

            migrationBuilder.DropTable(
                name: "Type1s");

            migrationBuilder.DropTable(
                name: "Type2s");

            migrationBuilder.DropTable(
                name: "Ventilations");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "AirLeakages");

            migrationBuilder.DropTable(
                name: "ATypicalEnergyLoads");

            migrationBuilder.DropTable(
                name: "greenerHomes");

            migrationBuilder.DropTable(
                name: "HouseHoldOCs");

            migrationBuilder.DropTable(
                name: "RedusedOcs");

            migrationBuilder.DropTable(
                name: "RefrenceHouses");

            migrationBuilder.DropTable(
                name: "WaterConservations");

            migrationBuilder.DropTable(
                name: "Generations");

            migrationBuilder.DropTable(
                name: "HouseFile");

            migrationBuilder.DropTable(
                name: "Composites");

            migrationBuilder.DropTable(
                name: "InsulationConfigs");

            migrationBuilder.DropTable(
                name: "CodeSelectors");

            migrationBuilder.DropTable(
                name: "LintelCodeSelectors");

            migrationBuilder.DropTable(
                name: "cSAP9TestDatas");

            migrationBuilder.DropTable(
                name: "ComboTankAndPumps");

            migrationBuilder.DropTable(
                name: "DWHRs");

            migrationBuilder.DropTable(
                name: "HeatPumpSourceTempMonthlies");

            migrationBuilder.DropTable(
                name: "RoomsInputs");

            migrationBuilder.DropTable(
                name: "TestEquips");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Justifications");

            migrationBuilder.DropTable(
                name: "Regions");

            migrationBuilder.DropTable(
                name: "TbDetails");

            migrationBuilder.DropTable(
                name: "TbHeads");
        }
    }
}
