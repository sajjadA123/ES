using Microsoft.EntityFrameworkCore;
using ES.Domain.Entity;
namespace ES.Domain
{
    public class DB : DbContext
    {
        public DB(DbContextOptions<DB> options) : base(options)
        {

        }

        //Table
        public DbSet<User> Users { get; set; }
        #region BaseInfo
        public DbSet<Entity.baseInfo.CodeSelector> CodeSelectors { get; set; }
        public DbSet<Entity.baseInfo.Composite> Composites { get; set; }
        public DbSet<Entity.baseInfo.KeyValue> KeyValues { get; set; }
        public DbSet<Entity.baseInfo.LintelCodeSelector> LintelCodeSelectors { get; set; }
        public DbSet<Entity.baseInfo.Location> Locations { get; set; }
        public DbSet<Entity.baseInfo.Regions> Regions { get; set; }
        public DbSet<Entity.baseInfo.TbDetail> TbDetails { get; set; }
        public DbSet<Entity.baseInfo.TbHead> TbHeads { get; set; }
        #endregion
        #region BaseLoad
        public DbSet<Entity.baseLoad.ElectricalUsage> ElectricalUsages { get; set; }
        public DbSet<Entity.baseLoad.WaterUsage> WaterUsages { get; set; }
        #endregion
        #region Common
        public DbSet<Entity.common.DWHR> DWHRs { get; set; }

        #endregion
        #region Components
        public DbSet<Entity.components.Ceiling> Ceilings { get; set; }
        public DbSet<Entity.components.Components> Components { get; set; }
        public DbSet<Entity.components.Door> Doors { get; set; }
        public DbSet<Entity.components.Floor> Floors { get; set; }
        public DbSet<Entity.components.Room> Rooms { get; set; }
        public DbSet<Entity.components.Walls> Walls { get; set; }
        public DbSet<Entity.components.Windows> Windows { get; set; }
        #endregion
        #region DomesticHotWater
        public DbSet<Entity.domesticHotWater.DomesticHotWater> DomesticHotWaters { get; set; }
        #endregion
        #region Foundation
        public DbSet<Entity.foundation.BasementAttach> BasementAttaches { get; set; }
        public DbSet<Entity.foundation.BasementConfig> BasementConfigs { get; set; }
        public DbSet<Entity.foundation.InsulationConfig> InsulationConfigs { get; set; }
        public DbSet<Entity.foundation.WallFloorConstruction> WallFloorConstructions { get; set; }
        #endregion
        #region Generation
        public DbSet<Entity.generation.Generation> Generations { get; set; }
        public DbSet<Entity.generation.PhotovoltaicSystem> PhotovoltaicSystems { get; set; }
        #endregion
        #region HeatingAndCooling
        public DbSet<Entity.heatingAndCooling.AdditionalOpening> AdditionalOpenings { get; set; }
        public DbSet<Entity.heatingAndCooling.ComboTankAndPump> ComboTankAndPumps { get; set; }
        public DbSet<Entity.heatingAndCooling.CSAP9TestData> cSAP9TestDatas { get; set; }
        public DbSet<Entity.heatingAndCooling.CSATestedComboHeating> CSATestedComboHeatings { get; set; }
        public DbSet<Entity.heatingAndCooling.FansAndPumps> FansAndPumps { get; set; }
        public DbSet<Entity.heatingAndCooling.HeatingAndCooling> HeatingAndCoolings { get; set; }
        public DbSet<Entity.heatingAndCooling.HeatPumpSourceTempMonthly> HeatPumpSourceTempMonthlies { get; set; }
        public DbSet<Entity.heatingAndCooling.Radiant> Radiants { get; set; }
        public DbSet<Entity.heatingAndCooling.Type1> Type1s { get; set; }
        public DbSet<Entity.heatingAndCooling.Type2> Type2s { get; set; }
        #endregion
        #region House
        public DbSet<Entity.house.Client> Clients { get; set; }
        public DbSet<Entity.house.CodeSummary> CodeSummaries { get; set; }
        public DbSet<Entity.house.HouseWeather> HouseWeathers { get; set; }
        public DbSet<Entity.house.Justification> Justifications { get; set; }
        public DbSet<Entity.house.RoofCavityInput> RoofCavityInputs { get; set; }
        public DbSet<Entity.house.UnitsMode> UnitsModes { get; set; }
        public DbSet<Entity.house.fuel.FuelCost> FuelCosts { get; set; }
        public DbSet<Entity.house.fuel.FuelMonthlyCostData> FuelMonthlyCostDatas { get; set; }
        #endregion
        #region NaturalAir
        public DbSet<Entity.naturalAir.AirLeakage> AirLeakages { get; set; }
        public DbSet<Entity.naturalAir.NaturalAirInfiltration> NaturalAirInfiltrations { get; set; }
        public DbSet<Entity.naturalAir.TestEquip> TestEquips { get; set; }
        public DbSet<Entity.naturalAir.TestEquipData> TestEquipDatas { get; set; }
        #endregion
        #region OntarioRefrence
        public DbSet<Entity.ontarioRefrence.ATypicalEnergyLoad> ATypicalEnergyLoads { get; set; }
        public DbSet<Entity.ontarioRefrence.GreenerHome> greenerHomes { get; set; }
        public DbSet<Entity.ontarioRefrence.HouseHoldOC> HouseHoldOCs { get; set; }
        public DbSet<Entity.ontarioRefrence.OntarioRefrence> OntarioRefrences { get; set; }
        public DbSet<Entity.ontarioRefrence.RedusedOc> RedusedOcs { get; set; }
        public DbSet<Entity.ontarioRefrence.RefrenceHouse> RefrenceHouses { get; set; }
        public DbSet<Entity.ontarioRefrence.WaterConservation> WaterConservations { get; set; }
        #endregion
        #region Ventilation
        public DbSet<Entity.ventilation.HouseComponents> HouseComponents { get; set; }
        public DbSet<Entity.ventilation.HRVDucts> HRVDucts { get; set; }
        public DbSet<Entity.ventilation.RoomsInput> RoomsInputs { get; set; }
        public DbSet<Entity.ventilation.Ventilation> Ventilations { get; set; }
        public DbSet<Entity.ventilation.VentilatorFanTypeDetail> VentilatorFanTypeDetails { get; set; }
        #endregion





