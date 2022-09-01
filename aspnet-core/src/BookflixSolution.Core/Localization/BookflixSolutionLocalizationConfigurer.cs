using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace BookflixSolution.Localization
{
    public static class BookflixSolutionLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(BookflixSolutionConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(BookflixSolutionLocalizationConfigurer).GetAssembly(),
                        "BookflixSolution.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
