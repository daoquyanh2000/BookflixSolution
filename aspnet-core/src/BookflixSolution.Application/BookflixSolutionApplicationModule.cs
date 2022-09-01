using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using BookflixSolution.Authorization;

namespace BookflixSolution
{
    [DependsOn(
        typeof(BookflixSolutionCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class BookflixSolutionApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<BookflixSolutionAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(BookflixSolutionApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
