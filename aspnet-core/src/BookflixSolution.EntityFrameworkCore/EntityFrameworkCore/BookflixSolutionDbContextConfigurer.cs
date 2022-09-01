using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace BookflixSolution.EntityFrameworkCore
{
    public static class BookflixSolutionDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<BookflixSolutionDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<BookflixSolutionDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
