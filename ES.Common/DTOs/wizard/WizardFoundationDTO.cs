using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.Common.DTOs.wizard
{
    public class WizardFoundationDTO
    {
        public string foundationLable { get; set; }
        public int crawlSpaceType { get; set; }
        public int wallHeigth { get; set; }
        public int wallDepthBelowGrade { get; set; }
        public bool ponyWall { get; set; }
        public int exposedSurfacePerimeter { get; set; }
    }
}