        //View
        //public DbSet<User> ERC_USERS { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToView("ERC_USERS");
            #region Baseinfo
                 modelBuilder.Entity<Entity.baseInfo.CodeSelector>().HasKey(b => b.ID).HasName("ES_PK_CODESELECTOR");
                 modelBuilder.Entity<Entity.baseInfo.CodeSelector>().HasOne(b => b.StructureType).WithMany().HasConstraintName("ES_FK_CS_STRUCTURE_TB_DETAIL");
                 modelBuilder.Entity<Entity.baseInfo.CodeSelector>().HasOne(b => b.StudCornrIntersect).WithMany().HasConstraintName("ES_FK_CS_STUD_TB_DETAIL");
                 modelBuilder.Entity<Entity.baseInfo.CodeSelector>().HasOne(b => b.ComponentTypeSize).WithMany().HasConstraintName("ES_FK_CS_COM_TB_DETAIL");
                 modelBuilder.Entity<Entity.baseInfo.CodeSelector>().HasOne(b => b.Spacing).WithMany().HasConstraintName("ES_FK_CS_SPC_TB_DETAIL");
                 modelBuilder.Entity<Entity.baseInfo.CodeSelector>().HasOne(b => b.InsulLay1).WithMany().HasConstraintName("ES_FK_CS_InsL1_TB_DETAIL");
                 modelBuilder.Entity<Entity.baseInfo.CodeSelector>().HasOne(b => b.InsulLay2).WithMany().HasConstraintName("ES_FK_CS_InsL2_TB_DETAIL");
                 modelBuilder.Entity<Entity.baseInfo.CodeSelector>().HasOne(b => b.Interior).WithMany().HasConstraintName("ES_FK_CS_Iter_TB_DETAIL");
                 modelBuilder.Entity<Entity.baseInfo.CodeSelector>().HasOne(b => b.Sheathing).WithMany().HasConstraintName("ES_FK_CS_Sheathing_TB_DETAIL");
                 modelBuilder.Entity<Entity.baseInfo.CodeSelector>().HasOne(b => b.Exterior).WithMany().HasConstraintName("ES_FK_CS_EXTERIOR_TB_DETAIL");



