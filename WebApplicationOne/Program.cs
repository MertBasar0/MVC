using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationOne
{
    public class Program
    {
        //Asp.net core uygulamalar� �z�nde bir console uygulamas�d�r.
        //Asp.net core kendi dahilinde sunucu bar�nd�r�r dedik. �ste o sunucuyu aya�a kald�r�ld��� yer program.cs dosyas�d�r.
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }
        //��erisinde g�m�l� olan host'un kullanaca�� konfig�rasyonlar� nerden alaca��n� bildirmektedir.
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                    //Burada temel konfig�rasyon ayarlar� ya��ld��� yer startup class�d�r.
                });
    }
}
