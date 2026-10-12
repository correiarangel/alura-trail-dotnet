using ListaTarefaz;
using ListaTarefaz.Converters;
using ListaTarefaz.Data;
using Microsoft.EntityFrameworkCore;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();

builder.Services.ConfigureHttpJsonOptions(options =>
{
    options.SerializerOptions.Converters.Add(new NullableDateOnlyJsonConverter());
});

builder.Services.AddDbContext<ListaTarefazContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("TarefazConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/openapi/v1.json", "ListaTarefaz v1");
        options.RoutePrefix = "swagger";
    });
}

app.UseHttpsRedirection();

app.MapTarefazEndPoints();

app.Run();
