using MediatR;

namespace _COMPANYNAME_._PROJECTNAME_._SERVICE_.Application.Services.TestService.Commands.AddItem
{
    public class TestAddItemCommand : IRequest
    {
        public string Name { get; set; }
    }
}
