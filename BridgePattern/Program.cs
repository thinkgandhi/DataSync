using BridgePattern.Sync;
using BridgePattern.Sync.Employee;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace BridgePattern
{
    internal class Program
    {
        public static async Task Main(string[] args)
        {
            HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);
           
            builder.Services.AddTransient<ISourceDataConfig, EmployeeSourceDataConfig>();
            builder.Services.AddTransient<IDestinationConfig, EmployeeDestinationConfig>();
            builder.Services.AddTransient<EmployeeData>();
            builder.Services.AddTransient<EmployeeSync>();

            //Execute
            using IHost host = builder.Build();
           
            //Comes within the hangfire job
            EmployeeSync sync = host.Services.GetService(typeof(EmployeeSync)) as EmployeeSync;
            sync.LoadData();
            sync.UploadAllRecords();


            await host.RunAsync();
        }
    }
}
