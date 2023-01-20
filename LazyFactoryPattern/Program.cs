using LazyFactoryPattern.Extensions;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace LazyFactoryPattern
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            IServiceProvider provider = ConfigureServices();

            var engine = provider.GetRequiredService<Engine>();
            using (engine)
            {
                engine.DoSomething();
            }

            Console.Read();
        }

        public static IServiceProvider ConfigureServices()
        {
            IServiceCollection services = new ServiceCollection();
            services.AddMyServices();

            return services.BuildServiceProvider();
        }
    }


    public enum ContextType
    {
        EfContext,
        AdonetContext
    }
}
