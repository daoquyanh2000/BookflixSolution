namespace BookflixSolution.EntityFrameworkCore.Seed.Host
{
    public class InitialHostDbBuilder
    {
        private readonly BookflixSolutionDbContext _context;

        public InitialHostDbBuilder(BookflixSolutionDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            new DefaultEditionCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();

            _context.SaveChanges();
        }
    }
}
