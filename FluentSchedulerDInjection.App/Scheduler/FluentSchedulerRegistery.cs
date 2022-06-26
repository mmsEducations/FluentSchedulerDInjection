
using FluentScheduler;
using FluentSchedulerDInjection.App.Configuration;
using FluentSchedulerDInjection.App.Job;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentSchedulerDInjection.App.Scheduler
{
    public class FluentSchedulerRegistery : Registry
    {
        private readonly IFluentSchedulerConfigurationManager _fsConfigurationManager;

        //Job'ın Hangi ayarlara göre ne zaman çalışacağını belirtir
        public FluentSchedulerRegistery(IFluentSchedulerConfigurationManager fsConfigurationManager)
        {
            _fsConfigurationManager = fsConfigurationManager;
            var interval = int.Parse(_fsConfigurationManager.GetConfigKeyValue("JobIntervalForEvrySeconds"));

            Schedule<SchedulerJob>()
                    .NonReentrant() // Çalışma anında job'ın  tek bir instance üzerinden çalışmasını sağlar 
                    .ToRunNow()    //Hemen çalıştır 
                    .AndEvery(interval).Seconds();  //Interval
           
        }
    }
}
 
//dı NEDEN KULLANILIR _>BAĞIMLILIĞI AZALTMAK İÇİN
//1) Interface ve class oluşturulur 
//2) Uygulama şekli -> constructor yönetmi ile uygulama 
//3) datnet core kısmı ile entegrasyon kısmı a)singleten , transient , scoped