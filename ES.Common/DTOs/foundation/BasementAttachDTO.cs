using ES.Core.Contracts.DTOs;
using ES.Core.Contracts.Entities;
using ES.DTOs.components;

namespace ES.Common.DTOs.foundation
{
    public class BasementAttachDTO:StrongEntityDTO
    {
			public decimal? BasementId { get; set; }
			public BasementDTO Basement { get; set; }

			public long? AttachToTypeId { get; set; }
            public ComponentsDTO AttachToType { get; set; }
            public long? AttachToId { get; set; }
			public string AtachedFoundationType { get; set; }
			public decimal? AboveGArea { get; set; }
			public decimal? BelowGArea { get; set; }
			public decimal? Length { get; set; }
		public class BasementAttachSearch : BaseSearch
		{

		}
	}
}
