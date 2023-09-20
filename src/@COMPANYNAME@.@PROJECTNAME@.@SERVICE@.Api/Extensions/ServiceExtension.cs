using _COMPANYNAME_._PROJECTNAME_._SERVICE_.Api.Extensions.Configurations;
using _COMPANYNAME_._PROJECTNAME_._SERVICE_.Api.Filters;

namespace _COMPANYNAME_._PROJECTNAME_._SERVICE_.Api.Extensions
{
    public static class ServiceExtension
    {
        public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddControllers(opt => opt.Filters.Add<ExceptionFilter>());
            services.AddSiteCors();
            services.AddDbContext(configuration);
            services.AddJwtAuthentication(configuration);
            services.AddSiteSwagger();
            services.AddMediator();
            services.AddOwnService();
            services.AddFluentValidations();
            services.AddMapper();
            services.AddOptions(configuration);
            services.AddMemoryCache();

            return services;
        }

        public static WebApplication UseServices(this WebApplication app)
        {
            app.UseSiteCors();
            app.UseHttpsRedirection();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseHelpers();
            return app;
        }
    }
}
