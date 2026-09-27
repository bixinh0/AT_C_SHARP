using System;
using System.Collections.Generic;
using Exercicio12.Models;

namespace Exercicio12.Formatters
{
    public class MarkdownFormatter : ContatoFormatter
    {
        public override void ExibirContatos(List<Contato> contatos)
        {
            Console.WriteLine("## Lista de Contatos");

            foreach (Contato contato in contatos)
            {
                Console.WriteLine($"- **Nome:** {contato.Nome}");
                Console.WriteLine($"- Telefone: {contato.Telefone}");
                Console.WriteLine($"- Email: {contato.Email}");
            }
        }
    }
}