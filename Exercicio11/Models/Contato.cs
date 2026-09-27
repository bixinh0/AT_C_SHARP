namespace Exercicio11.Models
{
    public class Contato
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        public Contato(string nome, string telefone, string email)
        {
            Nome = nome;
            Telefone = telefone;
            Email = email;
        }

        public string ParaLinhaDeArquivo()
        {
            return $"{Nome},{Telefone},{Email}";
        }

        public override string ToString()
        {
            return $"Nome: {Nome} | Telefone: {Telefone} | Email: {Email}";
        }
    }
}