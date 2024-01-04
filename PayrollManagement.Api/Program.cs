using Microsoft.AspNetCore.Identity;
using PayrollManagement.Business.ModuleRole.Models;
using PayrollManagement.Business.ModuleUser.Models;
using PayrollManagement.Infraestructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
IConfiguration configuration = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json", optional: true)            
            .Build();

builder.Services.AddControllers();


//.AddDefaultTokenProviders(); // Agregar proveedores de tokens por defecto
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCustomaizedDataStore(configuration);
builder.Services.AddCustomizedRepository();

builder.Services.AddIdentity<User, Role>(options =>
{
    options.Password.RequireDigit = true;
    options.Password.RequiredLength = 8;

}).AddDefaultTokenProviders();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
