using _COMPANYNAME_._PROJECTNAME_._SERVICE_.Application.Interfaces;
using _COMPANYNAME_._PROJECTNAME_._SERVICE_.Persistence;
using Microsoft.EntityFrameworkCore;

namespace _COMPANYNAME_._PROJECTNAME_._SERVICE_.Api.Extensions.Configurations
{
    public static class DbContextExtension
    {
        public static void AddDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<I_SERVICE_DbContext, _SERVICE_DbContext>();

            services.AddDbContext<_SERVICE_DbContext>(x => x.UseNpgsql(configuration.GetConnectionString("Database"), option =>
            {
                option.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery);
            }));
        }
    }
}
