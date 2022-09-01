using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using BookflixSolution.Configuration.Dto;

namespace BookflixSolution.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : BookflixSolutionAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
