using _COMPANYNAME_._PROJECTNAME_._SERVICE_.Common.Helpers;

namespace _COMPANYNAME_._PROJECTNAME_._SERVICE_.Api.Extensions.Configurations
{
    public static class HelperExtension
    {
        public static void UseHelpers(this IApplicationBuilder app)
        {
            AuthHelper.Configure(app.ApplicationServices.GetService<IHttpContextAccessor>());
        }
    }
}
