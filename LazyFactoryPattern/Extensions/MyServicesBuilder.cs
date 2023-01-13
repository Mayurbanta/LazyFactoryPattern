using LazyFactoryPattern.Services;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace LazyFactoryPattern.Extensions
{
    internal static class MyServicesBuilder
    {
        internal static void AddMyServices(this IServiceCollection services)
        {
            services.AddTransient<Engine>();
            services.AddTransient<EfContext>();
            services.AddTransient<AdonetContext>();
            services.AddSingleton<IDbContextFactory, DbContextFactory>();

            services.AddSingleton(p =>
                    new Func<ContextType, IDbContext>((s) =>
                    {
                        if (s == ContextType.EfContext)
                        {
                            return p.GetRequiredService<EfContext>();
                        }
                        else if (s == ContextType.AdonetContext)
                        {
                            return p.GetRequiredService<AdonetContext>();
                        }
                        return p.GetRequiredService<EfContext>();
                    }
                    )
            );
        }
    }
}
