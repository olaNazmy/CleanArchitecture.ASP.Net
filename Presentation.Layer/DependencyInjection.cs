using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentaion.Layer
{
    public static class DependencyInjection
    {
        // Add Presentation Layer
        public static IServiceCollection AddPresentation(this IServiceCollection services)
        {
            
            return services;

        }
    }
}
