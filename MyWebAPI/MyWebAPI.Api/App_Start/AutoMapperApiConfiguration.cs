using AutoMapper;
using MyWebAPI.Api.Models;
using MyWebAPI.BL.ModelsContract;

namespace MyWebAPI.Api.App_Start
{
    public static class AutoMapperApiConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile(new ClientProfile());
            });
        }
        public class ClientProfile : Profile
        {
            public ClientProfile()
            {
                CreateMap<ClientContract, Client>();
            }

        }
    }
}