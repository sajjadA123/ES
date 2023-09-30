using ES.Common.Enums;
using ES.Core.Biz;
using ES.Core.Contracts.Entities;
using ES.DTOs.codes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.Service.Contracts.codes
{
    public interface ICodesBiz : IBiz<CodeByTypesDTO>
    {
        PaginatedResult<CodeByTypesDTO> Show(CodeByTypesSearch search);
        CodeByTypesDTO getByTypeAndCode(CodeTypes type, string Code);
    }
}
