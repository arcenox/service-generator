using _COMPANYNAME_._PROJECTNAME_._SERVICE_.Application.Services.TestService.Queries.Get;
using _COMPANYNAME_._PROJECTNAME_._SERVICE_.UnitTest.Base;
using System.Threading.Tasks;
using Xunit;

namespace _COMPANYNAME_._PROJECTNAME_._SERVICE_.UnitTest
{
    public class UnitTest1 : UnitContext
    {
        [Fact]
        public async Task Test1()
        {
            var query = new GetItemsQuery();

            var result = await Mediator.Send(query);

            Assert.NotNull(result);
        }
    }
}