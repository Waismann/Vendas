using System.Globalization; 

namespace ExercicioFinalSistemaVenda.Entities
{
    class ItensDoPedido
    {
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
        public double Preco { get; set; }

        public ItensDoPedido()
        {
        }

        public ItensDoPedido(Produto produto, int quantidade, double preco)
        {
            Produto = produto;
            Quantidade = quantidade;
            Preco = preco;
        }

        public double TotalPedido ()
        {
            return Preco * Quantidade;
        }

        public override string ToString()
        {
            return Produto.Nome
                + " , Quantidade: "
                + Quantidade
                + " Total do Pedido: R$"
                + TotalPedido().ToString("F2", CultureInfo.InvariantCulture);

        }
    }
}
