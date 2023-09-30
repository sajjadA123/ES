using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.DTOs.codes
{
    public class CodesDTO
    {
        public virtual List<CodeByTypesDTO> Wall { get; set; }
        public virtual List<CodeByTypesDTO> Ceiling { get; set; }    
        public virtual List<CodeByTypesDTO> CeilingFlat { get; set; }
        public virtual List<CodeByTypesDTO> Floor { get; set; }
        public virtual List<CodeByTypesDTO> Lintel { get; set; }
        public virtual List<CodeByTypesDTO> Window { get; set; }
        public virtual List<CodeByTypesDTO> FloorsAbove { get; set; }
        public virtual List<CodeByTypesDTO> FloorsAdded { get; set; }  
        public virtual List<CodeByTypesDTO> BasementWall { get; set; }
        public virtual List<CodeByTypesDTO> CrawlspaceWall { get; set; }   
        public virtual List<CodeByTypesDTO> FloorHeader { get; set; }   
        public house.HouseFileDTO House_ { get; set; } 
    }
}
