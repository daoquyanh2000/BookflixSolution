using System.Threading.Tasks;
using BookflixSolution.Configuration.Dto;

namespace BookflixSolution.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
