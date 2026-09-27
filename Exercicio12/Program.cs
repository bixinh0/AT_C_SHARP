using System;
using System.Collections.Generic;
using Exercicio12.Models;
using Exercicio12.Services;
using Exercicio12.Formatters;

namespace Exercicio12
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
                        ExibirContatosComFormatoEscolhido(gerenciador);
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

        static void ExibirContatosComFormatoEscolhido(GerenciadorContatos gerenciador)
        {
            List<Contato> contatos = gerenciador.LerContatos();

            if (contatos.Count == 0)
            {
                Console.WriteLine("Nenhum contato cadastrado.");
                return;
            }

            Console.WriteLine("\nEscolha o formato de exibição:");
            Console.WriteLine("1 - Markdown");
            Console.WriteLine("2 - Tabela");
            Console.WriteLine("3 - Texto Puro");
            Console.Write("Opção: ");

            int formatoEscolhido;
            while (!int.TryParse(Console.ReadLine(), out formatoEscolhido) || formatoEscolhido < 1 || formatoEscolhido > 3)
            {
                Console.Write("Opção inválida! Escolha 1, 2 ou 3: ");
            }

            ContatoFormatter formatter;

            switch (formatoEscolhido)
            {
                case 1:
                    formatter = new MarkdownFormatter();
                    break;
                case 2:
                    formatter = new TabelaFormatter();
                    break;
                default:
                    formatter = new RawTextFormatter();
                    break;
            }

            formatter.ExibirContatos(contatos);
        }
    }
}