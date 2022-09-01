using System.Threading.Tasks;
using BookflixSolution.Models.TokenAuth;
using BookflixSolution.Web.Controllers;
using Shouldly;
using Xunit;

namespace BookflixSolution.Web.Tests.Controllers
{
    public class HomeController_Tests: BookflixSolutionWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}