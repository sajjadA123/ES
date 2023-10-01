using ES.Core.Contracts.Entities;
using ES.Domain.Entity.house;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ES.Domain.Entity
{
	public class HouseFile:StrongEntity
	{
		[MaxLength(30)]
        public string	FileId { get; set; }
		[MaxLength(30)]
		public string PrevFileId { get; set; }
		[MaxLength(30)]
		public string HouseId { get; set; }
		[MaxLength(30)]
		public string HomeOwnerId { get; set; }
		public long? OwnershipId { get; set; }
		[MaxLength(50)]
		public string TaxRollNum { get; set; }
		[MaxLength(50)]
		public string BuilderName { get; set; }
		public TimeSpan EvalDate { get; set; }
		[MaxLength(50)]
		public string EnteredBy { get; set; }
		[MaxLength(20)]
		public string Telephone { get; set; }
		[MaxLength(5)]
		public string Extention { get; set; }
		[MaxLength(5)]
		public string CompanyExtention { get; set; }
		[MaxLength(30)]
		public string CompanyUser { get; set; }
		[MaxLength(20)]
		public string CompanyTelephone { get; set; }
		public bool? MixedUse { get; set; }

		public long? ClientId { get; set; }
        public Client HouseClient { get; set; }
		public long? JustificationId { get; set; }
        public Justification Justification { get; set; }
    }
}