            modelBuilder.Entity<Entity.baseInfo.Composite>().HasKey(b => b.ID).HasName("ES_PK_COMPOSITE");
            modelBuilder.Entity<Entity.baseInfo.Composite>().Property(b => b.EffRsi).HasColumnType("numeric(18,2)");
            modelBuilder.Entity<Entity.baseInfo.Composite>().Property(b => b.RemArea).HasColumnType("numeric(18,2)");
            modelBuilder.Entity<Entity.baseInfo.Composite>().Property(b => b.RemRsi).HasColumnType("numeric(18,2)");
            modelBuilder.Entity<Entity.baseInfo.Composite>().Property(b => b.Sec1Area).HasColumnType("numeric(18,2)");
            modelBuilder.Entity<Entity.baseInfo.Composite>().Property(b => b.Sec1Rsi).HasColumnType("numeric(18,2)");
            modelBuilder.Entity<Entity.baseInfo.Composite>().Property(b => b.Sec2Area).HasColumnType("numeric(18,2)");
            modelBuilder.Entity<Entity.baseInfo.Composite>().Property(b => b.Sec2Rsi).HasColumnType("numeric(18,2)");


            modelBuilder.Entity<Entity.baseInfo.KeyValue>().HasKey(b => b.ID).HasName("ES_PK_KEYVALUE");

                 modelBuilder.Entity<Entity.baseInfo.LintelCodeSelector>().HasKey(b => b.ID).HasName("ES_PK_LINTELCODESELECTOR");


            modelBuilder.Entity<Entity.baseInfo.Location>().HasKey(b => b.ID).HasName("ES_PK_LOCATION");
                 modelBuilder.Entity<Entity.baseInfo.Regions>().HasKey(b => b.ID).HasName("ES_PK_REGIONS");
                 modelBuilder.Entity<Entity.baseInfo.TbDetail>().HasKey(b => b.ID).HasName("ES_PK_TBDETAIL");
                 modelBuilder.Entity<Entity.baseInfo.TbHead>().HasKey(b => b.ID).HasName("ES_PK_TBHEAD");
            #endregion
            #region BaseLoad
            modelBuilder.Entity<Entity.baseLoad.ElectricalUsage>().HasKey(b => b.ID).HasName("ES_PK_ELECTRICALUSAGE");
            modelBuilder.Entity<Entity.baseLoad.ElectricalUsage>().Property(b => b.AvgExtUse).HasColumnType("numeric(18,2)");
            modelBuilder.Entity<Entity.baseLoad.ElectricalUsage>().Property(b => b.CLTH_ANNUAL_ENERGY_CONS_RATE).HasColumnType("numeric(18,2)");
            modelBuilder.Entity<Entity.baseLoad.ElectricalUsage>().Property(b => b.ClothWashLoadDryPer).HasColumnType("numeric(18,2)");
            modelBuilder.Entity<Entity.baseLoad.ElectricalUsage>().Property(b => b.LigthDailyElecEnConsVal).HasColumnType("numeric(18,2)");
            modelBuilder.Entity<Entity.baseLoad.ElectricalUsage>().Property(b => b.OtherElecLoad).HasColumnType("numeric(18,2)");
            modelBuilder.Entity<Entity.baseLoad.ElectricalUsage>().Property(b => b.RegrigAnnualEnConsRateYear).HasColumnType("numeric(18,2)");
            modelBuilder.Entity<Entity.baseLoad.ElectricalUsage>().Property(b => b.StoveAnnualEnConsRateYear).HasColumnType("numeric(18,2)");

