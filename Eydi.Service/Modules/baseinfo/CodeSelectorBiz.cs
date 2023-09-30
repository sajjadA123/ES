using ES.Core.Biz;
using ES.Core.Contracts.Entities;
using ES.Core.DataAccess;
using ES.Core.Module;
using ES.Domain.Entity;
using ES.Services.Contracts;
using ES.DTOs;
using ES.Common.DTOs;
using ES.Service.Contracts;
using ES.DTOs.baseInfo;
using ES.Domain.Entity.baseInfo;

namespace ES.Services.Modules
{
    public class CodeSelectorBiz : BaseBiz<CodeSelector, CodeSelectorDTO>, ICodeSelectorBiz
    {
        public CodeSelectorBiz(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public PaginatedResult<CodeSelectorDTO> Show(CodeSelectorSearch search)
        {
            throw new System.NotImplementedException();
        }
    }
}
