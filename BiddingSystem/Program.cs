using Microsoft.EntityFrameworkCore;
using BiddingSystem.Data;

var builder = WebApplication.CreateBuilder(args);

//Add services to container
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<BiddingSystemContext>(
    options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

//Configure the  Http request pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{d?}");

app.Run();