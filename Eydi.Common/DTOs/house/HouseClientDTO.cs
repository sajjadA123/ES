using ES.Common.DTOs.baseInfo;
using ES.Core.Contracts.DTOs;
using ES.Core.Contracts.Entities;
using ES.DTOs.baseInfo;

namespace ES.DTOs.house
{
    public class HouseClientDTO: StrongEntityDTO
    {
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Telephone { get; set; }
		public AddressDTO StreetAddress { get; set; }
        public AddressDTO MailAddress { get; set; }
        public class ClientSearch : BaseSearch
        {

        }

    }
}
