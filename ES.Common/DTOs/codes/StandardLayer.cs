using ES.DTOs.baseInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.DTOs.codes
{
    public class StandardLayer
    {
        public TbDetailDTO InsulationInFramingLayer { get; set; }
        public TbDetailDTO ExtraInsulationLayer { get; set; }
        public TbDetailDTO Framing { get; set; }
        public TbDetailDTO StructureType { get; set; }
        public TbDetailDTO ComponentTypeSize { get; set; }
        public TbDetailDTO Spacing { get; set; }    
        public TbDetailDTO Insulation { get; set; } 
        public TbDetailDTO InsulationLayer1 { get; set; }
        public TbDetailDTO InsulationLayer2 { get; set; }   
        public TbDetailDTO Interior { get; set; }   
        public TbDetailDTO InteriorFinish { get; set; } 
        public TbDetailDTO Sheathing { get; set; }  
        public TbDetailDTO Exterior { get; set; }   
        public TbDetailDTO Type { get; set; }   
        public TbDetailDTO DropFraming { get; set; }    
        public TbDetailDTO Material { get; set; }   
        public TbDetailDTO StudsCornerIntersection { get; set; }    
        public TbDetailDTO GlazingTypes { get; set; }   
        public TbDetailDTO CoatingsTints { get; set; }  
        public TbDetailDTO FillType { get; set; }   
        public TbDetailDTO SpacerType { get; set; } 
        public TbDetailDTO FrameMaterial { get; set; }  
    }
}
