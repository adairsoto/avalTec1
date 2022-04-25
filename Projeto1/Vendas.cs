namespace Projeto1
{
    public class Vendas
    {
        public int IdVendedor { get; set; }

        public int QtdVenda { get; set; }

        public double ValorVenda { get; set; }

        public Vendas(int idVendedor, int qtdVenda, double valorVenda)
        {
            IdVendedor = idVendedor;
            QtdVenda = qtdVenda;
            ValorVenda = valorVenda;
        }

        public override string ToString()
        {
            return "Id Vendedor: " + IdVendedor + " - Qtd Vendas: " + QtdVenda + " - Valor total: " + ValorVenda;
        }

    }
}