            modelBuilder.Entity<Entity.baseLoad.WaterUsage>().HasKey(b => b.ID).HasName("ES_PK_WATERUSAGE");
            modelBuilder.Entity<Entity.baseLoad.WaterUsage>().Property(b => b.AvgShwrDur).HasColumnType("numeric(18,2)");
            modelBuilder.Entity<Entity.baseLoad.WaterUsage>().Property(b => b.BathFaucetUserPerOcc).HasColumnType("numeric(18,2)");
            modelBuilder.Entity<Entity.baseLoad.WaterUsage>().Property(b => b.ClthWasherClothNumPerOcc).HasColumnType("numeric(18,2)");
            modelBuilder.Entity<Entity.baseLoad.WaterUsage>().Property(b => b.ClthWasherRateAnnPerYear).HasColumnType("numeric(18,2)");
            modelBuilder.Entity<Entity.baseLoad.WaterUsage>().Property(b => b.ClthWasherRatePerCycle).HasColumnType("numeric(18,2)");
            modelBuilder.Entity<Entity.baseLoad.WaterUsage>().Property(b => b.DshWasherAnnualEnergyPerYear).HasColumnType("numeric(18,2)");
            modelBuilder.Entity<Entity.baseLoad.WaterUsage>().Property(b => b.DshWasherCycleNumPerOcc).HasColumnType("numeric(18,2)");
            modelBuilder.Entity<Entity.baseLoad.WaterUsage>().Property(b => b.DshWasherDishNumPerCycle).HasColumnType("numeric(18,2)");
            modelBuilder.Entity<Entity.baseLoad.WaterUsage>().Property(b => b.DshWasherRateWaterPerCycle).HasColumnType("numeric(18,2)");
            modelBuilder.Entity<Entity.baseLoad.WaterUsage>().Property(b => b.HotWaterTemp).HasColumnType("numeric(18,2)");
            modelBuilder.Entity<Entity.baseLoad.WaterUsage>().Property(b => b.LowFlushNum).HasColumnType("numeric(18,2)");
            modelBuilder.Entity<Entity.baseLoad.WaterUsage>().Property(b => b.OtherWaterConsPerDay).HasColumnType("numeric(18,2)");
            modelBuilder.Entity<Entity.baseLoad.WaterUsage>().Property(b => b.ShwrNumPerOcc).HasColumnType("numeric(18,2)");

            #endregion
            #region Common
            modelBuilder.Entity<Entity.common.DWHR>().HasKey(b => b.ID).HasName("ES_PK_DWHR");
            modelBuilder.Entity<Entity.common.DWHR>().Property(b => b.Efficiency).HasColumnType("numeric(18,2)");
            modelBuilder.Entity<Entity.common.DWHR>().Property(b => b.ShowerLength).HasColumnType("numeric(18,2)");
            modelBuilder.Entity<Entity.common.DWHR>().Property(b => b.ShowerPerDayNum).HasColumnType("numeric(18,2)");
            #endregion
            #region Component
            modelBuilder.Entity<Entity.components.Ceiling>().HasKey(b => b.ID).HasName("ES_PK_CEILING");
            modelBuilder.Entity<Entity.components.Ceiling>().Property(b => b.Area).HasColumnType("numeric(18,2)");
            modelBuilder.Entity<Entity.components.Ceiling>().Property(b => b.HeelHeigth).HasColumnType("numeric(18,2)");
            modelBuilder.Entity<Entity.components.Ceiling>().Property(b => b.Length).HasColumnType("numeric(18,2)");
            modelBuilder.Entity<Entity.components.Ceiling>().Property(b => b.RValue).HasColumnType("numeric(18,2)");
            modelBuilder.Entity<Entity.components.Ceiling>().Property(b => b.RoofSlopeValue).HasColumnType("numeric(18,2)");


            modelBuilder.Entity<Entity.components.Components>().HasKey(b => b.ID).HasName("ES_PK_COMPONENTS");
            modelBuilder.Entity<Entity.components.Door>().HasKey(b => b.ID).HasName("ES_PK_DOOR");
            modelBuilder.Entity<Entity.components.Door>().Property(b => b.GArea).HasColumnType("numeric(18,2)");
            modelBuilder.Entity<Entity.components.Door>().Property(b => b.Heigth).HasColumnType("numeric(18,2)");
            modelBuilder.Entity<Entity.components.Door>().Property(b => b.RValue).HasColumnType("numeric(18,2)");
            modelBuilder.Entity<Entity.components.Door>().Property(b => b.Width).HasColumnType("numeric(18,2)");


