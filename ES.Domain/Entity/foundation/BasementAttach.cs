using ES.Core.Contracts.Entities;
using ES.Domain.Entity.components;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ES.Domain.Entity.foundation
{
    public class BasementAttach:StrongEntity
    {
		public class Base_Attachment
		{
			public long BasementId { get; set; }
			public Basement Basement { get; set; }

			public long? AttachToTypeId { get; set; }
            public Components AttachToType { get; set; }
            public long? AttachToId { get; set; }
			[MaxLength(50)]
			public string AtachedFoundationType { get; set; }
			[Column(TypeName = "numeric(18,4)")]
			public decimal? AboveGArea { get; set; }
			[Column(TypeName = "numeric(18,4)")]
			public decimal? BelowGArea { get; set; }
			[Column(TypeName = "numeric(18,4)")]
			public decimal? Length { get; set; }
		}
	}
}
