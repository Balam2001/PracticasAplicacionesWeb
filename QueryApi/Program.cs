using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace QueryApi
{
    public class Program
    {
        //Universidad Tecnologica Metropolitana
        //Aplicaciones Web orientada a Servicios
        //Joel Chuc
        //Christian Jesus Balam Rosas
        //4to Cuatrimestre
        //Grupo C
        //Parcial 2


        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
