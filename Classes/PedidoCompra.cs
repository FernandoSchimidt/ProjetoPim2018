using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPim.Classes
{
    public class PedidoCompra
    {
        public int Id { get; set; }
        public int IdFornecedor { get; set; }
        public DateTime Data { get; set; }
        public DateTime DataRecebimento { get; set; }
        public DateTime DataCancelamento { get; set; }
        public DateTime DataPagamento { get; set; }
        public int IdUsuarioComprador { get; set; }
        public List<PedidoCompraItem> PedidoCompraItens{ get; set; }

        public PedidoCompra()
        {
            PedidoCompraItens = new List<PedidoCompraItem>();
        }

        public void Crud(PedidoCompra PedidoCompra)
        {

        }

        public List<PedidoCompra> ConsultaPorNome(string nome)
        {
            return new List<PedidoCompra>();
        }

        public List<PedidoCompra> ConsultaPorEmail(string email)
        {
            return new List<PedidoCompra>();
        }

    }

}
