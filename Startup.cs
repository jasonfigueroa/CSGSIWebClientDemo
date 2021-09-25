using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace CSGSIWebClientDemo
{
    public class Startup
    {
        private IHostingEnvironment _env;

        public Startup(IHostingEnvironment env)
        {
            _env = env;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            if (_env.IsDevelopment())
            {
                services.AddWebOptimizer(minifyJavaScript: false, minifyCss: false);
            }
            else
            {
                services.AddWebOptimizer(pipeline =>
                {
                    pipeline.AddJavaScriptBundle(
                        "js/dist/bundle.js", // destination
                        "js/*.js"
                    );
                    pipeline.MinifyJsFiles(
                        "js/views/*.js"
                    );
                    pipeline.MinifyCssFiles(
                        "css/*.css"
                    );
                });
            }
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            _env = env;

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseWebOptimizer();

            app.UseStatusCodePages();

            app.UseStaticFiles(); // for wwwroot

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}"
                );
            });
        }
    }
}
