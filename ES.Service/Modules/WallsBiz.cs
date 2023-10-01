using ES.Core.Biz;
using ES.Core.Contracts.Entities;
using ES.Core.DataAccess;
using ES.Core.Module;
using ES.Service.Contracts;
using ES.Domain.Entity.components;
using ES.DTOs.components;
using static ES.DTOs.components.WallsDTO;

namespace ES.Services.Modules
{
    public class WallsBiz : BaseBiz<Walls, WallsDTO>, IWallsBiz
    {
        public WallsBiz(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
        public PaginatedResult<WallsDTO> Show(WallsSearch search)
        {
            var data = Get();
            return data.ToDTOPaginatedResult<Walls, WallsDTO>(search);
        }
    }
}
