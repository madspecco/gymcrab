using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace YourNamespace
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            // Add any services you need, such as CORS, authentication, etc.
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // Add middleware configurations, routing, and other setup here.
        }
    }
}
