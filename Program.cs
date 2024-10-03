using DotNetEnv;
using API_FARM.Data;
using Microsoft.EntityFrameworkCore;
using API_FARM.Repositories;
using API_FARM.Services;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Annotations;

Env.Load();

var host = Environment.GetEnvironmentVariable("DB_HOST");
var port = Environment.GetEnvironmentVariable("DB_PORT");
var databaseName = Environment.GetEnvironmentVariable("DB_DATABASE_NAME");
var userName = Environment.GetEnvironmentVariable("DB_USERNAME");
var password = Environment.GetEnvironmentVariable("DB_PASSWORD");

var connectionString = $"server={host};port={port};database={databaseName};uid={userName};password={password}";

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ApplicationDbContext>(options =>
                                                        //parseo de conexion
    options.UseMySql(connectionString, ServerVersion.Parse("8.0.20-mysql")));

builder.Services.AddControllers();
builder.Services.AddScoped<IAnimalTypeRepository,AnimalTypeServices>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(
    c=>{
        c.SwaggerDoc("v1",new OpenApiInfo{Title = "Api Farm", Version = "v1"});
        c.EnableAnnotations();
    }
);

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
