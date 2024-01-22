using AIMSService.Entity;
using AIMSService.Helper.Enum;
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
            CreateMap<Client, ClientDto>().ReverseMap();
            CreateMap<ClientARTDetail, ClientARTDetailDto>().ReverseMap();
            CreateMap<ClientCTOPPDetail, ClientCTOPPDetailDto>().ReverseMap();

            CreateMap<ClientTOMALDetail, ClientTOMALDetailDto>().ReverseMap();
            CreateMap<ClientTOWREDetail, ClientTOWREDetailDto>().ReverseMap();
            CreateMap<ClientWRATDetail, ClientWRATDetailDto>().ReverseMap();
            CreateMap<ClientWRITDetail, ClientWRITDetailDto>().ReverseMap();

            CreateMap<StudentDocumentDto, StudentDocument>()
                .ForMember(x => x.Id, y => y.MapFrom(z => Guid.Parse(z.Id))); ;
            CreateMap<StudentDocument, StudentDocumentDto>()
                .ForMember(x => x.Id, y => y.MapFrom(z => z.Id.ToString())); ;

        }
    }
}
