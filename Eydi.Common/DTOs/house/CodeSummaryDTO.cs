using ES.Core.Contracts.DTOs;
using ES.Core.Contracts.Entities;
namespace ES.DTOs.house
{
    public class CodeSummaryDTO: StrongEntityDTO
    {
        public string Code { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public bool? Liberary { get; set; }
        public class CodeSummarySearch : BaseSearch
        {

        }
    }
}
