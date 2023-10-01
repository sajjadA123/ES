using ES.Core.Biz;
using ES.Core.Contracts.Entities;
using ES.Core.DataAccess;
using ES.Core.Module;
using ES.Common.DTOs;
using ES.Service.Contracts;
using ES.Domain.Entity.components;

namespace ES.Services.Modules
{
    public class ComponentsBiz : BaseBiz<Components, ComponentsDTO>, IComponentsBiz
    {
        public ComponentsBiz(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
        public PaginatedResult<ComponentsDTO> Show(ComponentsSearch search)
        {
            var data = Get();
            return data.ToDTOPaginatedResult<Components, ComponentsDTO>(search);
        }
    }
}
