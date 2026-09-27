using System;
using System.IO;
using Exercicio11.Models;

namespace Exercicio11.Services
{
    public class GerenciadorContatos
    {
        private const string ARQUIVO = "contatos.txt";

        public void AdicionarContato(Contato contato)
        {
            try
            {
                using (StreamWriter escritor = new StreamWriter(ARQUIVO, true))
                {
                    escritor.WriteLine(contato.ParaLinhaDeArquivo());
                }

                Console.WriteLine("Contato cadastrado com sucesso!");
            }
            catch (IOException erro)
            {
                Console.WriteLine($"Erro ao salvar o contato no arquivo: {erro.Message}");
            }
        }

        public void ListarContatos()
        {
            if (!File.Exists(ARQUIVO))
            {
                Console.WriteLine("Nenhum contato cadastrado.");
                return;
            }

            try
            {
                using (StreamReader leitor = new StreamReader(ARQUIVO))
                {
                    string linha;
                    bool encontrouAlgumContato = false;

                    Console.WriteLine("Contatos cadastrados:");

                    while ((linha = leitor.ReadLine()) != null)
                    {
                        if (string.IsNullOrWhiteSpace(linha))
                        {
                            continue;
                        }

                        Contato contato = ConverterLinhaEmContato(linha);
                        Console.WriteLine(contato);
                        encontrouAlgumContato = true;
                    }

                    if (!encontrouAlgumContato)
                    {
                        Console.WriteLine("Nenhum contato cadastrado.");
                    }
                }
            }
            catch (IOException erro)
            {
                Console.WriteLine($"Erro ao ler o arquivo de contatos: {erro.Message}");
            }
        }

        private Contato ConverterLinhaEmContato(string linha)
        {
            string[] dados = linha.Split(',');
            string nome = dados[0];
            string telefone = dados[1];
            string email = dados[2];

            return new Contato(nome, telefone, email);
        }
    }
}