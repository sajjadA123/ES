using ES.Core.Contracts.DTOs;
using ES.Core.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ES.Common.DTOs
{
    public class WinTightnessDTO:StrongEntityDTO
    {
        public decimal? HOUSEID { get; set; }
        public decimal? WINAIRTIGTHNESSTYPE { get; set; }
        public decimal? WINAIRTIGTHNESSVALUE { get; set; }
    }
    public class WinTightnessSearch : BaseSearch
    {

    }
}
