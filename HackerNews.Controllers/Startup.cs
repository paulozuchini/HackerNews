using HackerNews.Services;
using HackerNews.Services.Interfaces;
using System.Diagnostics.CodeAnalysis;

namespace HackerNews.Controllers
{
    [ExcludeFromCodeCoverage]
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers(mvcOptions => mvcOptions.EnableEndpointRouting = false);
            services.AddCors();

            services.AddLogging();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo() { Title = "HackerNews - API", Version = "v1" });
            });

            // Services
            services.AddTransient<IHackerNewsService, HackerNewsService>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if(env.IsDevelopment())
                app.UseDeveloperExceptionPage();

            app.UseCors(x => x
            .AllowAnyMethod()
            .AllowAnyHeader()
            .SetIsOriginAllowed(origin => true));

            app.UseMvc();

            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "HackerNews - API v1"));
        }
    }
}
