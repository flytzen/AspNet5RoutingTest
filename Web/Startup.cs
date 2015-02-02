using System;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;

namespace Web
{
    using Microsoft.AspNet.Routing;
    using Microsoft.Framework.DependencyInjection;

    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {

            // Add MVC services to the services container.
            services.AddMvc();
        }
        public void Configure(IApplicationBuilder app)
        {
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller}/{action}/{id?}",
                    defaults: new { controller = "Home", action = "Index" });
            });
        }
    }
}
