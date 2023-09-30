using ES.Core.Biz;
using ES.Core.Contracts.Entities;
using ES.Core.Contracts.Entities.calculate;
using ES.Core.DataAccess;
using ES.Service.Contracts;

namespace ES.Services.Modules.Calculate
{
    public class CalculateBiz : BaseBiz<BaseEntity, CalculateInput>, ICalculateBiz
    {
        public CalculateBiz(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
        public PaginatedResult<CalculateInput> Show(CalculateInputSearch search)
        {
            //var data = Get();
            return null; //data.ToDTOPaginatedResult<BankInformation, BankInformationDTO>(search);
        }
       
    }
}
