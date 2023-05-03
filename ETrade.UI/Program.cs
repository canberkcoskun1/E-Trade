using ETrade.Dal;
using ETrade.Rep.Abstracts;
using ETrade.Rep.Concretes;
using ETrade.UI.Models.ViewModel;
using ETrade.UOW;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<Context>(options =>
		options.UseSqlServer(builder.Configuration.GetConnectionString("ETrade")));
builder.Services.AddScoped<IUow, Uow>();
builder.Services.AddScoped<IFoodRepos, FoodRepos>();
builder.Services.AddScoped<ICatRepos, CatRepos>();
builder.Services.AddScoped<IOrderRepos, OrderRepos>();
builder.Services.AddScoped<IOrderDetailRepos, OrderDetailRepos>();
builder.Services.AddScoped<IUserRepos, UserRepos>();
builder.Services.AddScoped<IPropertiesRepos, PropertiesRepos>();
builder.Services.AddScoped<BaseCrud>();
builder.Services.AddScoped<CategoriesModel>();

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
