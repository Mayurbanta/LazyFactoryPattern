using System;

namespace LazyFactoryPattern.Services
{
    public interface IDbContextFactory: IDisposable
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

        public void Dispose()
        {
            Console.WriteLine($"{nameof(DbContextFactory)} dispose called...");
        }
    }
}
