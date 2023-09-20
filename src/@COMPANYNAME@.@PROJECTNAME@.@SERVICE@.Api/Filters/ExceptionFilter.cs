using _COMPANYNAME_._PROJECTNAME_._SERVICE_.Common.Exceptions;
using _COMPANYNAME_._PROJECTNAME_._SERVICE_.Common.Extensions;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Net;

namespace _COMPANYNAME_._PROJECTNAME_._SERVICE_.Api.Filters
{
    public class ExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            if (context.Exception is ValidationException validatorException)
                context.ExceptionFilerResponse(HttpStatusCode.BadRequest, new { validatorException.Title, validatorException.Errors });
        }
    }
}
