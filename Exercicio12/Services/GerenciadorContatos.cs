using System;
using System.Collections.Generic;
using System.IO;
using Exercicio12.Models;

namespace Exercicio12.Services
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

        public List<Contato> LerContatos()
        {
            List<Contato> contatos = new List<Contato>();

            if (!File.Exists(ARQUIVO))
            {
                return contatos; 
            }

            try
            {
                using (StreamReader leitor = new StreamReader(ARQUIVO))
                {
                    string linha;
                    while ((linha = leitor.ReadLine()) != null)
                    {
                        if (string.IsNullOrWhiteSpace(linha))
                        {
                            continue;
                        }

                        string[] dados = linha.Split(',');
                        Contato contato = new Contato(dados[0], dados[1], dados[2]);
                        contatos.Add(contato);
                    }
                }
            }
            catch (IOException erro)
            {
                Console.WriteLine($"Erro ao ler o arquivo de contatos: {erro.Message}");
            }

            return contatos;
        }
    }
}