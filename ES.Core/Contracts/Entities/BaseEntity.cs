using System;

namespace ES.Core.Contracts.Entities
{
	public abstract class BaseEntity
    {
	    public BaseEntity()
	    {
            DATEINSERTED = DateTime.Now;
	    }
        public int CREATORID { get; set; }
        public DateTime DATEINSERTED { get; set; }
        public DateTime? DATEMODIFIED { get; set; }
        public long? LocationType { get; set; }
        public long? LocationId { get; set; }
        public int? UPDATERID { get; set; }
        public bool ISDELETE { get; set; }

    }
}