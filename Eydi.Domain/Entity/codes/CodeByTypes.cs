using ES.Common.Enums;
using ES.Domain.Entity.baseInfo;
using ES.DTOs.baseInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.Domain.Entity.codes
{
    public class CodeByTypes:Code
    {
        public string Value { get; set; }
        public CodeTypes CodeType { get; set; }
        public bool IsFavorite { get; set; }
        // public List<UserDefinedDTO> UserDefineds { get; set; }
        public TbDetail InsulationInFramingLayer { get; set; }
        public TbDetail ExtraInsulationLayer { get; set; }
        public TbDetail Framing { get; set; }
        public TbDetail StructureType { get; set; }
        public TbDetail ComponentTypeSize { get; set; }
        public TbDetail Spacing { get; set; }
        public TbDetail Insulation { get; set; }
        public TbDetail InsulationLayer1 { get; set; }
        public TbDetail InsulationLayer2 { get; set; }
        public TbDetail Interior { get; set; }
        public TbDetail InteriorFinish { get; set; }
        public TbDetail Sheathing { get; set; }
        public TbDetail Exterior { get; set; }
        public TbDetail Type { get; set; }
        public TbDetail DropFraming { get; set; }
        public TbDetail Material { get; set; }
        public TbDetail StudsCornerIntersection { get; set; }
        public TbDetail GlazingTypes { get; set; }
        public TbDetail CoatingsTints { get; set; }
        public TbDetail FillType { get; set; }
        public TbDetail SpacerType { get; set; }
        public TbDetail FrameMaterial { get; set; }
    }
}
