using ApiContratos.models;

namespace ApiContratos.Routes;

public static class ROTA_POST
{
    public static void MapPostRoutes(this WebApplication app)
    {
        // Lista simulada armazenada em memória
        List<Contrato> contratos = new List<Contrato>();

        app.MapPost("/api/contratos", (Contrato novo) =>
        {
            novo.Id = contratos.Count + 1;
            contratos.Add(novo);
            return Results.Created($"/api/contrato/{novo.Id}", novo);
        });
    }
}