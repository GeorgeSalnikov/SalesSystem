using SalesSystem.DAL;
using SalesSystem.BL;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace SalesSystem
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        private const string SalesSystemNGOrigin = "SalesSystemNGOrigin";
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options => options.AddPolicy(SalesSystemNGOrigin, builder => builder.WithOrigins("http://localhost:4200").AllowAnyHeader().AllowAnyMethod()));
            services.AddMvc(); //.SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
            services.AddControllersWithViews(); //.AddNewtonsoftJson(options => options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore); 
            services.AddRazorPages();
            services.AddDbContext<SalesSystemDbContext>(op => op.UseInMemoryDatabase(SalesSystemDbContext.DatabaseName));
            services.AddScoped<IBookService, BookService>();
            services.AddScoped<ICustomerService, CustomerService>();
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<UtilityService, UtilityService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                using (var scope = app.ApplicationServices.CreateScope())
                {
                    var utilSvc = scope.ServiceProvider.GetRequiredService<UtilityService>();

                    // initialize in-memory database with test data
                    utilSvc.PopulateRepoWithTestData();
                }
            }

            app.UseCors(SalesSystemNGOrigin);
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapControllers();
            });
            
        }
    }
}
