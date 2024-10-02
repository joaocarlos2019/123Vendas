using _123Vendas.Data;
using _123Vendas.Data.Interfaces;
using _123Vendas.Service;
using System.Collections.Generic;

namespace _123Vendas.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
           
            services.AddSingleton<IVendaRepository, VendaRepository>();
            services.AddTransient<IVendasService, VendasService>();
            return services;
        }
    }
}
