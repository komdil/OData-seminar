using Microsoft.EntityFrameworkCore;
using ProductAPI.Abstractions;
using ProductAPI.Repositories;

namespace ProductAPI
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers().AddNewtonsoftJson();
            services.AddDbContext<ApplicationDbContext>(options =>
                  options.UseSqlServer("data source=localhost;integrated security=True;Database=ODataseminar;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True"));
            services.AddScoped<IApplicationDbContext>(provider => provider.GetRequiredService<ApplicationDbContext>());
            services.AddScoped<IApplicationDbContextInitializer, ApplicationDbContextInitializer>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment environment, IApplicationDbContextInitializer initializer)
        {
            app.UseRouting();
            if (environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseHttpsRedirection();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseEndpoints(routebuilder =>
            {
                routebuilder.MapControllers();
            });
            initializer.Init();
        }
    }
}
