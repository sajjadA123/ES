using ES.Core.Contracts.DTOs;
using ES.Core.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.Common.DTOs.wizard
{
    public class WizardDTO:BaseEntityDTO
    {
        public WizardGeneralDTO general { get; set; }
        public WizardFoundationNumberDTO foundations { get; set; }
        public WizardBasementDTO basement { get; set; }
        public WizardBasementDTO crawlSpace { get; set; }
        public WizardBasementDTO slapOnGrade { get; set; }
        public int storeyNumber { get; set; }
        public WizardMainWallDTO mainWall { get; set; }
        public WizardFloorHeaderDTO header { get; set; }
        public WizardCeilingDTO ceiling { get; set; }
    }
    public class WizardSearch : BaseSearch
    {

    }

}
