# 💰 Gestor Financeiro Pessoal (CLI)

[![CI Gestor Financeiro](https://github.com/Bernardo061/GerenciadorFinanceiro/actions/workflows/main.yml/badge.svg)](https://github.com/Bernardo061/GerenciadorFinanceiro/actions)

**Versão:** 1.0.0  
**Autor:** João Bernardo Dias de Brito  

## 🎯 Problema Real
Muitos jovens e estudantes têm dificuldade em visualizar e controlar pequenos gastos diários (como lanches e transportes), o que frequentemente gera insegurança financeira e falta de dinheiro ao fim do mês.

## 👥 Público-Alvo
Estudantes universitários, jovens adultos e pessoas que buscam uma forma rápida, direta e sem distrações visuais para registrar finanças diárias sem depender de planilhas complexas.

## 🚀 Solução
Uma aplicação de Linha de Comando (CLI) simples e eficiente para registrar receitas e despesas. O sistema mantém o saldo atualizado em tempo real e persiste os dados localmente em um arquivo `.json` para consultas futuras, garantindo autonomia e privacidade.

## ✨ Funcionalidades Principais
- Registro rápido de Receitas.
- Registro de Despesas.
- Exibição de Extrato/Histórico de transações.
- Cálculo automático de saldo atualizado.
- Persistência automática em arquivo `dados.json`.

## 🛠️ Tecnologias Utilizadas
- **Linguagem:** C# (.NET 8.0)
- **Armazenamento de Dados:** JSON (`System.Text.Json`)
- **Testes Automatizados:** xUnit
- **Análise Estática (Linting):** `dotnet format`
- **CI/CD:** GitHub Actions (Integração Contínua)

## 🚀 Novidades da Versão (Entrega Intermediária)
- **Integração com API Externa:** Agora o sistema consome a [AwesomeAPI](https://docs.awesomeapi.com.br/api-de-moedas) para exibir a cotação em tempo real do Dólar e do Euro logo na tela inicial, auxiliando no registro de despesas internacionais.
- **Testes de Integração:** Adicionado teste para garantir a estabilidade da comunicação com a API.

## 📦 Como Instalar e Executar

1. Certifique-se de ter o [.NET SDK 8.0](https://dotnet.microsoft.com/download/dotnet/8.0) instalado em sua máquina.
2. Clone o repositório:
   ```bash
   git clone https://github.com/Bernardo061/GerenciadorFinanceiro.git