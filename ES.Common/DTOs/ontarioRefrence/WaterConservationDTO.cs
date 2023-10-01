using ES.Core.Contracts.DTOs;
using ES.Core.Contracts.Entities;

namespace ES.DTOs.ontarioRefrence
{
    public class WaterConservationDTO:StrongEntityDTO
    {
        //[Key]
        //public long? Id { get; set; }
        public decimal? Observed { get; set; }
        public decimal? Recommnded { get; set; }
        public class WaterConservationSearch : BaseSearch
        {

        }
    }
}
