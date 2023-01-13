using LazyFactoryPattern.Services;

namespace LazyFactoryPattern
{
    public class Engine
    {
        private readonly IDbContextFactory _dbContextFactory;

        public Engine(IDbContextFactory dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        public void DoSomething()
        {
            _dbContextFactory.Create(ContextType.AdonetContext);

            var efContext = _dbContextFactory.Create(ContextType.EfContext);
            _ = efContext.SaveChanges();

            var adoContext = _dbContextFactory.Create(ContextType.AdonetContext);
            _ = adoContext.SaveChanges();
        }
    }
}
