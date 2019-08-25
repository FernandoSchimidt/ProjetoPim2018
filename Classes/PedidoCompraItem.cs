using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPim.Classes
{
    public class PedidoCompraItem
    {
        public int Id { get; set; }
        public int IdPedidoCompra { get; set; }
        public long IdProduto { get; set; }
        public decimal Quantidade { get; set; }
        public decimal Preco { get; set; }
          
        public void Crud(PedidoCompraItem pedidoCompraItem)
        {

        }

        public List<PedidoCompraItem> ConsultaPorPedido(PedidoCompra pedidoCompra)
        {
            return new List<PedidoCompraItem>();
        }

        public List<PedidoCompraItem> ConsultaPorProduto(Produto produto)
        {
            return new List<PedidoCompraItem>();
        }

        public decimal ConsultaTotalPorPedido(PedidoCompra pedidoCompra)
        {
            return 0;
        }

    }

}