            modelBuilder.Entity<Entity.components.Floor>().HasKey(b => b.ID).HasName("ES_PK_FLOOR");
            modelBuilder.Entity<Entity.components.Floor>().Property(b => b.Area).HasColumnType("numeric(18,2)");
            modelBuilder.Entity<Entity.components.Floor>().Property(b => b.Heigth).HasColumnType("numeric(18,2)");
            modelBuilder.Entity<Entity.components.Floor>().Property(b => b.RValue).HasColumnType("numeric(18,2)");


            modelBuilder.Entity<Entity.components.Room>().HasKey(b => b.ID).HasName("ES_PK_ROOM");
            modelBuilder.Entity<Entity.components.Room>().Property(b => b.DimensionHeigth).HasColumnType("numeric(18,2)");
            modelBuilder.Entity<Entity.components.Room>().Property(b => b.DoorsGArea).HasColumnType("numeric(18,2)");
            modelBuilder.Entity<Entity.components.Room>().Property(b => b.DoorsNetArea).HasColumnType("numeric(18,2)");
            modelBuilder.Entity<Entity.components.Room>().Property(b => b.DoorsQty).HasColumnType("numeric(18,2)");
            modelBuilder.Entity<Entity.components.Room>().Property(b => b.ExtCeillingGArea).HasColumnType("numeric(18,2)");
            modelBuilder.Entity<Entity.components.Room>().Property(b => b.ExtCeillingNetArea).HasColumnType("numeric(18,2)");
            modelBuilder.Entity<Entity.components.Room>().Property(b => b.ExtCeillingQty).HasColumnType("numeric(18,2)");
            modelBuilder.Entity<Entity.components.Room>().Property(b => b.ExtFloorGArea).HasColumnType("numeric(18,2)");
            modelBuilder.Entity<Entity.components.Room>().Property(b => b.ExtFloorsQty).HasColumnType("numeric(18,2)");
            modelBuilder.Entity<Entity.components.Room>().Property(b => b.ExtWallsGArea).HasColumnType("numeric(18,2)");
            modelBuilder.Entity<Entity.components.Room>().Property(b => b.ExtWallsNetArea).HasColumnType("numeric(18,2)");


