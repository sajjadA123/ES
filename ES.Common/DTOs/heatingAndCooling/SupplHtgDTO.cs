using ES.Common.Enums;
using ES.Core.Contracts.DTOs;
using ES.DTOs.baseInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.DTOs.heatingAndCooling
{
    public class SupplHtgDTO : StrongEntityDTO, IType1
    {
        public EquipmentDTO Equipment { get; set; }
        public EquipmentInformationDTO EquipmentInformation { get; set; }
        public TbDetailDTO YearMade { get; set; }
        public long? YearMadeId { get; set; }
        public TbDetailDTO Usage { get; set; }
        public long? UsageId { get; set; }
        public MonthlyDataDTO MonthlyData { get; set; }
        public long? MonthlyDataId { get; set; }

        public TbDetailDTO LocationHeated { get; set; }
        public long? LocationHeatedId { get; set; }
        public decimal? FloorArea { get; set; }

        public FlueLocation FlueLocation { get; set; }

        public TbDetailDTO FlueType { get; set; }
        public long? FlueTypeId { get; set; }

        public bool? IsFlueDiameter { get; set; }
        public decimal? FlueDiameter { get; set; }
        public decimal? FlueArea { get; set; }

        public decimal? HeatCapacity { get; set; }
        public CapacityUnit HeatCapacityUnit { get; set; }
        public decimal? SteadyEff { get; set; }
        public decimal? EngPilotCons { get; set; }
        public bool DapperClosed { get; set; }

        public long? HeatingAndCoolingId { get; set; }


    }
}
