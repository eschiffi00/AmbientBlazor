using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using DataLogicLibrary;
using DataLogicLibrary.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using InterfaceLogicLibrary.InterfacesRepo;
using DataLogicLibrary.Models;
using BusinessLogicLibrary;
using BusinessLogicLibrary.BusinessLogic.Ratios.Interfaces;
using BusinessLogicLibrary.BusinessLogic.Ratios;
using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.AspNetCore;

var builder = WebHost.CreateDefaultBuilder(args)
    .ConfigureAppConfiguration((hostingContext, config) =>
    {
        config.AddJsonFile("appsettings.json", optional: true);
    })
    .UseStartup<Startup>();

//builder.UseConfiguration(configuration);
//builder.UseStartup<Startup>();

var app = builder.Build();

app.Run();