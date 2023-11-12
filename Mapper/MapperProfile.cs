using AutoMapper;
using Web.Entity;
using Web.Model;

namespace Web.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<Questions, QuestionDto>().ReverseMap();
            CreateMap<AssessorProfile, AssessorProfileDto>().ReverseMap();
            CreateMap<AssessorAnswer, AssessorAnswerDto>().ReverseMap();
            
        }
    }
}
