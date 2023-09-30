using ES.Core.Contracts.DTOs;
using ES.Core.Contracts.Entities;


namespace ES.Common.DTOs.foundation
{
    public class BasementConfigDTO:StrongEntityDTO
    {
        public string ConfingLable { get; set; }
        public byte[] ConfigImage { get; set; }
        public string ConfigDecriprion { get; set; }
        public long? IsulationId { get; set; }
        public InsulationConfigDTO Isulation { get; set; }
        public class BasementConfigSearch : BaseSearch
        {

        }

    }
}
