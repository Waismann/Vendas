using System;
using System.Globalization;
using ExercicioFinalSistemaVenda.Entities;
using ExercicioFinalSistemaVenda.Entities.Enums;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dados do cliente ");
            Console.Write("Nome: ");
            string clientName = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Data de Nascimento (DD/MM/YYYY): ");
            DateTime dataNascimento = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Dados do pedido: ");
            Console.Write("Status: ");
            Status status = Enum.Parse<Status>(Console.ReadLine());

            Cliente cliente = new Cliente(clientName, email, dataNascimento);
            Pedido pedido = new Pedido(DateTime.Now, status, cliente);

            Console.Write("Quantos itens terá seu pedido ? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Entre com #{i} item do pedido:");
                Console.Write("Nome do produto: ");
                string produtoNome = Console.ReadLine();

                Console.Write("Preço do Produto: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Produto produto = new Produto(produtoNome, preco);

                Console.Write("Quantidade: ");
                int quantidade = int.Parse(Console.ReadLine());

                ItensDoPedido itensDoPedido = new ItensDoPedido( produto, quantidade, preco);

                pedido.AdicionaItem(itensDoPedido);
            }

            Console.WriteLine();
            Console.WriteLine("Resumo do Pedido");
            Console.WriteLine(pedido);
        }
    }
}