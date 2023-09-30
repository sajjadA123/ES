using ES.Common.Enums;
using ES.Core.Contracts.DTOs;
using ES.Core.Contracts.Entities;

namespace ES.DTOs.components
{
    public class WindowsDTO : StrongEntityDTO
    {
        public string  Lable { get; set; }
        public decimal? ShuterRValue { get; set; }
        public decimal? Curtain { get; set; }
        public bool? AdjustEnclose { get; set; }
        public bool? EnergyStar { get; set; }
        public UValues UvalueType { get; set; }
        public long? ERValue { get; set; }

        public Orientation Orientation { get; set; }

        public long? WinNumber { get; set; }
        public long? Width { get; set; }
        public long? Heigth { get; set; }
        public long? GrossArea { get; set; }
        public long? OvHangWidth { get; set; }
        public long? HeaderHeigth { get; set; }

        public WindowTiltType TiltType { get; set; }

        public decimal? TiltValue { get; set; }

        public decimal? Er2009 { get; set; }
        public decimal? RValue { get; set; }
        public decimal? SHGC { get; set; }

    }
    public class WindowsSearch : BaseSearch
    {

    }
}
