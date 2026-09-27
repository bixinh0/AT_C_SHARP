using System;

namespace Exercicio2
{
    class Program
    {
        static void Main()
        {
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();

            char[] letras = nome.ToCharArray();

            for (int i = 0; i < letras.Length; i++)
            {
                char c = letras[i];

                if (c >='a' && c <= 'z')
                {
                    letras[i] = (char)(((c - 'a' + 2) % 26) + 'a');
                }
                else if (c>='A' && c <= 'Z')
                {
                    letras[i] = (char)(((c - 'A' + 2) % 26) + 'A');
                }
            }

            string resultado = new string(letras);

            Console.WriteLine(resultado);
        }
    }
}