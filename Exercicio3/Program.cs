using System;
namespace Exercicio3
{
    class Program
    {
        static void Main()
        {
            double numero1;
            double numero2;
            int operador;
            double resultado;
            string sinal;

            // Leitura e validação do primeiro número
            Console.Write("Digite o primeiro número: ");
            while (!double.TryParse(Console.ReadLine(), out numero1))
            {
                Console.WriteLine("Valor inválido! Tente novamente.");
                Console.Write("Digite um valor: ");
            }

            // Leitura e validação do segundo número
            Console.Write("Digite o segundo número: ");
            while (!double.TryParse(Console.ReadLine(), out numero2))
            {
                Console.WriteLine("Valor inválido! Tente novamente.");
                Console.Write("Digite um valor: ");
            }

            // Leitura e validação da operação (deve ser um número entre 1 e 4)
            Console.Write("Digite um número para a operação:\n1 - Soma;\n2 - Subtração;\n3 - Multiplicação;\n4 - Divisão\nDigite seu número: ");
            while (!int.TryParse(Console.ReadLine(), out operador) || (operador < 1) || (operador > 4))
            {
                Console.WriteLine("Opção inválida. Selecione uma opção de 1 a 4: ");
            }

            // Executa a operação escolhida
            if (operador == 1)
            {
                resultado = numero1 + numero2;
                sinal = "+";
            }
            else if (operador == 2)
            {
                resultado = numero1 - numero2;
                sinal = "-";
            }
            else if (operador == 3)
            {
                resultado = numero1 * numero2;
                sinal = "*";
            }
            else // operador == 4 (divisão)
            {
                // Evita divisão por zero, pedindo um novo valor enquanto numero2 for 0
                while (numero2 == 0)
                {
                    Console.Write("Divisão por zero não é permitida! Digite um novo valor para o segundo número: ");
                    while (!double.TryParse(Console.ReadLine(), out numero2))
                    {
                        Console.WriteLine("Valor inválido! Tente novamente.");
                        Console.Write("Digite um valor: ");
                    }
                }
                resultado = numero1 / numero2;
                sinal = "/";
            }
            // Exibe o resultado final
            Console.WriteLine($"{numero1} {sinal} {numero2} = {resultado}");
        }
    }
}