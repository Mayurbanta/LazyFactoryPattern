using System;

namespace LazyFactoryPattern.Services
{
    public class EfContext : IDbContext
    {
        public void Dispose()
        {
            Console.WriteLine($"{nameof(EfContext)} dispose called...");
        }

        public string SaveChanges()
        {
            Console.WriteLine("Save EF context called...");
            return "Save EF context called";
        }
    }
}
