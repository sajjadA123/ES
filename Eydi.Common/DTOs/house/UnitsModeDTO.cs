using ES.Common.Enums;
using ES.Core.Contracts.DTOs;
using ES.Core.Contracts.Entities;
using ES.DTOs.baseInfo;

namespace ES.DTOs.house
{
    public class UnitsModeDTO: StrongEntityDTO
    {
        public long? HouseId { get; set; }
        public HouseFileDTO House { get; set; }

        public DisplayUnitType DisplayUnitType{ get; set; }

        public long? ProgramsTypeId{ get; set; }
        public TbDetailDTO ProgramsType { get; set; }
        public class UnitsModeSearch : BaseSearch
        {

        }
    }
}
