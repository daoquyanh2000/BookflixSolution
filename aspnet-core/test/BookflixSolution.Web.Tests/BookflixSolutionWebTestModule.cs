using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using BookflixSolution.EntityFrameworkCore;
using BookflixSolution.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace BookflixSolution.Web.Tests
{
    [DependsOn(
        typeof(BookflixSolutionWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class BookflixSolutionWebTestModule : AbpModule
    {
        public BookflixSolutionWebTestModule(BookflixSolutionEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(BookflixSolutionWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(BookflixSolutionWebMvcModule).Assembly);
        }
    }
}