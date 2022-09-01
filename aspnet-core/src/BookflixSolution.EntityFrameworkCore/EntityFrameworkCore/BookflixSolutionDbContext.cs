using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using BookflixSolution.Authorization.Roles;
using BookflixSolution.Authorization.Users;
using BookflixSolution.MultiTenancy;

namespace BookflixSolution.EntityFrameworkCore
{
    public class BookflixSolutionDbContext : AbpZeroDbContext<Tenant, Role, User, BookflixSolutionDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public BookflixSolutionDbContext(DbContextOptions<BookflixSolutionDbContext> options)
            : base(options)
        {
        }
    }
}
