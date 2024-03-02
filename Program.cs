using System.Text.Json;
using System.Text.Json.Serialization;
using Api_Farmancias.Database;
using Api_Farmancias.Repositorio;
using Api_Farmancias.Repositorio.InterFace;
using Microsoft.AspNetCore.Hosting;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddAutoMapper(typeof(StartupBase));
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<Appdbcontext>();
builder.Services.AddScoped<IFarmaciaRepisitory,FarmaciaRepository>();
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

