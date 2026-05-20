using ApiContratos.Routes;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

builder.Services.ConfigureHttpJsonOptions(options =>
{             // Configura o enum para aparecer como texto no JSON.   
    options.SerializerOptions.Converters.Add(new JsonStringEnumConverter());
});

var app = builder.Build();

app.MapGetRoutes();
app.MapPostRoutes();
app.MapPutRoutes();
app.MapDeleteRoutes();

app.Run();