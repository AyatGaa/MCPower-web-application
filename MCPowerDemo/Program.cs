using Business.Abstraction;
using Business.Implementation;
using Domain.Abstraction;
using Domain.Abstractions;
using Domain.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Repository.Implementation;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMemoryCache();
builder.Services.AddSession();

//builder.Services.AddSingleton<ISingletonService, SingletonService>();
builder.Services.AddTransient<IRoleRepo, RoleRepo>();
builder.Services.AddTransient<IAdminRepo, AdminRepo>();
builder.Services.AddTransient<IProductRepo,ProductRepo>();

 
builder.Services.AddScoped<IAdminService, AdminService>();
builder.Services.AddScoped<IProductService, ProductService>();
//builder.Services.AddTransient<IRoleService, RoleService>();

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<MCpowerDbcontext>(opt => opt.UseSqlServer(builder.Configuration
    .GetConnectionString("MCPowerConnectionString")));

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
app.UseSession();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute("Default", "{controller=Acount}/{action=Login}/{id?}");
});
app.Run();
