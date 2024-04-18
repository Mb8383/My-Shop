using Microsoft.EntityFrameworkCore;
using MobileShop.Data.AppDbContext;
using MobileShop.Application.Services.Interface;
using MobileShop.Application.Services.Implementation;
using MobileShop.Domain.IRepositories;
using MobileShop.Data.Repositories.Users;
namespace Mobile_Shop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            #region Builder
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<AppdbContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("AppDBContext"));
            });
          //  Add services to the container.
           builder.Services.AddControllersWithViews();
            builder.Services.AddScoped<IUserServices, UserServices>();
            builder.Services.AddScoped<IUserRepositories, UserRepository>();
            builder.Services.AddDbContext<AppdbContext>();
            #endregion

            #region AppServices
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                  name: "Admin",
                  pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                );
            });

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
            #endregion
        }
    }
}
