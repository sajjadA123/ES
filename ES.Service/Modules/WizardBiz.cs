using ES.Common.DTOs.components;
using ES.Common.DTOs.foundation;
using ES.Common.DTOs.wizard;
using ES.Common.Enums;
using ES.Core.Biz;
using ES.Core.Contracts.Entities;
using ES.Core.DataAccess;
using ES.DTOs.components;
using ES.DTOs.house;
using ES.Service.Contracts;
using ES.Service.Contracts.baseinfo;
using ES.Service.Contracts.components;
using ES.Service.Modules.baseinfo;
using ES.Service.Modules.components;
using ES.Services.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.Service.Modules
{
    public class WizardBiz : BaseBiz<BaseEntity, WizardDTO>, IWizardBiz
    {
        IUnitOfWork _unitOfWork;
        public WizardBiz(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        
        public bool Insert(WizardDTO wizardDTO)
        {
            BasementDTO basementDTO = getBasement(wizardDTO.basement,BasementType.Basement);
            BasementDTO crawlSpaceDTO = getBasement(wizardDTO.crawlSpace,BasementType.CrwlSpace);
            BasementDTO slapOnGradeDTO = getBasement(wizardDTO.slapOnGrade,BasementType.Slab);

            WallsDTO wallsDTO = getWall(wizardDTO.mainWall);

            FloorHeaderDTO floorHeaderDTO = getFloorHeader(wizardDTO.header);

            CeilingDTO ceilingDTO=getCeiling(wizardDTO.ceiling);

            IBasementBiz basementBiz = new BasementBiz(_unitOfWork);
            IWallsBiz wallsBiz = new WallsBiz(_unitOfWork);
            ICeilingBiz ceilingBiz = new CeilingBiz(_unitOfWork);
            IFloorHeaderBiz floorHeaderBiz = new FloorHeaderBiz(_unitOfWork);
            using (var _db = _unitOfWork.GetContext())
            {
                using (var _tr = _db.Database.BeginTransaction())
                {
                    try
                    {
                        var a=basementBiz.InsertAndReturn(basementDTO);
                        wallsBiz.Insert(wallsDTO, false);
                        ceilingBiz.Insert(ceilingDTO, false);
                        floorHeaderBiz.Insert(floorHeaderDTO, false);
                        _db.SaveChanges();
                        _tr.Commit();
                        return true;
                    }
                    catch (Exception ex) { _tr.Rollback(); return false; }
                }
            }

        }

        public PaginatedResult<WizardDTO> Show(WizardSearch search)
        {
            throw new NotImplementedException();
        }
        private BasementDTO getBasement(WizardBasementDTO wizardBasementDTO,BasementType bType)
        {
            ICodeSelectorBiz codeSelectorBiz = new CodeSelectorBiz(_unitOfWork);
            IBaseDetailBiz baseDetail = new BaseDetailBiz(_unitOfWork);
            BasementDTO basementDTO = new BasementDTO(bType)
            {
                FoundationConst = new FoundationDTO() {
                    PonyWall = wizardBasementDTO.foundation.ponyWall,
                    WallDimTotalHeigth = wizardBasementDTO.foundation.wallHeigth,
                    ExSurPerimeter = wizardBasementDTO.foundation.exposedSurfacePerimeter,
                    WallDepthBGrade = wizardBasementDTO.foundation.wallDepthBelowGrade,
                    Lable = wizardBasementDTO.foundation.foundationLable
                },
                WallFloorConst = new WallFloorConstructionDTO()
                {
                    FloorAbvFoundType = codeSelectorBiz.GetByPK(wizardBasementDTO.wallFloorConst.floorAboveFoundation),
                    FloorAbvFoundTypeId = wizardBasementDTO.wallFloorConst.floorAboveFoundation,
                    PonyWallConsTypeId = wizardBasementDTO.wallFloorConst.ponyWallConstType,
                    PonyWallConsType = codeSelectorBiz.GetByPK(wizardBasementDTO.wallFloorConst.ponyWallConstType),
                    ExtAddInsTypeId = wizardBasementDTO.wallFloorConst.exteriorInsulationConstType,
                    ExtAddInsType = baseDetail.GetByPK(wizardBasementDTO.wallFloorConst.exteriorInsulationConstType),
                    HeatedFloor = wizardBasementDTO.wallFloorConst.heatedFloor,
                    WallConsInAddedIns = codeSelectorBiz.GetByPK(wizardBasementDTO.wallFloorConst.ponyWallConstType),
                    WallConsInAddedInsId = wizardBasementDTO.wallFloorConst.corner
                }
            };
            return basementDTO;
        }
        private WallsDTO  getWall(WizardMainWallDTO wizardMainWallDTO)
        {
            ICodeSelectorBiz codeSelectorBiz = new CodeSelectorBiz(_unitOfWork);
            WallsDTO wallsDTO = new WallsDTO()
            {
                AdjustEnclosedUncondSPC = wizardMainWallDTO.adjstEncloseSp,
                Intersection = wizardMainWallDTO.intersectionNum,
                Lable = wizardMainWallDTO.wallLable,
                Primeter = wizardMainWallDTO.perimeter,
                Heigth = wizardMainWallDTO.totalHeigth,
                Corners = wizardMainWallDTO.cornerNum,
                WallType = codeSelectorBiz.GetByPK(wizardMainWallDTO.wallType),
                WallTypeId = wizardMainWallDTO.wallType

            };
            return wallsDTO;
        }
        private FloorHeaderDTO getFloorHeader(WizardFloorHeaderDTO wizardFloorHeaderDTO)
        {

            ICodeSelectorBiz codeSelectorBiz = new CodeSelectorBiz(_unitOfWork);
            FloorHeaderDTO floorHeaderDTO = new FloorHeaderDTO()
            {
                FloorHeaderType = codeSelectorBiz.GetByPK(wizardFloorHeaderDTO.headerType),
                FloorHeaderTypeId = wizardFloorHeaderDTO.headerType,
                Location = wizardFloorHeaderDTO.headerLocation,
                Heigth = wizardFloorHeaderDTO.headerHeigth,
                Primeter = wizardFloorHeaderDTO.headerPerimeter

        };
            return floorHeaderDTO;
        }
        private CeilingDTO getCeiling(WizardCeilingDTO wizardCeilingDTO)
        {
            
            ICodeSelectorBiz codeSelectorBiz = new CodeSelectorBiz(_unitOfWork);
            IBaseDetailBiz baseDetail = new BaseDetailBiz(_unitOfWork);
            CeilingDTO ceilingDTO = new CeilingDTO()
            {
                CeilLable = wizardCeilingDTO.ceilingLable,
                ConstractType =(CeilingConstType)  wizardCeilingDTO.constType,
                CeilType = codeSelectorBiz.GetByPK(wizardCeilingDTO.ceilingType),
                CeilTypeID = wizardCeilingDTO.ceilingType,
                Length = wizardCeilingDTO.EAVlength,
                Area = wizardCeilingDTO.area,
                RoofSlopeType=baseDetail.GetByPK( wizardCeilingDTO.roofSlopeType),
                RoofSlopeId=wizardCeilingDTO.roofSlopeType

            };
            return ceilingDTO;
        }

        public HouseFileDTO GeneateHouseDTO(WizardDTO wizardDTO)
        {
            throw new NotImplementedException();
        }
    }
}
