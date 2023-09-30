using ES.Core.Contracts.DTOs;
using ES.Core.Contracts.Entities;
using ES.DTOs.baseInfo;

namespace ES.DTOs.ventilation
{
    public class RoomsInputDTO:StrongEntityDTO
    {
		//[Key]
  //      public long Id { get; set; }
        public decimal? KitchenLivingDiningRoom { get; set; }
		public decimal? Bedroom { get; set; }
		public decimal? Bathroom { get; set; }
		public decimal? UtilityRoom { get; set; }
		public decimal? OtherHabitableRoom { get; set; }
		public long? VentiRateOtherBaseTypeId { get; set; }
		public TbDetailDTO VentiRateOtherBaseType { get; set; }
		public decimal? MinVentiRate { get; set; }
		public long? VentedComAppLimitTypeId { get; set; }
        public TbDetailDTO VentedComAppLimitType { get; set; }
		public decimal? VentedComAppLimitVal { get; set; }
		public class RoomsInputSearch : BaseSearch
		{

		}
	}
}
