using ES.Common.Enums;
using ES.Core.Contracts.Entities;
using ES.Domain.Entity.baseInfo;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ES.Domain.Entity.components
{
    public class Windows : StrongEntity
    {
        [MaxLength(100)]
        public string  Lable { get; set; }
        [Column(TypeName = "numeric(18,4)")]
        public decimal? ShuterRValue { get; set; }
        [Column(TypeName = "numeric(18,4)")]
        public decimal? Curtain { get; set; }
        public bool? AdjustEnclose { get; set; }
        public bool? EnergyStar { get; set; }
        public UValues UvalueType { get; set; }
        public long? ERValue { get; set; }

        public long? OrientationId { get; set; }
        public TbDetail Orientation { get; set; }

        public long? WinNumber { get; set; }
        public long? Width { get; set; }
        public long? Heigth { get; set; }
        public long? GrossArea { get; set; }
        public long? OvHangWidth { get; set; }
        public long? HeaderHeigth { get; set; }

        public long? TiltTypeId { get; set; }
        public TbDetail TiltType { get; set; }

        public long? TiltValue { get; set; }

        public long? Er2009 { get; set; }
        public long? RValue { get; set; }
        public long? SHGC { get; set; }


    }
}
