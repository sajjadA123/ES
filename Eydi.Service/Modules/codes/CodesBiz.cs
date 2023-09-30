using ES.Common.Enums;
using ES.Core.Biz;
using ES.Core.Contracts.Entities;
using ES.Core.DataAccess;
using ES.Core.Module;
using ES.Domain.Entity.codes;
using ES.DTOs.codes;
using ES.Service.Contracts.codes;
using System;
using System.Linq;

namespace ES.Service.Modules.codes
{
    public class CodesBiz : BaseBiz<CodeByTypes, CodeByTypesDTO>, ICodesBiz
    {
        public CodesBiz(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public CodeByTypesDTO getByTypeAndCode(CodeTypes type, string Code)
        {
            System.Linq.Expressions.Expression<Func<CodeByTypes, bool>> body = s => s.CodeType == type && s.Value == Code;
            return Extensions.ToDTO<CodeByTypesDTO>(base.Get(body).FirstOrDefault());
        }

        public PaginatedResult<CodeByTypesDTO> Show(CodeByTypesSearch search)
        {
            var data = Get();
            return data.ToDTOPaginatedResult<CodeByTypes, CodeByTypesDTO>(search);
        }
    }
}
