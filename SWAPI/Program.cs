using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SWAPI.Database;
using SWAPI.Database.Context;
using SWAPI.Service.AutoMapperProfile;
using SWAPI.Service.Films;
using SWAPI.Service.People;
using SWAPI.Service.Planets;
using SWAPI.Shared.Helper;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle


builder.Services.AddDbContext<SwapiDbContext>(options => options.UseInMemoryDatabase(databaseName: "SWAPI"));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(Profiler));
builder.Services.AddScoped<IPeopleService, PeopleService>();
builder.Services.AddScoped<IPlanetsService, PlanetsService>();
builder.Services.AddScoped<IFilmService, FilmService>();


JsonFileReader.Initialize(builder.Environment);

var app = builder.Build();
using (var scope = app.Services.CreateScope())
{
    var myService = scope.ServiceProvider.GetRequiredService<SwapiDbContext>();
    DataGenerator.Initialize(scope.ServiceProvider);
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseCors(builder =>
        builder
        .WithOrigins("http://localhost:4200")
        .AllowAnyMethod()
        .AllowAnyHeader());

app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllers();

app.Run();
