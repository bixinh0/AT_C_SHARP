using System;
using System.IO;
using Exercicio9.Models;

namespace Exercicio9.Services
{
    public class EstoqueArquivo
    {
        private const string ARQUIVO = "estoque.txt";
        private const int LIMITE = 5;

        public bool InserirProduto(Produto produto)
        {
            int totalProdutos = File.Exists(ARQUIVO) ? File.ReadAllLines(ARQUIVO).Length : 0;

            if (totalProdutos >= LIMITE)
            {
                return false;
            }

            string linha = $"{produto.Nome};{produto.Quantidade};{produto.Preco}";
            File.AppendAllText(ARQUIVO, linha + Environment.NewLine);
            return true;
        }

        public void ListarProdutos()
        {
            if (!File.Exists(ARQUIVO) || File.ReadAllLines(ARQUIVO).Length == 0)
            {
                Console.WriteLine("Nenhum produto cadastrado ainda.");
                return;
            }

            Console.WriteLine("\n--- Produtos cadastrados ---");
            string[] linhas = File.ReadAllLines(ARQUIVO);

            foreach (string linha in linhas)
            {
                Produto produto = ConverterLinhaEmProduto(linha);
                Console.WriteLine(produto);
            }
        }

        private Produto ConverterLinhaEmProduto(string linha)
        {
            string[] dados = linha.Split(';');
            string nome = dados[0];
            int quantidade = int.Parse(dados[1]);
            double preco = double.Parse(dados[2]);

            return new Produto(nome, quantidade, preco);
        }
    }
}