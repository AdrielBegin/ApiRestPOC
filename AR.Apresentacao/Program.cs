using AR.Data;
using AR.Data.Imp;
using AR.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

// Dependency Injection

builder.Services.AddScoped<IClienteRepository, ClienteRepository>();

// Add services to the container.

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// connecion with db
var connectionString = builder.Configuration.GetConnectionString("ApiRest");

builder.Services.AddEntityFrameworkSqlServer().AddDbContext<ContextoPricinpal>(options => options.UseSqlServer(connectionString));



var app = builder.Build();




// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
