using System;
using System.Text;
using System.Globalization;
using System.Collections.Generic;
using ExercicioFinalSistemaVenda.Entities.Enums;

namespace ExercicioFinalSistemaVenda.Entities
{
    class Pedido
    {
        public DateTime DataDoPedido { get; set; }
        public Status Status { get; set; }  
        public Cliente Cliente { get; set; }   
        public List<ItensDoPedido> Items { get; set; }  = new List<ItensDoPedido> ();

        public Pedido ()
        {
        }

        public Pedido(DateTime dataDoPedido, Status status, Cliente cliente)
        {
            DataDoPedido = dataDoPedido;
            Status = status;
            Cliente = cliente;
        }

        public void AdicionaItem (ItensDoPedido item)
        {
            Items.Add(item);
        }

        public void RemoveItem(ItensDoPedido item)
        {
            Items.Remove(item);
        }

        public double Total ()
        {
            double soma = 0.00;
            foreach (ItensDoPedido item in Items)
            {
                soma += item.TotalPedido();

            }
            return soma;    
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Data do pedido: " + DataDoPedido.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Status do pedido: " + Status);
            sb.AppendLine("Cliente: " + Cliente);
            sb.AppendLine("Itens do pedido:");
            foreach (ItensDoPedido item in Items)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Preço Total: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
