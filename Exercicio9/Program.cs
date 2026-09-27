using Exercicio9.Models;
using Exercicio9.Services;

namespace Exercicio9
{
    class Program
    {
        static void Main()
        {
            //Estoque estoque = new Estoque(); //Esse para parte A
            EstoqueArquivo estoque = new EstoqueArquivo(); //esse para a parte B
            int opcao;

            do
            {
                Console.WriteLine("\n===== MENU =====");
                Console.WriteLine("1. Inserir Produto");
                Console.WriteLine("2. Listar Produtos");
                Console.WriteLine("3. Sair");
                Console.Write("Escolha uma opção: ");

                while (!int.TryParse(Console.ReadLine(), out opcao) || opcao < 1 || opcao > 3)
                {
                    Console.Write("Opção inválida! Escolha 1, 2 ou 3: ");
                }

                switch (opcao)
                {
                    case 1:
                        Produto novoProduto = LerDadosDoProduto();
                        bool sucesso = estoque.InserirProduto(novoProduto);

                        if (!sucesso)
                        {
                            Console.WriteLine("Limite de produtos atingido!");
                        }
                        else
                        {
                            Console.WriteLine("Produto cadastrado com sucesso!");
                        }
                        break;

                    case 2:
                        estoque.ListarProdutos();
                        break;

                    case 3:
                        Console.WriteLine("Encerrando o programa...");
                        break;
                }

            } while (opcao != 3);
        }

        static Produto LerDadosDoProduto()
        {
            Console.Write("Nome do produto: ");
            string nome = Console.ReadLine();

            Console.Write("Quantidade em estoque: ");
            int quantidade;
            while (!int.TryParse(Console.ReadLine(), out quantidade) || quantidade < 0)
            {
                Console.Write("Quantidade inválida! Digite um número inteiro maior ou igual a 0: ");
            }

            Console.Write("Preço unitário: ");
            double preco;
            while (!double.TryParse(Console.ReadLine(), out preco) || preco < 0)
            {
                Console.Write("Preço inválido! Digite um número maior ou igual a 0: ");
            }

            return new Produto(nome, quantidade, preco);
        }
    }
}