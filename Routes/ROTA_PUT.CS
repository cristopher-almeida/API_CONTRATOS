using ApiContratos.models;

namespace ApiContratos.Routes;

public static class ROTA_PUT
{
    public static void MapPutRoutes(this WebApplication app)
    {
        List<Contrato> contratos = new List<Contrato>();

        app.MapPut("/api/referencias/{id}", (int id, Contrato atualizada) =>
        {
            var refItem = contratos.FirstOrDefault(r => r.Id == id);
            if (refItem is null)
                return Results.NotFound("Referência não encontrada.");

            refItem.Empresa = atualizada.Empresa;
            refItem.Id = atualizada.Id;
            refItem.Nome = atualizada.Nome;
            refItem.Valor = atualizada.Valor;
            refItem.Responsavel = atualizada.Responsavel;
            refItem.DataInicio = atualizada.DataInicio;
            refItem.Validade = atualizada.Validade;

            return Results.Ok(refItem);
        });
    }
}