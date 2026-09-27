using System;

namespace Exercicio7.Models
{
    public class ContaBancaria
    {
        public string cliente;
        private double saldo;

        public ContaBancaria(string cliente, double saldoInicial)
        {
            this.cliente = cliente;
            saldo = saldoInicial;
        }

        public void Depositar(double valor)
        {
            if (valor < 0)
            {
                Console.WriteLine($"Tentativa de Depósito: R$ {valor:F2}");
                throw new ArgumentException("O valor do depósito não pode ser negativo.");
            }
            else
            {
                saldo += valor;
                Console.WriteLine($"Depósito de R$ {valor:F2} realizado com sucesso!\n" +
                                  $"Saldo atual: R$ {saldo:F2}");
            }
        }

        public void Sacar(double valor)
        {
            if (saldo < valor)
            {
                Console.WriteLine($"Tentativa de Saque: R$ {valor:F2}");
                throw new InvalidOperationException("Saldo insuficiente para realizar o saque!");
            }
            else
            {
                saldo -= valor;
                Console.WriteLine($"Saque de R$ {valor:F2} realizado com sucesso!\n" +
                                  $"Saldo atual: R$ {saldo:F2}");
            }
        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"Titular: {cliente}\n" +
                $"Saldo atual: {saldo:F2}");
        }
    }
}