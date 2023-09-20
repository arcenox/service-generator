using _COMPANYNAME_._PROJECTNAME_._SERVICE_.Api.Controllers.Base;
using _COMPANYNAME_._PROJECTNAME_._SERVICE_.Application.Services.TestService.Commands.AddItem;
using _COMPANYNAME_._PROJECTNAME_._SERVICE_.Application.Services.TestService.Queries.Get;
using Microsoft.AspNetCore.Mvc;

namespace _COMPANYNAME_._PROJECTNAME_._SERVICE_.Api.Controllers
{
    [Route("api/examples")]
    public class ExampleController : BaseController
    {
        [HttpPost(":add")]
        public async Task<IActionResult> AddItem([FromBody] TestAddItemCommand command)
        {
            await Mediator.Send(command);

            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetItems([FromQuery] GetItemsQuery query)
        {
            var result = await Mediator.Send(query);

            return Ok(result);
        }
    }
}
