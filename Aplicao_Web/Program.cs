using Microsoft.EntityFrameworkCore;
using Aplicacao_Web.Data;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<Aplicacao_WebContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Aplicacao_WebContext") ?? throw new InvalidOperationException("Connection string 'Aplicacao_WebContext' not found.")));


string connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// Add services to the container.
builder.Services.AddControllersWithViews();

WebApplication app = builder.Build();

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

//Seed database


app.Run();