            modelBuilder.Entity<Entity.components.Walls>().HasKey(b => b.ID).HasName("ES_PK_WALLS");
            modelBuilder.Entity<Entity.components.Windows>().HasKey(b => b.ID).HasName("ES_PK_WINDOWS");
            #endregion
            #region DomesticHotWater
            modelBuilder.Entity<Entity.domesticHotWater.DomesticHotWater>().HasKey(b => b.ID).HasName("ES_PK_DomesticHotWater");
            #endregion
            #region Foundation
            modelBuilder.Entity<Entity.foundation.BasementAttach>().HasKey(b => b.ID).HasName("ES_PK_BASEMENTATTACH");
            modelBuilder.Entity<Entity.foundation.BasementConfig>().HasKey(b => b.ID).HasName("ES_PK_BASEMENTCONFIG");
            modelBuilder.Entity<Entity.foundation.InsulationConfig>().HasKey(b => b.ID).HasName("ES_PK_INSULATIONCONFIG");
            modelBuilder.Entity<Entity.foundation.WallFloorConstruction>().HasKey(b => b.ID).HasName("ES_PK_WALLFLOORCONSTRUCTION");;
            #endregion
            #region Generation
            modelBuilder.Entity<Entity.generation.Generation>().HasKey(b => b.ID).HasName("ES_PK_GENERATION");
            modelBuilder.Entity<Entity.generation.PhotovoltaicSystem>().HasKey(b => b.ID).HasName("ES_PK_PHOTOVOLTAICSYSTEM");
            #endregion
            #region HeatingAndCooling
            modelBuilder.Entity<Entity.heatingAndCooling.AdditionalOpening>().HasKey(b => b.ID).HasName("ES_PK_ADDITIONALOPENING");
            modelBuilder.Entity<Entity.heatingAndCooling.ComboTankAndPump>().HasKey(b => b.ID).HasName("ES_PK_COMBOTANKANDPUMP");
            modelBuilder.Entity<Entity.heatingAndCooling.CSAP9TestData>().HasKey(b => b.ID).HasName("ES_PK_CSAP9TESTDATA");
            modelBuilder.Entity<Entity.heatingAndCooling.CSATestedComboHeating>().HasKey(b => b.ID).HasName("ES_PK_CSATESTEDCOMBOHEATING");
            modelBuilder.Entity<Entity.heatingAndCooling.FansAndPumps>().HasKey(b => b.ID).HasName("ES_PK_FANSANDPUMPS");
            modelBuilder.Entity<Entity.heatingAndCooling.HeatingAndCooling>().HasKey(b => b.ID).HasName("ES_PK_HEATINGANDCOOLING");
            modelBuilder.Entity<Entity.heatingAndCooling.HeatPumpSourceTempMonthly>().HasKey(b => b.ID).HasName("ES_PK_HEATPUMPSOURCETEMPMONTHLY");
            modelBuilder.Entity<Entity.heatingAndCooling.Radiant>().HasKey(b => b.ID).HasName("ES_PK_RADIANT");
            modelBuilder.Entity<Entity.heatingAndCooling.Type1>().HasKey(b => b.ID).HasName("ES_PK_TYPE1");
            modelBuilder.Entity<Entity.heatingAndCooling.Type2>().HasKey(b => b.ID).HasName("ES_PK_TYPE2");
            #endregion
            #region House
            modelBuilder.Entity<Entity.house.Client>().HasKey(b => b.ID).HasName("ES_PK_CLIENT");
            modelBuilder.Entity<Entity.house.CodeSummary>().HasKey(b => b.ID).HasName("ES_PK_CODESUMMARY");
            modelBuilder.Entity<Entity.house.HouseWeather>().HasKey(b => b.ID).HasName("ES_PK_HOUSEWEATHER");
            modelBuilder.Entity<Entity.house.Justification>().HasKey(b => b.ID).HasName("ES_PK_JUSTIFICATION");
            modelBuilder.Entity<Entity.house.RoofCavityInput>().HasKey(b => b.ID).HasName("ES_PK_ROOFCAVITYINPUT");
            modelBuilder.Entity<Entity.house.UnitsMode>().HasKey(b => b.ID).HasName("ES_PK_UNITSMODE");
            #region Fuel
            modelBuilder.Entity<Entity.house.fuel.FuelCost>().HasKey(b => b.ID).HasName("ES_PK_FUELCOST");
            modelBuilder.Entity<Entity.house.fuel.FuelMonthlyCostData>().HasKey(b => b.ID).HasName("ES_PK_FUELMONTHLYCOSTDATA");
            #endregion
            #endregion
            #region NaturalAir
            modelBuilder.Entity<Entity.baseInfo.CodeSelector>().HasKey(b => b.ID).HasName("ES_PK_CODESELECTOR");
            modelBuilder.Entity<Entity.baseInfo.Composite>().HasKey(b => b.ID).HasName("ES_PK_COMPOSITE");
            modelBuilder.Entity<Entity.baseInfo.KeyValue>().HasKey(b => b.ID).HasName("ES_PK_KEYVALUE");
            modelBuilder.Entity<Entity.baseInfo.LintelCodeSelector>().HasKey(b => b.ID).HasName("ES_PK_LINTELCODESELECTOR");
            modelBuilder.Entity<Entity.baseInfo.Location>().HasKey(b => b.ID).HasName("ES_PK_LOCATION");
            modelBuilder.Entity<Entity.baseInfo.Regions>().HasKey(b => b.ID).HasName("ES_PK_REGIONS");
            modelBuilder.Entity<Entity.baseInfo.TbDetail>().HasKey(b => b.ID).HasName("ES_PK_TBDETAIL");
            modelBuilder.Entity<Entity.baseInfo.TbHead>().HasKey(b => b.ID).HasName("ES_PK_TBHEAD");
            #endregion
            #region ontarioRefrence
            modelBuilder.Entity<Entity.ontarioRefrence.ATypicalEnergyLoad>().HasKey(b => b.ID).HasName("ES_PK_ATYPICALENERGYLOAD");
            modelBuilder.Entity<Entity.ontarioRefrence.GreenerHome>().HasKey(b => b.ID).HasName("ES_PK_GREENERHOME");
            modelBuilder.Entity<Entity.ontarioRefrence.HouseHoldOC>().HasKey(b => b.ID).HasName("ES_PK_HOUSEHOLDOC");
            modelBuilder.Entity<Entity.ontarioRefrence.OntarioRefrence>().HasKey(b => b.ID).HasName("ES_PK_ONTARIOREFRENCE");
            modelBuilder.Entity<Entity.ontarioRefrence.RedusedOc>().HasKey(b => b.ID).HasName("ES_PK_REDUSEDOC");
            modelBuilder.Entity<Entity.ontarioRefrence.RefrenceHouse>().HasKey(b => b.ID).HasName("ES_PK_REFRENCEHOUSE");
            modelBuilder.Entity<Entity.ontarioRefrence.WaterConservation>().HasKey(b => b.ID).HasName("ES_PK_WATERCONSERVATION");
            #endregion
            #region Ventilation
            modelBuilder.Entity<Entity.ventilation.HouseComponents>().HasKey(b => b.ID).HasName("ES_PK_HOUSECOMPONENTS");
            modelBuilder.Entity<Entity.ventilation.HouseComponents>().HasOne(b => b.Ventilation).WithMany().HasConstraintName("ES_FK_HC_VENTILATION_VENTILATIONSYS");

