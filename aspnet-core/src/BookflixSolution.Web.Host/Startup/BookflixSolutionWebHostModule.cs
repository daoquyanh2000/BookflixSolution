using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using BookflixSolution.Configuration;

namespace BookflixSolution.Web.Host.Startup
{
    [DependsOn(
       typeof(BookflixSolutionWebCoreModule))]
    public class BookflixSolutionWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public BookflixSolutionWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(BookflixSolutionWebHostModule).GetAssembly());
        }
    }
}
