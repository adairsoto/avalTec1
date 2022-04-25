namespace Projeto1
{
    public class Produtos
    {
        public int IdProduto { get; set; }
        public string NomeProduto { get; set; }
        public int QtdProduto { get; set; }

        public double ValorProduto { get; set; }

        public Produtos(int idProduto, string nomeProduto, int qtdProduto, double valorProduto)
        {
            IdProduto = idProduto;
            NomeProduto = nomeProduto;
            QtdProduto = qtdProduto;   
            ValorProduto = valorProduto;
        }

        public override string ToString()
        {
            return IdProduto + " - " + NomeProduto + " - Qtd em estoque: " + QtdProduto + " - Valor Unidade: " + ValorProduto;
        }



    }
}
