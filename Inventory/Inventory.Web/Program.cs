using Inventory.Repository;
using Inventory.Utility.HelperClass;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Configuration;
using Microsoft.AspNetCore.Identity;

var webApplicationOptions = new WebApplicationOptions
{
	ContentRootPath = AppContext.BaseDirectory,
	Args = args,
};
var builder = WebApplication.CreateBuilder(webApplicationOptions);
var connectionString = builder.Configuration.GetConnectionString("ApplicationDbContextConnection") ?? throw new InvalidOperationException("Connection string 'ApplicationDbContextConnection' not found.");

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();

//builder.Services.AddDbContext<ApplicationDbContext>(option =>
//	option.UseSqlServer(builder.Configuration.GetConnectionString("InventoryDb")));


// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.Configure<SuperAdmin>(builder.Configuration.GetSection("SuperAdmin"));

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
app.UseAuthentication();;

app.UseAuthorization();

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
