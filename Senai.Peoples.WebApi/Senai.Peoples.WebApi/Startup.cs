using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace Senai.Peoples.WebApi
{
    public class Startup
    {
        
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddMvc()                                                                               //ADICIONOU MVC AO PROJETO
                .SetCompatibilityVersion(Microsoft.AspNetCore.Mvc.CompatibilityVersion.Version_2_1);        //ADICIONOU SERVICOS / DEFINE A VERSÃO .NET CORE CONPATÍVEL

        }
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();                                                                                 //DEFINE O USO DO MVC
        }
    }
}

