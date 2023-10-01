using ES.Core.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ES.Domain.Entity.heatingAndCooling
{
    public class Radiant:StrongEntity
    {
		//[Key]
		//public long? Id { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? AticCeilingEffTemp { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? AticCeilingTotArea { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? FlatRoofEffTemp { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? FlatRoofTotArea { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? FloorAbCrawlSpcEffTemp { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? FloorAbCrawlSpcTotArea { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? SlabOnGradeEffTemp { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? SlabOnGradeTotArea { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? FloorAbBasementEffTemp { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? FloorAbBasementTotArea { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? BasementEffTemp { get; set; }
		[Column(TypeName = "numeric(18,4)")]
		public decimal? BasementTotArea { get; set; }
		
	}
}
