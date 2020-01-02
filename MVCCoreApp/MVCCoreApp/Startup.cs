using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.Routing.Constraints;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


namespace MVCCoreApp
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddRazorPages();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.EnvironmentName == Environments.Development)
            {
                app.UseDeveloperExceptionPage();
            }
            //app.UseMvcWithDefaultRoute();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();


            // app.UseMvc();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id:int?}");
                endpoints.MapRazorPages();
            });
            // app.UseMvc(routes =>
            // {
                //routes.MapRoute("secure", "secure", new
                //{
                //    Controller = "Admin",
                //    Action = "Index"
                //});

                //routes.MapRoute("default", "{controller=Home}/{action=Index}/{id:alpha:minlength(6)?}");

                //routes.MapRoute("default", "{controller}/{action}/{id}",
                //    new { controller = "Home", action = "Index" },
                //    new
                //    {
                //        id = new CompositeRouteConstraint(
                //            new IRouteConstraint[]
                //            {
                //                new AlphaRouteConstraint(), 
                //                new MinLengthRouteConstraint(6), 
                //            })
                //    });


                //routes.MapRoute("default", "{controller}/{action}/{id}",
                //    new {controller = "Home",action="Index"},
                //    new { id = new IntRouteConstraint()});

                //routes.MapRoute("default",
                //    "post/{id:int}",
                //    new { controller = "Post", action = "PostsByID" });

                //routes.MapRoute("anotherRoute",
                //    "post/{id:alpha}",
                //    new { controller = "Post", action = "PostsByPostName" });

                //routes.MapRoute("default",
                //    "{controller}/{action}/{year:regex(^\\d{{4}}$)}",
                //    new { controller = "Home", action = "Index" });
            // });

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Failed to find route");
            });
        }
    }
}
