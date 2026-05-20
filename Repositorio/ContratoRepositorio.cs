using ApiContratos.models;

namespace ApiContratos.Repositorio; // Lista compartilhada usada por todas as rotas.
// Funciona como um banco de dados temporário em memória.

public static class ContratoRepositorio
{
    public static List<Contrato> contratos = new List<Contrato>
        {
            new Contrato {Empresa = " TechNova Sistemas ", Id = 1, Nome = " Contrato de suporte técnico ", Valor = 2500.00m, Responsavel = " Carlos Mendes ", DataInicio = new DateOnly(2026, 1, 10), Validade = new DateOnly(2026, 5, 20) },
            new Contrato {Empresa = " Alfa Contabilidade ", Id = 2, Nome = " Contrato de prestação de serviços contábeis ", Valor = 1800.00m, Responsavel = " Mariana Souza ", DataInicio = new DateOnly(2026, 2, 1), Validade = new DateOnly(2026, 6, 1) },
            new Contrato {Empresa = " FastNet Telecom ", Id = 3, Nome = " Contrato de internet corporativa ", Valor = 799.90m, Responsavel = " João Pereira ", DataInicio = new DateOnly(2026, 3, 15), Validade = new DateOnly(2026, 5, 15) },
            new Contrato {Empresa = " Clínica Vida Mais ", Id = 4, Nome = " Contrato de manutenção de sistema ", Valor = 1200.00m, Responsavel = " Ana Ribeiro ", DataInicio = new DateOnly(2026, 1, 5), Validade = new DateOnly(2026, 7, 5) },
            new Contrato {Empresa = " Mercado Bom Preço ", Id = 5, Nome = " Contrato de fornecimento de software ", Valor = 3500.00m, Responsavel = " Lucas Almeida ", DataInicio = new DateOnly(2026, 4, 1), Validade = new DateOnly(2026, 5, 25) },
            new Contrato {Empresa = " Escola Futuro Digital ", Id = 6, Nome = " Contrato de licença educacional ", Valor = 4200.00m, Responsavel = " Fernanda Lima ", DataInicio = new DateOnly(2026, 2, 20), Validade = new DateOnly(2026, 8, 20) },
            new Contrato {Empresa = " Construtora Horizonte ", Id = 7, Nome = " Contrato de consultoria administrativa ", Valor = 5100.00m, Responsavel = " Roberto Martins ", DataInicio = new DateOnly(2026, 1, 25), Validade = new DateOnly(2026, 5, 18) },
            new Contrato {Empresa = " Loja Estilo Urbano ", Id = 8, Nome = " Contrato de marketing digital ", Valor = 2200.00m, Responsavel = " Patrícia Gomes ", DataInicio = new DateOnly(2026, 3, 10), Validade = new DateOnly(2026, 9, 10) },
            new Contrato {Empresa = " Auto Peças Brasil ", Id = 9, Nome = " Contrato de sistema de estoque ", Valor = 3100.00m, Responsavel = " Eduardo Costa ", DataInicio = new DateOnly(2026, 4, 12), Validade = new DateOnly(2026, 5, 22) },
            new Contrato {Empresa = " Hotel Central Palace ", Id = 10, Nome = " Contrato de suporte e hospedagem web ", Valor = 1600.00m, Responsavel = " Juliana Rocha ", DataInicio = new DateOnly(2026, 2, 8) , Validade = new DateOnly(2026, 10, 8) }
            
        };
}