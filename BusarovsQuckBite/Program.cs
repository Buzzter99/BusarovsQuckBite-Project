using BusarovsQuckBite.Contracts;
using BusarovsQuckBite.Data;
using BusarovsQuckBite.Data.Models;
using BusarovsQuckBite.Hubs;
using BusarovsQuckBite.Middlewares;
using BusarovsQuckBite.ModelBinders;
using BusarovsQuckBite.Providers;
using BusarovsQuckBite.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApplicationUser = BusarovsQuckBite.Data.Models.ApplicationUser;

namespace BusarovsQuckBite
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(connectionString).UseLazyLoadingProxies());
            builder.Services.AddDatabaseDeveloperPageExceptionFilter();
            builder.Services.AddScoped<IAddressService, AddressService>();
            builder.Services.AddScoped<ICategoryService, CategoryService>();
            builder.Services.AddScoped<IProductService, ProductService>();
            builder.Services.AddScoped<IImgService, ImgService>();
            builder.Services.AddScoped<ICartService, CartService>();
            builder.Services.AddScoped<IOrderService, OrderService>();
            builder.Services.AddSignalR();
            builder.Services.AddScoped<IDataProtectionService, DataProtectionService>();
            builder.Services.AddTransient<IEmailSender, EmailService>();
            builder.Services.Configure<CustomTokenProviderOptions>(options => {options.TokenLifespan = TimeSpan.FromHours(2);});
            builder.Services.Configure<DataProtectionTokenProviderOptions>(options => { options.TokenLifespan = TimeSpan.FromDays(1);});
            builder.Services.AddIdentity<ApplicationUser, ApplicationRole>(options =>
                {
                    options.SignIn.RequireConfirmedAccount = false;
                    options.Password.RequireDigit = false;
                    options.Password.RequireLowercase = false;
                    options.Password.RequireUppercase = false;
                    options.Password.RequireNonAlphanumeric = false;
                    options.Tokens.PasswordResetTokenProvider = "ResetTokenProvider";
                })
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddSignInManager<ApplicationSignInManager<ApplicationUser>>()
                .AddUserManager<ApplicationUserManager<ApplicationUser>>()
                .AddDefaultTokenProviders()
                .AddTokenProvider<CustomTokenProvider<ApplicationUser>>("ResetTokenProvider");
            builder.Services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = "/AccountManager/Users/Login";
                options.AccessDeniedPath = "/Home/Unauthorized";
            });
            builder.Services.AddControllersWithViews(options =>
            {
                options.Filters.Add(new AutoValidateAntiforgeryTokenAttribute());
                options.ModelBinderProviders.Insert(0, new DecimalModelBinderProvider());
            });
            builder.Services.AddRazorPages();
            var app = builder.Build();
            app.MapHub<ChatHub>("/chatHub");
            if (app.Environment.IsDevelopment())
            {
                app.UseMigrationsEndPoint();
                app.UseMiddleware<BadResponseCodeRedirect>();
                app.UseMiddleware<ExceptionLogger>();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
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
                    name: "areas",
                    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                );
            });
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            app.MapRazorPages();
            app.Run();
        }
    }
}