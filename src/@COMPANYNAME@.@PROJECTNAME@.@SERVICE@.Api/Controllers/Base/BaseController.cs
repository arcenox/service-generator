using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace _COMPANYNAME_._PROJECTNAME_._SERVICE_.Api.Controllers.Base
{
    [ApiController]
    public abstract class BaseController : ControllerBase
    {
        private IMediator _mediator;
        protected IMediator Mediator => (_mediator ??= HttpContext.RequestServices.GetService<IMediator>());
    }
}
