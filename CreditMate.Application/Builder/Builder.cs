using CreditMate.Application.Repositories;
using CreditMate.Application.Repositories.Interfaces;
using CreditMate.Application.Services;
using CreditMate.Application.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace CreditMate.Application
{
    public class Builder
    {
        public static void RepositoryBuilder(IServiceCollection services)
        {
            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<IFinanciamentoRepository, FinanciamentoRepository>();
            services.AddScoped<IParcelaRepository, ParcelaRepository>();
        }

        public static void ServiceBuilder(IServiceCollection services)
        {
            services.AddScoped<ICreditoService, CreditoService>();
            services.AddScoped<IClienteService, ClienteService>();
            services.AddScoped<IFinanciamentoService, FinanciamentoService>();
            services.AddScoped<IParcelaService, ParcelaService>();
        }
    }
}
