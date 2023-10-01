using ES.Core.Contracts.DTOs;
using ES.Core.Contracts.Entities;
using System;

namespace ES.DTOs.baseInfo
{
    public class TbHeadDTO:StrongEntityDTO
    {
        public string HeadCode { get; set; }
        public string HeadDesc { get; set; }
        public bool? Status { get; set; }
        public TimeSpan StatusDate { get; set; }
        public class TbHeadSearch : BaseSearch
        {

        }
    }
}
