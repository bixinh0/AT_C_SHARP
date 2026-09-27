using Exercicio6.Models;
using System;

namespace Exercicio6
{
    class Program
    {
        static void Main()
        {
            Aluno novoAluno = new Aluno();
            novoAluno.nome = "Luan";
            novoAluno.matricula = "123";
            novoAluno.curso = "ADS";
            novoAluno.medias = 7.5;

            novoAluno.ExibirDados();
            Console.WriteLine($"Situação: {novoAluno.VerificarAprovacao()}");
        }
    }
}