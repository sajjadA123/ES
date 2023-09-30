using ES.Core.Contracts.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ES.Domain.Entity
{
    //امضا کننده
    public class User : StrongEntity
    {
        [Required]
        [MaxLength(200)]
        [Column(TypeName = "VARCHAR(200)")]
        public string FIRSTNAME { get; set; }

        [Required]
        [MaxLength(200)]
        [Column(TypeName = "VARCHAR(200)")]
        public string LASTNAME { get; set; }
    }
}
