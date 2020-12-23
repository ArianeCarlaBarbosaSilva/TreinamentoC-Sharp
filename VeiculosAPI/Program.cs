using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace VeiculosAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateHostBuilder(string[] args)
        {
            var host = Environment.GetEnvironmentVariable("DEFAULT_HOST");
            
            return WebHost.CreateDefaultBuilder(args)
                .UseUrls(args != null && args.Length > 0 ? args[0] : "http://0.0.0.0:5000")
                .UseStartup<Startup>();
        }
    }
}
