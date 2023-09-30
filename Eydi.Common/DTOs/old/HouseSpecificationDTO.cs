using ES.Core.Contracts.DTOs;
using ES.Core.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ES.Common.DTOs
{
    public class HouseSpecificationDTO:StrongEntityDTO
    {
		public decimal? BULIDINGTYPE { get; set; }
		public decimal? PLANSHAPE { get; set; }
		public decimal? STOREYS { get; set; }
		public decimal? FRONTORIEN { get; set; }
		public decimal? THERMALMASS { get; set; }
		public decimal? YEARBUILT { get; set; }
		public decimal? CUSTOMYEARBUILT { get; set; }
		public decimal? EFFECTIVEMASSFRACT { get; set; }
		public decimal? WALLCOLTYPE { get; set; }
		public decimal? WALLCOLVALUE { get; set; }
		public decimal? FOUNDSOILCOND { get; set; }
		public decimal? ROOFCOLTYPE { get; set; }
		public decimal? ROOFCOLVALUE { get; set; }
		public decimal? WATERTABLEVEL { get; set; }
		public decimal? ROOFCAVITYID { get; set; }
		public string? ISNBCCOMP { get; set; }
		public decimal? HEATFLOORABOVE { get; set; }
		public decimal? HEADFLOORBELOW { get; set; }
		public string HOUSEID { get; set; }
	}
	public class HouseSpecificationSearch : BaseSearch
	{

	}
}
