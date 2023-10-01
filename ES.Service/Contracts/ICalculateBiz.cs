using ES.Core.Biz;
using ES.Core.Contracts.Entities;
using ES.Core.Contracts.Entities.calculate;

namespace ES.Service.Contracts
{
    public  interface ICalculateBiz :IBiz<CalculateInput>
    {
        PaginatedResult<CalculateInput> Show(CalculateInputSearch search);
    }
}
