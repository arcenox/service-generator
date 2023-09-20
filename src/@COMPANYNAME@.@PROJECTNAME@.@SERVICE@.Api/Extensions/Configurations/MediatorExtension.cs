using _COMPANYNAME_._PROJECTNAME_._SERVICE_.Application.Infrastructure.Mediator;
using _COMPANYNAME_._PROJECTNAME_._SERVICE_.Application.Interfaces;
using MediatR;

namespace _COMPANYNAME_._PROJECTNAME_._SERVICE_.Api.Extensions.Configurations
{
    public static class MediatorExtension
    {
        public static void AddMediator(this IServiceCollection services)
        {
            services.AddMediatR(options =>
            {
                options.RegisterServicesFromAssembly(typeof(I_SERVICE_DbContext).Assembly);
                options.AddBehavior(typeof(IPipelineBehavior<,>), typeof(RequestValidationBehavior<,>));
                options.AddBehavior(typeof(IPipelineBehavior<,>), typeof(RequestPerformanceBehavior<,>));
            });
        }
    }
}
