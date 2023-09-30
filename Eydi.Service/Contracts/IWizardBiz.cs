using ES.Common.DTOs.wizard;
using ES.Core.Biz;
using ES.Core.Contracts.Entities;
using ES.Core.Contracts.Entities.calculate;
using ES.DTOs.house;

namespace ES.Service.Contracts
{
    public  interface IWizardBiz :IBiz<WizardDTO>
    {
        PaginatedResult<WizardDTO> Show(WizardSearch search);
        bool Insert(WizardDTO wizardDTO);
        HouseFileDTO GeneateHouseDTO(WizardDTO wizardDTO);
    }
}
