using System;

namespace Projeto1
{   
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o número de indices (vendas): ");
            var numVend = Convert.ToInt32(Console.ReadLine());

            Produtos[] produtos = new Produtos[3];

            produtos[0] = new Produtos(0, "Caneta", 5, 2);
            produtos[1] = new Produtos(1, "Caderno", 3, 10);
            produtos[2] = new Produtos(2, "Livro", 8, 20);

            Vendas[] vendas = new Vendas[numVend];

            Console.WriteLine("Produtos Disponíveis:");
            foreach (var p in produtos)
            {
                Console.WriteLine(p);
            }

            for (int i = 0; i < numVend; i++)
            {
                Console.WriteLine($"Venda: {i + 1}");
                Console.Write("Informe o Id do Vendedor: ");
                int idVendedor = int.Parse(Console.ReadLine());
                Console.Write("Informe o Id do produto: ");
                int idProduto = int.Parse(Console.ReadLine());
                Console.Write("Infome a quantidade: ");
                int qtd = int.Parse(Console.ReadLine());
                if (qtd <= produtos[idProduto].QtdProduto)
                {
                    produtos[idProduto].QtdProduto -= qtd;
                    var valorVenda = produtos[idProduto].ValorProduto * qtd;
                    vendas[i] = new Vendas(idVendedor, qtd, valorVenda);
                }
                else
                {                    
                    Console.WriteLine("Quantidade Insuficiente em estoque. Vamos tentar de novo...");
                    i--;
                }
            }
            Console.WriteLine("Produtos Disponíveis:");

            foreach (var p in produtos)
            {
                Console.WriteLine(p);
            }
            var qtdVendas = 0;
            double valorVendas = 0;

            for (int i = 0; i < numVend; i++)
            {
                qtdVendas += vendas[i].QtdVenda;
                valorVendas += vendas[i].ValorVenda;
            }
            Console.WriteLine($"Vendedor Id: {vendas[0].IdVendedor} vendeu {qtdVendas} itens em {numVend} vendas. Total de R$ {valorVendas}");
        }
    }
}

