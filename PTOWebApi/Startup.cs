using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.Swagger;

namespace PTOWebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            //services.AddSwaggerGen(c =>
            //{
            //    c.SwaggerDoc("v1", new Info
            //    {
            //        Version = "v1",
            //        Title = "ATI PTO Repository API",
            //        Description = "Describes the REST API used to interact with the ATI PTO Repository API",
            //        TermsOfService = "See license agreement.",
            //        Contact = new Contact { Name = "support@accuratetechnologies.com", Email = "support@accuratetechnologies.com", Url = "http://www.accuratetechnologies.com" },
            //        License = new License { Name = "Use under LICX", Url = "http://url.com" },
            //    });

            //    //c.SwaggerDoc("v1", new Info { Title = "My API", Version = "v1" });
            //});

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

           // app.UseSwaggerForDocumentation();

            app.UseMvc();
        }
    }
}
