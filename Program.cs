using CordiSimpleDotnet.Data;
using CordiSimpleDotnet.Repositories;
using CordiSimpleDotnet.Services;
using CordiSimpleDotnet.Utilities;
using DotNetEnv;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Database connection

Env.Load();

var dbHost = Environment.GetEnvironmentVariable("DB_HOST");
var dbPort = Environment.GetEnvironmentVariable("DB_PORT");
var dbName = Environment.GetEnvironmentVariable("DB_DATABASE");
var dbUser = Environment.GetEnvironmentVariable("DB_USERNAME");
var dbPassword = Environment.GetEnvironmentVariable("DB_PASSWORD");

var conectionDB = $"server={dbHost};port={dbPort};database={dbName};uid={dbUser};password={dbPassword}";

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseMySql(conectionDB, ServerVersion.Parse("8.0.15-mysql")));



// Add services to the container.

builder.Services.AddSingleton<PasswordHasher>();

// Repositories and services
builder.Services.AddScoped<IUserRepository, UserService>();

// Controllers and Endpoints
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{

    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "CordiSimple API",
        Version = "V1",
        Description = "API for managing an events database. This version includes basic CRUD operations for users, events and reserves.",
        Contact = new OpenApiContact
        {
            Name = "Carolina Bustamante Escobar",
            Email = "caro.bustamante.escobar@gmail.com",
            Url = new Uri("https://www.linkedin.com/in/caro-bustamante-escobar")
        }
    }
         );

    c.EnableAnnotations();
});

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
