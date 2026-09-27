using System.Net.Http.Headers;

namespace Exercicio6.Models
{
    public class Aluno
    {
        public string nome;
        public string matricula;
        public string curso;
        public double medias;

        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {nome}\n" +
                $"Matricula: {matricula}\n" +
                $"Curso: {curso} \n" +
                $"Média das notas: {medias} \n");
        }
        public void VerificarAprovacao()
        {
            if (medias >= 7)
            {
                Console.WriteLine("Aluno aprovado!");
            }
            else
            {
                Console.WriteLine("Aluno reprovado!");
            }
        }
    }
}