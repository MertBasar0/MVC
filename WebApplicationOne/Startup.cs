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
            //Burasý uygulamada kullanýlacak olan servislerin eklendiði ve konfigüre edildiði yerdir.
            //Servis : Belirlii iþlere odaklanmýþ sadece o iþleri yapan o iiþn sorumluluðunun onda olduðu kütüphanedir.

            //Mesela örnek site yaptýn. Kart ile ödeme kýsmýný ayrý geliþtirdin. Bu yapýyý kendi hali hazýrda kullanýlmýþ
            //olduðun sistemin içerisine dahil etme durumudur.

            // Servis == modül == kütüphane
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //Bu metot kullanýlarak uygulamada kullanýlacak olan middleware // ara katman ara yazýlýmlarý çaðrýlmaktadýr.
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
