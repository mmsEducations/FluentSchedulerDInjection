using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentSchedulerDInjection.App.Configuration
{
    public interface IFluentSchedulerConfigurationManager
    {
        string GetConfigKeyValue(string key);

        IConfigurationRoot GetConfiguration();
    }
}
