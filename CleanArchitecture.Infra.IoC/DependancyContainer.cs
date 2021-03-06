using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.Services;
using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Infra.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infra.IoC
{
    public class DependancyContainer
    {
        public static void RegisterServices(IServiceCollection service)
        {
            // this from CleanArchitecture.Application layer
            service.AddScoped<IProductService, ProductService>();

            //CleanArchitecture.Domain.Interface  | CleanArchitecture.Infra.Data.Repositories;
            service.AddScoped<IProductRepository, ProductRepository>();
        }

    }
}
