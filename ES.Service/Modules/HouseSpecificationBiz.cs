using ES.Core.Biz;
using ES.Core.Contracts.Entities;
using ES.Core.DataAccess;
using ES.Core.Module;
using ES.Domain.Entity;
using ES.Services.Contracts;
using ES.DTOs;
using ES.Common.DTOs;
using ES.Service.Contracts;

namespace ES.Services.Modules
{
    public class HouseSpecificationBiz : BaseBiz<HouseSpecification, Common.DTOs.HouseSpecificationDTO>, IHouseSpecificationBiz
    {
        public HouseSpecificationBiz(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
        public PaginatedResult<Common.DTOs.HouseSpecificationDTO> Show(HouseSpecificationSearch search)
        {
            var data = Get();
            return data.ToDTOPaginatedResult<HouseSpecification, Common.DTOs.HouseSpecificationDTO>(search);
        }
    }
}
