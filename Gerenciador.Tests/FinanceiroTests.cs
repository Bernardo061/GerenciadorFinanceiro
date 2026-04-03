using Xunit;
using Gerenciador.App;

namespace Gerenciador.Tests;

public class FinanceiroTests
{
    [Fact]
    public void TestarSomaDeReceita() // Caminho Feliz
    {
        var lista = new List<Transacao> {
            new Transacao { Descricao = "Salário", Valor = 1000, Tipo = "Receita" }
        };
        var saldo = lista.Sum(t => t.Tipo == "Receita" ? t.Valor : -t.Valor);
        Assert.Equal(1000, saldo);
    }

    [Fact]
    public void TestarSubtracaoDeDespesa() // Regra de Negócio
    {
        var lista = new List<Transacao> {
            new Transacao { Descricao = "Lanche", Valor = 50, Tipo = "Despesa" }
        };
        var saldo = lista.Sum(t => t.Tipo == "Receita" ? t.Valor : -t.Valor);
        Assert.Equal(-50, saldo);
    }

    [Fact]
    public void TestarSaldoMisto() // Caso Real
    {
        var lista = new List<Transacao> {
            new Transacao { Valor = 100, Tipo = "Receita" },
            new Transacao { Valor = 40, Tipo = "Despesa" }
        };
        var saldo = lista.Sum(t => t.Tipo == "Receita" ? t.Valor : -t.Valor);
        Assert.Equal(60, saldo);
    }
}