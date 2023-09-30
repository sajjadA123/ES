
using ES.Core.Biz;
using ES.Core.Contracts.Entities;
using ES.DTOs.components;
using static ES.DTOs.components.WallsDTO;

namespace ES.Service.Contracts
{
    public interface IWallsBiz:IBiz<WallsDTO>
    {
        PaginatedResult<WallsDTO> Show(WallsSearch search);
    }
}
