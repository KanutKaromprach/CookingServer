using CookingServer.Models;
using CookingServer.Repositories;
using CookingServer.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace CookingServer
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(o => o.AddPolicy("CorsPolicy", builder =>
           {
               builder.AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader();
           })
           );
            services.Configure<CookingDatabaseSettings>(Configuration.GetSection(nameof(CookingDatabaseSettings)));
            services.AddSingleton<ICookingDatabaseSettings>(sp => sp.GetRequiredService<IOptions<CookingDatabaseSettings>>().Value);
            services.AddScoped<ICookingService, CookingService>();
            services.AddScoped<ICookingRepository, CookingRepository>();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }
            app.UseCors("CorsPolicy");
            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
