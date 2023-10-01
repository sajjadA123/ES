using ES.Core.Contracts.Entities;
using System.ComponentModel.DataAnnotations;

namespace ES.Domain.Entity.components
{
    public class Components : StrongEntity
    {
        public int ComponentType { get; set; }
        [MaxLength(100)]
        public string Description { get; set; }
        public bool Insertable { get; set; }
    }
}
