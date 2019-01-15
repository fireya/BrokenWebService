﻿using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace BrokenWebApplication
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            await Task.Factory.StartNew(()=>CreateWebHostBuilder(args).Build().RunAsync());
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
