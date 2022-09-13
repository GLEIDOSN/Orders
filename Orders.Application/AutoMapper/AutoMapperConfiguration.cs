using AutoMapper;

namespace Orders.Application.AutoMapper
{
    public class AutoMapperConfiguration
    {
        public static MapperConfiguration RegisterMappings()
        {
            return new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new ViewModalToDomainProfile());
                cfg.AddProfile(new DomainViewModelProfile());
            });
        }
    }
}
