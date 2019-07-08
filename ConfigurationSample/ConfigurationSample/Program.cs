using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace ConfigurationSample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args)
        {
           var builder = WebHost.CreateDefaultBuilder(args)
                   .ConfigureAppConfiguration((hostingContext, config) =>
                   {
                       var env = hostingContext.HostingEnvironment;

                       config.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                           .AddJsonFile($"appsettings.{env.EnvironmentName}.json", 
                               optional: true, reloadOnChange: true);

                       if (env.IsDevelopment())
                       {
                           var appAssembly = Assembly.Load(new AssemblyName(env.ApplicationName));
                           if (appAssembly != null)
                           {
                               config.AddUserSecrets(appAssembly, optional: true);
                           }
                       }

                       config.AddEnvironmentVariables();

                       if (args != null)
                       {
                           config.AddCommandLine(args);
                       }
                   })
                .UseStartup<Startup>();
           return builder;
        }
      
    }
}
