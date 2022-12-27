using AutoMapper;
using Villa_API.Model;

namespace Villa_API
   
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<Villa, Villa_DTO>();
            CreateMap<Villa_DTO, Villa>();


            CreateMap<Villa_DTO, Villa_DTO_Create>().ReverseMap();
            CreateMap<Villa_DTO, Villa_DTO_Update>().ReverseMap();
        }
    }
}
