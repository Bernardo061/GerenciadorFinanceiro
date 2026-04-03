using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using Gerenciador.App;

// Configurações iniciais
string arquivo = "dados.json";
List<Transacao> transacoes = new List<Transacao>();

// 1. Tenta carregar dados existentes do JSON
if (File.Exists(arquivo))
{
    string jsonEntrada = File.ReadAllText(arquivo);
    transacoes = JsonSerializer.Deserialize<List<Transacao>>(jsonEntrada) ?? new List<Transacao>();
}

// 2. Interface do Usuário (CLI)
Console.Clear();
Console.WriteLine("======================================");
Console.WriteLine("   MEU GESTOR FINANCEIRO - V1.0.0");
Console.WriteLine("======================================");

while (true)
{
    decimal saldo = transacoes.Sum(t => t.Tipo == "Receita" ? t.Valor : -t.Valor);
    
    Console.WriteLine($"\nSALDO ATUAL: R$ {saldo:N2}");
    Console.WriteLine("--------------------------------------");
    Console.WriteLine("1. Adicionar Receita (+)");
    Console.WriteLine("2. Adicionar Despesa (-)");
    Console.WriteLine("3. Ver Extrato");
    Console.WriteLine("4. Sair e Salvar");
    Console.Write("\nEscolha uma opção: ");
    
    var opcao = Console.ReadLine();

    if (opcao == "4") break;

    if (opcao == "3")
    {
        Console.WriteLine("\n--- EXTRATO ---");
        foreach (var t in transacoes)
        {
            Console.WriteLine($"{t.Tipo}: {t.Descricao} - R$ {t.Valor:N2}");
        }
        continue;
    }

    try 
    {
        Console.Write("Descrição: ");
        string desc = Console.ReadLine() ?? "Sem descrição";
        
        Console.Write("Valor (ex: 50,00): ");
        decimal val = decimal.Parse(Console.ReadLine() ?? "0");

        transacoes.Add(new Transacao { 
            Descricao = desc, 
            Valor = val, 
            Tipo = opcao == "1" ? "Receita" : "Despesa" 
        });

        // 3. Salva no arquivo JSON automaticamente
        string jsonSaida = JsonSerializer.Serialize(transacoes, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(arquivo, jsonSaida);
        
        Console.WriteLine("\n✅ Registro salvo com sucesso!");
    }
    catch (Exception)
    {
        Console.WriteLine("\n❌ Erro: Valor inválido. Use números (ex: 10,50).");
    }
}

Console.WriteLine("\nObrigado por usar o Gestor. Até logo!");