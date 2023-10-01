using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.Common.DTOs.wizard
{
    public class WizardMainWallDTO
    {
        public string wallLable { get; set; }
        public int wallType { get; set; }
        public int cornerNum { get; set; }
        public int intersectionNum { get; set; }
        public int totalHeigth { get; set; }
        public int perimeter { get; set; }
        public bool adjstEncloseSp { get; set; }
    }
}