            modelBuilder.Entity<Entity.ventilation.HRVDucts>().HasKey(b => b.ID).HasName("ES_PK_HRVDUCTS");
            modelBuilder.Entity<Entity.ventilation.RoomsInput>().HasKey(b => b.ID).HasName("ES_PK_ROOMSINPUT");
            modelBuilder.Entity<Entity.ventilation.Ventilation>().HasKey(b => b.ID).HasName("ES_PK_VENTILATION");
            modelBuilder.Entity<Entity.ventilation.VentilatorFanTypeDetail>().HasKey(b => b.ID).HasName("ES_PK_VENTILATORFANTYPEDETAIL");

            #endregion


            //modelBuilder.Entity<>().HasKey(b => b.ID).HasName("ERC_PK_MONTHS");
            //modelBuilder.Entity<Indicator>().HasKey(b => b.ID).HasName("ERC_PK_INDIC");
            //modelBuilder.Entity<Expertise>().HasKey(b => b.ID).HasName("ERC_PK_EXPERT");



            //modelBuilder.Entity<AssessmentTrustee>().HasKey(b => b.ID).HasName("ERC_PK_ASS");


            //modelBuilder.Entity<Grade>().HasKey(b => b.ID).HasName("ERC_PK_GRADE");


            //modelBuilder.Entity<UserExpertise>().HasKey(b => b.ID).HasName("ERC_PK_USEREXP");
            //modelBuilder.Entity<UserExpertise>().HasOne(e => e.EXPERTISE).WithMany().HasConstraintName("ERC_FK_USEREXP");
            //modelBuilder.Entity<UserExpertise>().HasOne(e => e.GRADE).WithMany().HasConstraintName("ERC_FK_GRADE");
            //modelBuilder.Entity<UserExpertise>().HasIndex(b => b.EXPERTISEID).HasName("ERC_IX_USEEX");
            //modelBuilder.Entity<UserExpertise>().HasIndex(b => b.USERID).HasName("ERC_IX_EXUSE");
            //modelBuilder.Entity<UserExpertise>().HasIndex(b => b.GRADEID).HasName("ERC_IX_GRADE");


            //modelBuilder.Entity<UnitDivision>().HasKey(b => b.ID).HasName("ERC_PK_UNIT");
            //modelBuilder.Entity<UnitDivision>().HasOne(e => e.PARENT).WithMany().HasConstraintName("ERC_FK_UNITPARENT");
            //modelBuilder.Entity<UnitDivision>().HasIndex(b => b.PARENTID).HasName("ERC_IX_UNITDPARENT");


