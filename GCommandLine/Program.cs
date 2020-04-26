using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace GCommandLine
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Starting Host");
            CreateHostBuilder(args).Build().Run();
            Console.WriteLine("Closing Host");
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration(configure =>
                {
                    configure.SetBasePath(Directory.GetCurrentDirectory());
                    configure.AddJsonFile(AppDomain.CurrentDomain.BaseDirectory + "\\appsettings.json", optional: true, reloadOnChange: true);
                })
                .ConfigureWebHostDefaults(host =>
                {
                    host.UseStartup<Startup>();
                });
    }
}


// using System;
// using System.IO;
// using System.Threading.Tasks;
// using Microsoft.AspNetCore.Hosting;
// using Microsoft.Extensions.Configuration;
// //using Microsoft.Extensions.Hosting;

// namespace GCommandLine
// {
//     public class Program
//     {
//         private static async Task Main(string[] args)
//         {
//             // Host.CreateDefaultBuilder(args);
//             // var Configuration = new Microsoft.Extensions.Configuration.ConfigurationBuilder()
//             //     .SetBasePath(Directory.GetCurrentDirectory())
//             //     .AddJsonFile(AppDomain.CurrentDomain.BaseDirectory + "\\appsettings.json", optional: true, reloadOnChange: true)
//             //     .AddEnvironmentVariables()
//             //     .Build();

//             CreateHostBuilder(args).Build().Run();

//             Console.WriteLine("Hello World!");
//         }

//        public static Microsoft.Extensions.Hosting.IHostBuilder CreateHostBuilder(string[] args) =>
//             Host.CreateDefaultBuilder(args)
//                 .ConfigureWebHostDefaults(webBuilder =>
//                 {
//                     webBuilder.UseStartup<Startup>();
//                 });

//         // private static void CreateConfiguration()
//         // {
//         //     var Configuration = new ConfigurationBuilder()
//         //         .SetBasePath(Directory.GetCurrentDirectory())
//         // }

//         // private static IHostBuilder CreateHostBuilder(string[] args)
//         // {
//         //     return Host.CreateDefaultBuilder(args)
//         //     .ConfigureAppConfiguration(configHost =>
//         //     {
//         //         configHost.SetBasePath(Directory.GetCurrentDirectory());
//         //         configHost.AddJsonFile("hostsettings.json", optional: true);
//         //         configHost.AddEnvironmentVariables(prefix: "PREFIX_");
//         //         configHost.AddCommandLine(args);
//         //     });
//         // }
//     }
// }
