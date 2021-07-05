using DevExpress.AspNetCore;
using DevExpress.DashboardAspNetCore;
using DevExpress.DashboardCommon;
using DevExpress.DashboardWeb;
using DevExpress.DataAccess.Json;
using Microsoft.Extensions.FileProviders;
using System;
namespace AmorAuditDashboard.Server
{
    public class Startup
    {
        public Startup(IConfiguration configuration, IWebHostEnvironment hostingEnvironment)
        {
            Configuration = configuration;
            FileProvider = hostingEnvironment.ContentRootFileProvider;
        }

        public IConfiguration Configuration { get; }
        public IFileProvider FileProvider { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDevExpressControls();
            services.AddMvc()
                    .AddDefaultDashboardController(configurator => {
                // Register Dashboard Storage
                configurator.SetDashboardStorage(new DashboardFileStorage(FileProvider.GetFileInfo("App_Data/Dashboards").PhysicalPath));
                // Create a sample JSON data source
                DataSourceInMemoryStorage dataSourceStorage = new DataSourceInMemoryStorage();
                        DashboardJsonDataSource jsonDataSourceUrl = new DashboardJsonDataSource("JSON Data Source (URL)");
                        jsonDataSourceUrl.JsonSource = new UriJsonSource(
                                new Uri("https://raw.githubusercontent.com/DevExpress-Examples/DataSources/master/JSON/customers.json"));
                        jsonDataSourceUrl.RootElement = "Customers";
                        dataSourceStorage.RegisterDataSource("jsonDataSourceUrl", jsonDataSourceUrl.SaveToXml());
                        configurator.SetDataSourceStorage(dataSourceStorage);
                    });
            services.AddControllersWithViews();
            services.AddRazorPages();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseWebAssemblyDebugging();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseBlazorFrameworkFiles();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapControllers();
                endpoints.MapFallbackToFile("index.html");
            });
        }
    }
}
