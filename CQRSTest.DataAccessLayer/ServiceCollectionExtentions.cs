using CQRSTest.DataAccessLayer.DAL;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSTest.DataAccessLayer
{
    public static class ServiceCollectionExtentions
    {
        public static IServiceCollection GetDAOServices(this IServiceCollection services)
        {
            services.AddScoped<IPersonDAO, PersonDAO>();
            return services;
        }
    }
}
