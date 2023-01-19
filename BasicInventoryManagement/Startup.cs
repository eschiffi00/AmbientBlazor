using BusinessLogicLibrary.BusinessLogic.Ratios.Interfaces;
using BusinessLogicLibrary.BusinessLogic.Ratios;
using DataLogicLibrary.Models;
using DataLogicLibrary.Repositories;
using InterfaceLogicLibrary.InterfacesRepo;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using DataLogicLibrary;
using BusinessLogicLibrary;
using Microsoft.AspNetCore;


public class Startup
{
    private readonly IConfiguration _configuration;

    public Startup(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        // ...
        if (!env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
            app.UseExceptionHandler("/error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();

        app.UseStaticFiles();

        app.UseRouting();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapBlazorHub();
            endpoints.MapFallbackToPage("/_Host");
        });
    }
    public void ConfigureAppConfiguration(IConfigurationBuilder builder)
    {
        builder.AddJsonFile("appsettings.json");
    }
    public void ConfigureServices(IServiceCollection services)
    {
        var connectionString = _configuration.GetSection("ConnectionStrings").GetValue<string>("DefaultConnection");    
        services.AddRazorPages();
        services.AddServerSideBlazor();
        services.AddDbContext<AmbientHouseDbContext>(options => options.UseSqlServer(connectionString));
        services.AddScoped<DbContext, AmbientHouseDbContext>();
        services.AddScoped<IRepository<TEntityBase>, BaseRepository<TEntityBase>>();
        services.AddScoped<IRepository<Ratio>, RatiosRepository>();
        //services.AddScoped<IRepository<Ratio>, BaseRepository<Ratio>>();
        services.AddScoped<ICreateRatio, CreateRatio>();
        services.AddScoped<IUpdateRatio, UpdateRatio>();
        services.AddScoped<IGetRatioById, GetRatioById>();

    }
    //...
}