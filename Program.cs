using ApiContratos.Routes;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

builder.Services.ConfigureHttpJsonOptions(options =>
{
    options.SerializerOptions.Converters.Add(new JsonStringEnumConverter());
});

var app = builder.Build();

app.MapGetRoutes();
app.MapPostRoutes();
app.MapPutRoutes();
app.MapDeleteRoutes();

app.Run();