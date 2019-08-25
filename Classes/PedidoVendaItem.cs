using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPim.Classes
{
    public class PedidoVendaItem
    {
        public int Id { get; set; }
        public int IdPedidoVenda { get; set; }
        public long IdProduto { get; set; }
        public decimal Quantidade { get; set; }
        public decimal Preco { get; set; }
          
        public void Crud(PedidoVendaItem PedidoVendaItem)
        {

        }

        public List<PedidoVendaItem> ConsultaPorPedido(PedidoVenda pedidoVenda)
        {
            return new List<PedidoVendaItem>();
        }

        public List<PedidoVendaItem> ConsultaPorProduto(Produto produto)
        {
            return new List<PedidoVendaItem>();
        }

        public decimal ConsultaTotalPorPedido(PedidoVenda pedidoVenda)
        {
            return 0;
        }

    }

}
