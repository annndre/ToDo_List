using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.Extensions.Hosting;
using ToDo_List.Data;
using Microsoft.EntityFrameworkCore.Infrastructure;
using ToDo_List.Data.Repository;


var builder = WebApplication.CreateBuilder(args);
string connString = builder.Configuration.GetConnectionString("AppDb");

// Add services to the container.
builder.Services.AddDbContext<DB>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("AppDb"));
    //string sql = "SELECT toDoItems.Date FROM toDoItems ";
    
});

builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

builder.Services.AddScoped<IRepository, SQLRepository>();

builder.Services.AddSingleton<WeatherForecastService>();

builder.Services.AddSingleton<Email_controller>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();


