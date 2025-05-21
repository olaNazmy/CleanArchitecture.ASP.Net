using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Layer
{
    public static class DependencyInjection
    {
        // Add Infrastructure Layer
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            
            return services;

        }
    }
}
