using System;
using Exercicio7.Models;

namespace Exercicio7
{
    class Program
    {
        public static void Main()
        {
            ContaBancaria conta = new ContaBancaria("Luan", 100.50);

            conta.ExibirSaldo();

            try
            {
                conta.Depositar(500.00);
            }
            catch (InvalidOperationException erro)
            {
                Console.WriteLine(erro.Message);
            }

            try
            {
                conta.Sacar(700.00);
            }
            catch (InvalidOperationException erro)
            {
                Console.WriteLine(erro.Message);
            }

            try
            {
                conta.Sacar(200.00);
            }
            catch (InvalidOperationException erro)
            {
                Console.WriteLine(erro.Message);
            }
        }
    }
}