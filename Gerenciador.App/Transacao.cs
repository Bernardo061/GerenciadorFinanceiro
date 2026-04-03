namespace Gerenciador.App;

public class Transacao {
    public string Descricao { get; set; } = string.Empty;
    public decimal Valor { get; set; }
    public string Tipo { get; set; } = "Despesa"; // Receita ou Despesa
}