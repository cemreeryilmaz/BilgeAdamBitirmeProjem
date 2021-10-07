using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Shop.Business.Abstract;
using Shop.Business.Concrete;
using Shop.DataAccess.Abstract;
using Shop.DataAccess.Concrete.EntityFramework;
using Shop.WebUI.Entites;
using Shop.WebUI.Helpers;

namespace Shop.WebUI
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
            services.AddSingleton<IProductService, ProductManager>();
            services.AddSingleton<IProductDal, EfProductDal>();
            services.AddSingleton<ICategoryService, CategoryManager>();
            services.AddSingleton<ICategoryDal, EfCategoryDal>();
            services.AddScoped<ICartService, CartManager>();
            services.AddScoped<ICartSessionHelper, CartSessionHelper>();
            services.AddSingleton<IUserService, UserManager>();
            services.AddSingleton<IUserDal, EfUserDal>();
            services.AddSingleton<IOrderService, OrderManager>();
            services.AddSingleton<IOrderDal, EfOrderDal>();
            services.AddSingleton<ITicketService, TicketManager>();
            services.AddSingleton<ITicketDal, EfTicketDal>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddDbContext<CustomIdentityDbContext>(options =>
                options.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;initial catalog=Shop;integrated security=true"));
            services.AddIdentity<CustomIdentityUser, CustomIdentityRole>()
                .AddEntityFrameworkStores<CustomIdentityDbContext>().AddDefaultTokenProviders();
            services.AddSession();

            services.AddControllersWithViews();
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
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            
            app.UseRouting();
            app.UseSession();
            app.UseAuthorization();
            app.UseAuthentication();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
