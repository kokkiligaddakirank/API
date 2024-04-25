using API.Repos.Implementations;
using API.Repos.Interfaces;
using API.Services.Implementations;
using API.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddTransient<IProductRepo, ProductRepo>(); 
builder.Services.AddTransient<IProductServices, ProductServices>();
builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
