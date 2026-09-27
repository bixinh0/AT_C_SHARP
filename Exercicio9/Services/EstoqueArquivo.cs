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
            int totalProdutos = ContarProdutos();

            if (totalProdutos >= LIMITE)
            {
                return false;
            }

            try
            {
                using (StreamWriter escritor = new StreamWriter(ARQUIVO, true))
                {
                    escritor.WriteLine($"{produto.Nome};{produto.Quantidade};{produto.Preco}");
                }
                return true;
            }
            catch (IOException erro)
            {
                Console.WriteLine($"Erro ao salvar o produto: {erro.Message}");
                return false;
            }
        }

        public void ListarProdutos()
        {
            if (!File.Exists(ARQUIVO))
            {
                Console.WriteLine("Nenhum produto cadastrado.");
                return;
            }

            try
            {
                using (StreamReader leitor = new StreamReader(ARQUIVO))
                {
                    string linha;
                    bool encontrouAlgum = false;

                    Console.WriteLine("\n--- Produtos cadastrados ---");

                    while ((linha = leitor.ReadLine()) != null)
                    {
                        if (string.IsNullOrWhiteSpace(linha))
                        {
                            continue;
                        }

                        Produto produto = ConverterLinhaEmProduto(linha);

                        if (produto != null)
                        {
                            Console.WriteLine(produto);
                            encontrouAlgum = true;
                        }
                    }

                    if (!encontrouAlgum)
                    {
                        Console.WriteLine("Nenhum produto cadastrado.");
                    }
                }
            }
            catch (IOException erro)
            {
                Console.WriteLine($"Erro ao ler o arquivo: {erro.Message}");
            }
        }

        private int ContarProdutos()
        {
            if (!File.Exists(ARQUIVO))
            {
                return 0;
            }

            int total = 0;
            using (StreamReader leitor = new StreamReader(ARQUIVO))
            {
                while (leitor.ReadLine() != null)
                {
                    total++;
                }
            }
            return total;
        }
        private Produto ConverterLinhaEmProduto(string linha)
        {
            try
            {
                string[] dados = linha.Split(';');
                string nome = dados[0];
                int quantidade = int.Parse(dados[1]);
                double preco = double.Parse(dados[2]);

                return new Produto(nome, quantidade, preco);
            }
            catch (Exception)
            {
                Console.WriteLine($"Linha corrompida ignorada: \"{linha}\"");
                return null;
            }
        }
    }
}