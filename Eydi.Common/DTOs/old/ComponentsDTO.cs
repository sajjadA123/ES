using ES.Core.Contracts.DTOs;
using ES.Core.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ES.Common.DTOs
{
    public class ComponentsDTO : StrongEntityDTO
    {
        public string Decription { get; set; }
        public string   ComponentType { get; set; }
        public string Insertable { get; set; }
    }
    public class ComponentsSearch : BaseSearch
    {

    }
}
