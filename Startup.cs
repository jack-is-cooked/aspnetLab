using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace MyCourse
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            //if (env.IsEnviroment("Development"))
            {
                app.UseDeveloperExceptionPage();
            }

        app.UseStaticFiles();

            app.Run(async (context) =>
            {
                string nome = context.Request.Query["nome"];
                await context.Response.WriteAsync($"Hello {nome.ToUpper()}!");
                //http://www.miosito.it/Products?id=1
                //per sapere il dominio con cui siamo stati chiamati:
                //context.Request.Host
                //per sapere il percorso, cioè tutto ciò che viene dopo il nome dominio
                //context.Request.Path
                //se  vogliamo ottenere il valore di questa variabile query string
                //context.Request.Query["id"]

            });
        }
    }
}
