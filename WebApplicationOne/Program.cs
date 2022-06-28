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
        //Asp.net core uygulamalarý özünde bir console uygulamasýdýr.
        //Asp.net core kendi dahilinde sunucu barýndýrýr dedik. Ýste o sunucuyu ayaða kaldýrýldýðý yer program.cs dosyasýdýr.
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }
        //Ýçerisinde gömülü olan host'un kullanacaðý konfigürasyonlarý nerden alacaðýný bildirmektedir.
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                    //Burada temel konfigürasyon ayarlarý yaðýldýðý yer startup classýdýr.
                });
    }
}
