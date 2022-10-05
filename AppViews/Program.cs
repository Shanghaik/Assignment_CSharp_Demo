
using Assignment_CSharp_Demo_API.IServices;
using Assignment_CSharp_Demo_API.Sevices;
using Data.DbContexts;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//builder.Services.AddTransient<ISanphamsServices, SanphamsService>();
//builder.Services.AddDbContext<CuahangDbContext>(options => options.UseSqlServer(@"Server=SHANGHAIK\SQLEXPRESS;Initial Catalog=CS5_DemoDB;Persist Security Info=True;User ID=shanghaik;Password=123456"));
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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
