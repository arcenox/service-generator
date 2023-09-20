using _COMPANYNAME_._PROJECTNAME_._SERVICE_.Application.Infrastructure.AutoMapper;

namespace _COMPANYNAME_._PROJECTNAME_._SERVICE_.Api.Extensions.Configurations
{
    public static class AutoMapperExctension
    {
        public static void AddMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(opts =>
            {
                opts.AddProfile<MapperProfileLocator>();
            });
        }
    }
}
