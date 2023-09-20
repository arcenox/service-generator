using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace _COMPANYNAME_._PROJECTNAME_._SERVICE_.Application.Services.TestService.Commands.AddItem
{
    public class TestAddCommandHandler : IRequestHandler<TestAddItemCommand>
    {
        public Task Handle(TestAddItemCommand request, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
