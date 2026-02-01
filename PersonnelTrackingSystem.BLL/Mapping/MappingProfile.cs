using AutoMapper;
using PersonnelTrackingSystem.DAL;
using PersonnelTrackingSystem.Entities.DTOs;

namespace PersonnelTrackingSystem.BLL.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Personel, PersonelDto>().ReverseMap();
        }
    }
}
