﻿using AIMSService.Entity;
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
            CreateMap<UserDto, User>()
                .ForMember(x => x.Id, y => y.MapFrom(z => Guid.Parse(z.Id)));
            //.ForMember(x => x.UserType, y => y.MapFrom(z => Enum.Parse<UserTypeEnum>(z.UserType)));
            CreateMap<User, UserDto>()
                .ForMember(x => x.Id, y => y.MapFrom(z => z.Id.ToString()));
                //.ForMember(x => x.Type, y => y.MapFrom(z => z.UserType.ToString().Replace('_', ' ')));

            //CreateMap<User, UserDto>().ReverseMap();
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

            CreateMap<StudentPage1, StudentPage1Dto>().ReverseMap();
            CreateMap<StudentPage2, StudentPage2Dto>().ReverseMap();
            CreateMap<StudentPage3, StudentPage3Dto>().ReverseMap();
            CreateMap<StudentPage4, StudentPage4Dto>().ReverseMap();


        }
    }
}
