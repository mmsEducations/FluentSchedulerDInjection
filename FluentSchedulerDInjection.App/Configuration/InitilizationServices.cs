using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentSchedulerDInjection.App.Configuration
{
    public class InitilizationServices
    {
        public static ServiceProvider Initilization()
        {
            return new ServiceCollection()
                                   .AddSingleton<IFluentSchedulerConfigurationManager, FluentSchedulerConfigurationManager>()
                                   .BuildServiceProvider();
        }
    }
}
