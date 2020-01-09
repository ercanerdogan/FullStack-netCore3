using Core.Utilities.IoC;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.DependencyResolvers
{
    public class CoreModule : ICoreModules
    {
        public void Load(IServiceCollection services)
        {
            services.AddMemoryCache();
        }
    }
}
