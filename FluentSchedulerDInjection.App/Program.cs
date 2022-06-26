// See https://aka.ms/new-console-template for more information
using FluentScheduler;
using FluentSchedulerDInjection.App.Configuration;
using FluentSchedulerDInjection.App.Scheduler;
using Microsoft.Extensions.DependencyInjection;

Console.WriteLine("Job Çalışmaya Başladı");

ServiceProvider serviceProvider = InitilizationServices.Initilization();

var fsRegistery = new FluentSchedulerRegistery(serviceProvider.GetService<IFluentSchedulerConfigurationManager>());
JobManager.Initialize(fsRegistery);

Console.WriteLine("Press enterto terminate");
Console.ReadLine();
JobManager.StopAndBlock();

