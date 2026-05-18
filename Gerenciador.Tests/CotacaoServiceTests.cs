using System.Threading.Tasks;
using GerenciadorFinanceiro.Services; 
using Xunit;

namespace Gerenciador.Tests; 

public class CotacaoServiceTests
{
    [Fact]
    public async Task ObterCotacoesAsync_DeveRetornarDadosValidos_QuandoAPIEstiverOnline()
    {
        // Arrange
        var service = new CotacaoService();

        // Act
        var resultado = await service.ObterCotacoesAsync();

        // Assert
        Assert.NotNull(resultado);
        Assert.NotNull(resultado.Dolar);
        Assert.NotNull(resultado.Euro);
        
        // Garante que o código retornado é realmente o esperado
        Assert.Equal("USD", resultado.Dolar.Codigo);
        Assert.Equal("EUR", resultado.Euro.Codigo);

        // Garante que os valores de compra não vieram vazios
        Assert.False(string.IsNullOrWhiteSpace(resultado.Dolar.ValorCompra));
        Assert.False(string.IsNullOrWhiteSpace(resultado.Euro.ValorCompra));
    }
}