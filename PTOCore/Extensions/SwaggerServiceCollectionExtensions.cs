using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.PlatformAbstractions;
using Swashbuckle.AspNetCore.Swagger;
using System;
using System.IO;
using System.Reflection;

namespace PTOCore.Extensions
{
    public static class SwaggerServiceCollectionExtensions
    {
        public static IServiceCollection AddSwaggerPageConfiguration(this IServiceCollection services)
        {
            // Inject an implementation of ISwaggerProvider with defaulted settings applied
            services.AddSwaggerGen();

            services.ConfigureSwaggerGen(options =>
            {

                options.SwaggerDoc("test", new Info
                {
                    Version = "v1",
                    Title = "ATI PTO API",
                    Description = "Describes the REST API used to interact with the ATI PTO Repository",
                    TermsOfService = "See license agreement.",
                    Contact = new Contact { Name = "support@accuratetechnologies.com", Email = "support@accuratetechnologies.com", Url = "http://www.accuratetechnologies.com" },
                    License = new License { Name = "Use under LICX", Url = "http://url.com" },
                });

                //Determine base path for the application.
                var basePath = PlatformServices.Default.Application.ApplicationBasePath;

                //Set the comments path for the swagger json and ui.
                // options.IncludeXmlComments(basePath + "\\CalibrationRepository.xml");
                var xmlFile = $"{Assembly.GetEntryAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                options.IncludeXmlComments(xmlPath);


                // UseFullTypeNameInSchemaIds replacement for .NET Core
                options.CustomSchemaIds(t => t.FullName);
            });

            return services;
        }
    }
}