using System;

namespace LazyFactoryPattern.Services
{
    public class AdonetContext : IDbContext
    {
        public void Dispose()
        {
            Console.WriteLine($"{nameof(AdonetContext)} dispose called...");
        }

        public string SaveChanges()
        {
            Console.WriteLine("Save ADO context called...");
            return "Save ADO context called";
        }
    }
}
