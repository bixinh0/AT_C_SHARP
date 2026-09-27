using Exercicio9.Models;

namespace Exercicio9.Services
{
    public class Estoque
    {
        private const int LIMITE = 5;
        private Produto[] produtos = new Produto[LIMITE];
        private int totalProdutos = 0;

        public bool InserirProduto(Produto produto)
        {
            if (totalProdutos >= LIMITE)
            {
                return false;
            }

            produtos[totalProdutos] = produto;
            totalProdutos++;
            return true;
        }

        public void ListarProdutos()
        {
            if (totalProdutos == 0)
            {
                Console.WriteLine("Nenhum produto cadastrado ainda.");
                return;
            }

            Console.WriteLine("\n--- Produtos cadastrados ---");
            for (int i = 0; i < totalProdutos; i++)
            {
                Console.WriteLine(produtos[i]);
            }
        }
    }
}