namespace Projeto1
{
    public class Vendedor 
    {
        public int idVendedor { get; set; }

        public Vendas[] Vendas { get; set; }

       // public double valorVendas { get; set; }

        public Vendedor(int idVendedor, int qtdVendas, double valorVendas)
        {
            this.idVendedor = idVendedor;
            this.qtdVendas = qtdVendas;
            //this.valorVendas = valorVendas;
        }
    }
   
}
