using AspNetWebApi_Northwind.Mapper;
using AspNetWebApi_Northwind.Models.Entities;
using AspNetWebApi_Northwind.Repository.Abstract;
using AspNetWebApi_Northwind.Repository.Concrete;
using AspNetWebApi_Northwind.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(typeof(NorthwindMapper));

builder.Services.AddTransient<ICategoryRepository,CategoryRepository>();


builder.Services.AddDbContext<NorthwindContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("Connection")));

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
