using System;
namespace Exercicio4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Digite sua data de nascimento (dd/MM/yyyy):");
            DateTime nascimento = DateTime.Parse(Console.ReadLine());
            DateTime hoje = DateTime.Today;

            DateTime aniversario = nascimento.AddYears(hoje.Year - nascimento.Year);

            if (aniversario < hoje)
                aniversario = aniversario.AddYears(1);

            int diasRestantes = (aniversario - hoje).Days;

            if (diasRestantes == 0)
            {
                Console.WriteLine("É hoje! Parabéns.");
            }
            else if (diasRestantes < 7)
            {
                Console.WriteLine("Falta menos de uma semana para seu aniversário!!");
            }
            else
            {
                Console.WriteLine($"Faltam: {diasRestantes} dias até o seu aniversário.");
            }
        }
    }
}