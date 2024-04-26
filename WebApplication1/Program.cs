using API.Entites;
using API.Repos.Implementations;
using API.Repos.Interfaces;
using API.Services.Implementations;
using API.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ProductDbContext>(o =>
{
    o.UseSqlServer(builder.Configuration.GetConnectionString("ProductDbConnectionString"));
});
builder.Services.AddTransient<IProductRepo, ProductRepo>(); 
builder.Services.AddTransient<IProductServices, ProductServices>();
builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
