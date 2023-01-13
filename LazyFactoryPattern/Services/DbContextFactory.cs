using System;

namespace LazyFactoryPattern.Services
{
    public interface IDbContextFactory
    {
        IDbContext Create(ContextType contextType);
    }

    public class DbContextFactory : IDbContextFactory
    {
        private readonly IDbContext _dbContext;
        private readonly Func<ContextType, IDbContext> _context;
        public DbContextFactory(Func<ContextType, IDbContext> context)
        {
            _context = context;
        }

        public IDbContext Create(ContextType contextType)
        {
            return _context(contextType);
        }
    }
}
