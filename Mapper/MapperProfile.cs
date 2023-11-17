using AIMSService.Entity;
using AIMSService.Model;
using AutoMapper;
using Web.Entity;
using Web.Helper.Enum;
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
            CreateMap<Client, ClientDto>().ForMember(x=>x.Status, y=> y.MapFrom(s=>s.Status.ToString()));
            CreateMap<ClientDto, Client>().ForMember(x=>x.Status, y=> y.MapFrom(s=> s.Status));

        }
    }
}
