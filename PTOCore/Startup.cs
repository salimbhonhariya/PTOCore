
using System;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Server.IISIntegration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PTOCore.Data;
using PTOCore.Extensions;
using PTOCore.Models;
using PTOCore.Repositories.PTO;
using PTOCore.Services;
using Swashbuckle.AspNetCore.Swagger;

namespace PTOCore
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

            services.AddIdentity<ApplicationUser, ApplicationRole>()
                  .AddEntityFrameworkStores<ApplicationDbContext>()
                  .AddDefaultTokenProviders();
         
            //services.AddAuthentication(options =>
            //{
            //    options.DefaultChallengeScheme = IISDefaults.AuthenticationScheme;
            //});
           // services.AddTransient<IClaimsTransformation, ClaimsTransformer>();

            services.AddMvc();

            // Add functionality to inject IOptions<T>
            services.AddOptions();

            // Add framework services.
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            // Inject the configuration object for settings
            services.AddSingleton<IConfiguration>(Configuration);

            // Add application services.
            services.AddTransient<IDbInitializer, DbInitializer>();

            services.AddTransient<IPTORepository, PTORepository>();
            services.AddTransient<IEmailSender, EmailSender>();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info
                {
                    Version = "v1",
                    Title = "ATI PTO Repository API",
                    Description = "Describes the REST API used to interact with the ATI PTO Repository API",
                    TermsOfService = "See license agreement.",
                    Contact = new Contact { Name = "support@accuratetechnologies.com", Email = "support@accuratetechnologies.com", Url = "http://www.accuratetechnologies.com" },
                    License = new License { Name = "Use under LICX", Url = "http://url.com" },
                });
            });

        }
 



        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, 
            ApplicationDbContext context, 
            IDbInitializer dbInitializer            )
        {
            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
               // app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            
            app.UseSwaggerForDocumentation();

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
            dbInitializer.Initialize();

            // DbInitializer.Initialize(context);
            // https://docs.microsoft.com/en-us/aspnet/core/mvc/controllers/routing?view=aspnetcore-2.1
            //app.UseMvc(routes =>
            //{
            //    routes.MapRoute("blog", "blog/{*article}",
            //             defaults: new { controller = "Blog", action = "Article" });
            //    routes.MapRoute("default", "{controller=Home}/{action=Index}/{id?}");

            //});
        }

        // In this method we will create default User roles and Admin user for login   
    }
}