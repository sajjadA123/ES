using ES.Common.DTOs;
using ES.Common.DTOs.Common;
using ES.Core.Biz;
using ES.Core.Contracts.Entities;
using ES.DTOs.house;
using System;
using System.Collections.Generic;
using System.Text;

namespace ES.Service.Contracts
{
    public interface IHouseFileBiz:IBiz<HouseFileDTO>
    {
        PaginatedResult<HouseFileDTO> Show(HouseFileSearch search);
        //NetworkResponseDTO GetTree(string houseId);
        HouseFileDTO GetDataFromFile(string fileName);
    }
}
