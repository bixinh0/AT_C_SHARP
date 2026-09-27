using System;

namespace Exercicio8.Models
{
    public class Gerente : Funcionario
    {
        public Gerente(string nome, string cargo, double salarioBase)
            : base(nome, cargo, salarioBase)
        {
        }
        public override double CalcularSalario()
        {
            return salarioBase * 1.2;
        }
    }
}