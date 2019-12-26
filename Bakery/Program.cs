using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Bakery
{
    public class Program
    {
        // en ASP.NET app er i bund og grund en console app, som starter en server op når programmet startes.
        public static void Main(string[] args)
        {
            // this will set up a server
            CreateHostBuilder(args).Build().Run();
        }

        // this is the class that builds the server(kestrel) and host, that is called from main and will run our app
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    // passing the startup class to the hostbuilder, this class will handle configuration
                    webBuilder.UseStartup<Startup>();
                });
    }
}
