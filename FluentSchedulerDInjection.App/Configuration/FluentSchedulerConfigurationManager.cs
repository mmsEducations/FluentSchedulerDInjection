using Microsoft.Extensions.Configuration;
using System.Reflection;

namespace FluentSchedulerDInjection.App.Configuration
{
    public class FluentSchedulerConfigurationManager : IFluentSchedulerConfigurationManager
    {

        public  string GetConfigKeyValue(string key)
        {
            var value = GetConfiguration().GetSection(key).Value;
            return value;
        }
        public  IConfigurationRoot GetConfiguration()
        {
            var configuration = new ConfigurationManager()
                                               .SetBasePath(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location))
                                               .AddJsonFile("appsettings.json").Build();

            return configuration;
        }
    }
}