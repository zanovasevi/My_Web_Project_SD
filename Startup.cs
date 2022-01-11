using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Mvc;
using SoundAndDance_v2.Data;
using SoundAndDance_v2.Services.CategoryServices;
using SoundAndDance_v2.Services.DrumsServices;
using SoundAndDance_v2.Services.BassServices;
using SoundAndDance_v2.Services.GuitarServices;
using SoundAndDance_v2.Services.KeyboardServices;
using SoundAndDance_v2.Services.InstrumentServices;
using SoundAndDance_v2.Infrastructure;

namespace SoundAndDance_v2
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
            services.AddDbContext<SDDbContext>();

            services.AddDatabaseDeveloperPageExceptionFilter();

            services.AddDefaultIdentity<IdentityUser>(options =>
                options.SignIn.RequireConfirmedAccount = false)
                    .AddRoles<IdentityRole>()
                    .AddEntityFrameworkStores<SDDbContext>();

            services.AddControllersWithViews(options =>
                options.Filters.Add<AutoValidateAntiforgeryTokenAttribute>());

            services.AddControllersWithViews().AddRazorRuntimeCompilation();


            services.AddTransient<ICategoryService, CategoryService>();
            services.AddTransient<IDrumsService, DrumsService>();
            services.AddTransient<IBassService, BassService>();
            services.AddTransient<IGuitarService, GuitarService>();
            services.AddTransient<IKeyboardService, KeyboardService>();
            services.AddTransient<IInstrumentService, InstrumentService>();

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.PrepareAdministrator();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();
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
                //endpoints.MapControllerRoute(
                //    name: "Areas",
                //    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

                endpoints.MapDefaultControllerRoute();

                endpoints.MapRazorPages();
            });
        }
    }
}