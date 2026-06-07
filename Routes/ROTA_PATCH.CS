using ApiContratos.Repositorio;
using ApiContratos.models;

namespace ApiContratos.Routes;

public static class ROTA_PATCH
{
    public static void MapPatchRoutes(this WebApplication app)
    {
        app.MapMethods("/api/contratos/{id:int}", new[] { "PATCH" }, (int id, Contrato parcial) =>
        {
            var contrato = ContratoRepositorio.contratos
                .FirstOrDefault(c => c.Id == id);

            if (contrato == null)
            {
                return Results.NotFound("Contrato não encontrado.");
            }

            // Atualiza só os campos que vieram preenchidos
            if (!string.IsNullOrEmpty(parcial.Empresa))    contrato.Empresa    = parcial.Empresa;
            if (!string.IsNullOrEmpty(parcial.Nome))       contrato.Nome       = parcial.Nome;
            if (!string.IsNullOrEmpty(parcial.Responsavel)) contrato.Responsavel = parcial.Responsavel;
            if (parcial.Valor > 0)                         contrato.Valor      = parcial.Valor;
            if (parcial.DataInicio != default)             contrato.DataInicio = parcial.DataInicio;
            if (parcial.Validade   != default)             contrato.Validade   = parcial.Validade;

            return Results.Ok(contrato);
        });
    }
}