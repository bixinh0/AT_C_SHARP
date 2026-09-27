using System;

namespace Exercicio8.Models
{
    public class Funcionario
    {
        private string nome;
        private string cargo;
        protected double salarioBase;

        public Funcionario(string nome, string cargo, double salarioBase)
        {
            this.nome = nome;
            this.cargo = cargo;
            this.salarioBase = salarioBase;
        }

        public virtual double CalcularSalario()
        {
            return salarioBase;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {nome}\n" +
                              $"Cargo: {cargo}\n" +
                              $"Salário: R$ {CalcularSalario():F2}");
        }
    }
}