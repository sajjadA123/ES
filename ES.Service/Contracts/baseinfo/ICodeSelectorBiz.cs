using ES.Common.DTOs;
using ES.Core.Biz;
using ES.Core.Contracts.Entities;
using ES.DTOs.baseInfo;
using System;
using System.Collections.Generic;
using System.Text;
using static ES.DTOs.baseInfo.CodeSelectorDTO;

namespace ES.Service.Contracts
{
    public interface ICodeSelectorBiz:IBiz<CodeSelectorDTO>
    {
        PaginatedResult<CodeSelectorDTO> Show(CodeSelectorSearch search);
    }
}
