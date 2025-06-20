#region str ref
using Microsoft.EntityFrameworkCore;
using Scalar.AspNetCore;
using schoolArch.core;
using schoolArch.infra;
using schoolArch.infra.Abstracts;
using schoolArch.infra.Repo;
using schoolArch.service;
using static schoolArch.infra.Context.AppSchoolContext;

#endregion

#region builder,controller

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
#endregion

#region swagger replacement openapi

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
#endregion

#region context
builder.Services.AddDbContext<SchoolArchDb>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
#endregion

#region dependancy injection
builder.Services.AddInfra()
                .AddService()
                .AddCore();
#endregion

#region pipeline config and default app use
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())

{
    app.MapScalarApiReference();
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
#endregion
