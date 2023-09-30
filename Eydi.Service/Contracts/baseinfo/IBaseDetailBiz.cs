using ES.Core.Biz;
using ES.Core.Contracts.Entities;
using ES.DTOs.baseInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.Service.Contracts.baseinfo
{
    public interface IBaseDetailBiz : IBiz<TbDetailDTO>
    {
        PaginatedResult<CodeSelectorDTO> Show(CodeSelectorSearch search);
        List<TbDetailDTO> GetByHeadCode(string code);
        TbDetailDTO getByHeadCodeAndDetailCode(string headCode, string detailCode);
    }
}
