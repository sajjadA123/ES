using ES.Core.Contracts.DTOs;
using ES.Core.Contracts.Entities;

namespace ES.DTOs.components
{
    public class ComponentsDTO : StrongEntityDTO
    {
        public int ComponentType { get; set; }
        public string Description { get; set; }
        public bool Insertable { get; set; }
        public class ComponentsSearch : BaseSearch
        {

        }
    }
}
