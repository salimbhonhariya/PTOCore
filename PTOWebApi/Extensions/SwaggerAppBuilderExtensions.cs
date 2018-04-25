//using Microsoft.AspNetCore.Builder;

//namespace PTOWebApi.Extensions
//{
//    public static class SwaggerAppBuilderExtensions
//    {
//        /// <summary>
//        /// Uses the swagger for documentation.
//        /// </summary>
//        /// <param name="app">The application.</param>
//        public static IApplicationBuilder UseSwaggerForDocumentation(this IApplicationBuilder app)
//        {
//            // Enable middleware to serve generated Swagger as a JSON endpoint
//            app.UseSwagger();
//            // Enable middleware to serve swagger-ui assets (HTML, JS, CSS etc.)
//            app.UseSwaggerUI(c =>
//            {
//                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
//                // Comment this line of code if you don't want swagger as your home page during deployment. But best for development of API
//                c.RoutePrefix = string.Empty;
                
//            });

//            return app;
//        }
//    }
//}