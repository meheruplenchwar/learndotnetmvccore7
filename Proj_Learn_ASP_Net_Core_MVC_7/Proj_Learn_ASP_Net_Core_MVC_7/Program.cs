using Microsoft.EntityFrameworkCore;
using Proj_Learn_ASP_Net_Core_MVC_7.Models.Domain;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//Whatever services needed in applicatio will be declared here
    builder.Services.AddControllersWithViews();

//This code will create the connection with DB using the connection declared in appsettings.json file
builder.Services.AddDbContext<DatabaseContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("conn")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

//Section for configuring middlewares
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Person}/{action=Index}/{id?}"); //Defined Default URL (Index Method in Home Controller)

app.Run();
