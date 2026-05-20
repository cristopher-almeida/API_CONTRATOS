using ApiContratos.Repositorio;
using ApiContratos.models;

namespace ApiContratos.Routes;

public static class ROTA_GET
{
    public static void MapGetRoutes(this WebApplication app)
    {
        app.MapGet("/", () => "API de Contratos em funcionamento!"); 

        app.MapGet("/api/contratos", () => {
            return Results.Ok(ContratoRepositorio.contratos);
        });

        app.MapGet("/api/contratos/ativos", () =>
{
    var contratosAtivos = ContratoRepositorio.contratos.Where(c => c.Status == StatusContrato.Ativo || c.Status == StatusContrato.PertoDeVencer).ToList();

    return Results.Ok(contratosAtivos);
});

app.MapGet("/api/contratos/inativos", () =>
{
    var contratosInativos = ContratoRepositorio.contratos.Where(c => c.Status == StatusContrato.Vencido).ToList();

    return Results.Ok(contratosInativos);
});

        app.MapGet("/api/contratos/{id:int}", (int id) =>
        {
            var contrato = ContratoRepositorio.contratos.FirstOrDefault(c => c.Id == id);

            if (contrato != null)
{
    return Results.Ok(contrato);
}
else
{
    return Results.NotFound("Contrato não encontrado.");
}

        });
    }
}