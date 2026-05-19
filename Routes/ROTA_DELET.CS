using ApiContratos.models;

namespace ApiContratos.Routes;

public static class ROTA_DELETE
{
    public static void MapDeleteRoutes(this WebApplication app)
    {
        List<Contrato> contratos = new List<Contrato>();

        app.MapDelete("/api/contratos/{id}", (int id) =>
        {
            var refItem = contratos.FirstOrDefault(r => r.Id == id);
            if (refItem is null)
                return Results.NotFound("Referência não encontrada.");

            contratos.Remove(refItem);
            return Results.NoContent();
        });
    }
}