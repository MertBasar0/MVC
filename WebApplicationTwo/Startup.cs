using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationTwo
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting(); // gelen iste�in rotas� bu middleware sayesinde belirlenir.

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute(); //controller = Home / Action = index/id? => default olan endpoint �emas� bu �ekildedir.
                //E�er controller bo� geliyorsa home action index kabul eder.
                // Endpoint �emas� s�sl� parantezler i�erisinde yaz�l�r.
                //Mesela : {controller}{action}{id}
            });
        }
    }
}
