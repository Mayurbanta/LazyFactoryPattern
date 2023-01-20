using LazyFactoryPattern.Services;
using System;

namespace LazyFactoryPattern
{
    public class Engine : IDisposable
    {
        private readonly IDbContextFactory _dbContextFactory;

        public Engine(IDbContextFactory dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        public void Dispose()
        {
            Console.WriteLine($"{nameof(Engine)} dispose called...");
            _dbContextFactory.Dispose();
        }

        public void DoSomething()
        {
            _dbContextFactory.Create(ContextType.AdonetContext);

            var efContext = _dbContextFactory.Create(ContextType.EfContext);
            using (efContext)
            {
                _ = efContext.SaveChanges();
            }



            var adoContext = _dbContextFactory.Create(ContextType.AdonetContext);
            using (adoContext)
            {
                _ = adoContext.SaveChanges();
            }
        }
    }
}
