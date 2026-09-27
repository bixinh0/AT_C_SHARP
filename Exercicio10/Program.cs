using System;

namespace Exercicio10
{
    class Program
    {
        public static void Main()
        {
            Random random = new Random();
            int numeroAleatorio = random.Next(1, 51);

            Console.WriteLine("Tente acertar o número entre 1 e 50! Você terá 5 tentativas!");

            for (int i = 0; i < 5; i++)
            {
                try
                {
                    Console.Write("Digite um número: ");
                    int numero = int.Parse(Console.ReadLine());

                    if (numero == numeroAleatorio)
                    {
                        Console.WriteLine("Parabéns!!! Você acertou o número aleatório!");
                        break;
                    }
                    else if (numero < 1 || numero > 50)
                    {
                        Console.WriteLine("Você digitou um número fora do intervalo e desperdiçou uma chance!");
                    }
                    else
                    {
                        Console.WriteLine("Número errado. Tente novamente!");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Entrada inválida! Digite um número inteiro.");
                }

                if (i == 4)
                {
                    Console.WriteLine("Você gastou todas as suas tentativas. Fim de jogo!");
                }
            }
        }
    }
}