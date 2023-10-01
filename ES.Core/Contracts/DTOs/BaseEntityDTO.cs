using System;

namespace ES.Core.Contracts.DTOs
{
    public abstract class BaseEntityDTO //: IEntityDTO
    {
        public BaseEntityDTO()
        {
            DateInserted = DateTime.Now;
        }


        public int CreatorId { get; set; }
        public DateTime DateInserted { get; set; }
        public DateTime? DateModified { get; set; }
        public int? UpdaterId { get; set; }
        public bool IsDelete { get; set; }

    }
}
