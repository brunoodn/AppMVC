using DevIo.App.Extensions;
using DevIo.Business.Interfaces;
using DevIo.Data.Context;
using DevIo.Data.Repository;
using Microsoft.AspNetCore.Mvc.DataAnnotations;
using Microsoft.Extensions.DependencyInjection;

namespace DevIo.App.Configurations
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies (this IServiceCollection services)
        {
            services.AddScoped<MeuDbContext>();
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IFornecedorRepository, FornecedorRepository>();
            services.AddScoped<IEnderecoRepository, EnderecoRepository>();
            services.AddSingleton<IValidationAttributeAdapterProvider, MoedaValidationAttributeAdapterProvider>();

            return services;
        }
    }
}
