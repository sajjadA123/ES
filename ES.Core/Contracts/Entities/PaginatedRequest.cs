using System.Collections.Generic;
//using Kendo.DynamicLinq;

namespace ES.Core.Contracts.Entities
{
	public class PaginatedRequest
	{
	    public PaginatedRequest()
	    {
	        Page = 1;
	        PageSize = 10;
	    }
		public int Skip => (Page - 1) * PageSize;

        public int Take => PageSize;

	    private string _sort;

	    public string Sort
	    {
	        get => _sort?.Replace("-", " ");
	        set => _sort = value;
	    }

	    public bool HasSort => _sort != null;

	    public int Page { get; set; }

	    public int PageSize { get; set; }
		
	}
}
