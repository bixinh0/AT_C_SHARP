using System;
using Exercicio11.Models;
using Exercicio11.Services;

namespace Exercicio11
{
    class Program
    {
        static void Main()
        {
            GerenciadorContatos gerenciador = new GerenciadorContatos();
            int opcao;

            do
            {
                Console.WriteLine("\n=== Gerenciador de Contatos ===");
                Console.WriteLine("1 - Adicionar novo contato");
                Console.WriteLine("2 - Listar contatos cadastrados");
                Console.WriteLine("3 - Sair");
                Console.Write("Escolha uma opção: ");

                while (!int.TryParse(Console.ReadLine(), out opcao) || opcao < 1 || opcao > 3)
                {
                    Console.Write("Opção inválida! Escolha 1, 2 ou 3: ");
                }

                switch (opcao)
                {
                    case 1:
                        Contato novoContato = LerDadosDoContato();
                        gerenciador.AdicionarContato(novoContato);
                        break;

                    case 2:
                        gerenciador.ListarContatos();
                        break;

                    case 3:
                        Console.WriteLine("Encerrando programa...");
                        break;
                }

            } while (opcao != 3);
        }

        static Contato LerDadosDoContato()
        {
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Telefone: ");
            string telefone = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            return new Contato(nome, telefone, email);
        }
    }
}