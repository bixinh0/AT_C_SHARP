using System;
using System.Collections.Generic;
using Exercicio12.Models;

namespace Exercicio12.Formatters
{
    public class RawTextFormatter : ContatoFormatter
    {
        public override void ExibirContatos(List<Contato> contatos)
        {
            foreach (Contato contato in contatos)
            {
                Console.WriteLine($"Nome: {contato.Nome} | Telefone: {contato.Telefone} | Email: {contato.Email}");
            }
        }
    }
}
