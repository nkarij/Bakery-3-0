using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bakery.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Bakery
{
    public class Startup
    {
        // the Configuration gets the appsettings connections string
        public IConfiguration Configuration { get; }

        // ctor passes the appsettings via constructor injection, we will have acces to the properties 
        // in appsettings through the Iconfiguration object
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            // register services here, by dependency injections.
            // fx register framework services, and our own services

            // accessing the Configuration Properties in appsettings, passing it to UseSqlServer
            services.AddDbContext<AppDbContext>(options => 
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            // configure identity, DefaultIdentity bring in basic functionality of Identity
            // Identity needs EntitiFramework and will use AppDbContext to store data.
            services.AddDefaultIdentity<IdentityUser>().AddEntityFrameworkStores<AppDbContext>();
            // AddScoped(): the instance will be created and scoped with the request, a singleton pr request.
            //register a service with its interface, remember ctr . to add using Bakery.Model
            // first param is interface, second param is implementation
            services.AddScoped<IPieRepository, PieRepository>();
            services.AddScoped<IContactUsRepository, MockContactUsRepository>();
            // registereing the reviewRepository
            services.AddScoped<IReviewRepository, ReviewRepository>();
            // passing in the serviceprovider, this will invoke the getCart on a request
            // and the getCart will check if a shoppingcart is active and related to the request
            services.AddScoped<ShoppingCart>(sp => ShoppingCart.GetCart(sp));
            // the request, hereunder the session
            services.AddHttpContextAccessor();
            // add session support, remember to also add middleware support
            services.AddSession();
            //Will give you a new instance every time you ask for one (???)
            //services.AddTransient<>();
            //singleton pattern:
            //services.AddSingleton<>();

            // this lets us use the MVC pattern
            services.AddControllersWithViews();
            // support for razor pages for scaffolding (Identity)
            services.AddRazorPages();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        // the request pipeline will be configured here
        // this is where middleware components is added. 
        // middleware handles http requests and responses
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // checks if environment is development
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // requires that the app run on https
            app.UseHttpsRedirection();
            // my app will serve static files, fx index.html, by default it will search the ..root folder, 
            app.UseStaticFiles();
            // middleware support for sessions, NB! before UseRouting
            app.UseSession();

            app.UseRouting();
            // middlewares for Identity
            app.UseAuthentication();
            app.UseAuthorization();
            // this is our endpoint-middleware:
            app.UseEndpoints(endpoints =>
            {
                // This is the default configuration, replaced by the below, thats dynamic
                // our / endpoint is serving Hello World to the browser as default.
                //endpoints.MapGet("/", async context =>
                //{
                    //await context.Response.WriteAsync("Hello World!");
                //});

                // this is a dynamic endpoint configuration, this will be responisble for mapping
                // an incoming request with an action on the controller...
                // map request with action on controller
                endpoints.MapControllerRoute(
                        name: "default",
                        pattern: "{controller=Home}/{action=Index}/{id?}");
                // endpoint for Identitys razor pages:
                endpoints.MapRazorPages();


             
            });
        }
    }
}
