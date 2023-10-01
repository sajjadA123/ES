using ES.Common.Enums;
using ES.Core.Biz;
using ES.Core.Contracts.Entities;
using ES.Core.DataAccess;
using ES.Core.Module;
using ES.Domain.Entity;
using ES.DTOs.baseInfo;
using ES.DTOs.codes;
using ES.DTOs.components;
using ES.DTOs.house;
using ES.DTOs.house.fuel;
using ES.Service.Contracts;
using ES.Service.Contracts.baseinfo;
using ES.Service.Contracts.codes;
using ES.Service.Contracts.fuel;
using ES.Service.Modules.baseinfo;
using ES.Service.Modules.codes;
using ES.Service.Modules.fuelCost;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ES.Services.Modules
{
    public class HouseFileBiz : BaseBiz<HouseFile, HouseFileDTO>, IHouseFileBiz
    {
        UnitOfWork _unitOfWork;
        public HouseFileBiz(IUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }

        public HouseFileDTO GetHouseFileDTOFromFile(string fileName)
        {
            ca.nrcan.gc.OEE.HouseFileLibrary.HouseFile house = new ca.nrcan.gc.OEE.HouseFileLibrary.HouseFile();
            IBaseDetailBiz baseDetail = new BaseDetailBiz(_unitOfWork);
            string xml = File.ReadAllText(fileName);
            List<TbDetailDTO> s = new List<TbDetailDTO>();
            house.LoadFromString(xml);
            HouseFileDTO houseFileDTO = new HouseFileDTO(){
                FileId = house.ProgramInformation.File.Identification,
                PrevFileId = house.ProgramInformation.File.PreviousFileId,
                HomeOwnerId = house.ProgramInformation.File.HomeownerAuthorizationId,
                OwnerShip = baseDetail.GetByHeadCode("OWNERSHIP").Where(c => c.DETAIL_CODE == house.ProgramInformation.File.Ownership.Code).FirstOrDefault(),
                TaxRollNum = house.ProgramInformation.File.TaxNumber,
                BuilderName = house.ProgramInformation.File.BuilderName,
                EvalDate = new System.TimeSpan(house.ProgramInformation.File.EvaluationDate.Ticks),
                EnteredBy=house.ProgramInformation.File.EnteredBy,
                Telephone=house.ProgramInformation.File.UserTelephone,
                Extention=house.ProgramInformation.File.UserExtension,
                CompanyUser=house.ProgramInformation.File.Company,
                CompanyTelephone=house.ProgramInformation.File.CompanyTelephone,
                CompanyExtention=house.ProgramInformation.File.CompanyExtension,
                HouseClient=GetHouseClientDTO(house),
                MixedUse=house.ProgramInformation.Mixed,
                Justification=GetJustificationDTO(house.ProgramInformation.Justifications),
                HouseInfo=GetHouseInfoDTOs(house),
                HouseSpecification= GetHouseSpecificationDTO( house.House.Specifications),
                HouseWeather= GetHouseWeatherDTO(house.ProgramInformation.Weather),
                FuelCost= GetHouseFuelDTO(house.FuelCosts),
                UnitsMode= GetUnitsModeDTO(house.UiUnits),
                WinTightness= GetWinTightnessDTO( house.House.WindowTightness),
                //CodeSummary=hou
                Ventilation= GetVentilationDTO(house.House.Ventilation),
                Temperatures= GetTemperaturesDTO(house.House.Temperatures),
                BaseLoad= GetBaseLoadDTO(house.House.BaseLoads),
                Generation= GetGenerationDTO(house.House.Generation),
                NaturalAirInfiltration= GetNaturalAirInfiltrationDTO(house.House.NaturalAirInfiltration),
                HeatingAndCooling= GetHeatingAndCoolingDTO(house.House.HeatingCooling),
                Codes= GetCodesDTO(house.Codes),


            };
        }
        private List<IBaseComponent> InitialComponents(ca.nrcan.gc.OEE.HouseFileLibrary.HouseFile house)
        {
            List<IBaseComponent> components = new List<IBaseComponent>();
            foreach (ca.nrcan.gc.OEE.HouseFileLibrary.Components.BaseComponent item in house.HouseComponents)
            {
                if (item.GetType()== typeof(ca.nrcan.gc.OEE.HouseFileLibrary.Components.HotWaterComponents.HotWater))
                {
                    components.Add(GetDomesticHotWaterDTO((ca.nrcan.gc.OEE.HouseFileLibrary.Components.HotWaterComponents.HotWater)item));
                }
                if (item.GetType() == typeof(ca.nrcan.gc.OEE.HouseFileLibrary.Components.WallComponents.Wall))
                {
                    components.Add(GetWallsDTO((ca.nrcan.gc.OEE.HouseFileLibrary.Components.WallComponents.Wall)item));
                }
                if (item.GetType() == typeof(ca.nrcan.gc.OEE.HouseFileLibrary.Components.WindowComponents.Window))
                {

                }
                if (item.GetType() == typeof(ca.nrcan.gc.OEE.HouseFileLibrary.Components.RoomComponents.Room))
                {

                }
                if (item.GetType() == typeof(ca.nrcan.gc.OEE.HouseFileLibrary.Components.FloorHeaderComponents.FloorHeader))
                {

                }
                if (item.GetType() == typeof(ca.nrcan.gc.OEE.HouseFileLibrary.Components.FloorComponents.Floor))
                {

                }
                if (item.GetType() == typeof(ca.nrcan.gc.OEE.HouseFileLibrary.Components.DoorComponents.Door))
                {

                }
                if (item.GetType() == typeof(ca.nrcan.gc.OEE.HouseFileLibrary.Components.CeilingComponents.Ceiling))
                {

                }
            }
        }
        private DTOs.components.WindowsDTO GetWindowsDTO(ca.nrcan.gc.OEE.HouseFileLibrary.Components.WindowComponents.Window window)
        {
            IBaseDetailBiz baseDetail = new BaseDetailBiz(_unitOfWork);
            ICodesBiz codesBiz = new CodesBiz(_unitOfWork);
            return new DTOs.components.WindowsDTO()
            {
                Lable =window.Label,
                              

            };
        }
        private DTOs.components.WallsDTO GetWallsDTO(ca.nrcan.gc.OEE.HouseFileLibrary.Components.WallComponents.Wall wall)
        {
            IBaseDetailBiz baseDetail = new BaseDetailBiz(_unitOfWork);
            ICodesBiz codesBiz = new CodesBiz(_unitOfWork);
            return new DTOs.components.WallsDTO()
            {
                Lable=wall.Label,
                WallType=codesBiz.getByTypeAndCode(CodeTypes.Wall, wall.Construction.Type.IdRef),
                LintelType=codesBiz.getByTypeAndCode(CodeTypes.Lintel, wall.Construction.LintelType.Code),
                WallLocation=WallLocation.House,
                Corners=wall.Construction.Corners,
                Intersection=wall.Construction.Intersections,
                FaceDir=baseDetail.getByHeadCodeAndDetailCode("FaceDir", wall.FacingDirection.Code),
                Heigth=wall.Measurements.Height,
                Primeter=wall.Measurements.Perimeter,
                Area=wall.Measurements.Area,
                //RValue=wall.Construction.
                AdjustEnclosedUncondSPC=wall.AdjacentEnclosedSpace

            };
        }
        private CodesDTO GetCodesDTO(ca.nrcan.gc.OEE.HouseFileLibrary.CodesComponent.Codes codes)
        {
            IBaseDetailBiz baseDetail = new BaseDetailBiz(_unitOfWork);
            CodesDTO codesDTO = new CodesDTO();
            codesDTO.Wall = GetCodeByTypes(codes.Wall.Standard, false, CodeTypes.Wall);
            if (codesDTO.Wall == null) codesDTO.Wall = GetCodeByTypes(codes.Wall.Favorite, true, CodeTypes.Wall);
            else codesDTO.Wall.AddRange(GetCodeByTypes(codes.Wall.Favorite, true, CodeTypes.Wall));

            if (codesDTO.BasementWall == null) codesDTO.BasementWall = GetCodeByTypes(codes.BasementWall.Favorite, true, CodeTypes.BasementWall);
            else codesDTO.BasementWall.AddRange(GetCodeByTypes(codes.BasementWall.Favorite, true, CodeTypes.BasementWall));

            if (codesDTO.CrawlspaceWall == null) codesDTO.CrawlspaceWall = GetCodeByTypes(codes.CrawlspaceWall.Favorite, true, CodeTypes.CrawlspaceWall);
            else codesDTO.CrawlspaceWall.AddRange(GetCodeByTypes(codes.CrawlspaceWall.Favorite, true, CodeTypes.CrawlspaceWall));

            if (codesDTO.FloorsAbove == null) codesDTO.FloorsAbove = GetCodeByTypes(codes.FloorsAbove.Favorite, true, CodeTypes.FloorsAbove);
            else codesDTO.FloorsAbove.AddRange(GetCodeByTypes(codes.FloorsAbove.Favorite, true, CodeTypes.FloorsAbove));

            if (codesDTO.Ceiling == null) codesDTO.Ceiling = GetCodeByTypes(codes.Ceiling.Favorite, true, CodeTypes.Ceiling);
            else codesDTO.Ceiling.AddRange(GetCodeByTypes(codes.Ceiling.Favorite, true, CodeTypes.Ceiling));

            if (codesDTO.CeilingFlat == null) codesDTO.CeilingFlat = GetCodeByTypes(codes.CeilingFlat.Favorite, true, CodeTypes.CeilingFlat);
            else codesDTO.CeilingFlat.AddRange(GetCodeByTypes(codes.CeilingFlat.Favorite, true, CodeTypes.CeilingFlat));

            if (codesDTO.Floor == null) codesDTO.Floor = GetCodeByTypes(codes.Floor.Favorite, true, CodeTypes.Floor);
            else codesDTO.Floor.AddRange(GetCodeByTypes(codes.Floor.Favorite, true, CodeTypes.Floor));

            if (codesDTO.FloorsAdded == null) codesDTO.FloorsAdded = GetCodeByTypes(codes.FloorsAdded.Favorite, true, CodeTypes.FloorsAdded);
            else codesDTO.FloorsAdded.AddRange(GetCodeByTypes(codes.FloorsAdded.Favorite, true, CodeTypes.FloorsAdded));

            if (codesDTO.Lintel == null) codesDTO.Lintel = GetCodeByTypes(codes.Lintel.Favorite, true, CodeTypes.Lintel);
            else codesDTO.Lintel.AddRange(GetCodeByTypes(codes.Lintel.Favorite, true, CodeTypes.Lintel));

            if (codesDTO.FloorHeader == null) codesDTO.FloorHeader = GetCodeByTypes(codes.FloorHeader.Favorite, true, CodeTypes.FloorHeader);
            else codesDTO.FloorHeader.AddRange(GetCodeByTypes(codes.FloorHeader.Favorite, true, CodeTypes.FloorHeader));

            if (codesDTO.Window == null) codesDTO.Window = GetCodeByTypes(codes.Window.Favorite, true, CodeTypes.Window);
            else codesDTO.Window.AddRange(GetCodeByTypes(codes.Window.Favorite, true, CodeTypes.Window));
            return codesDTO;
        }
        private List<CodeByTypesDTO> GetCodeByTypes(List<ca.nrcan.gc.OEE.HouseFileLibrary.CodesComponent.Standard> standards,bool isFavorite,CodeTypes codeTypes)
        {
            IBaseDetailBiz baseDetail = new BaseDetailBiz(_unitOfWork);
            List<CodeByTypesDTO> codeByTypes = new List<CodeByTypesDTO>();
            foreach (var item in standards)
            {
                codeByTypes.Add(new CodeByTypesDTO()
                {
                    Value=item.Value,
                    CodeType= codeTypes,
                    IsFavorite=isFavorite,
                    InsulationInFramingLayer=baseDetail.getByHeadCodeAndDetailCode("InsulationInFramingLayer", item.Layers.InsulationInFramingLayer.Code),
                    ExtraInsulationLayer = baseDetail.getByHeadCodeAndDetailCode("ExtraInsulationLayer", item.Layers.ExtraInsulationLayer.Code),
                    ComponentTypeSize=baseDetail.getByHeadCodeAndDetailCode("ComponentTypeSize", item.Layers.ComponentTypeSize.Code),
                    CoatingsTints=baseDetail.getByHeadCodeAndDetailCode("CoatingsTints", item.Layers.CoatingsTints.Code),
                    StudsCornerIntersection=baseDetail.getByHeadCodeAndDetailCode("StudsCornerIntersection", item.Layers.StudsCornerIntersection.Code),
                    Exterior=baseDetail.getByHeadCodeAndDetailCode("Exterior", item.Layers.Exterior.Code),
                    FillType=baseDetail.getByHeadCodeAndDetailCode("FillType", item.Layers.FillType.Code),
                    DropFraming=baseDetail.getByHeadCodeAndDetailCode("DropFraming", item.Layers.DropFraming.Code),
                    FrameMaterial=baseDetail.getByHeadCodeAndDetailCode("FrameMaterial", item.Layers.FrameMaterial.Code),
                    Framing=baseDetail.getByHeadCodeAndDetailCode("Framing", item.Layers.Framing.Code),
                    GlazingTypes=baseDetail.getByHeadCodeAndDetailCode("GlazingTypes", item.Layers.GlazingTypes.Code),
                    Insulation=baseDetail.getByHeadCodeAndDetailCode("Insulation", item.Layers.Insulation.Code),
                    InsulationLayer1=baseDetail.getByHeadCodeAndDetailCode("InsulationLayer1", item.Layers.InsulationLayer1.Code),
                    InsulationLayer2=baseDetail.getByHeadCodeAndDetailCode("InsulationLayer2", item.Layers.InsulationLayer2.Code),
                    Interior=baseDetail.getByHeadCodeAndDetailCode("Interior", item.Layers.Interior.Code),
                    InteriorFinish=baseDetail.getByHeadCodeAndDetailCode("InteriorFinish", item.Layers.InteriorFinish.Code),
                    Material=baseDetail.getByHeadCodeAndDetailCode("Material", item.Layers.Material.Code),
                    Sheathing=baseDetail.getByHeadCodeAndDetailCode("Sheathing", item.Layers.Sheathing.Code),
                    SpacerType=baseDetail.getByHeadCodeAndDetailCode("SpacerType", item.Layers.SpacerType.Code),
                    Spacing=baseDetail.getByHeadCodeAndDetailCode("Spacing", item.Layers.Spacing.Code),
                    StructureType=baseDetail.getByHeadCodeAndDetailCode("StructureType", item.Layers.StructureType.Code),
                    Type=baseDetail.getByHeadCodeAndDetailCode("Type", item.Layers.Type.Code)
                    
                });
            }
            return codeByTypes;
        }

        private DTOs.domesticHotWater.HotWater GetHotWater(ca.nrcan.gc.OEE.HouseFileLibrary.Components.HotWaterComponents.HotWater hotWater)
        {
            IBaseDetailBiz baseDetail = new BaseDetailBiz(_unitOfWork);
            return new DTOs.domesticHotWater.HotWater()
            {
               Primary= GetDomesticHotWaterDTO(hotWater.Primary),
               Secondary= GetDomesticHotWaterDTO(hotWater.Secondary)
            };
        }
        private DTOs.domesticHotWater.DomesticHotWaterDTO GetDomesticHotWaterDTO(ca.nrcan.gc.OEE.HouseFileLibrary.Components.HotWaterComponents.HotWater hotWater)
        {
            IBaseDetailBiz baseDetail = new BaseDetailBiz(_unitOfWork);
            return new DTOs.domesticHotWater.DomesticHotWaterDTO()
            {
                EnergySrcType=baseDetail.getByHeadCodeAndDetailCode("EnergySrcType", hotWater.EnergySource.Code),
                TankType= baseDetail.getByHeadCodeAndDetailCode("TankType", hotWater.TankType.Code),
                TankVolumeType= baseDetail.getByHeadCodeAndDetailCode("TankVolumeType", hotWater.TankVolume.Code),
                TankVolumeVal=hotWater.TankVolume.Value,
                EnergyFactorType = baseDetail.getByHeadCodeAndDetailCode("EnergyFactorType", hotWater.EnergyFactor.Code),
                EnergyFactorVal=hotWater.EnergyFactor.Value,
                UniformEnergyFactor= hotWater.EnergyFactor.isUniform? baseDetail.getByHeadCodeAndDetailCode("UniformEnergyFactor", hotWater.EnergyFactor.Code):null,
                TankLocationType= baseDetail.getByHeadCodeAndDetailCode("TankLocationType", hotWater.TankLocation.Code),
                EqupmentManufac=hotWater.EquipmentInformation.Manufacturer,
                EqupmentModel=hotWater.EquipmentInformation.Model,
                EqupmentES=hotWater.EnergyStar,
                EqupmentEco=hotWater.EcoEnergy,
                InsulatingBlanket=hotWater.InsulatingBlanket,
                PilotEnergy=hotWater.PilotEnergy,
                FlueCombined=hotWater.CombinedFlue,
                FlueDiameter=hotWater.FlueDiameter,
                standbyHeatLoss=hotWater.EnergyFactor.StandbyHeatLoss,
                StandyHeatLossUnit = hotWater.EnergyFactor.StandbyHeatLossMode == 0 ? StandyHeatLossUnit.BTU : StandyHeatLossUnit.Hr,
                StandyThermalEfficiency=hotWater.EnergyFactor.ThermalEfficiency,
                StandyInputCap=hotWater.EnergyFactor.InputCapacity,
                Azimuth=hotWater.Solar.Azimuth,
                Slope=hotWater.Solar.Slope,
                CsaVal=hotWater.Solar.Rating,
                FractionOfTank=hotWater.Fraction,
                DWHR= GetDWHRDTO(hotWater.DrainWaterHeatRecovery),
            };
        }

        private DTOs.Common.DWHRDTO GetDWHRDTO(ca.nrcan.gc.OEE.HouseFileLibrary.Components.HotWaterComponents.DrainWaterHeatRecovery drainWater)
        {
            IBaseDetailBiz baseDetail = new BaseDetailBiz(_unitOfWork);
            return new DTOs.Common.DWHRDTO()
            {
                ShowerTemperature=baseDetail.getByHeadCodeAndDetailCode("ShowerTemperature", drainWater.ShowerTemperature.Code),
                ShowerLength=drainWater.ShowerLength,
                ShowerPerDayNum=drainWater.DailyShowers,
                ShowerHeadRate= baseDetail.getByHeadCodeAndDetailCode("ShowerHeadRate", drainWater.ShowerHead.Code),
                Configuration=drainWater.PreheatShowerTank?DWHRConfig.HeaterShower:DWHRConfig.HeaterOnly,
                Manufacture=drainWater.EquipmentInformation.Manufacturer,
                Model=drainWater.EquipmentInformation.Model,
                Efficiency=drainWater.Effectiveness


            };
        }

        private DTOs.heatingAndCooling.HeatingAndCoolingDTO GetHeatingAndCoolingDTO(ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.HeatingCooling heatingCooling)
        {
            IBaseDetailBiz baseDetail = new BaseDetailBiz(_unitOfWork);
            return new DTOs.heatingAndCooling.HeatingAndCoolingDTO()
            {
                Type1= GetType1(heatingCooling.Type1),
                Type2= GetType2(heatingCooling.Type2),
                AccountForShading=heatingCooling.Type2.ShadingInF280CoolingIsAccountedFor,
                RadiantHeating= GetRadiantDTO(heatingCooling.RadiantHeating),
                AditionalOpenings= GetAdditionalOpeningDTOs(heatingCooling.AdditionalOpenings),
                SupplHtgs= GetAdditionalOpeningDTOs(heatingCooling.SupplementaryHeating)

            };
        }
        private List<DTOs.heatingAndCooling.SupplHtgDTO> GetAdditionalOpeningDTOs(List<ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.SupplementaryHeat.SupplementaryHeat> supplementaryHeats)
        {
            IBaseDetailBiz baseDetail = new BaseDetailBiz(_unitOfWork);
            List<DTOs.heatingAndCooling.SupplHtgDTO> supplHtgDTOs = new List<DTOs.heatingAndCooling.SupplHtgDTO>();
            foreach (ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.SupplementaryHeat.SupplementaryHeat item in supplementaryHeats)
            {
                DTOs.heatingAndCooling.SupplHtgDTO supplHtgDTO = new DTOs.heatingAndCooling.SupplHtgDTO()
                {
                    Equipment=new DTOs.heatingAndCooling.EquipmentDTO() 
                    {
                         EnergySrcType=baseDetail.getByHeadCodeAndDetailCode("EnergySrcType",item.Equipment.EnergySource.Code),
                         EquipmentType=baseDetail.getByHeadCodeAndDetailCode("EquipmentType", item.Equipment.Type.Code),

                    },
                    EquipmentInformation=new DTOs.heatingAndCooling.EquipmentInformationDTO ()
                    {
                        EquipmentManufact=item.EquipmentInformation.Manufacturer,
                        EquipmentModel=item.EquipmentInformation.Model,
                        Description=item.EquipmentInformation.Description,
                        EPA_CSA=item.EquipmentInformation.CsaEpa
                    },
                    YearMade = baseDetail.getByHeadCodeAndDetailCode("YearMade", item.Specifications.YearMade.Code),
                    Usage = baseDetail.getByHeadCodeAndDetailCode("Usage", item.Specifications.Usage.Code),
                    MonthlyData= GetMonthlyDataDTO(item.Specifications.MonthlyUsage),
                    LocationHeated=baseDetail.getByHeadCodeAndDetailCode("LocationHeated", item.Specifications.LocationHeated.Code),
                    FloorArea=item.Specifications.LocationHeated.Value,
                    FlueLocation =  item.Specifications.Flue.IsInterior? FlueLocation.Interior: FlueLocation.Exterior,
                    FlueType = baseDetail.getByHeadCodeAndDetailCode("FlueType", item.Specifications.Flue.Type.Code),
                    FlueDiameter = item.Specifications.Flue.Diameter,
                    FlueArea = item.Specifications.Flue.Area,
                    HeatCapacity=item.Specifications.OutputCapacity.ValueInUiUnits,
                    HeatCapacityUnit=item.Specifications.OutputCapacity.UiUnits == "btu/hr" ? CapacityUnit.BtuHr : CapacityUnit.KW,
                    SteadyEff=item.Specifications.Efficiency,
                    EngPilotCons=item.Specifications.PilotLight,
                    DapperClosed=item.Specifications.DamperClosed
                };
                supplHtgDTOs.Add(supplHtgDTO);
            }
            return supplHtgDTOs;

        }
        private DTOs.heatingAndCooling.MonthlyDataDTO GetMonthlyDataDTO(ca.nrcan.gc.OEE.HouseFileLibrary.MonthlyData monthlyData)
        {
            return new DTOs.heatingAndCooling.MonthlyDataDTO()
            {
                January = monthlyData.January,
                February = monthlyData.February,
                March = monthlyData.March,
                April = monthlyData.April,
                May = monthlyData.May,
                June = monthlyData.June,
                July = monthlyData.July,
                August = monthlyData.August,
                September = monthlyData.September,
                October = monthlyData.October,
                November = monthlyData.November,
                December = monthlyData.December

            };
        }
        private List<DTOs.heatingAndCooling.AdditionalOpeningDTO> GetAdditionalOpeningDTOs(List<ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.AdditionalOpening> additionalOpenings)
        {
            IBaseDetailBiz baseDetail = new BaseDetailBiz(_unitOfWork);
            List<DTOs.heatingAndCooling.AdditionalOpeningDTO> additionalOpeningDTOs = new List<DTOs.heatingAndCooling.AdditionalOpeningDTO>();
            foreach (ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.AdditionalOpening item in additionalOpenings)
            {
                DTOs.heatingAndCooling.AdditionalOpeningDTO additionalOpeningDTO = new DTOs.heatingAndCooling.AdditionalOpeningDTO()
                {
                    EquipmentType = baseDetail.getByHeadCodeAndDetailCode("EquipmentType", item.Code),
                    FlueDiameter=item.FlueDiameter,
                    DamperClosed=item.DamperClosed
                };
                additionalOpeningDTOs.Add(additionalOpeningDTO);
            }
            return additionalOpeningDTOs;

        }
        private DTOs.heatingAndCooling.RadiantDTO GetRadiantDTO(ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.RadiantHeating radiantHeating)
        {
            IBaseDetailBiz baseDetail = new BaseDetailBiz(_unitOfWork);
            return new DTOs.heatingAndCooling.RadiantDTO()
            {
                AticCeilingEffTemp=radiantHeating.AtticCeiling.EffectiveTemperature,
                AticCeilingTotArea=radiantHeating.AtticCeiling.FractionOfArea,

                FlatRoofEffTemp=radiantHeating.FlatRoof.EffectiveTemperature,
                FlatRoofTotArea=radiantHeating.FlatRoof.FractionOfArea,

                FloorAbCrawlSpcEffTemp=radiantHeating.AboveCrawlspace.EffectiveTemperature,
                FloorAbCrawlSpcTotArea=radiantHeating.AboveCrawlspace.FractionOfArea,

                SlabOnGradeEffTemp=radiantHeating.SlabOnGrade.EffectiveTemperature,
                SlabOnGradeTotArea=radiantHeating.SlabOnGrade.FractionOfArea,

                FloorAbBasementEffTemp=radiantHeating.AboveBasement.EffectiveTemperature,
                FloorAbBasementTotArea=radiantHeating.AboveBasement.FractionOfArea,

                BasementEffTemp=radiantHeating.Basement.EffectiveTemperature,
                BasementTotArea=radiantHeating.Basement.FractionOfArea
            };
        }
        private DTOs.heatingAndCooling.type2.Type2 GetType2(ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.Type2.Type2 type2)
        {
            IBaseDetailBiz baseDetail = new BaseDetailBiz(_unitOfWork);
            return new DTOs.heatingAndCooling.type2.Type2()
            {
               AirCondition= GetAirConditionDTO(type2.AirConditioning),
               AirHeatPump= GetAirHeatPumpDTO(type2.AirHeatPump),
               GroundHeatPump= GetGroundHeatPumpDTO(type2.GroundHeatPump),
               WaterHeatPump= GetWaterHeatPumpDTO( type2.WaterHeatPump)
            };
        }
        private DTOs.heatingAndCooling.type2.WaterHeatPumpDTO GetWaterHeatPumpDTO(ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.Type2.HeatPump heatPump)
        {
            IBaseDetailBiz baseDetail = new BaseDetailBiz(_unitOfWork);
            return new DTOs.heatingAndCooling.type2.WaterHeatPumpDTO()
            {
                EquipmentInformation = new DTOs.heatingAndCooling.EquipmentInformationType2DTO()
                {
                    EquipmentManufact = heatPump.EquipmentInformation.Manufacturer,
                    EquipmentModel = heatPump.EquipmentInformation.Model,
                    CanCsa = heatPump.EquipmentInformation.CanCsaC448,
                    EquipmentAHRI = heatPump.EquipmentInformation.AHRI.ToString(),
                },

                Specification = new DTOs.heatingAndCooling.SpecificationType2DTO()
                {
                    OutCapType = baseDetail.getByHeadCodeAndDetailCode("OutCapType", heatPump.Specifications.OutputCapacity.Code),
                    OutCapacityVal = heatPump.Specifications.OutputCapacity.Value,
                    OutCapacityUnit = heatPump.Specifications.OutputCapacity.UiUnits == "btu/hr" ? CapacityUnit.BtuHr : CapacityUnit.KW,
                    CoolEfficiencyType = heatPump.Specifications.CoolingEfficiency.IsCop ? HeatCoolEfficiencyType.COP : HeatCoolEfficiencyType.HSPF,
                    CoolEfficiencyVal = heatPump.Specifications.CoolingEfficiency.Value,
                    HeatEfficiencyType = heatPump.Specifications.HeatingEfficiency.IsCop ? HeatCoolEfficiencyType.COP : HeatCoolEfficiencyType.HSPF,
                    HeatEfficiencyVal = heatPump.Specifications.HeatingEfficiency.Value

                },
                EquipmentType = new DTOs.heatingAndCooling.EquipmentType2DTO
                {
                    UnitFuncType = baseDetail.getByHeadCodeAndDetailCode("UnitFuncType", heatPump.Equipment.Function.Code),
                },
                CrankcaseHeat = heatPump.Equipment.CrankcaseHeater,
                OpenableWinArea = heatPump.CoolingParameters.openableWindowArea,
                SensibleHeatRate = heatPump.CoolingParameters.sensibleHeatRatio,
                TempCutoffType = baseDetail.getByHeadCodeAndDetailCode("TempCutoffType", heatPump.Temperature.CutoffType.Code),
                CutoffTemp = heatPump.Temperature.CutoffType.Value,
                TempRatingType = baseDetail.getByHeadCodeAndDetailCode("TempRatingType", heatPump.Temperature.RatingType.Code),
                RatingTemp = heatPump.Temperature.RatingType.Value,

                WaterTempUseType = heatPump.SourceTemperature.Use.IsUserSpecified ? UserSpecOrCalcType.UserSpec : UserSpecOrCalcType.Calculated,
                WaterTempMon = GetHeatPumpSourceTempMonthly(heatPump.SourceTemperature.Temperatures),
                AvgDepth = heatPump.SourceTemperature.Depth,


            };
        }
        private DTOs.heatingAndCooling.type2.GroundHeatPumpDTO GetGroundHeatPumpDTO(ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.Type2.HeatPump heatPump)
        {
            IBaseDetailBiz baseDetail = new BaseDetailBiz(_unitOfWork);
            return new DTOs.heatingAndCooling.type2.GroundHeatPumpDTO()
            {
                EquipmentInformation = new DTOs.heatingAndCooling.EquipmentInformationType2DTO()
                {
                    EquipmentManufact = heatPump.EquipmentInformation.Manufacturer,
                    EquipmentModel = heatPump.EquipmentInformation.Model,
                    CanCsa= heatPump.EquipmentInformation.CanCsaC448,
                    EquipmentAHRI = heatPump.EquipmentInformation.AHRI.ToString(),
                },

                Specification = new DTOs.heatingAndCooling.SpecificationType2DTO()
                {
                    OutCapType = baseDetail.getByHeadCodeAndDetailCode("OutCapType", heatPump.Specifications.OutputCapacity.Code),
                    OutCapacityVal = heatPump.Specifications.OutputCapacity.Value,
                    OutCapacityUnit = heatPump.Specifications.OutputCapacity.UiUnits == "btu/hr" ? CapacityUnit.BtuHr : CapacityUnit.KW,
                    CoolEfficiencyType = heatPump.Specifications.CoolingEfficiency.IsCop ? HeatCoolEfficiencyType.COP : HeatCoolEfficiencyType.HSPF,
                    CoolEfficiencyVal = heatPump.Specifications.CoolingEfficiency.Value,
                    HeatEfficiencyType = heatPump.Specifications.HeatingEfficiency.IsCop ? HeatCoolEfficiencyType.COP : HeatCoolEfficiencyType.HSPF,
                    HeatEfficiencyVal = heatPump.Specifications.HeatingEfficiency.Value

                },
                EquipmentType = new DTOs.heatingAndCooling.EquipmentType2DTO
                {
                    UnitFuncType = baseDetail.getByHeadCodeAndDetailCode("UnitFuncType", heatPump.Equipment.Function.Code),
                },
                CrankcaseHeat = heatPump.Equipment.CrankcaseHeater,
                OpenableWinArea = heatPump.CoolingParameters.openableWindowArea,
                SensibleHeatRate = heatPump.CoolingParameters.sensibleHeatRatio,
                TempCutoffType = baseDetail.getByHeadCodeAndDetailCode("TempCutoffType", heatPump.Temperature.CutoffType.Code),
                CutoffTemp = heatPump.Temperature.CutoffType.Value,
                TempRatingType = baseDetail.getByHeadCodeAndDetailCode("TempRatingType", heatPump.Temperature.RatingType.Code),
                RatingTemp = heatPump.Temperature.RatingType.Value,

                GroundTempUseType = heatPump.SourceTemperature.Use.IsUserSpecified?UserSpecOrCalcType.UserSpec:UserSpecOrCalcType.Calculated,
                WaterTempMon= GetHeatPumpSourceTempMonthly(heatPump.SourceTemperature.Temperatures),
                AvgDepth = heatPump.SourceTemperature.Depth,


            };
        }
        private DTOs.heatingAndCooling.type2.HeatPumpSourceTempMonthlyDTO GetHeatPumpSourceTempMonthly(ca.nrcan.gc.OEE.HouseFileLibrary.MonthlyData monthlyData)
        {
            return new DTOs.heatingAndCooling.type2.HeatPumpSourceTempMonthlyDTO()
            {
                January=monthlyData.January,
                February=monthlyData.February,
                March=monthlyData.March,
                April=monthlyData.April,
                May=monthlyData.May,
                June=monthlyData.June,
                July=monthlyData.July,
                August=monthlyData.August,
                September=monthlyData.September,
                October=monthlyData.October,
                November=monthlyData.November,
                December=monthlyData.December

            };
        }
        private DTOs.heatingAndCooling.type2.AirHeatPumpDTO GetAirHeatPumpDTO(ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.Type2.HeatPump heatPump)
        {
            IBaseDetailBiz baseDetail = new BaseDetailBiz(_unitOfWork);
            return new DTOs.heatingAndCooling.type2.AirHeatPumpDTO()
            {
                EquipmentInformation = new DTOs.heatingAndCooling.EquipmentInformationType2DTO()
                {
                    EquipmentManufact = heatPump.EquipmentInformation.Manufacturer,
                    EquipmentModel = heatPump.EquipmentInformation.Model,
                    EnergyStar = heatPump.EquipmentInformation.EnergyStar,
                    EquipmentAHRI = heatPump.EquipmentInformation.AHRI.ToString(),
                },

                Specification = new DTOs.heatingAndCooling.SpecificationType2DTO()
                {
                    OutCapType = baseDetail.getByHeadCodeAndDetailCode("OutCapType", heatPump.Specifications.OutputCapacity.Code),
                    OutCapacityVal = heatPump.Specifications.OutputCapacity.Value,
                    OutCapacityUnit = heatPump.Specifications.OutputCapacity.UiUnits == "btu/hr" ? CapacityUnit.BtuHr : CapacityUnit.KW,
                    CoolEfficiencyType = heatPump.Specifications.CoolingEfficiency.IsCop ? HeatCoolEfficiencyType.COP : HeatCoolEfficiencyType.HSPF,
                    CoolEfficiencyVal = heatPump.Specifications.CoolingEfficiency.Value,
                    HeatEfficiencyType = heatPump.Specifications.HeatingEfficiency.IsCop ? HeatCoolEfficiencyType.COP : HeatCoolEfficiencyType.HSPF,
                    HeatEfficiencyVal = heatPump.Specifications.HeatingEfficiency.Value

                },
                EquipmentType = new DTOs.heatingAndCooling.EquipmentType2DTO
                {
                    CentralEquipmentTpe = baseDetail.getByHeadCodeAndDetailCode("CentralEquipmentTpe", heatPump.Equipment.Type.Code),
                    UnitFuncType = baseDetail.getByHeadCodeAndDetailCode("UnitFuncType", heatPump.Equipment.Function.Code),
                },
                CrankcaseHeat = heatPump.Equipment.CrankcaseHeater,
                OpenableWinArea = heatPump.CoolingParameters.openableWindowArea,
                SensibleHeatRate = heatPump.CoolingParameters.sensibleHeatRatio,
                TempCutoffType = baseDetail.getByHeadCodeAndDetailCode("TempCutoffType", heatPump.Temperature.CutoffType.Code),
                CutoffTemp = heatPump.Temperature.CutoffType.Value,
                TempRatingType = baseDetail.getByHeadCodeAndDetailCode("TempRatingType", heatPump.Temperature.RatingType.Code),
                RatingTemp = heatPump.Temperature.RatingType.Value,
                ColdClimateHeatPumo = heatPump.ColdClimateHeatPump != null,
                HeatEff=heatPump.ColdClimateHeatPump.HeatingEfficiency,
                CoolEf=heatPump.ColdClimateHeatPump.CoolingEfficiency,
                Capacity=heatPump.ColdClimateHeatPump.Capacity,
                CapacityUnit= heatPump.ColdClimateHeatPump.UiUnits == "btu/hr" ? CapacityUnit.BtuHr : CapacityUnit.KW,
                CopAt=heatPump.ColdClimateHeatPump.Cop,
                CapMain=heatPump.ColdClimateHeatPump.CapacityMaintenance


            };
        }
        private DTOs.heatingAndCooling.type2.AirConditionDTO GetAirConditionDTO(ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.Type2.AirConditioning airConditioning)
        {
            IBaseDetailBiz baseDetail = new BaseDetailBiz(_unitOfWork);
            return new DTOs.heatingAndCooling.type2.AirConditionDTO()
            {
                EquipmentInformation = new DTOs.heatingAndCooling.EquipmentInformationType2DTO()
                {
                    EquipmentManufact = airConditioning.EquipmentInformation.Manufacturer,
                    EquipmentModel = airConditioning.EquipmentInformation.Model,
                    EnergyStar = airConditioning.EquipmentInformation.EnergyStar
                },

                Specification = new DTOs.heatingAndCooling.SpecificationType2DTO ()
                {
                    RateCapacityUnit = airConditioning.Specifications.RatedCapacity.UiUnits == "btu/hr" ? CapacityUnit.BtuHr : CapacityUnit.KW,
                    CoolEfficiencyType=airConditioning.Specifications.Efficiency.IsCop?HeatCoolEfficiencyType.COP:HeatCoolEfficiencyType.HSPF,
                    CoolEfficiencyVal=airConditioning.Specifications.Efficiency.Value,
                    SizingFactor=airConditioning.Specifications.SizingFactor,
                    RatedCapacity=airConditioning.Specifications.RatedCapacity.Value
                    
                },
                EquipmentType = new DTOs.heatingAndCooling.EquipmentType2DTO
                {
                    CentralEquipmentTpe =baseDetail.getByHeadCodeAndDetailCode("CentralEquipmentTpe", airConditioning.Equipment.CentralType.Code),
                },
                CrankcaseHeat=airConditioning.Equipment.CrankcaseHeater,
                OpenableWinArea=airConditioning.CoolingParameters.openableWindowArea,
                SensibleHeatRate=airConditioning.CoolingParameters.sensibleHeatRatio

            };
        }
        private DTOs.heatingAndCooling.type1.Type1 GetType1(ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.Type1.Type1 type1)
        {
            IBaseDetailBiz baseDetail = new BaseDetailBiz(_unitOfWork);
            return new DTOs.heatingAndCooling.type1.Type1()
            {
                BaseBoard= GetBaseBoardDTO(type1.Baseboards),
                Boiler= GetBoilerDTO(type1.Boiler),
                ComboTankAndPump= GetComboTankAndPumpDTO(type1.ComboHeatDhw),
                cSAP9Test= GetSAP9TestDataDTO(type1.P9),
                Furnace= GetFurnaceDTO(type1.Furnace)
            };
        }
        private DTOs.heatingAndCooling.type1.BaseBoardDTO GetBaseBoardDTO(ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.Type1.Baseboards baseboards)
        {
            IBaseDetailBiz baseDetail = new BaseDetailBiz(_unitOfWork);
            return new DTOs.heatingAndCooling.type1.BaseBoardDTO()
            {
                EquipmentInformation = new DTOs.heatingAndCooling.EquipmentInformationDTO()
                { EquipmentManufact = baseboards.EquipmentInformation.Manufacturer, EquipmentModel = baseboards.EquipmentInformation.Model,ThermostatsNumber=baseboards.EquipmentInformation.NumberOfElectronicThermostats },
                Specification=new DTOs.heatingAndCooling.SpecificationDTO() 
                {OutCapacityUnit=baseboards.Specifications.OutputCapacity.UiUnits=="btu/hr"?CapacityUnit.BtuHr:CapacityUnit.KW,OutCapacityVal=baseboards.Specifications.OutputCapacity.ValueInUiUnits,Efficiency=baseboards.Specifications.Efficiency,SizingFactor=baseboards.Specifications.SizingFactor },
               
            };
        }
        private DTOs.heatingAndCooling.type1.BoilerDTO GetBoilerDTO(ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.Type1.Boiler boiler)
        {
            IBaseDetailBiz baseDetail = new BaseDetailBiz(_unitOfWork);
            return new DTOs.heatingAndCooling.type1.BoilerDTO()
            {
                EquipmentInformation = new DTOs.heatingAndCooling.EquipmentInformationDTO()
                {
                    EquipmentManufact = boiler.EquipmentInformation.Manufacturer,
                    EquipmentModel = boiler.EquipmentInformation.Model,
                    EnergyStar = boiler.EquipmentInformation.EnergyStar,
                    EPA_CSA = boiler.EquipmentInformation.EpaCsa 
                },

                Specification = new DTOs.heatingAndCooling.SpecificationDTO()
                { 
                    OutCapacityUnit = boiler.Specifications.OutputCapacity.UiUnits == "btu/hr" ? CapacityUnit.BtuHr : CapacityUnit.KW,
                    OutCapacityVal = boiler.Specifications.OutputCapacity.ValueInUiUnits,
                    Efficiency = boiler.Specifications.Efficiency,
                    SizingFactor = boiler.Specifications.SizingFactor,
                    EfficiencyType = boiler.Specifications.IsSteadyState ? EfficiencyType.SteadyState : EfficiencyType.AFUE,
                    PilotLigth=boiler.Specifications.PilotLight,
                    FlueDiameter=boiler.Specifications.FlueDiameter
                },
                Equipment=new DTOs.heatingAndCooling.EquipmentDTO() 
                { 
                    EnergySrcType=baseDetail.getByHeadCodeAndDetailCode("EnergySrcType", boiler.Equipment.EnergySource.Code),
                    DualFuelSystem=boiler.Equipment.IsBiEnergy,
                    EquipmentType= baseDetail.getByHeadCodeAndDetailCode("EquipmentType", boiler.Equipment.EquipmentType.Code),
                    SwitchoverTemp=boiler.Equipment.SwitchoverTemperature
                }

            };
        }
        private DTOs.heatingAndCooling.type1.FurnaceDTO GetFurnaceDTO(ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.Type1.Furnace furnace)
        {
            IBaseDetailBiz baseDetail = new BaseDetailBiz(_unitOfWork);
            return new DTOs.heatingAndCooling.type1.FurnaceDTO()
            {
                EquipmentInformation = new DTOs.heatingAndCooling.EquipmentInformationDTO()
                {
                    EquipmentManufact = furnace.EquipmentInformation.Manufacturer,
                    EquipmentModel = furnace.EquipmentInformation.Model,
                    EnergyStar = furnace.EquipmentInformation.EnergyStar,
                    EPA_CSA = furnace.EquipmentInformation.EpaCsa
                },

                Specification = new DTOs.heatingAndCooling.SpecificationDTO()
                {
                    OutCapacityUnit = furnace.Specifications.OutputCapacity.UiUnits == "btu/hr" ? CapacityUnit.BtuHr : CapacityUnit.KW,
                    OutCapacityVal = furnace.Specifications.OutputCapacity.ValueInUiUnits,
                    Efficiency = furnace.Specifications.Efficiency,
                    SizingFactor = furnace.Specifications.SizingFactor,
                    EfficiencyType = furnace.Specifications.IsSteadyState ? EfficiencyType.SteadyState : EfficiencyType.AFUE,
                    PilotLigth = furnace.Specifications.PilotLight,
                    FlueDiameter = furnace.Specifications.FlueDiameter
                },
                Equipment = new DTOs.heatingAndCooling.EquipmentDTO()
                {
                    EnergySrcType = baseDetail.getByHeadCodeAndDetailCode("EnergySrcType", furnace.Equipment.EnergySource.Code),
                    DualFuelSystem = furnace.Equipment.IsBiEnergy,
                    EquipmentType = baseDetail.getByHeadCodeAndDetailCode("EquipmentType", furnace.Equipment.EquipmentType.Code),
                    SwitchoverTemp = furnace.Equipment.SwitchoverTemperature
                }

            };
        }
        private DTOs.heatingAndCooling.type1.ComboTankAndPumpDTO GetComboTankAndPumpDTO(ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.Type1.ComboHeatDhw comboHeatDhw)
        {
            IBaseDetailBiz baseDetail = new BaseDetailBiz(_unitOfWork);
            return new DTOs.heatingAndCooling.type1.ComboTankAndPumpDTO()
            {
                EquipmentInformation = new DTOs.heatingAndCooling.EquipmentInformationDTO()
                {
                    EquipmentManufact = comboHeatDhw.EquipmentInformation.Manufacturer,
                    EquipmentModel = comboHeatDhw.EquipmentInformation.Model,
                    EnergyStar = comboHeatDhw.EquipmentInformation.EnergyStar,
                    EPA_CSA = comboHeatDhw.EquipmentInformation.EpaCsa
                },

                Specification = new DTOs.heatingAndCooling.SpecificationDTO()
                {
                    OutCapacityUnit = comboHeatDhw.Specifications.OutputCapacity.UiUnits == "btu/hr" ? CapacityUnit.BtuHr : CapacityUnit.KW,
                    OutCapacityVal = comboHeatDhw.Specifications.OutputCapacity.ValueInUiUnits,
                    Efficiency = comboHeatDhw.Specifications.Efficiency,
                    SizingFactor = comboHeatDhw.Specifications.SizingFactor,
                    EfficiencyType = comboHeatDhw.Specifications.IsSteadyState ? EfficiencyType.SteadyState : EfficiencyType.AFUE,
                    PilotLigth = comboHeatDhw.Specifications.PilotLight,
                    FlueDiameter = comboHeatDhw.Specifications.FlueDiameter
                },
                Equipment = new DTOs.heatingAndCooling.EquipmentDTO()
                {
                    EnergySrcType = baseDetail.getByHeadCodeAndDetailCode("EnergySrcType", comboHeatDhw.Equipment.EnergySource.Code),
                    DualFuelSystem = comboHeatDhw.Equipment.IsBiEnergy,
                    EquipmentType = baseDetail.getByHeadCodeAndDetailCode("EquipmentType", comboHeatDhw.Equipment.EquipmentType.Code),
                    SwitchoverTemp = comboHeatDhw.Equipment.SwitchoverTemperature
                },
                TankVolumeType= baseDetail.getByHeadCodeAndDetailCode("TankVolumeType", comboHeatDhw.ComboTankAndPump.TankCapacity.Code),
                TankVolumeVal=comboHeatDhw.ComboTankAndPump.TankCapacity.Value,
                EnergyFactorType=comboHeatDhw.ComboTankAndPump.EnergyFactor.UseDefaults?DefaultOrUserSpecType.Defaults:DefaultOrUserSpecType.Specification,
                EnergyFactorVal=comboHeatDhw.ComboTankAndPump.EnergyFactor.Value,
                TankLocation= baseDetail.getByHeadCodeAndDetailCode("TankLocation", comboHeatDhw.ComboTankAndPump.TankLocation.Code),
                CirculationPompType=comboHeatDhw.ComboTankAndPump.CirculationPump.IsCalculated?UserSpecOrCalcType.Calculated:UserSpecOrCalcType.UserSpec,
                CirculationPompVal=comboHeatDhw.ComboTankAndPump.CirculationPump.Value,
                EnergyEffMotor=comboHeatDhw.ComboTankAndPump.CirculationPump.HasEnergyEfficientMotor

            };
        }
        private DTOs.heatingAndCooling.type1.CSATestedComboHeatingDTO GetSAP9TestDataDTO(ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.Type1.P9 p9)
        {
            IBaseDetailBiz baseDetail = new BaseDetailBiz(_unitOfWork);
            return new DTOs.heatingAndCooling.type1.CSATestedComboHeatingDTO()
            {
                DataType =p9.IsUserSpecified ?CSADataType.UserSpecified :CSADataType.Library,
                Manufacture=p9.EquipmentInformation.Manufacturer,
                Model=p9.EquipmentInformation.Model,
                P9SysNum=p9.NumberOfSystems,
                ThrmalPerFactor=p9.ThermalPerformanceFactor,
                AnnualElec=p9.AnnualElectricity,
                SpcHeatingCap=p9.SpaceHeatingCapacity,
                CompositeSHE=p9.SpaceHeatingEfficiency,
                WaterHeatPerFact=p9.WaterHeatingPerformanceFactor,
                NominalBurner=p9.BurnerInput,
                RecoveryEff=p9.RecoveryEfficiency,
                CSAP9= GetSAP9TestDataDTO(p9.TestData),
                //DWHR=
            };
        }
        private DTOs.heatingAndCooling.type1.CSAP9TestDataDTO GetSAP9TestDataDTO(ca.nrcan.gc.OEE.HouseFileLibrary.Components.HeatingCoolingComponents.Type1.TestData testData)
        {
            IBaseDetailBiz baseDetail = new BaseDetailBiz(_unitOfWork);
            return new DTOs.heatingAndCooling.type1.CSAP9TestDataDTO()
            {
                EnergyType = baseDetail.getByHeadCodeAndDetailCode("EnergyType", testData.EnergySource.Code),
                NetEff15=testData.NetEfficiency.LoadPerformance15,
                NetEff40=testData.NetEfficiency.LoadPerformance40,
                NetEff100=testData.NetEfficiency.LoadPerformance100,

                AvgElecUse15=testData.ElectricalUse.LoadPerformance15,
                AvgElecUse40=testData.ElectricalUse.LoadPerformance40,
                AvgElecUse100=testData.ElectricalUse.LoadPerformance100,

                CirclBmePower15=testData.BlowerPower.LoadPerformance15,
                CirclBmePower40=testData.BlowerPower.LoadPerformance40,
                CirclBmePower100=testData.BlowerPower.LoadPerformance100,

                Pcont=testData.ControlsPower,
                Pcirc=testData.CirculationPower,
                DailyElWaterHeat=testData.DailyUse,
                ThemalStandbyOn=testData.StandbyLossWithFan,
                ThemalStandbyOff=testData.StandbyLossWithoutFan,
                HDeliverRateDhw=testData.OneHourRatingHotWater,
                HDeliverRateSh=testData.OneHourRatingConcurrent
            };
        }


        private DTOs.naturalAir.NaturalAirInfiltrationDTO GetNaturalAirInfiltrationDTO(ca.nrcan.gc.OEE.HouseFileLibrary.Components.NaturalAirInfiltrationComponents.NaturalAirInfiltration naturalAirInfiltration)
        {
            IBaseDetailBiz baseDetail = new BaseDetailBiz(_unitOfWork);
            return new DTOs.naturalAir.NaturalAirInfiltrationDTO()
            {
                HouseVolume = naturalAirInfiltration.Specifications.House.Volume,
                IncludeCrwlSpcVol = naturalAirInfiltration.Specifications.House.includeCrawlspaceVolume,
                AirTigthnessType = baseDetail.getByHeadCodeAndDetailCode("AirTigthnessType", naturalAirInfiltration.Specifications.House.AirTightnessTest.Code),
                BuildingSiteTerrain = baseDetail.getByHeadCodeAndDetailCode("BuildingSiteTerrain", naturalAirInfiltration.Specifications.BuildingSite.Terrain.Code),
                AboveGradeHeigth = naturalAirInfiltration.Specifications.BuildingSite.HighestCeiling,
                DepressTestType = baseDetail.getByHeadCodeAndDetailCode("DepressTestType", naturalAirInfiltration.Specifications.ExhaustDevicesTest.TestStatus.Code),
                DepressTestResult = naturalAirInfiltration.Specifications.ExhaustDevicesTest.Result,
                Guarded = naturalAirInfiltration.Specifications.BlowerTest.Guarded,
                AirChangeRate = naturalAirInfiltration.Specifications.BlowerTest.AirChangeRate,
                TestType = naturalAirInfiltration.Specifications.BlowerTest.IsCgsbTest ? BlowerTestType.OGSB : BlowerTestType.Operated,
                EquvalLeakageAreaType = naturalAirInfiltration.Specifications.BlowerTest.isCalculated ? UserSpecOrCalcType.Calculated : UserSpecOrCalcType.UserSpec,
                EquvalLeakageAreaVal = naturalAirInfiltration.Specifications.BlowerTest.LeakageArea,
                // EquvalLeakageAreaAt=naturalAirInfiltration.Specifications.BlowerTest.
                LocalShadeWallType = baseDetail.getByHeadCodeAndDetailCode("LocalShadeWallType", naturalAirInfiltration.Specifications.LocalShielding.Walls.Code),
                LocalShadeFlueType = baseDetail.getByHeadCodeAndDetailCode("LocalShadeFlueType", naturalAirInfiltration.Specifications.LocalShielding.Flue.Code),
                CommonSurTot = naturalAirInfiltration.Specifications.CommonSurfaceArea.SurfaceArea,
                WeatherStTerrainType = baseDetail.getByHeadCodeAndDetailCode("WeatherStTerrainType", naturalAirInfiltration.OtherFactors.WeatherStation.Terrain.Code),
                WeatherStTerrainAnemHeight = naturalAirInfiltration.OtherFactors.WeatherStation.AnemometerHeight,
                LeakageFracType = naturalAirInfiltration.OtherFactors.LeakageFractions.UseDefaults ? DefaultOrUserSpecType.Defaults : DefaultOrUserSpecType.Specification,
                LeakageFracCeillings = naturalAirInfiltration.OtherFactors.LeakageFractions.Ceilings,
                LeakageFracWalls = naturalAirInfiltration.OtherFactors.LeakageFractions.Walls,
                LeakageFracFloors = naturalAirInfiltration.OtherFactors.LeakageFractions.Floors

            };
        }
        private DTOs.generation.GenerationDTO GetGenerationDTO(ca.nrcan.gc.OEE.HouseFileLibrary.Components.GenerationComponents.Generation generation)
        {
            IBaseDetailBiz baseDetail = new BaseDetailBiz(_unitOfWork);
            return new DTOs.generation.GenerationDTO()
            {
                PhotovoliSysCount= generation.PhotovoltaicSystems!=null? generation.PhotovoltaicSystems.Count:0,
                CapPhotovoliSys=generation.PhotovoltaicCapacity,
                BatteryStorage=generation.BatteryStorage,
                WindEnergy=generation.WindEnergyContribution,
                SolarReady=generation.SolarReady,
                PhotovoltaicSystems= GetPhotovoltaicSystemDTOs(generation.PhotovoltaicSystems)
            };
        }
        private List<DTOs.generation.PhotovoltaicSystemDTO> GetPhotovoltaicSystemDTOs(List<ca.nrcan.gc.OEE.HouseFileLibrary.Components.GenerationComponents.Photovoltaic> photovoltaics)
        {
            List<DTOs.generation.PhotovoltaicSystemDTO> photovoltaicSystemDTOs = new List<DTOs.generation.PhotovoltaicSystemDTO>();
            foreach (ca.nrcan.gc.OEE.HouseFileLibrary.Components.GenerationComponents.Photovoltaic item in photovoltaics)
            {
                photovoltaicSystemDTOs.Add(GetPhotovoltaicSystemDTO(item));
            }
            return photovoltaicSystemDTOs;
        }
        private DTOs.generation.PhotovoltaicSystemDTO GetPhotovoltaicSystemDTO(ca.nrcan.gc.OEE.HouseFileLibrary.Components.GenerationComponents.Photovoltaic photovoltaic)
        {
            IBaseDetailBiz baseDetail = new BaseDetailBiz(_unitOfWork);
            return new DTOs.generation.PhotovoltaicSystemDTO()
            {
                Manufacture=photovoltaic.EquipmentInformation.Manufacturer,
                Model=photovoltaic.EquipmentInformation.Model,
                ArayArea=photovoltaic.Array.Area,
                SlopDeg=photovoltaic.Array.Slope,
                AzimuthDeg=photovoltaic.Array.Azimuth,
                ModuleType = baseDetail.getByHeadCodeAndDetailCode("ModuleType", photovoltaic.Module.Type.Code),
                ModuleEfficiency=photovoltaic.Module.Efficiency,
                NormOperationCellTemp=photovoltaic.Module.CellTemperature,
                TempCoefficientOfEff=photovoltaic.Module.CoefficientOfEfficiency,
                MissArrayLoss=photovoltaic.Efficiency.MiscellaneousLosses,
                OtherPow=photovoltaic.Efficiency.OtherPowerLosses,
                InverterEff=photovoltaic.Efficiency.InverterEfficiency,
                GridObsorRate=photovoltaic.Efficiency.GridAbsorptionRate

            };
        }
        private DTOs.baseLoad.BaseLoadDTO GetBaseLoadDTO(ca.nrcan.gc.OEE.HouseFileLibrary.Components.BaseLoadsComponents.BaseLoads baseLoads)
        {
            IBaseDetailBiz baseDetail = new BaseDetailBiz(_unitOfWork);
            return new DTOs.baseLoad.BaseLoadDTO()
            {
                UserSpecElWaterUsage= baseLoads.AdvancedUserSpecified!=null,
                OccupantsAdults=baseLoads.Occupancy.Adults.Occupants,
                OccupantsChildren=baseLoads.Occupancy.Children.Occupants,
                OccupantsInfants=baseLoads.Occupancy.Infants.Occupants,

                AtHomeAdults = baseLoads.Occupancy.Adults.AtHome,
                AtHomeChildren = baseLoads.Occupancy.Children.AtHome,
                AtHomeInfants = baseLoads.Occupancy.Infants.AtHome,
                FractionOfIntGain=baseLoads.BasementFractionOfInternalGains,

                ElecApp=baseLoads.Summary.ElectricalAppliances,
                LightingApp=baseLoads.Summary.Lighting,
                OtherElec=baseLoads.Summary.OtherElectric,
                AvgExUse=baseLoads.Summary.ExteriorUse,
                EstimatHotWater=baseLoads.Summary.HotWaterLoad,

                WaterUsage= GetWaterUsageDTO(baseLoads.WaterUsage),
                ElecUsage= GetElectricalUsageDTO(baseLoads.ElectricalUsage)
            };
        }
        private DTOs.baseLoad.ElectricalUsageDTO GetElectricalUsageDTO(ca.nrcan.gc.OEE.HouseFileLibrary.Components.BaseLoadsComponents.ElectricalUsage electricalUsage)
        {
            IBaseDetailBiz baseDetail = new BaseDetailBiz(_unitOfWork);
            return new DTOs.baseLoad.ElectricalUsageDTO()
            {
                ClothsDryerInstalled=electricalUsage.ClothesDryer.Installed,
                ClothsEnergySourceType = baseDetail.getByHeadCodeAndDetailCode("ClothsEnergySourceType", electricalUsage.ClothesDryer.EnergySource.Code),
                ClothWashLoadDryPer=electricalUsage.ClothesDryer.PercentageOfWasherLoads,
                ClthRateValType = baseDetail.getByHeadCodeAndDetailCode("ClthRateValType", electricalUsage.ClothesDryer.RatedValue.Code),
                ClthAnnualEnergyConsRate=electricalUsage.ClothesDryer.PercentageOfWasherLoads,
                DryerLocationType= baseDetail.getByHeadCodeAndDetailCode("DryerLocation", electricalUsage.ClothesDryer.Location.Code),

                StoveEnergySourceType = baseDetail.getByHeadCodeAndDetailCode("StoveEnergySourceType", electricalUsage.Stove.EnergySource.Code),
                StoveRateValType = baseDetail.getByHeadCodeAndDetailCode("StoveRateValType", electricalUsage.Stove.RatedValue.Code),
                StoveAnnualEnConsRateYear=electricalUsage.Stove.RatedValue.Value,

                RefrigRateValType = baseDetail.getByHeadCodeAndDetailCode("RefrigRateValType", electricalUsage.Refrigerator.Code),
                RegrigAnnualEnConsRateYear = electricalUsage.Refrigerator.Value,

                LigthDailyElecEnConsType= baseDetail.getByHeadCodeAndDetailCode("LigthDailyElecEnConsType", electricalUsage.InteriorLighting.Code),
                LigthDailyElecEnConsVal= electricalUsage.InteriorLighting.Value,

                OtherElecLoad=electricalUsage.OtherLoad,
                 AvgExtUse=electricalUsage.AverageExteriorUse
            };
        }
        private DTOs.baseLoad.WaterUsageDTO GetWaterUsageDTO(ca.nrcan.gc.OEE.HouseFileLibrary.Components.BaseLoadsComponents.WaterUsage waterUsage)
        {
            IBaseDetailBiz baseDetail = new BaseDetailBiz(_unitOfWork);
            return new DTOs.baseLoad.WaterUsageDTO()
            {
                HotWaterTemp=waterUsage.Temperature,
                BathFaucetFlowRateType= baseDetail.getByHeadCodeAndDetailCode("BathFaucetFlowRateType", waterUsage.BathroomFaucets.Code),
                BathFaucetUserPerOcc=waterUsage.BathroomFaucets.Value,
                ShowerTempType = baseDetail.getByHeadCodeAndDetailCode("ShowerTempType", waterUsage.Shower.Temperature.Code),
                ShwrHeadFlowRate = baseDetail.getByHeadCodeAndDetailCode("ShwrHeadFlowRate", waterUsage.Shower.FlowRate.Code),
                AvgShwrDur=waterUsage.Shower.AverageDuration,
                ShwrNumPerOcc=waterUsage.Shower.NumberPerOccupantPerWeek,
                ClothWasherInstalled=waterUsage.ClothesWasher!=null,
                ClthWasherRateValType = baseDetail.getByHeadCodeAndDetailCode("ClthWasherRateValType", waterUsage.ClothesWasher.RatedValues.Code),
                ClthWasherTempType = baseDetail.getByHeadCodeAndDetailCode("ClthWasherTempType", waterUsage.ClothesWasher.Temperature.Code),
                ClthWasherRatePerCycle=waterUsage.ClothesWasher.RatedValues.RatedWaterConsumptionPerCycle,
                ClthWasherRateAnnPerYear=waterUsage.ClothesWasher.RatedValues.RatedAnnualEnergyConsumption,
                ClthWasherClothNumPerOcc=waterUsage.ClothesWasher.NumberPerOccupantPerWeek,

                DishwasherInstalled=waterUsage.DishWasher!=null,
                DshWasherRateValType= baseDetail.getByHeadCodeAndDetailCode("DshWasherRateValType", waterUsage.DishWasher.RatedValues.Code),
                DshWasherDishNumPerCycle=waterUsage.DishWasher.RatedValues.RatedWaterConsumptionPerCycle,
                DshWasherAnnualEnergyPerYear=waterUsage.DishWasher.RatedValues.RatedAnnualEnergyConsumption,
                DshWasherCycleNumPerOcc=waterUsage.DishWasher.NumberPerOccupantPerWeek,

                OtherWaterConsPerDay=waterUsage.OtherHotWaterUse
            };
        }
        private DTOs.TemperaturesDTO GetTemperaturesDTO(ca.nrcan.gc.OEE.HouseFileLibrary.Components.HouseComponents.Temperatures temperatures)
        {
            IBaseDetailBiz baseDetail = new BaseDetailBiz(_unitOfWork);
            return new DTOs.TemperaturesDTO()
            {
                DaytimeHeatPoint=temperatures.MainFloors.DaytimeHeatingSetPoint,
                DaytimeCoolPoint=temperatures.MainFloors.CoolingSetPoint,
                NigthtimeHeatPoint=temperatures.MainFloors.NighttimeHeatingSetPoint,
                NigthtimeCoolPoint=temperatures.MainFloors.NighttimeSetbackDuration,
                AllowableRiseType=baseDetail.getByHeadCodeAndDetailCode("AllowableRiseType",temperatures.MainFloors.AllowableRise.Code),
                EquipmentHeadSetPoint=temperatures.Equipment.HeatingSetPoint,
                EquipmentCoolSetPoint=temperatures.Equipment.CoolingSetPoint,
                BasementCooled=temperatures.Basement.Cooled,
                BasementHeated=temperatures.Basement.Heated,
                BasementSepThermostat=temperatures.Basement.SeparateThermostat,
                BasementHeatDegr=temperatures.Basement.HeatingSetPoint,
                CrawlSpcHeated=temperatures.Crawlspace.Heated,
                CrawlSpcHeatSetPoint=temperatures.Crawlspace.HeatingSetPoint

            };
        }
        private ES.DTOs.ventilation.VentilationDTO GetVentilationDTO(ca.nrcan.gc.OEE.HouseFileLibrary.Components.VentilationComponents.Ventilation ventilation)
        {
            IBaseDetailBiz baseDetail = new BaseDetailBiz(_unitOfWork);
            return new DTOs.ventilation.VentilationDTO()
            {
               RequireACH=ventilation.Requirements.Ach,
               RequireExhaust=ventilation.Requirements.Exhaust,
               RequireSupply=ventilation.Requirements.Supply,
               RequireUseType= baseDetail.getByHeadCodeAndDetailCode("RequireUse" ,ventilation.Requirements.Use.Code),
               AirDistCircType = baseDetail.getByHeadCodeAndDetailCode("AirDistCircType", ventilation.SupplyAndExhaust.AirDistributionType.Code),
               AirDistCircFanPwrType = baseDetail.getByHeadCodeAndDetailCode("AirDistCircFanPwrType", ventilation.SupplyAndExhaust.AirDistributionFanPower.Code),
               AirDistCircFanPwrVal=ventilation.SupplyAndExhaust.AirDistributionFanPower.Value,
               OperationScheduleType = baseDetail.getByHeadCodeAndDetailCode("OperationScheduleType", ventilation.SupplyAndExhaust.OperationSchedule.Code),
               OperationScheduleVal=ventilation.SupplyAndExhaust.OperationSchedule.Value,
               RoomInput= GetRoomsInputDTO(ventilation.Rooms),
               WholeHouseComponent= GetWholeHouseComponentsDTOs( ventilation.WholeHouseVentilatorList),
               SupplementalComponent= GetWholeHouseComponentsDTOs(ventilation.SupplementalVentilatorList)
            };
        }
        private List<DTOs.ventilation.WholeHouseComponentsDTO> GetWholeHouseComponentsDTOs(List<ca.nrcan.gc.OEE.HouseFileLibrary.Components.VentilationComponents.VentilatorObjects> ventilatorObjects)
        {
            List<DTOs.ventilation.WholeHouseComponentsDTO> wholeHouseComponentsDTOs = new List<DTOs.ventilation.WholeHouseComponentsDTO>();
            foreach (ca.nrcan.gc.OEE.HouseFileLibrary.Components.VentilationComponents.VentilatorObjects item in ventilatorObjects)
            {
                wholeHouseComponentsDTOs.Add(GetWholeHouseComponentsDTO(item));
            }
            return wholeHouseComponentsDTOs;
        }
        private DTOs.ventilation.WholeHouseComponentsDTO GetWholeHouseComponentsDTO(ca.nrcan.gc.OEE.HouseFileLibrary.Components.VentilationComponents.VentilatorObjects ventilator)
        {
            IBaseDetailBiz baseDetail = new BaseDetailBiz(_unitOfWork);
            return new DTOs.ventilation.WholeHouseComponentsDTO()
            {
               VentilatorFanType=baseDetail.getByHeadCodeAndDetailCode("VentilatorFanType",ventilator.VentilatorType.Code),
              VentilatorDetail= GetVentilatorFanTypeDetailDTO(ventilator),
              SupplyFlowRate=ventilator.SupplyFlowrate,
              ExhaustFlowRate=ventilator.ExhaustFlowrate
            };
        }
        private DTOs.ventilation.VentilatorFanTypeDetailDTO GetVentilatorFanTypeDetailDTO(ca.nrcan.gc.OEE.HouseFileLibrary.Components.VentilationComponents.VentilatorObjects ventilator)
        {
            IBaseDetailBiz baseDetail = new BaseDetailBiz(_unitOfWork);
            return new DTOs.ventilation.VentilatorFanTypeDetailDTO()
            {
              EquipmentManufact=ventilator.EquipmentInformation.Manufacturer,
              EquipmentModel=ventilator.EquipmentInformation.Model,
              EnergyStar=ventilator.IsEnergyStar,
              HVI=ventilator.IsHomeVentilatingInstituteCertified,
              AirflowSupply=ventilator.SupplyFlowrate,
              AirflowExhaust=ventilator.ExhaustFlowrate,
             SchaduleOpType= baseDetail.getByHeadCodeAndDetailCode("SchaduleOpType", ventilator.OperationSchedule.Code),
             SCHADULE_OP_VAL=ventilator.OperationSchedule.Value

            };
        }
        private DTOs.ventilation.RoomsInputDTO GetRoomsInputDTO(ca.nrcan.gc.OEE.HouseFileLibrary.Components.VentilationComponents.Rooms room)
        {
            IBaseDetailBiz baseDetail = new BaseDetailBiz(_unitOfWork);
            return new DTOs.ventilation.RoomsInputDTO()
            {
                KitchenLivingDiningRoom=room.Living,
                Bedroom=room.Bedrooms,
                Bathroom=room.Bedrooms,
                UtilityRoom=room.Utility,
                OtherHabitableRoom=room.OtherHabitable,
                VentiRateOtherBaseType=baseDetail.getByHeadCodeAndDetailCode("VentiRateOtherBaseType",room.VentilationRate.Code),
                MinVentiRate=room.MinimumVentilationRate,
                VentedComAppLimitType=baseDetail.getByHeadCodeAndDetailCode("VentedComAppLimitType", room.DepressurizationLimit.Code),
                VentedComAppLimitVal=room.DepressurizationLimit.Value
            };
        }
        private WinTightnessDTO GetWinTightnessDTO(ca.nrcan.gc.OEE.HouseFileLibrary.H2kResources.WindowAirTightness windowAirTightness)
        {
            IBaseDetailBiz baseDetail = new BaseDetailBiz(_unitOfWork);
            return new WinTightnessDTO()
            {
               WinAirTigthnessType=baseDetail.getByHeadCodeAndDetailCode("WinTigthness", windowAirTightness.Code),
               WinAirTigthnessValue=windowAirTightness.Value

            };
        }
        private UnitsModeDTO GetUnitsModeDTO(string unitMode)
        {
            Common.Enums.DisplayUnitType displayUnitType= Common.Enums.DisplayUnitType.Metric;
            switch (unitMode)
            {
                case "Metric":
                    displayUnitType=Common.Enums.DisplayUnitType.Metric;
                    break;
                case "US":
                    displayUnitType=Common.Enums.DisplayUnitType.US;
                    break;
                case "Imperial":
                    displayUnitType=Common.Enums.DisplayUnitType.Imperial;
                    break;
            }
            IBaseDetailBiz baseDetail = new BaseDetailBiz(_unitOfWork);
            return new UnitsModeDTO()
            {
                DisplayUnitType=displayUnitType,
                ProgramsType=baseDetail.getByHeadCodeAndDetailCode("ProgramType","1")
            };
        }
        private HouseFuelDTO GetHouseFuelDTO(ca.nrcan.gc.OEE.HouseFileLibrary.FuelCostsComponents.FuelCosts fuelCosts)
        {
            IBaseDetailBiz baseDetail = new BaseDetailBiz(_unitOfWork);
            return new HouseFuelDTO()
            {
                FuelCostLib=fuelCosts.LibraryFile,
                IncludeCostCalc=fuelCosts.IncludeCostCalculations,
                YearlyFuelCost= GetFuelCostDTO(fuelCosts),
                FuelMonthlyCost= GetFuelMonthlyCostDataDTO(fuelCosts.Monthly),

            };
        }
        private FuelMonthlyCostDataDTO GetFuelMonthlyCostDataDTO(ca.nrcan.gc.OEE.HouseFileLibrary.FuelCostsComponents.FuelCostsMonthly fuelCostMonthly)
        {
            IBaseDetailBiz baseDetail = new BaseDetailBiz(_unitOfWork);
            return new FuelMonthlyCostDataDTO()
            {
                 JanuaryCost= GetFuelCostByNames(fuelCostMonthly.Wood.January, fuelCostMonthly.NaturalGas.January, fuelCostMonthly.Oil.January, fuelCostMonthly.Propane.January, fuelCostMonthly.Electricity.January),
                FebruaryCost = GetFuelCostByNames(fuelCostMonthly.Wood.February, fuelCostMonthly.NaturalGas.February, fuelCostMonthly.Oil.February, fuelCostMonthly.Propane.February, fuelCostMonthly.Electricity.February),
                MarchCost = GetFuelCostByNames(fuelCostMonthly.Wood.March, fuelCostMonthly.NaturalGas.March, fuelCostMonthly.Oil.March, fuelCostMonthly.Propane.March, fuelCostMonthly.Electricity.March),
                AprilCost = GetFuelCostByNames(fuelCostMonthly.Wood.April, fuelCostMonthly.NaturalGas.April, fuelCostMonthly.Oil.April, fuelCostMonthly.Propane.April, fuelCostMonthly.Electricity.April),
                MayCost = GetFuelCostByNames(fuelCostMonthly.Wood.May, fuelCostMonthly.NaturalGas.May, fuelCostMonthly.Oil.May, fuelCostMonthly.Propane.May, fuelCostMonthly.Electricity.May),
                JuneCost = GetFuelCostByNames(fuelCostMonthly.Wood.June, fuelCostMonthly.NaturalGas.June, fuelCostMonthly.Oil.June, fuelCostMonthly.Propane.June, fuelCostMonthly.Electricity.June),
                JulyCost = GetFuelCostByNames(fuelCostMonthly.Wood.July, fuelCostMonthly.NaturalGas.July, fuelCostMonthly.Oil.July, fuelCostMonthly.Propane.July, fuelCostMonthly.Electricity.July),
                AugustCost = GetFuelCostByNames(fuelCostMonthly.Wood.August, fuelCostMonthly.NaturalGas.August, fuelCostMonthly.Oil.August, fuelCostMonthly.Propane.August, fuelCostMonthly.Electricity.August),
                SeptemberCost = GetFuelCostByNames(fuelCostMonthly.Wood.September, fuelCostMonthly.NaturalGas.September, fuelCostMonthly.Oil.September, fuelCostMonthly.Propane.September, fuelCostMonthly.Electricity.September),
                OctoberCost = GetFuelCostByNames(fuelCostMonthly.Wood.October, fuelCostMonthly.NaturalGas.October, fuelCostMonthly.Oil.October, fuelCostMonthly.Propane.October, fuelCostMonthly.Electricity.October),
                NovemberCost = GetFuelCostByNames(fuelCostMonthly.Wood.November, fuelCostMonthly.NaturalGas.November, fuelCostMonthly.Oil.November, fuelCostMonthly.Propane.November, fuelCostMonthly.Electricity.November),
                DecemberCost = GetFuelCostByNames(fuelCostMonthly.Wood.December, fuelCostMonthly.NaturalGas.December, fuelCostMonthly.Oil.December, fuelCostMonthly.Propane.December, fuelCostMonthly.Electricity.December),
            };
        }
        private FuelCostDTO GetFuelCostByNames(string wood,string naturalGas,string oil,string propane,string electricity)
        {
            IFuelCostByTypeBiz fuelCostByTypeBiz = new FuelCostByTypeBiz(_unitOfWork);
            FuelCostDTO fuelCostDTO = new FuelCostDTO();
            fuelCostDTO.WoodType = fuelCostByTypeBiz.GetFuelCostByTypeDTOByName(wood);
            fuelCostDTO.PropaneType = fuelCostByTypeBiz.GetFuelCostByTypeDTOByName(propane);
            fuelCostDTO.OilType = fuelCostByTypeBiz.GetFuelCostByTypeDTOByName(oil);
            fuelCostDTO.ElectricityType = fuelCostByTypeBiz.GetFuelCostByTypeDTOByName(electricity);
            fuelCostDTO.NaturalGasType = fuelCostByTypeBiz.GetFuelCostByTypeDTOByName(naturalGas);
            return fuelCostDTO;
        }
        private FuelCostDTO GetFuelCostDTO(ca.nrcan.gc.OEE.HouseFileLibrary.FuelCostsComponents.FuelCosts fuelCosts)
        {
            IBaseDetailBiz baseDetail = new BaseDetailBiz(_unitOfWork);
            IFuelCostByTypeBiz fuelCostByTypeBiz = new FuelCostByTypeBiz(_unitOfWork);
            return new FuelCostDTO()
            {
               NaturalGasType= GetFuelCostByTypeDTO(fuelCosts.NaturalGas[0]),
               ElectricityType= GetFuelCostByTypeDTO(fuelCosts.Electricity[0]),
               PropaneType= GetFuelCostByTypeDTO(fuelCosts.Propane[0]),
               OilType= GetFuelCostByTypeDTO(fuelCosts.Oil[0]),
               WoodType= GetFuelCostByTypeDTO(fuelCosts.Wood[0]),
            };
        }

        private FuelCostByTypeDTO GetFuelCostByTypeDTO(ca.nrcan.gc.OEE.HouseFileLibrary.FuelCostsComponents.FuelCostByType fuelCostByType)
        {
            IBaseDetailBiz baseDetail = new BaseDetailBiz(_unitOfWork);
            return new FuelCostByTypeDTO()
            {
                Comment = fuelCostByType.Comment,
                Label = fuelCostByType.Label,
                Units = baseDetail.getByHeadCodeAndDetailCode("FuelUnit", fuelCostByType.Units.Code),
                RateBlockMinUnits = fuelCostByType.Minimum.units,
                RateBlockMinCharge =fuelCostByType.Minimum.charge,
                RateBlock1Unit=fuelCostByType.RateBlocks.Block1.units,
                RateBlock1costPerUnit=fuelCostByType.RateBlocks.Block1.costPerUnit,
                RateBlock2Unit = fuelCostByType.RateBlocks.Block2.units,
                RateBlock2costPerUnit = fuelCostByType.RateBlocks.Block2.costPerUnit,
                RateBlock3Unit = fuelCostByType.RateBlocks.Block3.units,
                RateBlock3costPerUnit = fuelCostByType.RateBlocks.Block3.costPerUnit,
                RateBlock4Unit = fuelCostByType.RateBlocks.Block4.units,
                RateBlock4costPerUnit = fuelCostByType.RateBlocks.Block4.costPerUnit,
            };
        }


        private HouseWeatherDTO GetHouseWeatherDTO(ca.nrcan.gc.OEE.HouseFileLibrary.Components.HouseComponents.Weather weather)
        {
            IBaseDetailBiz baseDetail = new BaseDetailBiz(_unitOfWork);
            return new HouseWeatherDTO()
            {
                WeatherLib=weather.Library,
                Region = baseDetail.getByHeadCodeAndDetailCode("REGION", weather.Region.Code.ToString()),
                Locations= baseDetail.getByHeadCodeAndDetailCode("LOCATION", weather.Location.Code.ToString()),
                DEPTH_FROST=weather.DepthOfFrost,
                HEATINGDEGREEDAYS=weather.HeatingDegreeDay
            };
        }
        private List<HouseInfoDTO> GetHouseInfoDTOs(ca.nrcan.gc.OEE.HouseFileLibrary.HouseFile house)
        {
            List < HouseInfoDTO > houseInfoDTOs=new List<HouseInfoDTO> ();
            foreach (var item in house.ProgramInformation.Information)
            {
                houseInfoDTOs.Add(new HouseInfoDTO() { KeyValue = new KeyValueDTO() { KEY = item.Code, VALUE = item.Text } });
            }
            return houseInfoDTOs;
        }
        private HouseSpecificationDTO GetHouseSpecificationDTO(ca.nrcan.gc.OEE.HouseFileLibrary.Components.HouseComponents.SpecificationsComponents.Specifications specifications)
        {
            IBaseDetailBiz baseDetail = new BaseDetailBiz(_unitOfWork);
            return new HouseSpecificationDTO()
            {
                BulidingType= baseDetail.GetByHeadCode("BuildingType").Where(c => c.DETAIL_CODE == specifications.BuildingType.ToString()).FirstOrDefault(),
                HouseType= baseDetail.GetByHeadCode("HouseType").Where(c => c.DETAIL_CODE == specifications.HouseType.Code).FirstOrDefault(),
                PlanShapeType= baseDetail.GetByHeadCode("PlanShape").Where(c => c.DETAIL_CODE == specifications.PlanShape.Code).FirstOrDefault(),
                Storeys= baseDetail.GetByHeadCode("Storey").Where(c => c.DETAIL_CODE == specifications.Storeys.Code).FirstOrDefault(),
                FrontOrientation= baseDetail.GetByHeadCode("FrontOriention").Where(c => c.DETAIL_CODE == specifications.FacingDirection.Code).FirstOrDefault(),
                ThermalMassType= baseDetail.GetByHeadCode("ThermalMass").Where(c => c.DETAIL_CODE == specifications.ThermalMass.Code).FirstOrDefault(),
                YearBuiltType= baseDetail.GetByHeadCode("YearBuilt").Where(c => c.DETAIL_CODE == specifications.YearBuilt.Code).FirstOrDefault(),
                CustomYearBuilt= ((long)specifications.YearBuilt.Value),
                EffectiveMassFract=specifications.EffectiveMassFraction,
                WallColourType= baseDetail.GetByHeadCode("ColuorType").Where(c => c.DETAIL_CODE == specifications.WallColour.Code).FirstOrDefault(),
                WallCoLourValue=specifications.WallColour.Value,
                FoundSoilCondType= baseDetail.GetByHeadCode("Soil").Where(c => c.DETAIL_CODE == specifications.SoilCondition.Code).FirstOrDefault(),
                RoofCoLourType=baseDetail.GetByHeadCode("ColuorType").Where(c => c.DETAIL_CODE == specifications.RoofColour.Code).FirstOrDefault(),
                RoofColourValue=specifications.RoofColour.Value,
                WaterTabLevelType= baseDetail.GetByHeadCode("WTableLevel").Where(c => c.DETAIL_CODE == specifications.WaterLevel.Code).FirstOrDefault(),
                DefaultCavity=specifications.DefaultRoofCavity,
                RoofCavityInput= GetRoofCavityInputDTO(specifications.RoofCavity),
                IS_NBC_COMP=specifications.EligibleForNBC,
                HeatFloorAreaAbove=specifications.HeatedFloorArea.AboveGrade,
                HeatFloorAreaBelow=specifications.HeatedFloorArea.BelowGrade,
                

            };
        }
        private RoofCavityInputDTO GetRoofCavityInputDTO(ca.nrcan.gc.OEE.HouseFileLibrary.Components.HouseComponents.SpecificationsComponents.RoofCavity roofCavity)
        {
            IBaseDetailBiz baseDetail = new BaseDetailBiz(_unitOfWork);
            return new RoofCavityInputDTO()
            {
                GeTotalArea=roofCavity.GableEnds.area,
                GeSheathingMatType=baseDetail.getByHeadCodeAndDetailCode("SheathingMatType",roofCavity.GableEnds.SheatingMaterial.Code),
                GeSheathingMatValue=roofCavity.GableEnds.SheatingMaterial.Value,
                GeExteriorMatType= baseDetail.getByHeadCodeAndDetailCode("ExteriorMatType", roofCavity.GableEnds.ExteriorMaterial.Code),
                GeExteriorMatValue=roofCavity.GableEnds.ExteriorMaterial.Value,
                SrTotalArea = roofCavity.SlopedRoof.area,
                SrSheathingMatType = baseDetail.getByHeadCodeAndDetailCode("SheathingMatType", roofCavity.SlopedRoof.SheatingMaterial.Code),
                SrSheathingMatValue = roofCavity.SlopedRoof.SheatingMaterial.Value,
                SrRoofingMatType = baseDetail.getByHeadCodeAndDetailCode("RoofingMatType", roofCavity.SlopedRoof.RoofingMaterial.Code),
                SrRoofingMatValue = roofCavity.SlopedRoof.RoofingMaterial.Value,
                CavityVol=roofCavity.Volume,
                VentilationRate=roofCavity.VentilationRate
            };
        }
        private JustificationDTO GetJustificationDTO(ca.nrcan.gc.OEE.HouseFileLibrary.Components.HouseComponents.Justifications justifications)
        {
            IBaseDetailBiz baseDetail = new BaseDetailBiz(_unitOfWork);
            return new JustificationDTO() {
                EfficFromNameplate = justifications.NameplateEfficiency,
                EfficFromComTest = justifications.CombustionTestEfficiency,
                HeatSysCorrect = justifications.HeatingCorrection,
                PossesionDate = justifications.PossessionDate.Date,
                HeatVolumeDec=justifications.HeatingVolumeDecrease.Text,
                InsCorrectValCeiling=justifications.CorrectedInsulation.Ceilings.Text,
                InsCorrectValWall=justifications.CorrectedInsulation.Walls.Text,
                InsCorrectValBasement=justifications.CorrectedInsulation.Basement.Text,
                AchCorrect=justifications.AchCorrection,
                TwoBlowerDoor=justifications.TwoBlowerDoors,
                Other=justifications.Other.Text,
                Up18Mon=justifications.Over18Months,
                EnergyStarType= baseDetail.GetByHeadCode("ENERGYSTAR").Where(c => c.DETAIL_CODE == justifications.EnergyStar.Code).FirstOrDefault()
            };
        }
        private HouseClientDTO GetHouseClientDTO(ca.nrcan.gc.OEE.HouseFileLibrary.HouseFile houseFile)
        {
            return new HouseClientDTO()
            {
                FirstName = houseFile.ProgramInformation.Client.Name.First,
                LastName = houseFile.ProgramInformation.Client.Name.Last,
                Telephone = houseFile.ProgramInformation.Client.Telephone,
                StreetAddress = new Common.DTOs.baseInfo.AddressDTO()
                {
                    Street = houseFile.ProgramInformation.Client.StreetAddress.Street,
                    City = houseFile.ProgramInformation.Client.StreetAddress.City.EnglishText,
                    ProvinceOrTerritory = houseFile.ProgramInformation.Client.StreetAddress.ProvinceOrTerritory,
                    PostalCode = houseFile.ProgramInformation.Client.StreetAddress.PostalCode,
                    UnitNumber = houseFile.ProgramInformation.Client.StreetAddress.UnitNumber
                },
                MailAddress = new Common.DTOs.baseInfo.AddressDTO()
                {
                    Street = houseFile.ProgramInformation.Client.MailingAddress.Street,
                    City = houseFile.ProgramInformation.Client.MailingAddress.City.EnglishText,
                    ProvinceOrTerritory = houseFile.ProgramInformation.Client.MailingAddress.ProvinceOrTerritory,
                    PostalCode = houseFile.ProgramInformation.Client.MailingAddress.PostalCode,
                    UnitNumber = houseFile.ProgramInformation.Client.MailingAddress.UnitNumber,
                    Name = houseFile.ProgramInformation.Client.MailingAddress.Name

                }
            };
        }
        public PaginatedResult<HouseFileDTO> Show(HouseFileSearch search)
        {
            var data = Get();
            return data.ToDTOPaginatedResult<HouseFile, HouseFileDTO>(search);
        }
        //public NetworkResponseDTO GetTree(string houseId)
        //{
        //    var data = Get(i=>i.HOUSE_ID==houseId);
        //    UnitOfWork.Repository<Windows>().Get(w=>w.)
        //    return data.ToDTOPaginatedResult<HouseFile, HouseFileDTO>(search);
        //}
    }
}
