using BookflixSolution.Debugging;

namespace BookflixSolution
{
    public class BookflixSolutionConsts
    {
        public const string LocalizationSourceName = "BookflixSolution";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "91642e1ab6324975b10c2d9c7b3a8071";
    }
}
