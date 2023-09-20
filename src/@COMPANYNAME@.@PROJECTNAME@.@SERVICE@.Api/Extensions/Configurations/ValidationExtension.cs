using _COMPANYNAME_._PROJECTNAME_._SERVICE_.Application.Interfaces;
using FluentValidation;

namespace _COMPANYNAME_._PROJECTNAME_._SERVICE_.Api.Extensions.Configurations
{
    public static class ValidationExtension
    {
        public static void AddFluentValidations(this IServiceCollection services)
        {
            services.AddValidatorsFromAssembly(typeof(I_SERVICE_DbContext).Assembly);
        }
    }
}
