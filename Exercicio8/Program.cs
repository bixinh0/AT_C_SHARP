using System;
using Exercicio8.Models;

class Program
{
    static void Main()
    {
        Funcionario funcionario = new Funcionario("João", "Analista", 3000);
        Gerente gerente = new Gerente("Maria", "Gerente", 3000);

        funcionario.ExibirDados();
        Console.WriteLine();
        gerente.ExibirDados();
    }
}