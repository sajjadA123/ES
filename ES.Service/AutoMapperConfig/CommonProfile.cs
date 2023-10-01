using AutoMapper;
using ES.Common.DTOs;
using ES.Common.Helpers;
using ES.Domain.Entity;

namespace ES.Service.AutoMapperConfig
{
    public class CommonProfile : Profile
    {
        public CommonProfile()
        {


            //CreateMap<Month, MonthDTO>().ReverseMap();
            //CreateMap<Month, MonthDTO>()
            //    .ForMember(d => d.monthTitle, o => o.MapFrom(s => s.MONTHTYPE.ToDescription()))
            //    .ForMember(d => d.year, o => o.MapFrom(s => s.YEAR))
            //    .ForMember(d => d.lockTypeTitle, o => o.MapFrom(s => s.LOCKTYPE.ToDescription()));

            
        }
    }
}
