using System;

namespace Exercicio5
{
    class Program
    {
        static void Main()
        {
            Console.Write("Digite a data de hoje (dd/MM/yyyy): ");
            DateTime dataHoje = DateTime.Parse(Console.ReadLine());

            while (dataHoje > DateTime.Today)
            {
                Console.Write("\nErro: A data informada não pode ser no futuro! Digite novamente: ");
                dataHoje = DateTime.Parse(Console.ReadLine());
            }

            Console.Write("Digite a data da formatura (dd/MM/yyyy): ");
            DateTime dataFormatura = DateTime.Parse(Console.ReadLine());

            int anos = dataFormatura.Year - dataHoje.Year;
            int meses = dataFormatura.Month - dataHoje.Month;
            int dias = dataFormatura.Day - dataHoje.Day;

            if (dias < 0)
            {
                meses--;
                DateTime mesAnterior = dataFormatura.AddMonths(-1);
                dias += DateTime.DaysInMonth(mesAnterior.Year, mesAnterior.Month);
            }

            if (meses < 0)
            {
                anos--;
                meses += 12;
            }

            if ((anos == 0) && (meses < 6))
            {
                Console.WriteLine($"Faltam {meses} meses e {dias} dias para sua formatura!");
                Console.WriteLine("A reta final chegou! Prepare-se para a formatura!");
            }
            else if (dataFormatura < dataHoje)
            {
                Console.WriteLine("Parabéns! Você já deveria estar formado!");
            }
            else
            {
                Console.WriteLine($"Faltam {anos} anos, {meses} meses e {dias} dias para a sua formatura!");
            }
        }
    }
}