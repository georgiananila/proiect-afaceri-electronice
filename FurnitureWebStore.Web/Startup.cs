using FurnitureWebStore.DataAccess;
using FurnitureWebStore.DataAccess.Interfaces;
using FurnitureWebStore.DataAccess.Repository;
using FurnitureWebStore.Models;
using FurnitureWebStore.Models.Entities;
using FurnitureWebStore.Models.Interfaces;
using FurnitureWebStore.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FurnitureWebStore.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<FurnitureWebStoreContext>(option => option.UseSqlServer(Configuration.GetConnectionString("AppDbConn")));
            services.AddControllersWithViews();

            services.AddSingleton(MapperConfig.GetMapper());
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(60);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            #region Services

            services.AddScoped<IProductTypeService, ProductTypeService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IFeedbackServices, FeedbackServices>();

            #endregion Services

            #region Repository

            services.AddScoped<IRepository<ProductType, int>, Repository<ProductType, int>>();
            services.AddScoped<IRepository<Product, int>, Repository<Product, int>>();
            services.AddScoped<IRepository<Feedback, int>, Repository<Feedback, int>>();

            #endregion Repository

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseSession();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
