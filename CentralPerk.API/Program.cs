using System.Data;
using System.Reflection;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using CentralPerk.API.DependencyResolver;
using CentralPerk.API.Filters;
using CentralPerk.API.Middlewares;
using CentralPerk.API.UnitOfWorks;
using FluentValidation.AspNetCore;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Npgsql;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers(opt =>
    {
        opt.Filters.Add(new ValidationFilter()); //Validate Filter Activated
    })
    .AddFluentValidation(x => x.RegisterValidatorsFromAssembly(Assembly.GetExecutingAssembly()));
builder.Services.Configure<ApiBehaviorOptions>(option => { option.SuppressModelStateInvalidFilter = true; });

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IDbConnection>(sp =>
    new NpgsqlConnection(builder.Configuration.GetConnectionString("PostgreSQL")));
builder.Services.AddScoped<UnitOfWork>();
builder.Services.AddScoped(sp =>
{
    var connection = sp.GetRequiredService<IDbConnection>();
    connection.Open();
    return connection.BeginTransaction();
});

builder.Services.AddMediatR(Assembly.GetExecutingAssembly());
builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
builder.Host.ConfigureContainer<ContainerBuilder>(containerBuilder =>
    containerBuilder.RegisterModule(new AutoFacResolver())); //AutoFac

var app = builder.Build();

// Configure the HTTP request pipeline.

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCustomException();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();