using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationOne
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //Buras� uygulamada kullan�lacak olan servislerin eklendi�i ve konfig�re edildi�i yerdir.
            //Servis : Belirlii i�lere odaklanm�� sadece o i�leri yapan o ii�n sorumlulu�unun onda oldu�u k�t�phanedir.

            //Mesela �rnek site yapt�n. Kart ile �deme k�sm�n� ayr� geli�tirdin. Bu yap�y� kendi hali haz�rda kullan�lm��
            //oldu�un sistemin i�erisine dahil etme durumudur.

            // Servis == mod�l == k�t�phane
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //Bu metot kullan�larak uygulamada kullan�lacak olan middleware // ara katman ara yaz�l�mlar� �a�r�lmaktad�r.
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                //endpoints.MapGet("/", async context =>
                //{
                //    await context.Response.WriteAsync("Hello World!");
                //});
                endpoints.MapDefaultControllerRoute();
            });
        }
    }
}
