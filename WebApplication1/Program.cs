using Microsoft.EntityFrameworkCore;
using MyLearning.Repo;
using MyLearning.Repo.Implementation;
using MyLearning.Repo.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ProjectContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("Conn"),b => b.MigrationsAssembly("MyLearning.UI")));
builder.Services.AddScoped<ICountryRepo, CountryRepo>();
builder.Services.AddScoped<IStateRepo, StateRepo>();
builder.Services.AddScoped<ICityRepo, CityRepo>();





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