            //modelBuilder.Entity<UnitDivisionUser>().HasKey(b => b.ID).HasName("ERC_PK_UNITUSER");
            //modelBuilder.Entity<UnitDivisionUser>().HasOne(e => e.UNITDIVISION).WithMany().HasConstraintName("ERC_FK_UNITUSER");
            //modelBuilder.Entity<UnitDivisionUser>().HasIndex(b => b.UNITDIVISIONID).HasName("ERC_IX_USUNIT");
            //modelBuilder.Entity<UnitDivisionUser>().HasIndex(b => b.USERID).HasName("ERC_IX_UNITUSE");


            //modelBuilder.Entity<UnitDivisionIndicator>().HasKey(b => b.ID).HasName("ERC_PK_UNITINDIC");
            //modelBuilder.Entity<UnitDivisionIndicator>().HasOne(e => e.INDICATOR).WithMany().HasConstraintName("ERC_FK_UNITINDIC");
            //modelBuilder.Entity<UnitDivisionIndicator>().HasOne(e => e.UNITDIVISION).WithMany().HasConstraintName("ERC_FK_UNITUNIT");
            //modelBuilder.Entity<UnitDivisionIndicator>().HasIndex(b => b.INDICATORID).HasName("ERC_IX_UNITINDIC");
            //modelBuilder.Entity<UnitDivisionIndicator>().HasIndex(b => b.UNITDIVISIONID).HasName("ERC_IX_INDICUNIT");


            //modelBuilder.Entity<MonthUserIndicator>().HasKey(b => b.ID).HasName("ERC_PK_MONUSINDIC");
            //modelBuilder.Entity<MonthUserIndicator>().HasOne(e => e.MONTHUSER).WithMany().HasConstraintName("ERC_FK_MONUSINDIC");
            //modelBuilder.Entity<MonthUserIndicator>().HasIndex(b => b.MONTHUSERID).HasName("ERC_IX_MONUSIND");


            //modelBuilder.Entity<MonthUserCommission>().HasKey(b => b.ID).HasName("ERC_PK_MONUSCOMM");
            //modelBuilder.Entity<MonthUserCommission>().HasIndex(b => b.USERID).HasName("ERC_IX_MONCOM");


            //modelBuilder.Entity<AssessmentTrusteeIndicator>().HasKey(b => b.ID).HasName("ERC_PK_ASTRSINDIC");
            //modelBuilder.Entity<AssessmentTrusteeIndicator>().HasOne(e => e.ASSESSMENTTRUSTEE).WithMany().HasConstraintName("ERC_FK_ASS");
            //modelBuilder.Entity<AssessmentTrusteeIndicator>().HasOne(e => e.INDICATOR).WithMany().HasConstraintName("ERC_FK_INDIC");
            //modelBuilder.Entity<AssessmentTrusteeIndicator>().HasIndex(b => b.ASSESSMENTTRUSTEEID).HasName("ERC_IX_ASSTRSIND");
            //modelBuilder.Entity<AssessmentTrusteeIndicator>().HasIndex(b => b.INDICATORID).HasName("ERC_IX_INDICASSTRS");


            //modelBuilder.Entity<AssessmentTrusteeUser>().HasKey(b => b.ID).HasName("ERC_PK_ASSUSER");
            //modelBuilder.Entity<AssessmentTrusteeUser>().HasOne(e => e.ASSESSMENTTRUSTEE).WithMany().HasConstraintName("ERC_FK_ASSUSER");
            //modelBuilder.Entity<AssessmentTrusteeUser>().HasIndex(b => b.ASSESSMENTTRUSTEEID).HasName("ERC_IX_ASSTRS");
            //modelBuilder.Entity<AssessmentTrusteeUser>().HasIndex(b => b.USERID).HasName("ERC_IX_ASSUSER");


            //modelBuilder.Entity<UserRole>().HasKey(b => b.ID).HasName("ERC_PK_USERROLE");
            //modelBuilder.Entity<UserRole>().HasIndex(b => b.USERID).HasName("ERC_IX_USROL");


            //modelBuilder.Entity<MonthUser>().HasKey(b => b.ID).HasName("ERC_PK_MONUSER");
            //modelBuilder.Entity<MonthUser>().HasIndex(b => b.USERID).HasName("ERC_IX_MONUSER");
        }
    }
}
