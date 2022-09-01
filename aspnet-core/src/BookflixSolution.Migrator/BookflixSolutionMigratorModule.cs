using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using BookflixSolution.Configuration;
using BookflixSolution.EntityFrameworkCore;
using BookflixSolution.Migrator.DependencyInjection;

namespace BookflixSolution.Migrator
{
    [DependsOn(typeof(BookflixSolutionEntityFrameworkModule))]
    public class BookflixSolutionMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public BookflixSolutionMigratorModule(BookflixSolutionEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(BookflixSolutionMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                BookflixSolutionConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(BookflixSolutionMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
